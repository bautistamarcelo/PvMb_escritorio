using Microsoft.Extensions.DependencyInjection;
using PVpresentation.Resources;
using PVservices.Interfaces;
using System.Runtime.InteropServices;

namespace PVpresentation.Formularios
{
    public partial class Frm_Main : Form
    {
        private readonly IServiceProvider _serviceProvider;
        private readonly IUsuariosService _usuariosService;
        private readonly IEmpresaService _empresaService;
        public Frm_Main(IServiceProvider serviceProvider, IUsuariosService usuariosService, IEmpresaService empresaService)
        {
            InitializeComponent();
            CustomizeMenu();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            _serviceProvider = serviceProvider;
            _usuariosService = usuariosService;
            _empresaService = empresaService;
        }

        #region FUNCIONALIDADES DEL FORMULARIO

        //METODOS PARA ARRASTRAR EL FORMULARIO------------------------------------------------------------------------------------------------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //RESIZE METODO PARA REDIMENCIONAR/CAMBIAR TAMAÑO A FORMULARIO EN TIEMPO DE EJECUCION ----------------------------------------------------------
        private int tolerance = 12;
        private const int WM_NCHITTEST = 132;
        private const int HTBOTTOMRIGHT = 17;
        private Rectangle sizeGripRectangle;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_NCHITTEST:
                    base.WndProc(ref m);
                    var hitPoint = this.PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                    if (sizeGripRectangle.Contains(hitPoint))
                        m.Result = new IntPtr(HTBOTTOMRIGHT);
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
        }
        //----------------DIBUJAR RECTANGULO / EXCLUIR ESQUINA PANEL 
        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            var region = new Region(new Rectangle(0, 0, this.ClientRectangle.Width, this.ClientRectangle.Height));

            sizeGripRectangle = new Rectangle(this.ClientRectangle.Width - tolerance, this.ClientRectangle.Height - tolerance, tolerance, tolerance);

