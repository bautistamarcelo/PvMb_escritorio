using PVpresentation.Formularios.Modelos;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Interfaces;
using System.Data;
using System.Windows.Controls;

namespace PVpresentation.Formularios
{
    public partial class Frm_Proveedores : FrmModeloCRUD
    {
        #region Funcionalidades y Constructor del formulario

        private readonly IProveedoresService _proveedoresService;
        private readonly ICaracterService _caracterService;

        public Frm_Proveedores(IProveedoresService proveedoresService, ICaracterService caracterService)
        {
            InitializeComponent();
            _proveedoresService = proveedoresService;
            _caracterService = caracterService;
            dgvListado.CellClick += CustomCellClick; // Evento adicional
        }

        public void MostrarTabs(string tabName)
        {
            var tabsMenu = new TabPage[] { tabListado, tabNuevo }; //, tabEditar
            foreach (var tab in tabsMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }

            }
        }

        private void CustomCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                txtOpcion.Text = "2"; // 1 Nuevo / 2 Edición
                var ProveedorSeleccionado = (ProveedorVM)dgvListado.CurrentRow.DataBoundItem;
                txtNombre.Text = ProveedorSeleccionado.Nombre.ToString();
                txtDomicilio.Text = ProveedorSeleccionado.Direccion.ToString();
                txtCuit.Text = ProveedorSeleccionado.Cuit.ToString();
                txtEmail.Text = ProveedorSeleccionado.Email.ToString();
                txtTelefono.Text = ProveedorSeleccionado.Telefono.ToString();
                txtID.Text = ProveedorSeleccionado.ID.ToString();
                txtRenta.Text = ProveedorSeleccionado.Renta.ToString();
                cmbCaracter.EstablecerValor(ProveedorSeleccionado.CaracterID);

                btnGrabar.Enabled = true;
            }
        }

        private async Task MostrarProveedores(string Buscar = "")
        {

            var listaProveedores = await _proveedoresService.Lista(Buscar);
            var VMListaProveedores = listaProveedores.Select(item => new ProveedorVM //Genero una lista con la estructura de la vista modelo para mostrar en el DG
            {
                ID = item.ID,
                Nombre = item.Nombre,
                Direccion = item.Direccion,
                Cuit = item.Cuit,
                Email = item.Email,
                Telefono = item.Telefono,
                Renta = item.Renta,
                CaracterID = item.CaracterID.ID,
                Caracter = item.CaracterID.Nombre,
            }).ToList();
            dgvListado.DataSource = VMListaProveedores; //Llenar el DG con los datos armados de la listaVM

            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["ID"].Visible = false;
            dgvListado.Columns["Renta"].Visible = false;
            dgvListado.Columns["CaracterID"].Visible = false;
            dgvListado.Columns["Caracter"].Visible = false;
            btnDetalles.Visible = false;
            btnEditar.Visible = false;
            dgvListado.Columns["Nombre"].Width = 80;
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

        public async void LimpiarMantenimiento()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtCuit.Text = "";
            txtTelefono.Text = "";
            txtOpcion.Text = "0"; // 1 Nuevo / 2 Edición
            txtRenta.Text = "0";
            cmbCaracter.SelectedIndex = 0;
            txtID.Enabled = false;
            txtBuscar.Select();
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = true;
            await MostrarProveedores(txtBuscar.Text.Trim());
            //MostrarTabs(tabListado.Name);
        }

        private async void Frm_Proveedores_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);
            await MostrarProveedores();

            //Completo los datos de los comboBox no enlazados con otras tablas
            var ListaCaracter = await _caracterService.Lista();
            var items = ListaCaracter.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();

            cmbCaracter.InsertarItems(items);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarProveedores(txtBuscar.Text.Trim());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
            txtID.Enabled = false;
            btnGrabar.Enabled = true;
            //MostrarTabs(tabNuevo.Name);
            txtNombre.Select();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            //MostrarTabs(tabListado.Name);
            btnGrabar.Enabled = false;
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            var respuesta = "";
            //Validamos que los campos no se encuentren vacíos
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre del Proveedor es obligatorio");
                return;
            }
            if (txtDomicilio.Text.Trim() == "")
            {
                MessageBox.Show("El Domicilio del Proveedor es obligatorio");
                return;
            }
            if (txtCuit.Text.Trim() == "")
            {
                MessageBox.Show("El DNI ó CUIT del Proveedor es obligatorio");
                return;
            }

            //Creo las variables con los valores de los comboBox            
            var itemCaracter = (OpcionesComboBox)cmbCaracter.SelectedItem!;

            //Cargo los datos en el objeto Cliente para guardarlo después
            var objeTo = new Proveedores
            {
                ID = Convert.ToInt32(txtID.Text.Trim()),
                Nombre = txtNombre.Text.Trim(),
                Direccion = txtDomicilio.Text.Trim(),
                Cuit = txtCuit.Text.Trim(),
                Renta = Convert.ToInt32(txtRenta.Text),
                Email = txtEmail.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                CaracterID = new Caracter { ID = itemCaracter.Valor }
            };

            //Evalúo si es nuevo o edición
            if (txtOpcion.Text.Trim() == "2") // Si la opcion es 2: Editar
            {
                respuesta = await _proveedoresService.editar(objeTo);
            }
            else //Si la opcion es 1: Nueva
            {
                respuesta = await _proveedoresService.crear(objeTo);
            }

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarProveedores();
                MostrarTabs(tabListado.Name);
                btnGrabar.Enabled = false;
            }
        }

        private void btnCierreVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        private async void Frm_Proveedores_FormClosing(object sender, FormClosingEventArgs e)
        {
            Frm_Productos fProd = ObtenerFormularioAbierto();
            if (fProd != null)
            {
                fProd.CambiarVisibilidadControles();
                await fProd.agregarProveedorComboBox(txtNombre.Text.Trim());
                fProd.cmbProveedor.SelectedItem = txtNombre.Text.Trim();
            }
        }
    }
}
