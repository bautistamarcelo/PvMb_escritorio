using PVpresentation.Formularios.Modelos;
using PVpresentation.Resources;
using PVrepository.Entities;
using PVservices.Interfaces;
using System.Data;

namespace PVpresentation.Formularios
{
    public partial class Frm_Marcas : FrmModeloCRUD
    {
        #region Funcionalidades y Constructor del formulario
        private readonly IMarcasService _marcasService;
        public Frm_Marcas(IMarcasService marcasService)
        {
            InitializeComponent();
            _marcasService = marcasService;
        }

        private Frm_Productos ObtenerFormularioAbierto()
        {
            foreach (Form formPadre in Application.OpenForms)
            {
                if (formPadre is Frm_Productos)
                {
                    return (Frm_Productos)formPadre;
                }
            }
            return null; // No se encontró un formulario abierto de tipo Frm_Productos
        }

        public void LimpiarMantenimiento()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtID.Enabled = false;
            txtNombre.Enabled = false;
            txtBuscar.Select();
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = true;

        }

        private async Task MostrarMarcas(string Buscar = "")
        {

            var listaMarcas = await _marcasService.Lista(Buscar);
            var VMListaMarcas = listaMarcas.Select(item => new Marcas //Genero una lista con la estructura de la vista modelo para mostrar en el DG
            {
                ID = item.ID,
                Nombre = item.Nombre,
            }).ToList();
            dgvListado.DataSource = VMListaMarcas; //Llenar el DG con los datos armados de la listaVM

            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["ID"].Visible = false;
        }
        #endregion

        #region CRUD y Navegación del formulario
        private async void Frm_Marcas_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Editar");
            //MostrarTabs(tabListado.Name);
            await MostrarMarcas();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarMarcas(txtBuscar.Text.Trim());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            txtNombre.Enabled = true;
            txtNombre.Select();
            btnGrabar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var MarcaSeleccionada = (Marcas)dgvListado.CurrentRow.DataBoundItem;
            txtNombre.Text = MarcaSeleccionada.Nombre.ToString();
            txtID.Text = MarcaSeleccionada.ID.ToString();
            txtOpcion.Text = "2";// 1 Nuevo / 2 Edición
            txtNombre.Enabled = true;
            txtNombre.ReadOnly = false;
            txtNombre.Select();
            btnGrabar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            await MostrarMarcas(txtNombre.Text);
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            var respuesta = "";
            //Validamos que los campos no se encuentren vacíos
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre de la marca es obligatorio");
                return;
            }

            //Cargo los datos en el objeto Empresa para guardarlo después
            var miID = 0;
            if (txtID.Text.Trim() == "")
            {
                miID = 0;
            }
            else
            {
                miID = Convert.ToInt32(txtID.Text.Trim()!);
            }

            var objeTo = new Marcas
            {
                ID = miID,
                Nombre = txtNombre.Text.Trim()
            };

            //Evalúo si es nuevo o edición
            if (txtOpcion.Text.Trim() == "2") // Si la opcion es 2: Editar
            {
                respuesta = await _marcasService.editar(objeTo);
            }
            else //Si la opcion es 1: Nueva
            {
                respuesta = await _marcasService.crear(objeTo);
            }

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarMarcas();
                MostrarTabs(tabListado.Name);
            }
        }
        #endregion



        private async void Frm_Marcas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Productos fProd = ObtenerFormularioAbierto();
            if (fProd != null)
            {
                fProd.CambiarVisibilidadControles();
                await fProd.agregarMarcaComboBox(txtNombre.Text.Trim());
                fProd.cmbMarca.SelectedItem = txtNombre.Text.Trim();
            }
        }
    }
}
