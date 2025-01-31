namespace PVpresentation.Formularios
{
    partial class Frm_Productos_BuscaDeInstancia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Productos_BuscaDeInstancia));
            pnTituloFormulario = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            btnCerrar = new PictureBox();
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
            lblTituloForm = new Label();
            tabControlMain = new MiTabControl();
            tabListado = new TabPage();
            btnBuscar = new Button();
            label4 = new Label();
            txtBuscar = new TextBox();
            dgvListado = new DataGridView();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            tabControlMain.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
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
            pnTituloFormulario.Size = new Size(788, 45);
            pnTituloFormulario.TabIndex = 51;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(45, 43);
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
            label1.Location = new Point(291, 9);
            label1.Name = "label1";
            label1.Size = new Size(227, 28);
            label1.TabIndex = 52;
            label1.Text = "Buscar Producto";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.Close;
            btnCerrar.Location = new Point(748, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 21);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 49;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // txtInstancia
            // 
            txtInstancia.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtInstancia.BorderStyle = BorderStyle.FixedSingle;
            txtInstancia.Location = new Point(157, 14);
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
            txtOpcion.Location = new Point(117, 14);
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
            lblTituloForm.Location = new Point(914, 9);
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
            tabControlMain.Cursor = Cursors.Hand;
            tabControlMain.Font = new Font("EngraversGothic BT", 10F);
            tabControlMain.ItemSize = new Size(200, 35);
            tabControlMain.LineBackColor = Color.FromArgb(4, 41, 68);
            tabControlMain.LineForeColor = Color.White;
            tabControlMain.Location = new Point(0, 45);
            tabControlMain.Margin = new Padding(0);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.Padding = new Point(0, 0);
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(788, 348);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 54;
            tabControlMain.TabStyle = MiTabControl.Style.Line;
            // 
            // tabListado
            // 
            tabListado.BackColor = Color.FromArgb(4, 41, 68);
            tabListado.Controls.Add(btnBuscar);
            tabListado.Controls.Add(label4);
            tabListado.Controls.Add(txtBuscar);
            tabListado.Controls.Add(dgvListado);
            tabListado.Location = new Point(4, 39);
            tabListado.Margin = new Padding(0);
            tabListado.Name = "tabListado";
            tabListado.Size = new Size(780, 305);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
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
            btnBuscar.Location = new Point(718, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(30, 30);
            btnBuscar.TabIndex = 54;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("EngraversGothic BT", 10F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(37, 23);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 23;
            label4.Text = "Artículo:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Gainsboro;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("EngraversGothic BT", 11F);
            txtBuscar.Location = new Point(113, 20);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(599, 23);
            txtBuscar.TabIndex = 22;
            txtBuscar.KeyDown += txtBuscar_KeyDown;
            // 
            // dgvListado
            // 
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(16, 55);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(748, 229);
            dgvListado.TabIndex = 17;
            dgvListado.CellContentClick += dgvListado_CellContentClick;
            // 
            // Frm_Productos_BuscaDeInstancia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(4, 41, 68);
            ClientSize = new Size(788, 391);
            Controls.Add(tabControlMain);
            Controls.Add(pnTituloFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Productos_BuscaDeInstancia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Productos_BuscaDeInstancia";
            Load += Frm_Productos_BuscaDeInstancia_Load;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            tabControlMain.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnTituloFormulario;
        private PictureBox btnCerrar;
        public TextBox txtInstancia;
        public TextBox txtOpcion;
        public Label lblTituloForm;
        public Label label1;
        public MiTabControl tabControlMain;
        public TabPage tabListado;
        public Button btnBuscar;
        public Label label4;
        public TextBox txtBuscar;
        public DataGridView dgvListado;
        private PictureBox pictureBox1;
    }
}