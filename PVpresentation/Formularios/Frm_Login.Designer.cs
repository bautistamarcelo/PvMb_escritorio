namespace PVpresentation.Formularios
{
    partial class Frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Login));
            pnTituloFormulario = new Panel();
            pictureBox1 = new PictureBox();
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
            lblTituloForm = new Label();
            pnl_Contenedor = new Panel();
            pnMantenimiento = new Panel();
            chkSucursal = new CheckBox();
            cmbSucursales = new ComboBox();
            label4 = new Label();
            cmbEmpresa = new ComboBox();
            LnkOlvideClave = new LinkLabel();
            LnkCambiarClave = new LinkLabel();
            label3 = new Label();
            label2 = new Label();
            txtClave = new TextBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            btnCancelar = new Button();
            btnLogin = new Button();
            chkEmpresa = new CheckBox();
            pnListado = new Panel();
            pictureBox2 = new PictureBox();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            pnl_Contenedor.SuspendLayout();
            pnMantenimiento.SuspendLayout();
            pnListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.BackColor = Color.FromArgb(74, 134, 160);
            pnTituloFormulario.Controls.Add(pictureBox1);
            pnTituloFormulario.Controls.Add(txtInstancia);
            pnTituloFormulario.Controls.Add(txtOpcion);
            pnTituloFormulario.Controls.Add(lblTituloForm);
            pnTituloFormulario.Dock = DockStyle.Top;
            pnTituloFormulario.Location = new Point(0, 0);
            pnTituloFormulario.Margin = new Padding(0);
            pnTituloFormulario.Name = "pnTituloFormulario";
            pnTituloFormulario.Size = new Size(605, 50);
            pnTituloFormulario.TabIndex = 50;
            pnTituloFormulario.MouseMove += pnTituloFormulario_MouseMove;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(11, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(86, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // txtInstancia
            // 
            txtInstancia.BorderStyle = BorderStyle.FixedSingle;
            txtInstancia.Location = new Point(63, 9);
            txtInstancia.Name = "txtInstancia";
            txtInstancia.Size = new Size(34, 23);
            txtInstancia.TabIndex = 47;
            txtInstancia.Text = "0";
            txtInstancia.Visible = false;
            // 
            // txtOpcion
            // 
            txtOpcion.BorderStyle = BorderStyle.FixedSingle;
            txtOpcion.Location = new Point(12, 9);
            txtOpcion.Name = "txtOpcion";
            txtOpcion.Size = new Size(34, 23);
            txtOpcion.TabIndex = 46;
            txtOpcion.Text = "0";
            txtOpcion.Visible = false;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloForm.AutoSize = true;
            lblTituloForm.Enabled = false;
            lblTituloForm.Font = new Font("EngraversGothic BT", 20F);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(224, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(174, 28);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Iniciar Sesión";
            // 
            // pnl_Contenedor
            // 
            pnl_Contenedor.Controls.Add(pnMantenimiento);
            pnl_Contenedor.Controls.Add(pnListado);
            pnl_Contenedor.Dock = DockStyle.Top;
            pnl_Contenedor.Location = new Point(0, 50);
            pnl_Contenedor.Name = "pnl_Contenedor";
            pnl_Contenedor.Size = new Size(605, 340);
            pnl_Contenedor.TabIndex = 51;
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnMantenimiento.BackColor = Color.FromArgb(4, 41, 68);
            pnMantenimiento.Controls.Add(chkSucursal);
            pnMantenimiento.Controls.Add(cmbSucursales);
            pnMantenimiento.Controls.Add(label4);
            pnMantenimiento.Controls.Add(cmbEmpresa);
            pnMantenimiento.Controls.Add(LnkOlvideClave);
            pnMantenimiento.Controls.Add(LnkCambiarClave);
            pnMantenimiento.Controls.Add(label3);
            pnMantenimiento.Controls.Add(label2);
            pnMantenimiento.Controls.Add(txtClave);
            pnMantenimiento.Controls.Add(label1);
            pnMantenimiento.Controls.Add(txtUsuario);
            pnMantenimiento.Controls.Add(btnCancelar);
            pnMantenimiento.Controls.Add(btnLogin);
            pnMantenimiento.Controls.Add(chkEmpresa);
            pnMantenimiento.Location = new Point(280, 0);
            pnMantenimiento.Name = "pnMantenimiento";
            pnMantenimiento.Size = new Size(325, 340);
            pnMantenimiento.TabIndex = 2;
            // 
            // chkSucursal
            // 
            chkSucursal.AutoSize = true;
            chkSucursal.CheckAlign = ContentAlignment.MiddleRight;
            chkSucursal.ForeColor = Color.SteelBlue;
            chkSucursal.ImageAlign = ContentAlignment.MiddleRight;
            chkSucursal.Location = new Point(137, 202);
            chkSucursal.Name = "chkSucursal";
            chkSucursal.Size = new Size(166, 19);
            chkSucursal.TabIndex = 43;
            chkSucursal.TabStop = false;
            chkSucursal.Text = "Establecer Predeterminada";
            chkSucursal.TextAlign = ContentAlignment.MiddleRight;
            chkSucursal.UseVisualStyleBackColor = true;
            chkSucursal.Visible = false;
            chkSucursal.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // cmbSucursales
            // 
            cmbSucursales.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbSucursales.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSucursales.BackColor = Color.Gainsboro;
            cmbSucursales.DropDownWidth = 269;
            cmbSucursales.Font = new Font("Square721 BT", 12F);
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(22, 220);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(281, 28);
            cmbSucursales.TabIndex = 3;
            cmbSucursales.Enter += cmbSucursales_Enter;
            cmbSucursales.KeyDown += cmbSucursales_KeyDown;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("EngraversGothic BT", 10F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(22, 139);
            label4.Name = "label4";
            label4.Size = new Size(63, 15);
            label4.TabIndex = 41;
            label4.Text = "Empresa:";
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbEmpresa.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbEmpresa.BackColor = Color.Gainsboro;
            cmbEmpresa.DropDownWidth = 269;
            cmbEmpresa.Font = new Font("Square721 BT", 12F);
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(22, 157);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(281, 28);
            cmbEmpresa.TabIndex = 2;
            cmbEmpresa.SelectedIndexChanged += cmbEmpresa_SelectedIndexChanged;
            // 
            // LnkOlvideClave
            // 
            LnkOlvideClave.AutoSize = true;
            LnkOlvideClave.LinkColor = Color.SteelBlue;
            LnkOlvideClave.Location = new Point(22, 271);
            LnkOlvideClave.Name = "LnkOlvideClave";
            LnkOlvideClave.Size = new Size(114, 15);
            LnkOlvideClave.TabIndex = 39;
            LnkOlvideClave.TabStop = true;
            LnkOlvideClave.Text = "Olvié mi Contraseña";
            LnkOlvideClave.Visible = false;
            // 
            // LnkCambiarClave
            // 
            LnkCambiarClave.AutoSize = true;
            LnkCambiarClave.LinkColor = Color.SteelBlue;
            LnkCambiarClave.Location = new Point(22, 251);
            LnkCambiarClave.Name = "LnkCambiarClave";
            LnkCambiarClave.Size = new Size(84, 15);
            LnkCambiarClave.TabIndex = 5;
            LnkCambiarClave.TabStop = true;
            LnkCambiarClave.Text = "Cambiar Clave";
            LnkCambiarClave.LinkClicked += LnkCambiarClave_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(22, 202);
            label3.Name = "label3";
            label3.Size = new Size(71, 15);
            label3.TabIndex = 37;
            label3.Text = "Sucursal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("EngraversGothic BT", 10F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(22, 67);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 26;
            label2.Text = "Contraseña:";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.Gainsboro;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Font = new Font("Square721 BT", 12F);
            txtClave.Location = new Point(22, 85);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(281, 27);
            txtClave.TabIndex = 1;
            txtClave.UseSystemPasswordChar = true;
            txtClave.KeyDown += txtClave_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("EngraversGothic BT", 10F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(22, 13);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 24;
            label1.Text = "Usuario:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Gainsboro;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Square721 BT", 12F);
            txtUsuario.Location = new Point(22, 31);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(281, 27);
            txtUsuario.TabIndex = 0;
            txtUsuario.KeyDown += txtUsuario_KeyDown;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(189, 289);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 32);
            btnCancelar.TabIndex = 6;
            btnCancelar.TabStop = false;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.Location = new Point(45, 289);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 32);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // chkEmpresa
            // 
            chkEmpresa.AutoSize = true;
            chkEmpresa.CheckAlign = ContentAlignment.MiddleRight;
            chkEmpresa.ForeColor = Color.SteelBlue;
            chkEmpresa.ImageAlign = ContentAlignment.MiddleRight;
            chkEmpresa.Location = new Point(137, 137);
            chkEmpresa.Name = "chkEmpresa";
            chkEmpresa.Size = new Size(166, 19);
            chkEmpresa.TabIndex = 42;
            chkEmpresa.TabStop = false;
            chkEmpresa.Text = "Establecer Predeterminada";
            chkEmpresa.TextAlign = ContentAlignment.MiddleRight;
            chkEmpresa.UseVisualStyleBackColor = true;
            chkEmpresa.Visible = false;
            chkEmpresa.CheckedChanged += chkEmpresa_CheckedChanged;
            // 
            // pnListado
            // 
            pnListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnListado.BackColor = Color.FromArgb(45, 66, 91);
            pnListado.Controls.Add(pictureBox2);
            pnListado.Location = new Point(-2, 0);
            pnListado.Name = "pnListado";
            pnListado.Size = new Size(284, 344);
            pnListado.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(14, 31);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(263, 282);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // Frm_Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 134, 160);
            ClientSize = new Size(605, 390);
            Controls.Add(pnl_Contenedor);
            Controls.Add(pnTituloFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Login";
            Load += Frm_Login_Load;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            pnl_Contenedor.ResumeLayout(false);
            pnMantenimiento.ResumeLayout(false);
            pnMantenimiento.PerformLayout();
            pnListado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnTituloFormulario;
        public TextBox txtInstancia;
        public TextBox txtOpcion;
        public Label lblTituloForm;
        private Panel pnl_Contenedor;
        public Panel pnMantenimiento;
        public Label label2;
        public TextBox txtClave;
        public Label label1;
        public TextBox txtUsuario;
        public Button btnCancelar;
        public Button btnLogin;
        public Panel pnListado;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        public Label label3;
        public ComboBox cmbSucursales;
        private LinkLabel LnkCambiarClave;
        private LinkLabel LnkOlvideClave;
        public Label label4;
        public ComboBox cmbEmpresa;
        private CheckBox chkEmpresa;
        private CheckBox chkSucursal;
    }
}