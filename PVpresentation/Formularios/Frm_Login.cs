using PVpresentation.Resources;
using PVservices.Implementation;
using PVservices.Interfaces;
using System.Runtime.InteropServices;

namespace PVpresentation.Formularios
{
    public partial class Frm_Login : Form
    {
        #region VARIABLES Y CONSTRUCTOR DE SERVICIOS QUE NECESITO EN EL FORMULARIO 
        private readonly IServiceProvider _serviceProvider;
        private readonly IUsuariosService _usuariosService;
        private readonly ISucursalesService _sucursalesService;

        public Frm_Login(IServiceProvider serviceProvider, ISucursalesService sucursalesService, IUsuariosService usuariosService)
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            _serviceProvider = serviceProvider;
            _sucursalesService = sucursalesService;
            _usuariosService = usuariosService;
        }
        #endregion

        #region METODOS PARA ARRASTRAR EL FORMULARIO------------------------------------------------------------------------------------------------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void pnTituloFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        private async void Frm_Login_Load(object sender, EventArgs e)
        {
            //Llenar el combobox de sucursales
            var ListaSucursales = await _sucursalesService.Lista();
            var itemsSucursal = ListaSucursales.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbSucursales.InsertarItems(itemsSucursal);
            txtUsuario.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no esten vacios
            if (txtUsuario.Text == string.Empty || txtClave.Text == string.Empty || cmbSucursales.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Campos vacíos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validamos que el usuario exista
            var usuarioEncontrado = await _usuariosService.Login(txtUsuario.Text, txtClave.Text);
            if (usuarioEncontrado == null || usuarioEncontrado.IDUsuario == 0)
            {
                MessageBox.Show("Usuario o contraseña incorrectos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var cajaAbierta = await _usuariosService.BuscaCajaUsuario(usuarioEncontrado.IDUsuario);
                if (cajaAbierta == 0)
                {
                    MessageBox.Show("No tiene caja abierta, por favor abra una caja.", "Caja cerrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //return;
                }

                //Asignar valores a variables globales
                VariablesGlobales.UsuarioNombre = usuarioEncontrado.nombre;
                VariablesGlobales.UsuarioID = usuarioEncontrado.IDUsuario;
                VariablesGlobales.UsuarioIDrol = usuarioEncontrado.IDRol.IDRol;
                VariablesGlobales.RolNombre = usuarioEncontrado.IDRol.descripcion;
                VariablesGlobales.SucursalID = cmbSucursales.SelectedIndex;
                VariablesGlobales.CajaID = cajaAbierta;
                //Abrir el siguiente formulario
                Frm_Main mainForm = (Frm_Main)_serviceProvider.GetService(typeof(Frm_Main));
                this.Hide();

                mainForm.Show();
                if (mainForm != null)
                {
                    mainForm.txtNombreUsuario.Text = VariablesGlobales.UsuarioNombre;
                    mainForm.txtCategoria.Text = VariablesGlobales.RolNombre;
                }
            }

        }

        private async void LnkCambiarClave_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (txtUsuario.Text == string.Empty)
            {
                MessageBox.Show("Por favor, ingrese un usuario.", "Usuario vacío", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var usuarioCambioClave = await _usuariosService.Buscar(txtUsuario.Text);
            if (usuarioCambioClave == null || usuarioCambioClave.IDUsuario == 0)
            {
                MessageBox.Show("Usuario no encontrado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Frm_Login_NuevaClave frmCambioClave = (Frm_Login_NuevaClave)_serviceProvider.GetService(typeof(Frm_Login_NuevaClave));
            VariablesGlobales.UsuarioID = usuarioCambioClave.IDUsuario;
            VariablesGlobales.UsuarioNombre = usuarioCambioClave.nombre;
            VariablesGlobales.UsuarioClave = usuarioCambioClave.clave;
            frmCambioClave.ShowDialog();

        }

        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtClave.Text = string.Empty;
                txtClave.Focus();
            }
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                cmbSucursales.Focus();
            }
        }

        private void cmbSucursales_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                btnLogin.Focus();
            }
        }
    }
}
