using Microsoft.Extensions.DependencyInjection;
using PVpresentation.Resources;
using System.Runtime.InteropServices;

namespace PVpresentation.Formularios
{
    public partial class Frm_Main : Form
    {
        private readonly IServiceProvider _serviceProvider;

        public Frm_Main(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            CustomizeMenu();
            //Estas lineas eliminan los parpadeos del formulario o controles en la interfaz grafica (Pero no en un 100%)
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            _serviceProvider = serviceProvider;
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
            pnSubComprobantes.Visible = false;
            pnSubConsultas.Visible = false;
            pnSubMantenimiento.Visible = false;

        }

        public void OcultarSubMEnu()
        {
            if (pnSubAdministracion.Visible == true)
                pnSubAdministracion.Visible = false;

            if (pnSubCajas.Visible == true)
                pnSubCajas.Visible = false;

            if (pnSubComprobantes.Visible == true)
                pnSubComprobantes.Visible = false;

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





        #endregion
        private void btnMenuAdministracion_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubAdministracion);
        }

        private void btnSubRespaldarDatos_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubMantenimiento);
        }

        private void btnComprobantes_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubComprobantes);
        }

        private void btnCajas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubCajas);
        }

        private void btnConsultas_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnSubConsultas);
        }

        private void btnAdmUsuarios_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Usuarios>();

        }

        private void btnAdmInventario_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }

        private void btnAdmListas_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }

        private void btnAdmRecuperaDatos_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
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

        private void btnCmpCompras_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }

        private void btnCmpVentas_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            if (VariablesGlobales.Frm_Venta01 == 0)
            {
                VariablesGlobales.Frm_Venta01 = 1;
                Frm_Ventas frmVenta01 = new Frm_Ventas();
                frmVenta01.lblTituloForm.Text = "Venta N° 1";
                frmVenta01.txtInstancia.Text = "1";
                
                frmVenta01.Show();
                return;
            }
            if (VariablesGlobales.Frm_Venta02 == 0)
            {
                VariablesGlobales.Frm_Venta02 = 1;
                Frm_Ventas frmVenta02 = new Frm_Ventas();
                frmVenta02.lblTituloForm.Text = "Venta N° 2";
                frmVenta02.txtInstancia.Text = "2";
                
                frmVenta02.Show();
                return;
            }
            if (VariablesGlobales.Frm_Venta03 == 0)
            {
                VariablesGlobales.Frm_Venta03 = 1;
                Frm_Ventas frmVenta03 = new Frm_Ventas();
                frmVenta03.lblTituloForm.Text = "Venta N° 3";
                frmVenta03.txtInstancia.Text = "3";
                
                frmVenta03.Show();
                return;
            }
        }

        private void btnCmpCierresZ_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }

        private void btnCmpNCredito_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }

        private void btnCmpNDebito_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }

        private void btnCjaApertura_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Cajas>();
        }

        private void btnCjaCierre_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }

        private void btnCjaSalidas_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
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

        private void btnMenuHome_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }

        private void IconoFormularioActual_Click(object sender, EventArgs e)
        {

        }

        //private void label1_Click(object sender, EventArgs e)
        //{

        //}
        private int lx;
        private int ly;
        private int sw;
        private int sh;

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

        private void btnRespaldos_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pnRespaldos);
        }

        private void timerFechaHora_Tick(object sender, EventArgs e)
        {
            txtFecha.Text = DateTime.Now.ToLongDateString();
            txtHoraActual.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        private void btnMntClientes_Click_1(object sender, EventArgs e)
        {

        }

        private void btnCjaIngresos_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
        }

        private void pnSuperior_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAdmSucursales_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Sucursales>();
        }

        private void btnAdmEmpresas_Click(object sender, EventArgs e)
        {
            OcultarSubMEnu();
            AbrirFormulario<Frm_Empresas>();
        }
    }
}
