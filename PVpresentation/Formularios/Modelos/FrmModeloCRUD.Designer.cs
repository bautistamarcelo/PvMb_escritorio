namespace PVpresentation.Formularios.Modelos
{
    partial class FrmModeloCRUD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModeloCRUD));
            pnGral = new Panel();
            pnTituloFormulario = new Panel();
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
            btnCierreVolver = new PictureBox();
            lblTituloForm = new Label();
            pnlContenedorPrincipal = new Panel();
            tabControlMain = new MiTabControl();
            tabListado = new TabPage();
            pnMantenimiento = new Panel();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnGrabar = new Button();
            pnListado = new Panel();
            btnEditar = new Button();
            btnNuevo = new Button();
            dgvListado = new DataGridView();
            label4 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            tabNuevo = new TabPage();
            tabEditar = new TabPage();
            btnDetalles = new Button();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).BeginInit();
            pnlContenedorPrincipal.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabListado.SuspendLayout();
            pnMantenimiento.SuspendLayout();
            pnListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // pnGral
            // 
            pnGral.BackColor = Color.FromArgb(74, 154, 190);
            pnGral.Dock = DockStyle.Fill;
            pnGral.Location = new Point(0, 0);
            pnGral.Name = "pnGral";
            pnGral.Size = new Size(984, 561);
            pnGral.TabIndex = 51;
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.BackColor = Color.FromArgb(74, 134, 160);
            pnTituloFormulario.Controls.Add(txtInstancia);
            pnTituloFormulario.Controls.Add(txtOpcion);
            pnTituloFormulario.Controls.Add(btnCierreVolver);
            pnTituloFormulario.Controls.Add(lblTituloForm);
            pnTituloFormulario.Dock = DockStyle.Top;
            pnTituloFormulario.Location = new Point(0, 0);
            pnTituloFormulario.Margin = new Padding(0);
            pnTituloFormulario.Name = "pnTituloFormulario";
            pnTituloFormulario.Size = new Size(984, 50);
            pnTituloFormulario.TabIndex = 49;
            // 
            // txtInstancia
            // 
            txtInstancia.BorderStyle = BorderStyle.FixedSingle;
            txtInstancia.Location = new Point(779, 12);
            txtInstancia.Name = "txtInstancia";
            txtInstancia.Size = new Size(34, 23);
            txtInstancia.TabIndex = 47;
            txtInstancia.Text = "0";
            txtInstancia.Visible = false;
            // 
            // txtOpcion
            // 
            txtOpcion.BorderStyle = BorderStyle.FixedSingle;
            txtOpcion.Location = new Point(728, 12);
            txtOpcion.Name = "txtOpcion";
            txtOpcion.Size = new Size(34, 23);
            txtOpcion.TabIndex = 46;
            txtOpcion.Text = "0";
            txtOpcion.Visible = false;
            // 
            // btnCierreVolver
            // 
            btnCierreVolver.Cursor = Cursors.Hand;
            btnCierreVolver.Image = Properties.Resources.left_arrow__1_;
            btnCierreVolver.Location = new Point(12, 9);
            btnCierreVolver.Name = "btnCierreVolver";
            btnCierreVolver.Size = new Size(31, 35);
            btnCierreVolver.SizeMode = PictureBoxSizeMode.Zoom;
            btnCierreVolver.TabIndex = 6;
            btnCierreVolver.TabStop = false;
            btnCierreVolver.Click += btnCierreVolver_Click;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("EngraversGothic BT", 20F);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(279, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(424, 28);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Formulario Modelo Mantenimiento";
            // 
            // pnlContenedorPrincipal
            // 
            pnlContenedorPrincipal.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnlContenedorPrincipal.Controls.Add(tabControlMain);
            pnlContenedorPrincipal.Location = new Point(4, 53);
            pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            pnlContenedorPrincipal.Size = new Size(976, 501);
            pnlContenedorPrincipal.TabIndex = 50;
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.BottomBackColor = Color.Black;
            tabControlMain.BottomForeColor = Color.White;
            tabControlMain.Controls.Add(tabListado);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.Cursor = Cursors.Hand;
            tabControlMain.Font = new Font("EngraversGothic BT", 10F);
            tabControlMain.ItemSize = new Size(200, 30);
            tabControlMain.LineBackColor = Color.FromArgb(74, 134, 160);
            tabControlMain.LineForeColor = Color.White;
            tabControlMain.Location = new Point(0, 3);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.Padding = new Point(3, 3);
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(980, 502);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 5;
            tabControlMain.TabStyle = MiTabControl.Style.Line;
            // 
            // tabListado
            // 
            tabListado.BackColor = Color.FromArgb(74, 134, 160);
            tabListado.Controls.Add(pnMantenimiento);
            tabListado.Controls.Add(pnListado);
            tabListado.Location = new Point(4, 34);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(972, 464);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnMantenimiento.BackColor = Color.FromArgb(4, 41, 68);
            pnMantenimiento.Controls.Add(label2);
            pnMantenimiento.Controls.Add(txtNombre);
            pnMantenimiento.Controls.Add(label1);
            pnMantenimiento.Controls.Add(txtID);
            pnMantenimiento.Controls.Add(btnEliminar);
            pnMantenimiento.Controls.Add(btnCancelar);
            pnMantenimiento.Controls.Add(btnGrabar);
            pnMantenimiento.Location = new Point(662, 3);
            pnMantenimiento.Name = "pnMantenimiento";
            pnMantenimiento.Size = new Size(310, 456);
            pnMantenimiento.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("EngraversGothic BT", 10F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(14, 92);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 26;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Gainsboro;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(14, 110);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(288, 22);
            txtNombre.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("EngraversGothic BT", 10F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(14, 37);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 24;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.Gainsboro;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(14, 55);
            txtID.Name = "txtID";
            txtID.Size = new Size(288, 22);
            txtID.TabIndex = 23;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Red;
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnEliminar.FlatStyle = FlatStyle.Flat;
            btnEliminar.ForeColor = Color.WhiteSmoke;
            btnEliminar.Location = new Point(216, 411);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 32);
            btnEliminar.TabIndex = 22;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.SteelBlue;
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnCancelar.FlatStyle = FlatStyle.Flat;
            btnCancelar.ForeColor = Color.WhiteSmoke;
            btnCancelar.Location = new Point(114, 411);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 32);
            btnCancelar.TabIndex = 21;
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
            btnGrabar.Location = new Point(14, 411);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(86, 32);
            btnGrabar.TabIndex = 20;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            // 
            // pnListado
            // 
            pnListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnListado.BackColor = Color.FromArgb(45, 66, 91);
            pnListado.Controls.Add(btnDetalles);
            pnListado.Controls.Add(btnEditar);
            pnListado.Controls.Add(btnNuevo);
            pnListado.Controls.Add(dgvListado);
            pnListado.Controls.Add(label4);
            pnListado.Controls.Add(txtBuscar);
            pnListado.Controls.Add(btnBuscar);
            pnListado.Location = new Point(3, 3);
            pnListado.Name = "pnListado";
            pnListado.Size = new Size(660, 458);
            pnListado.TabIndex = 0;
            // 
            // btnEditar
            // 
            btnEditar.BackColor = Color.SteelBlue;
            btnEditar.Cursor = Cursors.Hand;
            btnEditar.Enabled = false;
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnEditar.FlatStyle = FlatStyle.Flat;
            btnEditar.ForeColor = Color.WhiteSmoke;
            btnEditar.Location = new Point(222, 411);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 32);
            btnEditar.TabIndex = 18;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.SteelBlue;
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.WhiteSmoke;
            btnNuevo.Location = new Point(14, 411);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(86, 32);
            btnNuevo.TabIndex = 17;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dgvListado
            // 
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(14, 55);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(639, 345);
            dgvListado.TabIndex = 16;
            dgvListado.CellContentClick += dgvListado_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("EngraversGothic BT", 10F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(21, 21);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 15;
            label4.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Gainsboro;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(85, 19);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(511, 22);
            txtBuscar.TabIndex = 14;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(23, 54, 93);
            btnBuscar.Image = (Image)resources.GetObject("btnBuscar.Image");
            btnBuscar.Location = new Point(602, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(37, 32);
            btnBuscar.TabIndex = 13;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tabNuevo
            // 
            tabNuevo.BackColor = Color.FromArgb(74, 134, 160);
            tabNuevo.Location = new Point(4, 34);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(972, 464);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nueva";
            // 
            // tabEditar
            // 
            tabEditar.BackColor = Color.FromArgb(74, 134, 160);
            tabEditar.Location = new Point(4, 34);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(972, 464);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            // 
            // btnDetalles
            // 
            btnDetalles.BackColor = Color.SteelBlue;
            btnDetalles.Cursor = Cursors.Hand;
            btnDetalles.Enabled = false;
            btnDetalles.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnDetalles.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnDetalles.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnDetalles.FlatStyle = FlatStyle.Flat;
            btnDetalles.ForeColor = Color.WhiteSmoke;
            btnDetalles.Location = new Point(116, 411);
            btnDetalles.Name = "btnDetalles";
            btnDetalles.Size = new Size(86, 32);
            btnDetalles.TabIndex = 20;
            btnDetalles.Text = "Detalles";
            btnDetalles.UseVisualStyleBackColor = false;
            btnDetalles.Visible = false;
            // 
            // FrmModeloCRUD
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 134, 160);
            ClientSize = new Size(984, 561);
            Controls.Add(pnlContenedorPrincipal);
            Controls.Add(pnTituloFormulario);
            Controls.Add(pnGral);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModeloCRUD";
            Text = "Form1";
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).EndInit();
            pnlContenedorPrincipal.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            pnMantenimiento.ResumeLayout(false);
            pnMantenimiento.PerformLayout();
            pnListado.ResumeLayout(false);
            pnListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public Panel pnGral;
        public Panel pnTituloFormulario;
        public TextBox txtInstancia;
        public TextBox txtOpcion;
        public PictureBox btnCierreVolver;
        public Label lblTituloForm;
        public Panel pnlContenedorPrincipal;
        public MiTabControl tabControlMain;
        public TabPage tabListado;
        public TabPage tabNuevo;
        public TabPage tabEditar;
        public Label label4;
        public TextBox txtBuscar;
        public Button btnBuscar;
        public DataGridView dgvListado;
        public Button btnEditar;
        public Button btnNuevo;
        public Button btnEliminar;
        public Button btnCancelar;
        public Button btnGrabar;
        public Label label2;
        public TextBox txtNombre;
        public Label label1;
        public TextBox txtID;
        public Panel pnMantenimiento;
        public Panel pnListado;
        public Button btnDetalles;
    }
}