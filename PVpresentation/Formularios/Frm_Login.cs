using FiscalPrinterLib;
using PVpresentation.Resources;
using PVrepository.Entities;
using PVservices.Implementation;
using PVservices.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace PVpresentation.Formularios
{
    public partial class Frm_Login : Form
    {
        // Diccionario para almacenar los colores originales de los controles
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();

        #region VARIABLES Y CONSTRUCTOR DE SERVICIOS QUE NECESITO EN EL FORMULARIO 
        private readonly IServiceProvider _serviceProvider;
        private readonly IUsuariosService _usuariosService;
        private readonly ISucursalesService _sucursalesService;
        private readonly IEmpresaService _empresaService;
        private readonly IPredeterminadasService _predeterminadasService;
        private Empresa vEmpresa = new Empresa();
        public Frm_Login(IServiceProvider serviceProvider, ISucursalesService sucursalesService, IUsuariosService usuariosService, IEmpresaService empresaService, IPredeterminadasService predeterminadasService)
        {
            InitializeComponent();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            _serviceProvider = serviceProvider;
            _sucursalesService = sucursalesService;
            _usuariosService = usuariosService;
            _empresaService = empresaService;
            _predeterminadasService = predeterminadasService;
            // Asignar los eventos Enter y Leave solo a TextBox y ComboBox
            AssignFocusEvents(this);
            
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

        #region Métodos para asignar los eventos Enter y Leave solo a TextBox y ComboBox
        private void AssignFocusEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Verificar si el control es un TextBox o ComboBox
                if (control is TextBox || control is ComboBox)
                {
                    // Guardar el color original del control
                    originalColors[control] = control.BackColor;

                    // Asignar los eventos Enter y Leave
                    control.Enter += Control_Enter;
                    control.Leave += Control_Leave;
                }

                // Si el control tiene controles hijos (por ejemplo, un Panel), aplicar recursivamente
                if (control.HasChildren)
                {
                    AssignFocusEvents(control);
                }
            }
        }

        // Evento Enter: Cambia el BackColor cuando el control recibe el foco
        private void Control_Enter(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                control.BackColor = Color.YellowGreen; // Color cuando recibe el foco
            }
        }

        // Evento Leave: Restaura el BackColor original cuando el control pierde el foco
        private void Control_Leave(object sender, EventArgs e)
        {
            if (sender is Control control && originalColors.ContainsKey(control))
            {
                control.BackColor = originalColors[control]; // Restaurar el color original
            }
        }
        #endregion

        private async void Frm_Login_Load(object sender, EventArgs e)
        {
            var predeterMinadas = await _predeterminadasService.Obtener();
            var ListaEmpresas = await _empresaService.Lista();
            var itemsEmpresas = ListaEmpresas.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();

            cmbEmpresa.Items.Add(new OpcionesComboBox { Texto = "Seleccione una Empresa", Valor = 0});
            cmbEmpresa.InsertarItems(itemsEmpresas);
            cmbEmpresa.EstablecerValor(predeterMinadas.EmpresaID);

            var ListaSucursales = await _sucursalesService.Lista("", predeterMinadas.EmpresaID);
            var itemsSucursal = ListaSucursales.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();

            cmbSucursales.Items.Add(new OpcionesComboBox { Texto = "Seleccione una Sucursal", Valor = 0});
            cmbSucursales.InsertarItems(itemsSucursal);
            cmbSucursales.EstablecerValor(predeterMinadas.SucursalID);

            txtUsuario.Focus();
           
            
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
                cmbEmpresa.Focus();
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

        private async void cmbEmpresa_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbEmpresa.SelectedIndex > 0)
            {
                cmbSucursales.Items.Clear();
                cmbSucursales.Items.Add(new OpcionesComboBox { Texto = "Seleccione una Sucursal", Valor = 0});
                var itemEmpresa = (OpcionesComboBox)cmbEmpresa.SelectedItem!;
                vEmpresa = await _empresaService.Obtener(Convert.ToInt32(itemEmpresa.Valor));
                if (vEmpresa.Predeterminada != 0)
                {
                    chkEmpresa.Checked = false;
                }
                else
                {
                    chkEmpresa.Checked = true;
                }
                var ListaSucursales = await _sucursalesService.Lista("", itemEmpresa.Valor);
                var itemsSucursal = ListaSucursales.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
                cmbSucursales.InsertarItems(itemsSucursal);
                
                cmbSucursales.Focus();

            }
            else
            {
                cmbSucursales.Items.Clear();
                txtUsuario.Select();
            }
        }

        private void cmbSucursales_Enter(object sender, EventArgs e)
        {
            if (cmbEmpresa.SelectedIndex == -1)
            {
                cmbSucursales.Items.Clear();
                txtUsuario.Select();
            }

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            //Validamos que los campos no esten vacios
            if (txtUsuario.Text == string.Empty || txtClave.Text == string.Empty || cmbSucursales.SelectedIndex <= 0 || cmbEmpresa.SelectedIndex <= 0)
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
                OpcionesComboBox miEmpresa = (OpcionesComboBox)cmbEmpresa.SelectedItem;
                int idSeleccionado = miEmpresa.Valor;
                var empresaSeleccionada = await _empresaService.Obtener(idSeleccionado);

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
                VariablesGlobales.EmpresaID = empresaSeleccionada.ID;
                VariablesGlobales.EmpresaNombre = empresaSeleccionada.Nombre;
                VariablesGlobales.EmpresaLogo = empresaSeleccionada.LogoUrl;
                VariablesGlobales.SucursalID = cmbSucursales.SelectedIndex + 1;
                VariablesGlobales.CajaID = cajaAbierta;
                //Abrir el siguiente formulario
                Frm_Main mainForm = (Frm_Main)_serviceProvider.GetService(typeof(Frm_Main));
                this.Hide();

                mainForm.Show();
                if (mainForm != null)
                {
                    mainForm.txtNombreUsuario.Text = VariablesGlobales.UsuarioNombre;
                    mainForm.txtCategoria.Text = VariablesGlobales.RolNombre;
                    if (VariablesGlobales.EmpresaLogo != null)
                    {
                        //mainForm.pctLogoCentral.ImageLocation = VariablesGlobales.EmpresaLogo.ToString();
                        mainForm.pctLogoCentral.Image = Image.FromFile(VariablesGlobales.EmpresaLogo.ToString());

                    }
                }
                

            }

        }

        private async void checkBox2_CheckedChanged(object sender, EventArgs e)
        {


        }

        private async void chkEmpresa_CheckedChanged(object sender, EventArgs e)
        {
            if (cmbEmpresa.SelectedIndex > 0)
            {
                if (chkEmpresa.Checked == true)  //Values: 0 Predeterminada | 1 No Predeterminada
                {
                    vEmpresa.Predeterminada = 0;
                }
                if (chkEmpresa.Checked == false)
                {
                    vEmpresa.Predeterminada = 1;
                }
            }

            var _configura = await _empresaService.editar(vEmpresa);

        }
       
    }
}
