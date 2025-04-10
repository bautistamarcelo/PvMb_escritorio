namespace PVpresentation.Formularios.Modelos
{
    partial class FrmModeloTransaccion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmModeloTransaccion));
            pnGral = new Panel();
            pnTituloFormulario = new Panel();
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
            btnCierreVolver = new PictureBox();
            lblTituloForm = new Label();
            pnlContenedorPrincipal = new Panel();
            tabControlMain = new MiTabControl();
            tabListado = new TabPage();
            btnEditar = new Button();
            btnNuevo = new Button();
            dgvListado = new DataGridView();
            label4 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            tabNuevo = new TabPage();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnGrabar = new Button();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).BeginInit();
            pnlContenedorPrincipal.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            tabNuevo.SuspendLayout();
            SuspendLayout();
            // 
            // pnGral
            // 
            pnGral.BackColor = Color.FromArgb(74, 154, 190);
            pnGral.Location = new Point(0, 0);
            pnGral.Name = "pnGral";
            pnGral.Size = new Size(968, 522);
            pnGral.TabIndex = 52;
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
            pnTituloFormulario.Size = new Size(968, 50);
            pnTituloFormulario.TabIndex = 50;
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
            pnlContenedorPrincipal.BackColor = Color.FromArgb(74, 134, 160);
            pnlContenedorPrincipal.Controls.Add(tabControlMain);
            pnlContenedorPrincipal.Location = new Point(0, 53);
            pnlContenedorPrincipal.Name = "pnlContenedorPrincipal";
            pnlContenedorPrincipal.Size = new Size(968, 469);
            pnlContenedorPrincipal.TabIndex = 51;
            // 
            // tabControlMain
            // 
            tabControlMain.BottomBackColor = Color.Black;
            tabControlMain.BottomForeColor = Color.White;
            tabControlMain.Controls.Add(tabListado);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Cursor = Cursors.Hand;
            tabControlMain.Dock = DockStyle.Fill;
            tabControlMain.Font = new Font("EngraversGothic BT", 10F);
            tabControlMain.ItemSize = new Size(200, 30);
            tabControlMain.LineBackColor = Color.FromArgb(74, 134, 160);
            tabControlMain.LineForeColor = Color.White;
            tabControlMain.Location = new Point(0, 0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.Padding = new Point(3, 3);
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(968, 469);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 6;
            tabControlMain.TabStyle = MiTabControl.Style.Line;
            // 
            // tabListado
            // 
            tabListado.BackColor = Color.FromArgb(45, 66, 91);
            tabListado.Controls.Add(btnEditar);
            tabListado.Controls.Add(btnNuevo);
            tabListado.Controls.Add(dgvListado);
            tabListado.Controls.Add(label4);
            tabListado.Controls.Add(txtBuscar);
            tabListado.Controls.Add(btnBuscar);
            tabListado.Location = new Point(4, 34);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(960, 431);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
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
            btnEditar.Location = new Point(135, 393);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(86, 32);
            btnEditar.TabIndex = 24;
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
            btnNuevo.Location = new Point(17, 393);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(86, 32);
            btnNuevo.TabIndex = 23;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // dgvListado
            // 
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(15, 39);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(924, 345);
            dgvListado.TabIndex = 22;
            dgvListado.CellContentClick += dgvListado_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("EngraversGothic BT", 10F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(163, 13);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 21;
            label4.Text = "Buscar:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Gainsboro;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(227, 11);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(511, 22);
            txtBuscar.TabIndex = 20;
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
            btnBuscar.Location = new Point(744, 4);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(37, 32);
            btnBuscar.TabIndex = 19;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // tabNuevo
            // 
            tabNuevo.BackColor = Color.FromArgb(4, 41, 68);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Controls.Add(txtNombre);
            tabNuevo.Controls.Add(label1);
            tabNuevo.Controls.Add(txtID);
            tabNuevo.Controls.Add(btnEliminar);
            tabNuevo.Controls.Add(btnCancelar);
            tabNuevo.Controls.Add(btnGrabar);
            tabNuevo.Location = new Point(4, 34);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(960, 431);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Mantenimiento";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("EngraversGothic BT", 10F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(22, 70);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 33;
            label2.Text = "Nombre:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Gainsboro;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Location = new Point(22, 88);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(288, 22);
            txtNombre.TabIndex = 32;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("EngraversGothic BT", 10F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(22, 15);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 31;
            label1.Text = "ID:";
            // 
            // txtID
            // 
            txtID.BackColor = Color.Gainsboro;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(22, 33);
            txtID.Name = "txtID";
            txtID.Size = new Size(288, 22);
            txtID.TabIndex = 30;
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
            btnEliminar.Location = new Point(325, 386);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(86, 32);
            btnEliminar.TabIndex = 29;
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
            btnCancelar.Location = new Point(171, 386);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 32);
            btnCancelar.TabIndex = 28;
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
            btnGrabar.Location = new Point(22, 386);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(86, 32);
            btnGrabar.TabIndex = 27;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            // 
            // FrmModeloTransaccion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 134, 160);
            ClientSize = new Size(968, 522);
            Controls.Add(pnlContenedorPrincipal);
            Controls.Add(pnTituloFormulario);
            Controls.Add(pnGral);
            FormBorderStyle = FormBorderStyle.None;
            MinimizeBox = false;
            Name = "FrmModeloTransaccion";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FrmModeloTransaccion";
            WindowState = FormWindowState.Maximized;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).EndInit();
            pnlContenedorPrincipal.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
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
        //public TabPage tabEditar;
        public Button btnEditar;
        public Button btnNuevo;
        public DataGridView dgvListado;
        public Label label4;
        public TextBox txtBuscar;
        public Button btnBuscar;
        public Label label2;
        public TextBox txtNombre;
        public Label label1;
        public TextBox txtID;
        public Button btnEliminar;
        public Button btnCancelar;
        public Button btnGrabar;
        
    }
}