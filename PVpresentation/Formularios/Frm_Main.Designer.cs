namespace PVpresentation.Formularios
{
    partial class Frm_Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Main));
            panelContenedor = new Panel();
            pnMain = new Panel();
            pictureBox1 = new PictureBox();
            pnInferior = new Panel();
            txtFecha = new TextBox();
            txtHoraActual = new TextBox();
            txtNombreUsuario = new TextBox();
            txtCategoria = new TextBox();
            pictureBox4 = new PictureBox();
            pnSuperior = new Panel();
            IconoFormularioActual = new FontAwesome.Sharp.IconPictureBox();
            btnMaximizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            LblTituloFormulario = new Label();
            pnMenuPrincipal = new Panel();
            btnSalir = new FontAwesome.Sharp.IconButton();
            pnRespaldos = new Panel();
            btnAdmRecuperaDatos = new FontAwesome.Sharp.IconButton();
            btnAdmRespaldarDatos = new FontAwesome.Sharp.IconButton();
            btnRespaldos = new FontAwesome.Sharp.IconButton();
            pnSubConsultas = new Panel();
            btnCnsEstadisticos = new FontAwesome.Sharp.IconButton();
            btnCnsCtaCte = new FontAwesome.Sharp.IconButton();
            btnCnsVentas = new FontAwesome.Sharp.IconButton();
            btnCnsCajas = new FontAwesome.Sharp.IconButton();
            btnConsultas = new FontAwesome.Sharp.IconButton();
            pnSubCajas = new Panel();
            btnCjaSalidas = new FontAwesome.Sharp.IconButton();
            btnCjaIngresos = new FontAwesome.Sharp.IconButton();
            btnCjaApertura = new FontAwesome.Sharp.IconButton();
            btnCajas = new FontAwesome.Sharp.IconButton();
            pnSubComprobantes = new Panel();
            btnCmpNDebito = new FontAwesome.Sharp.IconButton();
            btnCmpNCredito = new FontAwesome.Sharp.IconButton();
            btnCmpCierresZ = new FontAwesome.Sharp.IconButton();
            btnCmpVentas = new FontAwesome.Sharp.IconButton();
            btnCmpCompras = new FontAwesome.Sharp.IconButton();
            btnComprobantes = new FontAwesome.Sharp.IconButton();
            pnSubMantenimiento = new Panel();
            btnMntProveedores = new FontAwesome.Sharp.IconButton();
            btnMntClientes = new FontAwesome.Sharp.IconButton();
            btnMntArticulos = new FontAwesome.Sharp.IconButton();
            btnMantenimiento = new FontAwesome.Sharp.IconButton();
            pnSubAdministracion = new Panel();
            btnAdmInventario = new FontAwesome.Sharp.IconButton();
            btnAdmSucursales = new FontAwesome.Sharp.IconButton();
            btnAdmEmpresas = new FontAwesome.Sharp.IconButton();
            btnAdmUsuarios = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            btnMenuHome = new FontAwesome.Sharp.IconButton();
            pnLogo = new Panel();
            pictureBox2 = new PictureBox();
            timerFechaHora = new System.Windows.Forms.Timer(components);
            panelContenedor.SuspendLayout();
            pnMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnInferior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            pnSuperior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)IconoFormularioActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            pnMenuPrincipal.SuspendLayout();
            pnRespaldos.SuspendLayout();
            pnSubConsultas.SuspendLayout();
            pnSubCajas.SuspendLayout();
            pnSubComprobantes.SuspendLayout();
            pnSubMantenimiento.SuspendLayout();
            pnSubAdministracion.SuspendLayout();
            pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = Color.FromArgb(74, 134, 160);
            panelContenedor.Controls.Add(pnMain);
            panelContenedor.Controls.Add(pnInferior);
            panelContenedor.Controls.Add(pnSuperior);
            panelContenedor.Controls.Add(pnMenuPrincipal);
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(0, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1250, 720);
            panelContenedor.TabIndex = 0;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.FromArgb(74, 134, 160);
            pnMain.Controls.Add(pictureBox1);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(250, 45);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1000, 587);
            pnMain.TabIndex = 13;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(184, 141);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(641, 317);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pnInferior
            // 
            pnInferior.BackColor = Color.FromArgb(74, 134, 160);
            pnInferior.Controls.Add(txtFecha);
            pnInferior.Controls.Add(txtHoraActual);
            pnInferior.Controls.Add(txtNombreUsuario);
            pnInferior.Controls.Add(txtCategoria);
            pnInferior.Controls.Add(pictureBox4);
            pnInferior.Dock = DockStyle.Bottom;
            pnInferior.Location = new Point(250, 632);
            pnInferior.Name = "pnInferior";
            pnInferior.Size = new Size(1000, 88);
            pnInferior.TabIndex = 12;
            // 
            // txtFecha
            // 
            txtFecha.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtFecha.BackColor = Color.FromArgb(74, 134, 160);
            txtFecha.BorderStyle = BorderStyle.None;
            txtFecha.Font = new Font("Microsoft Sans Serif", 11F);
            txtFecha.ForeColor = Color.WhiteSmoke;
            txtFecha.Location = new Point(743, 58);
            txtFecha.Name = "txtFecha";
            txtFecha.ReadOnly = true;
            txtFecha.Size = new Size(245, 17);
            txtFecha.TabIndex = 9;
            txtFecha.Text = "Lunes, 26 de septiembre 2018";
            txtFecha.TextAlign = HorizontalAlignment.Right;
            // 
            // txtHoraActual
            // 
            txtHoraActual.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtHoraActual.BackColor = Color.FromArgb(74, 134, 160);
            txtHoraActual.BorderStyle = BorderStyle.None;
            txtHoraActual.Font = new Font("Microsoft Sans Serif", 28F);
            txtHoraActual.ForeColor = Color.WhiteSmoke;
            txtHoraActual.Location = new Point(779, 16);
            txtHoraActual.Name = "txtHoraActual";
            txtHoraActual.ReadOnly = true;
            txtHoraActual.Size = new Size(189, 43);
            txtHoraActual.TabIndex = 8;
            txtHoraActual.Text = "23:15:45";
            txtHoraActual.TextAlign = HorizontalAlignment.Right;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtNombreUsuario.BackColor = Color.FromArgb(74, 134, 160);
            txtNombreUsuario.BorderStyle = BorderStyle.None;
            txtNombreUsuario.Font = new Font("Microsoft Sans Serif", 11F);
            txtNombreUsuario.ForeColor = Color.WhiteSmoke;
            txtNombreUsuario.Location = new Point(86, 37);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.ReadOnly = true;
            txtNombreUsuario.Size = new Size(251, 17);
            txtNombreUsuario.TabIndex = 7;
            txtNombreUsuario.Text = "Nombre de Usuario";
            // 
            // txtCategoria
            // 
            txtCategoria.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtCategoria.BackColor = Color.FromArgb(74, 134, 160);
            txtCategoria.BorderStyle = BorderStyle.None;
            txtCategoria.Font = new Font("Microsoft Sans Serif", 10F);
            txtCategoria.ForeColor = Color.WhiteSmoke;
            txtCategoria.Location = new Point(86, 60);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.ReadOnly = true;
            txtCategoria.Size = new Size(251, 16);
            txtCategoria.TabIndex = 6;
            txtCategoria.Text = "Categoria";
            // 
            // pictureBox4
            // 
            pictureBox4.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(16, 16);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(64, 60);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            // 
            // pnSuperior
            // 
            pnSuperior.BackColor = Color.FromArgb(4, 41, 68);
            pnSuperior.Controls.Add(IconoFormularioActual);
            pnSuperior.Controls.Add(btnMaximizar);
            pnSuperior.Controls.Add(btnRestaurar);
            pnSuperior.Controls.Add(btnCerrar);
            pnSuperior.Controls.Add(btnMinimizar);
            pnSuperior.Controls.Add(LblTituloFormulario);
            pnSuperior.Dock = DockStyle.Top;
            pnSuperior.Location = new Point(250, 0);
            pnSuperior.Margin = new Padding(0);
            pnSuperior.Name = "pnSuperior";
            pnSuperior.Size = new Size(1000, 45);
            pnSuperior.TabIndex = 11;
            pnSuperior.Paint += pnSuperior_Paint;
            pnSuperior.MouseMove += pnSuperior_MouseMove;
            // 
            // IconoFormularioActual
            // 
            IconoFormularioActual.BackColor = Color.FromArgb(4, 41, 68);
            IconoFormularioActual.ForeColor = Color.WhiteSmoke;
            IconoFormularioActual.IconChar = FontAwesome.Sharp.IconChar.House;
            IconoFormularioActual.IconColor = Color.WhiteSmoke;
            IconoFormularioActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            IconoFormularioActual.Location = new Point(16, 7);
            IconoFormularioActual.Name = "IconoFormularioActual";
            IconoFormularioActual.Size = new Size(32, 32);
            IconoFormularioActual.TabIndex = 9;
            IconoFormularioActual.TabStop = false;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = Properties.Resources.maximize3;
            btnMaximizar.Location = new Point(942, 10);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(20, 21);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 7;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Properties.Resources.Normal;
            btnRestaurar.Location = new Point(942, 10);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(20, 21);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 8;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.Close;
            btnCerrar.Location = new Point(968, 10);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 21);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 6;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnSalir_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.Minimize;
            btnMinimizar.Location = new Point(916, 10);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(20, 21);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 5;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
            // 
            // LblTituloFormulario
            // 
            LblTituloFormulario.AutoSize = true;
            LblTituloFormulario.Font = new Font("Microsoft Sans Serif", 10F);
            LblTituloFormulario.ForeColor = Color.WhiteSmoke;
            LblTituloFormulario.Location = new Point(54, 14);
            LblTituloFormulario.Name = "LblTituloFormulario";
            LblTituloFormulario.Size = new Size(45, 17);
            LblTituloFormulario.TabIndex = 4;
            LblTituloFormulario.Text = "Home";
            // 
            // pnMenuPrincipal
            // 
            pnMenuPrincipal.AutoScroll = true;
            pnMenuPrincipal.BackColor = Color.FromArgb(4, 41, 68);
            pnMenuPrincipal.Controls.Add(btnSalir);
            pnMenuPrincipal.Controls.Add(pnRespaldos);
            pnMenuPrincipal.Controls.Add(btnRespaldos);
            pnMenuPrincipal.Controls.Add(pnSubConsultas);
            pnMenuPrincipal.Controls.Add(btnConsultas);
            pnMenuPrincipal.Controls.Add(pnSubCajas);
            pnMenuPrincipal.Controls.Add(btnCajas);
            pnMenuPrincipal.Controls.Add(pnSubComprobantes);
            pnMenuPrincipal.Controls.Add(btnComprobantes);
            pnMenuPrincipal.Controls.Add(pnSubMantenimiento);
            pnMenuPrincipal.Controls.Add(btnMantenimiento);
            pnMenuPrincipal.Controls.Add(pnSubAdministracion);
            pnMenuPrincipal.Controls.Add(iconButton1);
            pnMenuPrincipal.Controls.Add(btnMenuHome);
            pnMenuPrincipal.Controls.Add(pnLogo);
            pnMenuPrincipal.Dock = DockStyle.Left;
            pnMenuPrincipal.Location = new Point(0, 0);
            pnMenuPrincipal.Name = "pnMenuPrincipal";
            pnMenuPrincipal.Size = new Size(250, 720);
            pnMenuPrincipal.TabIndex = 0;
            // 
            // btnSalir
            // 
            btnSalir.BackgroundImageLayout = ImageLayout.None;
            btnSalir.Cursor = Cursors.Hand;
            btnSalir.Dock = DockStyle.Top;
            btnSalir.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnSalir.FlatAppearance.BorderSize = 0;
            btnSalir.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnSalir.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnSalir.FlatStyle = FlatStyle.Flat;
            btnSalir.Font = new Font("Microsoft Sans Serif", 10F);
            btnSalir.ForeColor = Color.WhiteSmoke;
            btnSalir.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            btnSalir.IconColor = Color.WhiteSmoke;
            btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnSalir.IconSize = 32;
            btnSalir.ImageAlign = ContentAlignment.MiddleLeft;
            btnSalir.Location = new Point(0, 1393);
            btnSalir.Margin = new Padding(0);
            btnSalir.Name = "btnSalir";
            btnSalir.Padding = new Padding(15, 0, 0, 0);
            btnSalir.Size = new Size(233, 50);
            btnSalir.TabIndex = 17;
            btnSalir.Text = "Salir";
            btnSalir.TextAlign = ContentAlignment.MiddleLeft;
            btnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // pnRespaldos
            // 
            pnRespaldos.BackColor = Color.FromArgb(45, 66, 91);
            pnRespaldos.Controls.Add(btnAdmRecuperaDatos);
            pnRespaldos.Controls.Add(btnAdmRespaldarDatos);
            pnRespaldos.Dock = DockStyle.Top;
            pnRespaldos.Location = new Point(0, 1303);
            pnRespaldos.Name = "pnRespaldos";
            pnRespaldos.Size = new Size(233, 90);
            pnRespaldos.TabIndex = 16;
            pnRespaldos.Visible = false;
            // 
            // btnAdmRecuperaDatos
            // 
            btnAdmRecuperaDatos.BackgroundImageLayout = ImageLayout.None;
            btnAdmRecuperaDatos.Cursor = Cursors.Hand;
            btnAdmRecuperaDatos.Dock = DockStyle.Top;
            btnAdmRecuperaDatos.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnAdmRecuperaDatos.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnAdmRecuperaDatos.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnAdmRecuperaDatos.FlatStyle = FlatStyle.Flat;
            btnAdmRecuperaDatos.Font = new Font("Microsoft Sans Serif", 10F);
            btnAdmRecuperaDatos.ForeColor = Color.WhiteSmoke;
            btnAdmRecuperaDatos.IconChar = FontAwesome.Sharp.IconChar.Server;
            btnAdmRecuperaDatos.IconColor = Color.WhiteSmoke;
            btnAdmRecuperaDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmRecuperaDatos.IconSize = 26;
            btnAdmRecuperaDatos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmRecuperaDatos.Location = new Point(0, 45);
            btnAdmRecuperaDatos.Margin = new Padding(0);
            btnAdmRecuperaDatos.Name = "btnAdmRecuperaDatos";
            btnAdmRecuperaDatos.Padding = new Padding(25, 0, 0, 0);
            btnAdmRecuperaDatos.Size = new Size(233, 45);
            btnAdmRecuperaDatos.TabIndex = 19;
            btnAdmRecuperaDatos.Text = "Recuperar Datos";
            btnAdmRecuperaDatos.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmRecuperaDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmRecuperaDatos.UseVisualStyleBackColor = false;
            btnAdmRecuperaDatos.Click += btnAdmRecuperaDatos_Click;
            // 
            // btnAdmRespaldarDatos
            // 
            btnAdmRespaldarDatos.BackgroundImageLayout = ImageLayout.None;
            btnAdmRespaldarDatos.Cursor = Cursors.Hand;
            btnAdmRespaldarDatos.Dock = DockStyle.Top;
            btnAdmRespaldarDatos.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnAdmRespaldarDatos.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnAdmRespaldarDatos.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnAdmRespaldarDatos.FlatStyle = FlatStyle.Flat;
            btnAdmRespaldarDatos.Font = new Font("Microsoft Sans Serif", 10F);
            btnAdmRespaldarDatos.ForeColor = Color.WhiteSmoke;
            btnAdmRespaldarDatos.IconChar = FontAwesome.Sharp.IconChar.Server;
            btnAdmRespaldarDatos.IconColor = Color.WhiteSmoke;
            btnAdmRespaldarDatos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmRespaldarDatos.IconSize = 26;
            btnAdmRespaldarDatos.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmRespaldarDatos.Location = new Point(0, 0);
            btnAdmRespaldarDatos.Margin = new Padding(0);
            btnAdmRespaldarDatos.Name = "btnAdmRespaldarDatos";
            btnAdmRespaldarDatos.Padding = new Padding(25, 0, 0, 0);
            btnAdmRespaldarDatos.Size = new Size(233, 45);
            btnAdmRespaldarDatos.TabIndex = 18;
            btnAdmRespaldarDatos.Text = "Respaldar Datos";
            btnAdmRespaldarDatos.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmRespaldarDatos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmRespaldarDatos.UseVisualStyleBackColor = false;
            btnAdmRespaldarDatos.Click += btnSubRespaldarDatos_Click;
            // 
            // btnRespaldos
            // 
            btnRespaldos.BackgroundImageLayout = ImageLayout.None;
            btnRespaldos.Cursor = Cursors.Hand;
            btnRespaldos.Dock = DockStyle.Top;
            btnRespaldos.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnRespaldos.FlatAppearance.BorderSize = 0;
            btnRespaldos.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnRespaldos.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnRespaldos.FlatStyle = FlatStyle.Flat;
            btnRespaldos.Font = new Font("Microsoft Sans Serif", 10F);
            btnRespaldos.ForeColor = Color.WhiteSmoke;
            btnRespaldos.IconChar = FontAwesome.Sharp.IconChar.Server;
            btnRespaldos.IconColor = Color.WhiteSmoke;
            btnRespaldos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnRespaldos.IconSize = 32;
            btnRespaldos.ImageAlign = ContentAlignment.MiddleLeft;
            btnRespaldos.Location = new Point(0, 1253);
            btnRespaldos.Margin = new Padding(0);
            btnRespaldos.Name = "btnRespaldos";
            btnRespaldos.Padding = new Padding(15, 0, 0, 0);
            btnRespaldos.Size = new Size(233, 50);
            btnRespaldos.TabIndex = 14;
            btnRespaldos.Text = "Respaldos";
            btnRespaldos.TextAlign = ContentAlignment.MiddleLeft;
            btnRespaldos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnRespaldos.UseVisualStyleBackColor = false;
            btnRespaldos.Click += btnRespaldos_Click;
            // 
            // pnSubConsultas
            // 
            pnSubConsultas.BackColor = Color.FromArgb(45, 66, 91);
            pnSubConsultas.Controls.Add(btnCnsEstadisticos);
            pnSubConsultas.Controls.Add(btnCnsCtaCte);
            pnSubConsultas.Controls.Add(btnCnsVentas);
            pnSubConsultas.Controls.Add(btnCnsCajas);
            pnSubConsultas.Dock = DockStyle.Top;
            pnSubConsultas.Location = new Point(0, 1072);
            pnSubConsultas.Name = "pnSubConsultas";
            pnSubConsultas.Size = new Size(233, 181);
            pnSubConsultas.TabIndex = 13;
            // 
            // btnCnsEstadisticos
            // 
            btnCnsEstadisticos.BackgroundImageLayout = ImageLayout.None;
            btnCnsEstadisticos.Cursor = Cursors.Hand;
            btnCnsEstadisticos.Dock = DockStyle.Top;
            btnCnsEstadisticos.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCnsEstadisticos.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCnsEstadisticos.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCnsEstadisticos.FlatStyle = FlatStyle.Flat;
            btnCnsEstadisticos.Font = new Font("Microsoft Sans Serif", 10F);
            btnCnsEstadisticos.ForeColor = Color.WhiteSmoke;
            btnCnsEstadisticos.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnCnsEstadisticos.IconColor = Color.WhiteSmoke;
            btnCnsEstadisticos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCnsEstadisticos.IconSize = 26;
            btnCnsEstadisticos.ImageAlign = ContentAlignment.MiddleLeft;
            btnCnsEstadisticos.Location = new Point(0, 135);
            btnCnsEstadisticos.Margin = new Padding(0);
            btnCnsEstadisticos.Name = "btnCnsEstadisticos";
            btnCnsEstadisticos.Padding = new Padding(25, 0, 0, 0);
            btnCnsEstadisticos.Size = new Size(233, 45);
            btnCnsEstadisticos.TabIndex = 17;
            btnCnsEstadisticos.Text = "Estadísticos";
            btnCnsEstadisticos.TextAlign = ContentAlignment.MiddleLeft;
            btnCnsEstadisticos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCnsEstadisticos.UseVisualStyleBackColor = false;
            btnCnsEstadisticos.Click += btnCnsEstadisticos_Click;
            // 
            // btnCnsCtaCte
            // 
            btnCnsCtaCte.BackgroundImageLayout = ImageLayout.None;
            btnCnsCtaCte.Cursor = Cursors.Hand;
            btnCnsCtaCte.Dock = DockStyle.Top;
            btnCnsCtaCte.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCnsCtaCte.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCnsCtaCte.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCnsCtaCte.FlatStyle = FlatStyle.Flat;
            btnCnsCtaCte.Font = new Font("Microsoft Sans Serif", 10F);
            btnCnsCtaCte.ForeColor = Color.WhiteSmoke;
            btnCnsCtaCte.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnCnsCtaCte.IconColor = Color.WhiteSmoke;
            btnCnsCtaCte.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCnsCtaCte.IconSize = 26;
            btnCnsCtaCte.ImageAlign = ContentAlignment.MiddleLeft;
            btnCnsCtaCte.Location = new Point(0, 90);
            btnCnsCtaCte.Margin = new Padding(0);
            btnCnsCtaCte.Name = "btnCnsCtaCte";
            btnCnsCtaCte.Padding = new Padding(25, 0, 0, 0);
            btnCnsCtaCte.Size = new Size(233, 45);
            btnCnsCtaCte.TabIndex = 16;
            btnCnsCtaCte.Text = "Cta. Cte.";
            btnCnsCtaCte.TextAlign = ContentAlignment.MiddleLeft;
            btnCnsCtaCte.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCnsCtaCte.UseVisualStyleBackColor = false;
            btnCnsCtaCte.Click += btnCnsCtaCte_Click;
            // 
            // btnCnsVentas
            // 
            btnCnsVentas.BackgroundImageLayout = ImageLayout.None;
            btnCnsVentas.Cursor = Cursors.Hand;
            btnCnsVentas.Dock = DockStyle.Top;
            btnCnsVentas.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCnsVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCnsVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCnsVentas.FlatStyle = FlatStyle.Flat;
            btnCnsVentas.Font = new Font("Microsoft Sans Serif", 10F);
            btnCnsVentas.ForeColor = Color.WhiteSmoke;
            btnCnsVentas.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnCnsVentas.IconColor = Color.WhiteSmoke;
            btnCnsVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCnsVentas.IconSize = 26;
            btnCnsVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCnsVentas.Location = new Point(0, 45);
            btnCnsVentas.Margin = new Padding(0);
            btnCnsVentas.Name = "btnCnsVentas";
            btnCnsVentas.Padding = new Padding(25, 0, 0, 0);
            btnCnsVentas.Size = new Size(233, 45);
            btnCnsVentas.TabIndex = 15;
            btnCnsVentas.Text = "Ventas";
            btnCnsVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnCnsVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCnsVentas.UseVisualStyleBackColor = false;
            btnCnsVentas.Click += btnCnsVentas_Click;
            // 
            // btnCnsCajas
            // 
            btnCnsCajas.BackgroundImageLayout = ImageLayout.None;
            btnCnsCajas.Cursor = Cursors.Hand;
            btnCnsCajas.Dock = DockStyle.Top;
            btnCnsCajas.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCnsCajas.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCnsCajas.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCnsCajas.FlatStyle = FlatStyle.Flat;
            btnCnsCajas.Font = new Font("Microsoft Sans Serif", 10F);
            btnCnsCajas.ForeColor = Color.WhiteSmoke;
            btnCnsCajas.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnCnsCajas.IconColor = Color.WhiteSmoke;
            btnCnsCajas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCnsCajas.IconSize = 26;
            btnCnsCajas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCnsCajas.Location = new Point(0, 0);
            btnCnsCajas.Margin = new Padding(0);
            btnCnsCajas.Name = "btnCnsCajas";
            btnCnsCajas.Padding = new Padding(25, 0, 0, 0);
            btnCnsCajas.Size = new Size(233, 45);
            btnCnsCajas.TabIndex = 14;
            btnCnsCajas.Text = "Cajas";
            btnCnsCajas.TextAlign = ContentAlignment.MiddleLeft;
            btnCnsCajas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCnsCajas.UseVisualStyleBackColor = false;
            btnCnsCajas.Click += btnCnsCajas_Click;
            // 
            // btnConsultas
            // 
            btnConsultas.BackgroundImageLayout = ImageLayout.None;
            btnConsultas.Cursor = Cursors.Hand;
            btnConsultas.Dock = DockStyle.Top;
            btnConsultas.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnConsultas.FlatAppearance.BorderSize = 0;
            btnConsultas.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnConsultas.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnConsultas.FlatStyle = FlatStyle.Flat;
            btnConsultas.Font = new Font("Microsoft Sans Serif", 10F);
            btnConsultas.ForeColor = Color.WhiteSmoke;
            btnConsultas.IconChar = FontAwesome.Sharp.IconChar.ChartColumn;
            btnConsultas.IconColor = Color.WhiteSmoke;
            btnConsultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnConsultas.IconSize = 32;
            btnConsultas.ImageAlign = ContentAlignment.MiddleLeft;
            btnConsultas.Location = new Point(0, 1022);
            btnConsultas.Margin = new Padding(0);
            btnConsultas.Name = "btnConsultas";
            btnConsultas.Padding = new Padding(15, 0, 0, 0);
            btnConsultas.Size = new Size(233, 50);
            btnConsultas.TabIndex = 12;
            btnConsultas.Text = "Consultas";
            btnConsultas.TextAlign = ContentAlignment.MiddleLeft;
            btnConsultas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnConsultas.UseVisualStyleBackColor = false;
            btnConsultas.Click += btnConsultas_Click;
            // 
            // pnSubCajas
            // 
            pnSubCajas.BackColor = Color.FromArgb(45, 66, 91);
            pnSubCajas.Controls.Add(btnCjaSalidas);
            pnSubCajas.Controls.Add(btnCjaIngresos);
            pnSubCajas.Controls.Add(btnCjaApertura);
            pnSubCajas.Dock = DockStyle.Top;
            pnSubCajas.Location = new Point(0, 886);
            pnSubCajas.Name = "pnSubCajas";
            pnSubCajas.Size = new Size(233, 136);
            pnSubCajas.TabIndex = 11;
            // 
            // btnCjaSalidas
            // 
            btnCjaSalidas.BackgroundImageLayout = ImageLayout.None;
            btnCjaSalidas.Cursor = Cursors.Hand;
            btnCjaSalidas.Dock = DockStyle.Top;
            btnCjaSalidas.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCjaSalidas.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCjaSalidas.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCjaSalidas.FlatStyle = FlatStyle.Flat;
            btnCjaSalidas.Font = new Font("Microsoft Sans Serif", 10F);
            btnCjaSalidas.ForeColor = Color.WhiteSmoke;
            btnCjaSalidas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnCjaSalidas.IconColor = Color.WhiteSmoke;
            btnCjaSalidas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCjaSalidas.IconSize = 26;
            btnCjaSalidas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCjaSalidas.Location = new Point(0, 90);
            btnCjaSalidas.Margin = new Padding(0);
            btnCjaSalidas.Name = "btnCjaSalidas";
            btnCjaSalidas.Padding = new Padding(25, 0, 0, 0);
            btnCjaSalidas.Size = new Size(233, 45);
            btnCjaSalidas.TabIndex = 14;
            btnCjaSalidas.Text = "Salidas / Gastos";
            btnCjaSalidas.TextAlign = ContentAlignment.MiddleLeft;
            btnCjaSalidas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCjaSalidas.UseVisualStyleBackColor = false;
            btnCjaSalidas.Click += btnCjaSalidas_Click;
            // 
            // btnCjaIngresos
            // 
            btnCjaIngresos.BackgroundImageLayout = ImageLayout.None;
            btnCjaIngresos.Cursor = Cursors.Hand;
            btnCjaIngresos.Dock = DockStyle.Top;
            btnCjaIngresos.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCjaIngresos.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCjaIngresos.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCjaIngresos.FlatStyle = FlatStyle.Flat;
            btnCjaIngresos.Font = new Font("Microsoft Sans Serif", 10F);
            btnCjaIngresos.ForeColor = Color.WhiteSmoke;
            btnCjaIngresos.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnCjaIngresos.IconColor = Color.WhiteSmoke;
            btnCjaIngresos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCjaIngresos.IconSize = 26;
            btnCjaIngresos.ImageAlign = ContentAlignment.MiddleLeft;
            btnCjaIngresos.Location = new Point(0, 45);
            btnCjaIngresos.Margin = new Padding(0);
            btnCjaIngresos.Name = "btnCjaIngresos";
            btnCjaIngresos.Padding = new Padding(25, 0, 0, 0);
            btnCjaIngresos.Size = new Size(233, 45);
            btnCjaIngresos.TabIndex = 13;
            btnCjaIngresos.Text = "Ingresos / Cobros";
            btnCjaIngresos.TextAlign = ContentAlignment.MiddleLeft;
            btnCjaIngresos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCjaIngresos.UseVisualStyleBackColor = false;
            btnCjaIngresos.Click += btnCjaIngresos_Click;
            // 
            // btnCjaApertura
            // 
            btnCjaApertura.BackgroundImageLayout = ImageLayout.None;
            btnCjaApertura.Cursor = Cursors.Hand;
            btnCjaApertura.Dock = DockStyle.Top;
            btnCjaApertura.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCjaApertura.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCjaApertura.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCjaApertura.FlatStyle = FlatStyle.Flat;
            btnCjaApertura.Font = new Font("Microsoft Sans Serif", 10F);
            btnCjaApertura.ForeColor = Color.WhiteSmoke;
            btnCjaApertura.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnCjaApertura.IconColor = Color.WhiteSmoke;
            btnCjaApertura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCjaApertura.IconSize = 26;
            btnCjaApertura.ImageAlign = ContentAlignment.MiddleLeft;
            btnCjaApertura.Location = new Point(0, 0);
            btnCjaApertura.Margin = new Padding(0);
            btnCjaApertura.Name = "btnCjaApertura";
            btnCjaApertura.Padding = new Padding(25, 0, 0, 0);
            btnCjaApertura.Size = new Size(233, 45);
            btnCjaApertura.TabIndex = 12;
            btnCjaApertura.Text = "Apertura / Cierre";
            btnCjaApertura.TextAlign = ContentAlignment.MiddleLeft;
            btnCjaApertura.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCjaApertura.UseVisualStyleBackColor = false;
            btnCjaApertura.Click += btnCjaApertura_Click;
            // 
            // btnCajas
            // 
            btnCajas.BackgroundImageLayout = ImageLayout.None;
            btnCajas.Cursor = Cursors.Hand;
            btnCajas.Dock = DockStyle.Top;
            btnCajas.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCajas.FlatAppearance.BorderSize = 0;
            btnCajas.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCajas.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCajas.FlatStyle = FlatStyle.Flat;
            btnCajas.Font = new Font("Microsoft Sans Serif", 10F);
            btnCajas.ForeColor = Color.WhiteSmoke;
            btnCajas.IconChar = FontAwesome.Sharp.IconChar.CashRegister;
            btnCajas.IconColor = Color.WhiteSmoke;
            btnCajas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCajas.IconSize = 32;
            btnCajas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCajas.Location = new Point(0, 836);
            btnCajas.Margin = new Padding(0);
            btnCajas.Name = "btnCajas";
            btnCajas.Padding = new Padding(15, 0, 0, 0);
            btnCajas.Size = new Size(233, 50);
            btnCajas.TabIndex = 10;
            btnCajas.Text = "Cajas";
            btnCajas.TextAlign = ContentAlignment.MiddleLeft;
            btnCajas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCajas.UseVisualStyleBackColor = false;
            btnCajas.Click += btnCajas_Click;
            // 
            // pnSubComprobantes
            // 
            pnSubComprobantes.BackColor = Color.FromArgb(45, 66, 91);
            pnSubComprobantes.Controls.Add(btnCmpNDebito);
            pnSubComprobantes.Controls.Add(btnCmpNCredito);
            pnSubComprobantes.Controls.Add(btnCmpCierresZ);
            pnSubComprobantes.Controls.Add(btnCmpVentas);
            pnSubComprobantes.Controls.Add(btnCmpCompras);
            pnSubComprobantes.Dock = DockStyle.Top;
            pnSubComprobantes.Location = new Point(0, 610);
            pnSubComprobantes.Name = "pnSubComprobantes";
            pnSubComprobantes.Size = new Size(233, 226);
            pnSubComprobantes.TabIndex = 9;
            // 
            // btnCmpNDebito
            // 
            btnCmpNDebito.BackgroundImageLayout = ImageLayout.None;
            btnCmpNDebito.Cursor = Cursors.Hand;
            btnCmpNDebito.Dock = DockStyle.Top;
            btnCmpNDebito.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCmpNDebito.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCmpNDebito.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCmpNDebito.FlatStyle = FlatStyle.Flat;
            btnCmpNDebito.Font = new Font("Microsoft Sans Serif", 10F);
            btnCmpNDebito.ForeColor = Color.WhiteSmoke;
            btnCmpNDebito.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            btnCmpNDebito.IconColor = Color.WhiteSmoke;
            btnCmpNDebito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCmpNDebito.IconSize = 26;
            btnCmpNDebito.ImageAlign = ContentAlignment.MiddleLeft;
            btnCmpNDebito.Location = new Point(0, 180);
            btnCmpNDebito.Margin = new Padding(0);
            btnCmpNDebito.Name = "btnCmpNDebito";
            btnCmpNDebito.Padding = new Padding(25, 0, 0, 0);
            btnCmpNDebito.Size = new Size(233, 45);
            btnCmpNDebito.TabIndex = 15;
            btnCmpNDebito.Text = "Notas de Débito";
            btnCmpNDebito.TextAlign = ContentAlignment.MiddleLeft;
            btnCmpNDebito.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCmpNDebito.UseVisualStyleBackColor = false;
            btnCmpNDebito.Click += btnCmpNDebito_Click;
            // 
            // btnCmpNCredito
            // 
            btnCmpNCredito.BackgroundImageLayout = ImageLayout.None;
            btnCmpNCredito.Cursor = Cursors.Hand;
            btnCmpNCredito.Dock = DockStyle.Top;
            btnCmpNCredito.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCmpNCredito.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCmpNCredito.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCmpNCredito.FlatStyle = FlatStyle.Flat;
            btnCmpNCredito.Font = new Font("Microsoft Sans Serif", 10F);
            btnCmpNCredito.ForeColor = Color.WhiteSmoke;
            btnCmpNCredito.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            btnCmpNCredito.IconColor = Color.WhiteSmoke;
            btnCmpNCredito.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCmpNCredito.IconSize = 26;
            btnCmpNCredito.ImageAlign = ContentAlignment.MiddleLeft;
            btnCmpNCredito.Location = new Point(0, 135);
            btnCmpNCredito.Margin = new Padding(0);
            btnCmpNCredito.Name = "btnCmpNCredito";
            btnCmpNCredito.Padding = new Padding(25, 0, 0, 0);
            btnCmpNCredito.Size = new Size(233, 45);
            btnCmpNCredito.TabIndex = 14;
            btnCmpNCredito.Text = "Notas de Crédito";
            btnCmpNCredito.TextAlign = ContentAlignment.MiddleLeft;
            btnCmpNCredito.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCmpNCredito.UseVisualStyleBackColor = false;
            btnCmpNCredito.Click += btnCmpNCredito_Click;
            // 
            // btnCmpCierresZ
            // 
            btnCmpCierresZ.BackgroundImageLayout = ImageLayout.None;
            btnCmpCierresZ.Cursor = Cursors.Hand;
            btnCmpCierresZ.Dock = DockStyle.Top;
            btnCmpCierresZ.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCmpCierresZ.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCmpCierresZ.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCmpCierresZ.FlatStyle = FlatStyle.Flat;
            btnCmpCierresZ.Font = new Font("Microsoft Sans Serif", 10F);
            btnCmpCierresZ.ForeColor = Color.WhiteSmoke;
            btnCmpCierresZ.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            btnCmpCierresZ.IconColor = Color.WhiteSmoke;
            btnCmpCierresZ.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCmpCierresZ.IconSize = 26;
            btnCmpCierresZ.ImageAlign = ContentAlignment.MiddleLeft;
            btnCmpCierresZ.Location = new Point(0, 90);
            btnCmpCierresZ.Margin = new Padding(0);
            btnCmpCierresZ.Name = "btnCmpCierresZ";
            btnCmpCierresZ.Padding = new Padding(25, 0, 0, 0);
            btnCmpCierresZ.Size = new Size(233, 45);
            btnCmpCierresZ.TabIndex = 13;
            btnCmpCierresZ.Text = "Cierre Z";
            btnCmpCierresZ.TextAlign = ContentAlignment.MiddleLeft;
            btnCmpCierresZ.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCmpCierresZ.UseVisualStyleBackColor = false;
            btnCmpCierresZ.Click += btnCmpCierresZ_Click;
            // 
            // btnCmpVentas
            // 
            btnCmpVentas.BackgroundImageLayout = ImageLayout.None;
            btnCmpVentas.Cursor = Cursors.Hand;
            btnCmpVentas.Dock = DockStyle.Top;
            btnCmpVentas.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCmpVentas.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCmpVentas.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCmpVentas.FlatStyle = FlatStyle.Flat;
            btnCmpVentas.Font = new Font("Microsoft Sans Serif", 10F);
            btnCmpVentas.ForeColor = Color.WhiteSmoke;
            btnCmpVentas.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            btnCmpVentas.IconColor = Color.WhiteSmoke;
            btnCmpVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCmpVentas.IconSize = 26;
            btnCmpVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnCmpVentas.Location = new Point(0, 45);
            btnCmpVentas.Margin = new Padding(0);
            btnCmpVentas.Name = "btnCmpVentas";
            btnCmpVentas.Padding = new Padding(25, 0, 0, 0);
            btnCmpVentas.Size = new Size(233, 45);
            btnCmpVentas.TabIndex = 12;
            btnCmpVentas.Text = "Ventas";
            btnCmpVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnCmpVentas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCmpVentas.UseVisualStyleBackColor = false;
            btnCmpVentas.Click += btnCmpVentas_Click;
            // 
            // btnCmpCompras
            // 
            btnCmpCompras.BackgroundImageLayout = ImageLayout.None;
            btnCmpCompras.Cursor = Cursors.Hand;
            btnCmpCompras.Dock = DockStyle.Top;
            btnCmpCompras.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCmpCompras.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCmpCompras.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCmpCompras.FlatStyle = FlatStyle.Flat;
            btnCmpCompras.Font = new Font("Microsoft Sans Serif", 10F);
            btnCmpCompras.ForeColor = Color.WhiteSmoke;
            btnCmpCompras.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            btnCmpCompras.IconColor = Color.WhiteSmoke;
            btnCmpCompras.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnCmpCompras.IconSize = 26;
            btnCmpCompras.ImageAlign = ContentAlignment.MiddleLeft;
            btnCmpCompras.Location = new Point(0, 0);
            btnCmpCompras.Margin = new Padding(0);
            btnCmpCompras.Name = "btnCmpCompras";
            btnCmpCompras.Padding = new Padding(25, 0, 0, 0);
            btnCmpCompras.Size = new Size(233, 45);
            btnCmpCompras.TabIndex = 11;
            btnCmpCompras.Text = "Compras";
            btnCmpCompras.TextAlign = ContentAlignment.MiddleLeft;
            btnCmpCompras.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCmpCompras.UseVisualStyleBackColor = false;
            btnCmpCompras.Click += btnCmpCompras_Click;
            // 
            // btnComprobantes
            // 
            btnComprobantes.BackgroundImageLayout = ImageLayout.None;
            btnComprobantes.Cursor = Cursors.Hand;
            btnComprobantes.Dock = DockStyle.Top;
            btnComprobantes.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnComprobantes.FlatAppearance.BorderSize = 0;
            btnComprobantes.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnComprobantes.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnComprobantes.FlatStyle = FlatStyle.Flat;
            btnComprobantes.Font = new Font("Microsoft Sans Serif", 10F);
            btnComprobantes.ForeColor = Color.WhiteSmoke;
            btnComprobantes.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            btnComprobantes.IconColor = Color.WhiteSmoke;
            btnComprobantes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnComprobantes.IconSize = 32;
            btnComprobantes.ImageAlign = ContentAlignment.MiddleLeft;
            btnComprobantes.Location = new Point(0, 560);
            btnComprobantes.Margin = new Padding(0);
            btnComprobantes.Name = "btnComprobantes";
            btnComprobantes.Padding = new Padding(15, 0, 0, 0);
            btnComprobantes.Size = new Size(233, 50);
            btnComprobantes.TabIndex = 8;
            btnComprobantes.Text = "Comprobantes";
            btnComprobantes.TextAlign = ContentAlignment.MiddleLeft;
            btnComprobantes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnComprobantes.UseVisualStyleBackColor = false;
            btnComprobantes.Click += btnComprobantes_Click;
            // 
            // pnSubMantenimiento
            // 
            pnSubMantenimiento.BackColor = Color.FromArgb(45, 66, 91);
            pnSubMantenimiento.Controls.Add(btnMntProveedores);
            pnSubMantenimiento.Controls.Add(btnMntClientes);
            pnSubMantenimiento.Controls.Add(btnMntArticulos);
            pnSubMantenimiento.Dock = DockStyle.Top;
            pnSubMantenimiento.Location = new Point(0, 424);
            pnSubMantenimiento.Name = "pnSubMantenimiento";
            pnSubMantenimiento.Size = new Size(233, 136);
            pnSubMantenimiento.TabIndex = 7;
            // 
            // btnMntProveedores
            // 
            btnMntProveedores.BackgroundImageLayout = ImageLayout.None;
            btnMntProveedores.Cursor = Cursors.Hand;
            btnMntProveedores.Dock = DockStyle.Top;
            btnMntProveedores.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnMntProveedores.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnMntProveedores.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnMntProveedores.FlatStyle = FlatStyle.Flat;
            btnMntProveedores.Font = new Font("Microsoft Sans Serif", 10F);
            btnMntProveedores.ForeColor = Color.WhiteSmoke;
            btnMntProveedores.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnMntProveedores.IconColor = Color.WhiteSmoke;
            btnMntProveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMntProveedores.IconSize = 26;
            btnMntProveedores.ImageAlign = ContentAlignment.MiddleLeft;
            btnMntProveedores.Location = new Point(0, 90);
            btnMntProveedores.Margin = new Padding(0);
            btnMntProveedores.Name = "btnMntProveedores";
            btnMntProveedores.Padding = new Padding(25, 0, 0, 0);
            btnMntProveedores.Size = new Size(233, 45);
            btnMntProveedores.TabIndex = 10;
            btnMntProveedores.Text = "Proveedores";
            btnMntProveedores.TextAlign = ContentAlignment.MiddleLeft;
            btnMntProveedores.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMntProveedores.UseVisualStyleBackColor = false;
            btnMntProveedores.Click += btnMntProveedores_Click;
            // 
            // btnMntClientes
            // 
            btnMntClientes.BackgroundImageLayout = ImageLayout.None;
            btnMntClientes.Cursor = Cursors.Hand;
            btnMntClientes.Dock = DockStyle.Top;
            btnMntClientes.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnMntClientes.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnMntClientes.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnMntClientes.FlatStyle = FlatStyle.Flat;
            btnMntClientes.Font = new Font("Microsoft Sans Serif", 10F);
            btnMntClientes.ForeColor = Color.WhiteSmoke;
            btnMntClientes.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnMntClientes.IconColor = Color.WhiteSmoke;
            btnMntClientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMntClientes.IconSize = 26;
            btnMntClientes.ImageAlign = ContentAlignment.MiddleLeft;
            btnMntClientes.Location = new Point(0, 45);
            btnMntClientes.Margin = new Padding(0);
            btnMntClientes.Name = "btnMntClientes";
            btnMntClientes.Padding = new Padding(25, 0, 0, 0);
            btnMntClientes.Size = new Size(233, 45);
            btnMntClientes.TabIndex = 9;
            btnMntClientes.Text = "Clientes";
            btnMntClientes.TextAlign = ContentAlignment.MiddleLeft;
            btnMntClientes.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMntClientes.UseVisualStyleBackColor = false;
            btnMntClientes.Click += btnMntClientes_Click;
            // 
            // btnMntArticulos
            // 
            btnMntArticulos.BackgroundImageLayout = ImageLayout.None;
            btnMntArticulos.Cursor = Cursors.Hand;
            btnMntArticulos.Dock = DockStyle.Top;
            btnMntArticulos.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnMntArticulos.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnMntArticulos.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnMntArticulos.FlatStyle = FlatStyle.Flat;
            btnMntArticulos.Font = new Font("Microsoft Sans Serif", 10F);
            btnMntArticulos.ForeColor = Color.WhiteSmoke;
            btnMntArticulos.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnMntArticulos.IconColor = Color.WhiteSmoke;
            btnMntArticulos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMntArticulos.IconSize = 26;
            btnMntArticulos.ImageAlign = ContentAlignment.MiddleLeft;
            btnMntArticulos.Location = new Point(0, 0);
            btnMntArticulos.Margin = new Padding(0);
            btnMntArticulos.Name = "btnMntArticulos";
            btnMntArticulos.Padding = new Padding(25, 0, 0, 0);
            btnMntArticulos.Size = new Size(233, 45);
            btnMntArticulos.TabIndex = 8;
            btnMntArticulos.Text = "Artículos";
            btnMntArticulos.TextAlign = ContentAlignment.MiddleLeft;
            btnMntArticulos.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMntArticulos.UseVisualStyleBackColor = false;
            btnMntArticulos.Click += btnMntArticulos_Click;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.BackgroundImageLayout = ImageLayout.None;
            btnMantenimiento.Cursor = Cursors.Hand;
            btnMantenimiento.Dock = DockStyle.Top;
            btnMantenimiento.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnMantenimiento.FlatAppearance.BorderSize = 0;
            btnMantenimiento.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnMantenimiento.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnMantenimiento.FlatStyle = FlatStyle.Flat;
            btnMantenimiento.Font = new Font("Microsoft Sans Serif", 10F);
            btnMantenimiento.ForeColor = Color.WhiteSmoke;
            btnMantenimiento.IconChar = FontAwesome.Sharp.IconChar.Database;
            btnMantenimiento.IconColor = Color.WhiteSmoke;
            btnMantenimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMantenimiento.IconSize = 32;
            btnMantenimiento.ImageAlign = ContentAlignment.MiddleLeft;
            btnMantenimiento.Location = new Point(0, 374);
            btnMantenimiento.Margin = new Padding(0);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Padding = new Padding(15, 0, 0, 0);
            btnMantenimiento.Size = new Size(233, 50);
            btnMantenimiento.TabIndex = 6;
            btnMantenimiento.Text = "Mantenimiento";
            btnMantenimiento.TextAlign = ContentAlignment.MiddleLeft;
            btnMantenimiento.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMantenimiento.UseVisualStyleBackColor = false;
            btnMantenimiento.Click += btnMantenimiento_Click;
            // 
            // pnSubAdministracion
            // 
            pnSubAdministracion.BackColor = Color.FromArgb(45, 66, 91);
            pnSubAdministracion.Controls.Add(btnAdmInventario);
            pnSubAdministracion.Controls.Add(btnAdmSucursales);
            pnSubAdministracion.Controls.Add(btnAdmEmpresas);
            pnSubAdministracion.Controls.Add(btnAdmUsuarios);
            pnSubAdministracion.Dock = DockStyle.Top;
            pnSubAdministracion.Location = new Point(0, 193);
            pnSubAdministracion.Name = "pnSubAdministracion";
            pnSubAdministracion.Size = new Size(233, 181);
            pnSubAdministracion.TabIndex = 5;
            // 
            // btnAdmInventario
            // 
            btnAdmInventario.BackgroundImageLayout = ImageLayout.None;
            btnAdmInventario.Cursor = Cursors.Hand;
            btnAdmInventario.Dock = DockStyle.Top;
            btnAdmInventario.Enabled = false;
            btnAdmInventario.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnAdmInventario.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnAdmInventario.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnAdmInventario.FlatStyle = FlatStyle.Flat;
            btnAdmInventario.Font = new Font("Microsoft Sans Serif", 10F);
            btnAdmInventario.ForeColor = Color.WhiteSmoke;
            btnAdmInventario.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnAdmInventario.IconColor = Color.WhiteSmoke;
            btnAdmInventario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmInventario.IconSize = 26;
            btnAdmInventario.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmInventario.Location = new Point(0, 135);
            btnAdmInventario.Margin = new Padding(0);
            btnAdmInventario.Name = "btnAdmInventario";
            btnAdmInventario.Padding = new Padding(25, 0, 0, 0);
            btnAdmInventario.Size = new Size(233, 45);
            btnAdmInventario.TabIndex = 10;
            btnAdmInventario.Text = "Inventario";
            btnAdmInventario.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmInventario.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmInventario.UseVisualStyleBackColor = false;
            // 
            // btnAdmSucursales
            // 
            btnAdmSucursales.BackgroundImageLayout = ImageLayout.None;
            btnAdmSucursales.Cursor = Cursors.Hand;
            btnAdmSucursales.Dock = DockStyle.Top;
            btnAdmSucursales.Enabled = false;
            btnAdmSucursales.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnAdmSucursales.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnAdmSucursales.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnAdmSucursales.FlatStyle = FlatStyle.Flat;
            btnAdmSucursales.Font = new Font("Microsoft Sans Serif", 10F);
            btnAdmSucursales.ForeColor = Color.WhiteSmoke;
            btnAdmSucursales.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnAdmSucursales.IconColor = Color.WhiteSmoke;
            btnAdmSucursales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmSucursales.IconSize = 26;
            btnAdmSucursales.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmSucursales.Location = new Point(0, 90);
            btnAdmSucursales.Margin = new Padding(0);
            btnAdmSucursales.Name = "btnAdmSucursales";
            btnAdmSucursales.Padding = new Padding(25, 0, 0, 0);
            btnAdmSucursales.Size = new Size(233, 45);
            btnAdmSucursales.TabIndex = 9;
            btnAdmSucursales.Text = "Sucursales";
            btnAdmSucursales.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmSucursales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmSucursales.UseVisualStyleBackColor = false;
            btnAdmSucursales.Click += btnAdmSucursales_Click;
            // 
            // btnAdmEmpresas
            // 
            btnAdmEmpresas.BackgroundImageLayout = ImageLayout.None;
            btnAdmEmpresas.Cursor = Cursors.Hand;
            btnAdmEmpresas.Dock = DockStyle.Top;
            btnAdmEmpresas.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnAdmEmpresas.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnAdmEmpresas.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnAdmEmpresas.FlatStyle = FlatStyle.Flat;
            btnAdmEmpresas.Font = new Font("Microsoft Sans Serif", 10F);
            btnAdmEmpresas.ForeColor = Color.WhiteSmoke;
            btnAdmEmpresas.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnAdmEmpresas.IconColor = Color.WhiteSmoke;
            btnAdmEmpresas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmEmpresas.IconSize = 26;
            btnAdmEmpresas.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmEmpresas.Location = new Point(0, 45);
            btnAdmEmpresas.Margin = new Padding(0);
            btnAdmEmpresas.Name = "btnAdmEmpresas";
            btnAdmEmpresas.Padding = new Padding(25, 0, 0, 0);
            btnAdmEmpresas.Size = new Size(233, 45);
            btnAdmEmpresas.TabIndex = 8;
            btnAdmEmpresas.Text = "Empresas";
            btnAdmEmpresas.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmEmpresas.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmEmpresas.UseVisualStyleBackColor = false;
            btnAdmEmpresas.Click += btnAdmEmpresas_Click;
            // 
            // btnAdmUsuarios
            // 
            btnAdmUsuarios.BackgroundImageLayout = ImageLayout.None;
            btnAdmUsuarios.Cursor = Cursors.Hand;
            btnAdmUsuarios.Dock = DockStyle.Top;
            btnAdmUsuarios.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnAdmUsuarios.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnAdmUsuarios.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnAdmUsuarios.FlatStyle = FlatStyle.Flat;
            btnAdmUsuarios.Font = new Font("Microsoft Sans Serif", 10F);
            btnAdmUsuarios.ForeColor = Color.WhiteSmoke;
            btnAdmUsuarios.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            btnAdmUsuarios.IconColor = Color.WhiteSmoke;
            btnAdmUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAdmUsuarios.IconSize = 26;
            btnAdmUsuarios.ImageAlign = ContentAlignment.MiddleLeft;
            btnAdmUsuarios.Location = new Point(0, 0);
            btnAdmUsuarios.Margin = new Padding(0);
            btnAdmUsuarios.Name = "btnAdmUsuarios";
            btnAdmUsuarios.Padding = new Padding(25, 0, 0, 0);
            btnAdmUsuarios.Size = new Size(233, 45);
            btnAdmUsuarios.TabIndex = 5;
            btnAdmUsuarios.Text = "Usuarios";
            btnAdmUsuarios.TextAlign = ContentAlignment.MiddleLeft;
            btnAdmUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAdmUsuarios.UseVisualStyleBackColor = false;
            btnAdmUsuarios.Click += btnAdmUsuarios_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackgroundImageLayout = ImageLayout.None;
            iconButton1.Cursor = Cursors.Hand;
            iconButton1.Dock = DockStyle.Top;
            iconButton1.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            iconButton1.FlatAppearance.BorderSize = 0;
            iconButton1.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            iconButton1.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            iconButton1.FlatStyle = FlatStyle.Flat;
            iconButton1.Font = new Font("Microsoft Sans Serif", 10F);
            iconButton1.ForeColor = Color.WhiteSmoke;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ListDots;
            iconButton1.IconColor = Color.WhiteSmoke;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 32;
            iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
            iconButton1.Location = new Point(0, 143);
            iconButton1.Margin = new Padding(0);
            iconButton1.Name = "iconButton1";
            iconButton1.Padding = new Padding(15, 0, 0, 0);
            iconButton1.Size = new Size(233, 50);
            iconButton1.TabIndex = 4;
            iconButton1.Text = "Administración";
            iconButton1.TextAlign = ContentAlignment.MiddleLeft;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += btnMenuAdministracion_Click;
            // 
            // btnMenuHome
            // 
            btnMenuHome.BackgroundImageLayout = ImageLayout.None;
            btnMenuHome.Cursor = Cursors.Hand;
            btnMenuHome.Dock = DockStyle.Top;
            btnMenuHome.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnMenuHome.FlatAppearance.BorderSize = 0;
            btnMenuHome.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnMenuHome.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnMenuHome.FlatStyle = FlatStyle.Flat;
            btnMenuHome.Font = new Font("Microsoft Sans Serif", 10F);
            btnMenuHome.ForeColor = Color.WhiteSmoke;
            btnMenuHome.IconChar = FontAwesome.Sharp.IconChar.House;
            btnMenuHome.IconColor = Color.WhiteSmoke;
            btnMenuHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnMenuHome.IconSize = 32;
            btnMenuHome.ImageAlign = ContentAlignment.MiddleLeft;
            btnMenuHome.Location = new Point(0, 93);
            btnMenuHome.Margin = new Padding(0);
            btnMenuHome.Name = "btnMenuHome";
            btnMenuHome.Padding = new Padding(15, 0, 0, 0);
            btnMenuHome.Size = new Size(233, 50);
            btnMenuHome.TabIndex = 3;
            btnMenuHome.Text = "Home";
            btnMenuHome.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuHome.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnMenuHome.UseVisualStyleBackColor = false;
            btnMenuHome.Click += btnMenuHome_Click;
            // 
            // pnLogo
            // 
            pnLogo.BackColor = Color.FromArgb(4, 41, 68);
            pnLogo.Controls.Add(pictureBox2);
            pnLogo.Dock = DockStyle.Top;
            pnLogo.Location = new Point(0, 0);
            pnLogo.Name = "pnLogo";
            pnLogo.Size = new Size(233, 93);
            pnLogo.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(42, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(129, 88);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // timerFechaHora
            // 
            timerFechaHora.Enabled = true;
            timerFechaHora.Tick += timerFechaHora_Tick;
            // 
            // Frm_Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 242, 233);
            ClientSize = new Size(1250, 720);
            Controls.Add(panelContenedor);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(1250, 690);
            Name = "Frm_Main";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmMain";
            panelContenedor.ResumeLayout(false);
            pnMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnInferior.ResumeLayout(false);
            pnInferior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            pnSuperior.ResumeLayout(false);
            pnSuperior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)IconoFormularioActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            pnMenuPrincipal.ResumeLayout(false);
            pnRespaldos.ResumeLayout(false);
            pnSubConsultas.ResumeLayout(false);
            pnSubCajas.ResumeLayout(false);
            pnSubComprobantes.ResumeLayout(false);
            pnSubMantenimiento.ResumeLayout(false);
            pnSubAdministracion.ResumeLayout(false);
            pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelContenedor;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer timerFechaHora;
        private Panel pnMenuPrincipal;
        private Panel pnLogo;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private Panel pnInferior;
        private TextBox txtFecha;
        private TextBox txtHoraActual;
        private PictureBox pictureBox4;
        private Panel pnSuperior;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        private Label LblTituloFormulario;
        private FontAwesome.Sharp.IconButton btnMenuHome;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Panel pnSubAdministracion;
        private Button btnAdmListas1;
        private FontAwesome.Sharp.IconButton btnMantenimiento;
        private Panel pnSubMantenimiento;
        private FontAwesome.Sharp.IconButton btnComprobantes;
        private FontAwesome.Sharp.IconButton btnCajas;
        private Panel pnSubComprobantes;
        private FontAwesome.Sharp.IconButton btnConsultas;
        private Panel pnSubCajas;
        private Button btnCjaSalidas1;
        private FontAwesome.Sharp.IconButton btnRespaldos;
        private Panel pnSubConsultas;
        private FontAwesome.Sharp.IconButton btnSalir;
        private Panel pnRespaldos;
        private FontAwesome.Sharp.IconButton btnAdmUsuarios;
        private FontAwesome.Sharp.IconButton btnMntArticulos;
        private FontAwesome.Sharp.IconButton btnMntClientes;
        private FontAwesome.Sharp.IconButton btnMntProveedores;
        private FontAwesome.Sharp.IconButton btnCmpCompras;
        private FontAwesome.Sharp.IconButton btnCmpVentas;
        private FontAwesome.Sharp.IconButton btnCmpCierresZ;
        private FontAwesome.Sharp.IconButton btnCmpNCredito;
        private FontAwesome.Sharp.IconButton btnCmpNDebito;
        private FontAwesome.Sharp.IconButton btnCjaApertura;
        private FontAwesome.Sharp.IconButton btnCjaIngresos;
        private FontAwesome.Sharp.IconButton btnCjaSalidas;
        private FontAwesome.Sharp.IconButton btnCnsCajas;
        private FontAwesome.Sharp.IconButton btnCnsVentas;
        private FontAwesome.Sharp.IconButton btnCnsCtaCte;
        private FontAwesome.Sharp.IconButton btnCnsEstadisticos;
        private FontAwesome.Sharp.IconButton btnAdmRespaldarDatos;
        private FontAwesome.Sharp.IconButton btnAdmRecuperaDatos;
        private FontAwesome.Sharp.IconPictureBox IconoFormularioActual;
        public Panel pnMain;
        private FontAwesome.Sharp.IconButton btnAdmSucursales;
        private FontAwesome.Sharp.IconButton btnAdmEmpresas;
        public TextBox txtNombreUsuario;
        public TextBox txtCategoria;
        private FontAwesome.Sharp.IconButton btnAdmInventario;
    }
}