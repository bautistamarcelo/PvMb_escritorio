namespace PVpresentation.Formularios
{
    partial class Frm_Clientes_Buscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Clientes_Buscar));
            pnTituloFormulario = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnCerrar = new PictureBox();
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
            lblTituloForm = new Label();
            tabControlMain = new MiTabControl();
            tabListado = new TabPage();
            btnNuevo = new Button();
            btnBuscar = new Button();
            label4 = new Label();
            txtBuscar = new TextBox();
            dgvListado = new DataGridView();
            tabNuevo = new TabPage();
            btnCancelar = new Button();
            btnGrabar = new Button();
            txtTelefono = new TextBox();
            cmbHabilitadoCta = new ComboBox();
            cmbCaracter = new ComboBox();
            cmbEstado = new ComboBox();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            txtEmail = new TextBox();
            txtCuit = new TextBox();
            txtDomicilio = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label7 = new Label();
            txtNombre = new TextBox();
            label3 = new Label();
            txtID = new TextBox();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            tabControlMain.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            tabNuevo.SuspendLayout();
            SuspendLayout();
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.BackColor = Color.FromArgb(74, 134, 160);
            pnTituloFormulario.Controls.Add(pictureBox1);
            pnTituloFormulario.Controls.Add(label1);
            pnTituloFormulario.Controls.Add(btnCerrar);
            pnTituloFormulario.Controls.Add(txtInstancia);
            pnTituloFormulario.Controls.Add(txtOpcion);
            pnTituloFormulario.Controls.Add(lblTituloForm);
            pnTituloFormulario.Dock = DockStyle.Top;
            pnTituloFormulario.Location = new Point(0, 0);
            pnTituloFormulario.Margin = new Padding(0);
            pnTituloFormulario.Name = "pnTituloFormulario";
            pnTituloFormulario.Size = new Size(825, 45);
            pnTituloFormulario.TabIndex = 54;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, -1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(67, 43);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 53;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("EngraversGothic BT", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(286, 10);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 52;
            label1.Text = "Buscar | Clientes";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.Close;
            btnCerrar.Location = new Point(788, 12);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 21);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 49;
            btnCerrar.TabStop = false;
            // 
            // txtInstancia
            // 
            txtInstancia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtInstancia.BorderStyle = BorderStyle.FixedSingle;
            txtInstancia.Location = new Point(46, 15);
            txtInstancia.Name = "txtInstancia";
            txtInstancia.Size = new Size(34, 23);
            txtInstancia.TabIndex = 47;
            txtInstancia.Text = "0";
            txtInstancia.Visible = false;
            // 
            // txtOpcion
            // 
            txtOpcion.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtOpcion.BorderStyle = BorderStyle.FixedSingle;
            txtOpcion.Location = new Point(6, 14);
            txtOpcion.Name = "txtOpcion";
            txtOpcion.Size = new Size(34, 23);
            txtOpcion.TabIndex = 46;
            txtOpcion.Text = "0";
            txtOpcion.Visible = false;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTituloForm.AutoSize = true;
            lblTituloForm.Enabled = false;
            lblTituloForm.Font = new Font("EngraversGothic BT", 20F);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(1582, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(289, 28);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Instancia de Venta N° 0";
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.BottomBackColor = Color.Black;
            tabControlMain.BottomForeColor = Color.White;
            tabControlMain.Controls.Add(tabListado);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Cursor = Cursors.Hand;
            tabControlMain.Font = new Font("EngraversGothic BT", 10F);
            tabControlMain.ItemSize = new Size(200, 30);
            tabControlMain.LineBackColor = Color.FromArgb(74, 134, 160);
            tabControlMain.LineForeColor = Color.White;
            tabControlMain.Location = new Point(0, 48);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.Padding = new Point(0, 0);
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(825, 347);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 55;
            tabControlMain.TabStyle = MiTabControl.Style.Line;
            // 
            // tabListado
            // 
            tabListado.BackColor = Color.FromArgb(4, 41, 68);
            tabListado.Controls.Add(btnNuevo);
            tabListado.Controls.Add(btnBuscar);
            tabListado.Controls.Add(label4);
            tabListado.Controls.Add(txtBuscar);
            tabListado.Controls.Add(dgvListado);
            tabListado.Location = new Point(4, 34);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(817, 309);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            // 
            // btnNuevo
            // 
            btnNuevo.BackgroundImageLayout = ImageLayout.None;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.FromArgb(23, 54, 93);
            btnNuevo.Image = (Image)resources.GetObject("btnNuevo.Image");
            btnNuevo.Location = new Point(47, 10);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(47, 49);
            btnNuevo.TabIndex = 55;
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(23, 54, 93);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(728, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(30, 30);
            btnBuscar.TabIndex = 54;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("EngraversGothic BT", 10F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(97, 29);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 23;
            label4.Text = "Cliente:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Gainsboro;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(154, 25);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(570, 22);
            txtBuscar.TabIndex = 22;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // dgvListado
            // 
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(20, 61);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(784, 229);
            dgvListado.TabIndex = 17;
            dgvListado.CellContentClick += dgvListado_CellContentClick;
            dgvListado.CellContentDoubleClick += dgvListado_CellContentDoubleClick;
            // 
            // tabNuevo
            // 
            tabNuevo.BackColor = Color.FromArgb(4, 41, 68);
            tabNuevo.Controls.Add(btnCancelar);
            tabNuevo.Controls.Add(btnGrabar);
            tabNuevo.Controls.Add(txtTelefono);
            tabNuevo.Controls.Add(cmbHabilitadoCta);
            tabNuevo.Controls.Add(cmbCaracter);
            tabNuevo.Controls.Add(cmbEstado);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(label10);
            tabNuevo.Controls.Add(label11);
            tabNuevo.Controls.Add(txtEmail);
            tabNuevo.Controls.Add(txtCuit);
            tabNuevo.Controls.Add(txtDomicilio);
            tabNuevo.Controls.Add(label6);
            tabNuevo.Controls.Add(label5);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(txtNombre);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(txtID);
            tabNuevo.Location = new Point(4, 34);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(817, 309);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
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
            btnCancelar.Location = new Point(653, 265);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 32);
            btnCancelar.TabIndex = 177;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.SteelBlue;
            btnGrabar.Cursor = Cursors.Hand;
            btnGrabar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.ForeColor = Color.WhiteSmoke;
            btnGrabar.Location = new Point(545, 265);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(86, 32);
            btnGrabar.TabIndex = 176;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Gainsboro;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Font = new Font("EngraversGothic BT", 11F);
            txtTelefono.Location = new Point(428, 50);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(365, 23);
            txtTelefono.TabIndex = 175;
            // 
            // cmbHabilitadoCta
            // 
            cmbHabilitadoCta.BackColor = Color.Gainsboro;
            cmbHabilitadoCta.Font = new Font("EngraversGothic BT", 11F);
            cmbHabilitadoCta.FormattingEnabled = true;
            cmbHabilitadoCta.Location = new Point(428, 213);
            cmbHabilitadoCta.Name = "cmbHabilitadoCta";
            cmbHabilitadoCta.Size = new Size(364, 24);
            cmbHabilitadoCta.TabIndex = 174;
            // 
            // cmbCaracter
            // 
            cmbCaracter.BackColor = Color.Gainsboro;
            cmbCaracter.Font = new Font("EngraversGothic BT", 11F);
            cmbCaracter.FormattingEnabled = true;
            cmbCaracter.Location = new Point(428, 160);
            cmbCaracter.Name = "cmbCaracter";
            cmbCaracter.Size = new Size(364, 24);
            cmbCaracter.TabIndex = 173;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.Gainsboro;
            cmbEstado.Font = new Font("EngraversGothic BT", 11F);
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(428, 110);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(364, 24);
            cmbEstado.TabIndex = 172;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(428, 197);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 171;
            label8.Text = "Situación";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("EngraversGothic BT", 10F);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(428, 143);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 170;
            label9.Text = "Caracter";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("EngraversGothic BT", 10F);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(428, 92);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 169;
            label10.Text = "Estado";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("EngraversGothic BT", 10F);
            label11.ForeColor = Color.FromArgb(224, 224, 224);
            label11.Location = new Point(428, 32);
            label11.Name = "label11";
            label11.Size = new Size(74, 15);
            label11.TabIndex = 168;
            label11.Text = "Teléfono/s";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Font = new Font("EngraversGothic BT", 11F);
            txtEmail.Location = new Point(31, 214);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(363, 23);
            txtEmail.TabIndex = 167;
            // 
            // txtCuit
            // 
            txtCuit.BackColor = Color.Gainsboro;
            txtCuit.BorderStyle = BorderStyle.FixedSingle;
            txtCuit.Font = new Font("EngraversGothic BT", 11F);
            txtCuit.Location = new Point(31, 156);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(363, 23);
            txtCuit.TabIndex = 166;
            // 
            // txtDomicilio
            // 
            txtDomicilio.BackColor = Color.Gainsboro;
            txtDomicilio.BorderStyle = BorderStyle.FixedSingle;
            txtDomicilio.Font = new Font("EngraversGothic BT", 11F);
            txtDomicilio.Location = new Point(31, 102);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(363, 23);
            txtDomicilio.TabIndex = 165;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(31, 196);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 164;
            label6.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(31, 138);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 163;
            label5.Text = "D.N.I. / C.U.I.T.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("EngraversGothic BT", 10F);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(31, 84);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 162;
            label7.Text = "Domicilio";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Gainsboro;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("EngraversGothic BT", 11F);
            txtNombre.Location = new Point(31, 50);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(363, 23);
            txtNombre.TabIndex = 160;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(34, 35);
            label3.Name = "label3";
            label3.Size = new Size(55, 15);
            label3.TabIndex = 161;
            label3.Text = "Nombre";
            // 
            // txtID
            // 
            txtID.BackColor = Color.Gainsboro;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(371, 272);
            txtID.Name = "txtID";
            txtID.Size = new Size(50, 22);
            txtID.TabIndex = 158;
            txtID.Visible = false;
            // 
            // Frm_Clientes_Buscar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 134, 160);
            ClientSize = new Size(825, 391);
            Controls.Add(tabControlMain);
            Controls.Add(pnTituloFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Clientes_Buscar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Clientes_Buscar";
            Load += Frm_Clientes_Buscar_Load;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            tabControlMain.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        public Panel pnTituloFormulario;
        public Label label1;
        private PictureBox btnCerrar;
        public TextBox txtInstancia;
        public TextBox txtOpcion;
        public Label lblTituloForm;
        public MiTabControl tabControlMain;
        public TabPage tabListado;
        public Button btnNuevo;
        public Button btnBuscar;
        public Label label4;
        public TextBox txtBuscar;
        public DataGridView dgvListado;
        public TabPage tabNuevo;
        private TextBox txtNombre;
        private Label label3;
        private TextBox txtID;
        private PictureBox pictureBox1;
        private TextBox txtEmail;
        private TextBox txtCuit;
        private TextBox txtDomicilio;
        private Label label6;
        private Label label5;
        private Label label7;
        private TextBox txtTelefono;
        private ComboBox cmbHabilitadoCta;
        private ComboBox cmbCaracter;
        public ComboBox cmbEstado;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        public Button btnCancelar;
        public Button btnGrabar;
    }
}