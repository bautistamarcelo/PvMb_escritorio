using PVpresentation.Formularios.Modelos;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Interfaces;
using System.Data;

namespace PVpresentation.Formularios
{
    public partial class Frm_Usuarios : FrmModeloCRUD
    {
        #region Funcionalidades y Constructor del formulario
        private readonly IUsuariosService _usuariosService;
        private readonly IRolService _rolService;
        public Frm_Usuarios(IUsuariosService usuariosService, IRolService rolService)
        {
            InitializeComponent();
            _usuariosService = usuariosService;
            _rolService = rolService;
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

        private async Task MostrarUsuarios(string Buscar = "")
        {
            var listaUsuarios = await _usuariosService.Lista(Buscar);
            var VMListaUsuarios = listaUsuarios.Select(item => new UsuariosVM //Genero una lista con la estructura de la vista modelo para mostrar en el DG
            {
                IDUsuario = item.IDUsuario,
                nombre = item.nombre,
                correo = item.correo,
                telefono = item.telefono,
                IDRol = item.IDRol.IDRol,
                nombreRol = item.IDRol.descripcion,
                urlFoto = item.urlFoto,
                nombreFoto = item.nombreFoto,
                clave = item.clave,
                esActivo = item.esActivo,
                Situacion = item.esActivo == 1 ? "Activo" : "Suspendido",
                fechaRegistro = item.fechaRegistro
            }).ToList();
            dgvListado.DataSource = VMListaUsuarios;
            dgvListado.ImplementarConfiguracion("Editar");
            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["clave"].Visible = false;
            dgvListado.Columns["esActivo"].Visible = false;
            dgvListado.Columns["fechaRegistro"].Visible = false;
            dgvListado.Columns["IDUsuario"].Visible = false;
            dgvListado.Columns["urlFoto"].Visible = false;
            dgvListado.Columns["nombreFoto"].Visible = false;
            dgvListado.Columns["IDRol"].Visible = false;

        }

        public async void LimpiarMantenimiento()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtTelefono.Text = "";
            txtClave.Text = "";
            txtUrlFoto.Text = "";
            txtNombreFoto.Text = "";
            txtOpcion.Text = "0"; // 1 Nuevo / 2 Edición
            cmbEsActivo.SelectedIndex = 1;
            cmbRol.SelectedIndex = 3;
            txtID.Enabled = false;
            txtBuscar.Select();
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = true;
            await MostrarUsuarios(txtBuscar.Text.Trim());
            //MostrarTabs(tabListado.Name);
        }

        #endregion

        private async void Frm_Usuarios_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);

            //Completo los datos de los comboBox no enlazados con otras tablas
            OpcionesComboBox[] itemsSituacion = new OpcionesComboBox[]
            {
                new OpcionesComboBox{Texto="Activo",Valor=1},
                new OpcionesComboBox{Texto="Suspendido",Valor=2}
            };
            cmbEsActivo.InsertarItems(itemsSituacion);

            //Completo los datos de los comboBox enlazados con otras tablas
            var ListaRol = await _rolService.Lista();
            var items = ListaRol.Select(item => new OpcionesComboBox { Texto = item.descripcion, Valor = item.IDRol }).ToArray();
            cmbRol.InsertarItems(items);

            LimpiarMantenimiento();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarUsuarios(txtBuscar.Text.Trim());
        }

        private void btnCierreVolver_Click(object sender, EventArgs e)
        {
            Close();
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtOpcion.Text = "2"; // 1 Nuevo / 2 Edición
            txtID.Enabled = false;
            btnGrabar.Enabled = true;
            var UsuarioSeleccionado = (UsuariosVM)dgvListado.CurrentRow.DataBoundItem;
            txtID.Text = UsuarioSeleccionado.IDUsuario.ToString();
            txtNombre.Text = UsuarioSeleccionado.nombre.ToString();
            txtCorreo.Text = UsuarioSeleccionado.correo.ToString();
            txtTelefono.Text = UsuarioSeleccionado.telefono.ToString();
            cmbEsActivo.EstablecerValor(UsuarioSeleccionado.esActivo);
            cmbRol.EstablecerValor(UsuarioSeleccionado.IDRol);
            txtUrlFoto.Text = UsuarioSeleccionado.urlFoto.ToString();
            txtNombreFoto.Text = UsuarioSeleccionado.nombreFoto.ToString();
            txtClave.Text = UsuarioSeleccionado.clave.ToString();
            //txtIDEditar.Visible = true; //Desabilitar cuando compruebe funcionamiento
            //MostrarTabs(tabEditar.Name);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            //MostrarTabs(tabListado.Name);
            btnGrabar.Enabled = false;
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            //Validamos que los campos no se encuentren vacíos
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre del Usuario es obligatorio");
                return;
            }
            if (txtTelefono.Text.Trim() == "")
            {
                MessageBox.Show("El Teléfono del Usuario es obligatorio");
                return;
            }
            if (txtClave.Text.Trim() == "")
            {
                MessageBox.Show("La Clave del Usuario es obligatoria");
                return;
            }
            if (cmbRol.SelectedIndex == -1)
            {
                MessageBox.Show("La selección del Rol es obligatoria");
                return;
            }
            if (cmbEsActivo.SelectedIndex == -1)
            {
                MessageBox.Show("La selección de la Situación es obligatoria");
                return;
            }

            //Creo las variables con los valores de los comboBox
            var itemRol = (OpcionesComboBox)cmbRol.SelectedItem!;
            var itemActivo = (OpcionesComboBox)cmbEsActivo.SelectedItem!;

            //Cargo los datos en el objeto Usuario para guardarlo después
            var objeTo = new Usuarios
            {
                IDUsuario = Convert.ToInt32(txtID.Text.Trim()),
                nombre = txtNombre.Text.Trim(),
                correo = txtCorreo.Text.Trim(),
                telefono = txtTelefono.Text.Trim(),
                IDRol = new Rol { IDRol = itemRol.Valor },
                urlFoto = txtUrlFoto.Text.Trim(),
                nombreFoto = txtNombreFoto.Text.Trim(),
                clave = txtClave.Text.Trim(),
                esActivo = itemActivo.Valor,
            };

            //Evalúo si es nuevo o edición
            if (txtOpcion.Text.Trim() == "2") // Si la opcion es 2: Editar
            {
                respuesta = await _usuariosService.editar(objeTo);
            }
            else //Si la opcion es 1: Nueva
            {
                respuesta = await _usuariosService.crear(objeTo);
            }

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarUsuarios();
                MostrarTabs(tabListado.Name);
                LimpiarMantenimiento();
                btnGrabar.Enabled = false;
            }
        }
    }
}