            region.Exclude(sizeGripRectangle);
            this.panelContenedor.Region = region;
            this.Invalidate();
        }
        //----------------COLOR Y GRIP DE RECTANGULO INFERIOR
        protected override void OnPaint(PaintEventArgs e)
        {
            SolidBrush blueBrush = new SolidBrush(Color.FromArgb(74, 134, 160));
            e.Graphics.FillRectangle(blueBrush, sizeGripRectangle);

            base.OnPaint(e);
            ControlPaint.DrawSizeGrip(e.Graphics, Color.Transparent, sizeGripRectangle);
        }

        public void CustomizeMenu()
        {
            pnMenuPrincipal.Visible = true;
            pnSubAdministracion.Visible = false;
            pnSubCajas.Visible = false;
            pnSubCompras.Visible = false;
            pnSubVentas.Visible = false;
            pnSubConsultas.Visible = false;
            pnSubMantenimiento.Visible = false;
        }

        public void OcultarSubMEnu()
        {
            if (pnSubAdministracion.Visible == true)
                pnSubAdministracion.Visible = false;

            if (pnSubCajas.Visible == true)
                pnSubCajas.Visible = false;

            if (pnSubCompras.Visible == true)
                pnSubCompras.Visible = false;

            if (pnSubVentas.Visible == true)
                pnSubVentas.Visible = false;

            if (pnSubConsultas.Visible == true)
                pnSubConsultas.Visible = false;

            if (pnSubMantenimiento.Visible == true)
                pnSubMantenimiento.Visible = false;
        }

        public void ShowSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubMEnu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void AbrirFormulario<T>() where T : Form
        {
            Form formulario;
            formulario = pnMain.Controls.OfType<T>().FirstOrDefault(); // Busca el formulario en la colección
            if (pnMain.Controls.Count > 1)
                pnMain.Controls[0].Dispose();

            // Si el formulario no fue encontrado / no existe
            if (formulario == null)
            {
                //currentFormChild = formulario;
                formulario = _serviceProvider.GetRequiredService<T>();
                formulario.TopLevel = false;
                formulario.TopMost = false;
                pnMain.Controls.Add(formulario);
                pnMain.Tag = formulario;
                formulario.Dock = DockStyle.Fill;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                formulario.BringToFront();
            }
        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
        private int lx;
        private int ly;
        private int sw;
        private int sh;

        #endregion

        #region Barra de Titulo
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }
        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void pnSuperior_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region     menu principal
        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region ADMINISTRACION
        private void btnMenuAdministracion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubAdministracion);
        }
        private void btnAdmUsuarios_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Usuarios>();
        }
        private void btnAdmEmpresas_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Empresas>();
        }
        private void btnAdmSucursales_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Sucursales>();
        }
        private void btnAdmInventario_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        #endregion

        #region MANTENIMIENTO
        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubMantenimiento);
        }
        private void btnMntArticulos_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Productos>();
        }
        private void btnMntClientes_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Clientes>();
        }
        private void btnMntProveedores_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Proveedores>();
        }
        private void btnCmpNCredito_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        private void btnCmpNDebito_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        #endregion

        #region COMPRAS
        private void btnCompras_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubCompras);
        }
        private void btnCmpCompras_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Compras>();
        }
        private void btnComprasDetalle_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        #endregion

        #region VENTAS
        private void btnVentas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubVentas);
        }
        private async void btnCmpVentas_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();

            var cajaAbierta = await _usuariosService.BuscaCajaUsuario(VariablesGlobales.UsuarioID);
            if (cajaAbierta == 0)
            {
                MessageBox.Show("No tiene caja abierta, por favor abra una caja.", "Caja cerrada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //return;
            }
            else
            {
                if (VariablesGlobales.Frm_Venta01 == 0)
                {
                    VariablesGlobales.Frm_Venta01 = 1;

                    // Resolver el formulario de ventas desde el contenedor
                    var frmVenta01 = _serviceProvider.GetRequiredService<Frm_Ventas>();
                    frmVenta01.lblTituloForm.Text = "Instancia de Venta N° 1";
                    frmVenta01.txtInstancia.Text = "1";
                    frmVenta01.FormClosed += (sender, e) =>
                    {
                        if (this.WindowState == FormWindowState.Minimized)
                        {
                            this.WindowState = FormWindowState.Normal; // Restaurar
                        }
                    };
                    frmVenta01.Show();
                    this.WindowState = FormWindowState.Minimized;
                    return;
                }
                if (VariablesGlobales.Frm_Venta02 == 0)
                {
                    VariablesGlobales.Frm_Venta02 = 1;
                    var frmVenta02 = _serviceProvider.GetRequiredService<Frm_Ventas>();
                    frmVenta02.lblTituloForm.Text = "Instancia de Venta N° 2";
                    frmVenta02.txtInstancia.Text = "2";
                    frmVenta02.FormClosed += (sender, e) =>
                    {
                        if (this.WindowState == FormWindowState.Minimized)
                        {
                            this.WindowState = FormWindowState.Normal; // Restaurar
                        }
                    };
                    frmVenta02.Show();
                    this.WindowState = FormWindowState.Minimized;
                    return;
                }
                if (VariablesGlobales.Frm_Venta03 == 0)
                {
                    VariablesGlobales.Frm_Venta03 = 1;
                    var frmVenta03 = _serviceProvider.GetRequiredService<Frm_Ventas>();
                    frmVenta03.lblTituloForm.Text = "Instancia de Venta N° 3";
                    frmVenta03.txtInstancia.Text = "3";
                    frmVenta03.FormClosed += (sender, e) =>
                    {
                        if (this.WindowState == FormWindowState.Minimized)
                        {
                            this.WindowState = FormWindowState.Normal; // Restaurar
                        }
                    };
                    frmVenta03.Show();
                    this.WindowState = FormWindowState.Minimized;
                    return;
                }
            }

        }
        private void btnVentasDetalle_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        #endregion

        #region CAJAS
        private void btnCajas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubCajas);
        }
        private void btnCjaApertura_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Cajas>();
        }
        private void btnCjaIngresos_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            Frm_Cajas_Movimientos frmIngresos = _serviceProvider.GetRequiredService<Frm_Cajas_Movimientos>();

            //currentFormChild = formulario;
            frmIngresos = _serviceProvider.GetRequiredService<Frm_Cajas_Movimientos>();
            frmIngresos.TopLevel = false;
            frmIngresos.TopMost = false;
            pnMain.Controls.Add(frmIngresos);
            pnMain.Tag = frmIngresos;
            frmIngresos.Dock = DockStyle.Fill;
            frmIngresos.txtOpcion.Text = "1";
            frmIngresos.Show();
            frmIngresos.tabIngresos.Select();
            frmIngresos.BringToFront();
        }
        private void btnCjaSalidas_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            Frm_Cajas_Movimientos frmIngresos = _serviceProvider.GetRequiredService<Frm_Cajas_Movimientos>();

            //currentFormChild = formulario;
            frmIngresos = _serviceProvider.GetRequiredService<Frm_Cajas_Movimientos>();
            frmIngresos.TopLevel = false;
            frmIngresos.TopMost = false;
            pnMain.Controls.Add(frmIngresos);
            pnMain.Tag = frmIngresos;
            frmIngresos.Dock = DockStyle.Fill;
            frmIngresos.txtOpcion.Text = "2";
            frmIngresos.Show();
            frmIngresos.tabEgresos.Select();
            frmIngresos.BringToFront();
        }
        private void btnCmpCierresZ_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        #endregion

        #region CONSULTAS
        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubConsultas);
        }
        private void btnCnsCajas_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        private void btnCnsVentas_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        private void btnCnsCtaCte_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        private void btnCnsEstadisticos_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        #endregion

        #region RESPALDOS
        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnRespaldos);
        }
        private async void btnSubRespaldarDatos_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            string Respaldo = await _empresaService.RespaldarDB();
            MessageBox.Show(Respaldo, "Respaldar Base de Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnAdmRecuperaDatos_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }
        #endregion
        #endregion

        #region Panel Inferior
        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToLongDateString();
            txtHoraActual.Text = DateTime.Now.ToString("HH:mm:ssss");
        }
        #endregion

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Frm_Splash splash = new Frm_Splash(_serviceProvider);
            
            splash.Opcion.Text = "1";
            splash.label1.ForeColor = Color.White;
            splash.label3.ForeColor = Color.White;
            splash.label4.ForeColor = Color.White;
            splash.BackColor = Color.FromArgb(4,41,68);
            splash.ShowDialog();
            
        }
    }
}
