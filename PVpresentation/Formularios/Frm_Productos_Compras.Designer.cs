namespace PVpresentation.Formularios
{
    partial class Frm_Productos_Compras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Productos_Compras));
            pnTituloFormulario = new Panel();
            txtImpuesto = new TextBox();
            txtMarca = new TextBox();
            txtCategoria = new TextBox();
            txtProveedorID = new TextBox();
            txtFecha = new TextBox();
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
            txtID = new TextBox();
            label3 = new Label();
            txtNombre = new TextBox();
            label2 = new Label();
            txtBarCode = new TextBox();
            label24 = new Label();
            cmbSituacion = new ComboBox();
            label26 = new Label();
            btnAgregarProveedor = new Button();
            btnAgregarMarca = new Button();
            btnAgregarCategoria = new Button();
            btnAgregarImpuesto = new Button();
            txtStock = new TextBox();
            txtColor = new TextBox();
            txtpVenta = new TextBox();
            txtpOferta = new TextBox();
            txtCosto = new TextBox();
            txtTalle = new TextBox();
            label27 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            label28 = new Label();
            cmbProveedor = new ComboBox();
            label16 = new Label();
            label17 = new Label();
            label21 = new Label();
            cmbMarca = new ComboBox();
            label22 = new Label();
            cmbCategoria = new ComboBox();
            label23 = new Label();
            cmbImpuesto = new ComboBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
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
            pnTituloFormulario.Controls.Add(txtImpuesto);
            pnTituloFormulario.Controls.Add(txtMarca);
            pnTituloFormulario.Controls.Add(txtCategoria);
            pnTituloFormulario.Controls.Add(txtProveedorID);
            pnTituloFormulario.Controls.Add(txtFecha);
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
            pnTituloFormulario.Size = new Size(850, 45);
            pnTituloFormulario.TabIndex = 55;
            pnTituloFormulario.MouseMove += pnTituloFormulario_MouseMove;
            // 
            // txtImpuesto
            // 
            txtImpuesto.BorderStyle = BorderStyle.FixedSingle;
            txtImpuesto.Location = new Point(233, 12);
            txtImpuesto.Name = "txtImpuesto";
            txtImpuesto.Size = new Size(34, 23);
            txtImpuesto.TabIndex = 60;
            txtImpuesto.Text = "0";
            txtImpuesto.Visible = false;
            // 
            // txtMarca
            // 
            txtMarca.BorderStyle = BorderStyle.FixedSingle;
            txtMarca.Location = new Point(193, 12);
            txtMarca.Name = "txtMarca";
            txtMarca.Size = new Size(34, 23);
            txtMarca.TabIndex = 59;
            txtMarca.Text = "0";
            txtMarca.Visible = false;
            // 
            // txtCategoria
            // 
            txtCategoria.BorderStyle = BorderStyle.FixedSingle;
            txtCategoria.Location = new Point(153, 12);
            txtCategoria.Name = "txtCategoria";
            txtCategoria.Size = new Size(34, 23);
            txtCategoria.TabIndex = 58;
            txtCategoria.Text = "0";
            txtCategoria.Visible = false;
            // 
            // txtProveedorID
            // 
            txtProveedorID.BorderStyle = BorderStyle.FixedSingle;
            txtProveedorID.Location = new Point(113, 12);
            txtProveedorID.Name = "txtProveedorID";
            txtProveedorID.Size = new Size(34, 23);
            txtProveedorID.TabIndex = 57;
            txtProveedorID.Text = "0";
            txtProveedorID.Visible = false;
            // 
            // txtFecha
            // 
            txtFecha.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtFecha.BorderStyle = BorderStyle.FixedSingle;
            txtFecha.Location = new Point(578, 14);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(34, 23);
            txtFecha.TabIndex = 54;
            txtFecha.Text = "0";
            txtFecha.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(83, 44);
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
            label1.Location = new Point(278, 10);
            label1.Name = "label1";
            label1.Size = new Size(263, 28);
            label1.TabIndex = 52;
            label1.Text = "Buscar | Productos";
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.Close;
            btnCerrar.Location = new Point(818, 14);
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
            txtInstancia.Location = new Point(696, 15);
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
            txtOpcion.Location = new Point(656, 14);
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
            lblTituloForm.Location = new Point(2232, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(289, 28);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Instancia de Venta N° 0";
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.None;
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
            tabControlMain.Size = new Size(850, 431);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 56;
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
            tabListado.Size = new Size(842, 393);
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
            btnBuscar.Location = new Point(739, 22);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(30, 30);
            btnBuscar.TabIndex = 1;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("EngraversGothic BT", 10F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(100, 32);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 23;
            label4.Text = "Cliente:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Gainsboro;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Font = new Font("Square721 BT", 12F);
            txtBuscar.Location = new Point(154, 25);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(570, 27);
            txtBuscar.TabIndex = 0;
            // 
            // dgvListado
            // 
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(8, 64);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(826, 320);
            dgvListado.TabIndex = 17;
            dgvListado.CellContentClick += dgvListado_CellContentClick;
            dgvListado.CellContentDoubleClick += dgvListado_CellContentDoubleClick;
            // 
            // tabNuevo
            // 
            tabNuevo.BackColor = Color.FromArgb(4, 41, 68);
            tabNuevo.Controls.Add(txtID);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(txtNombre);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Controls.Add(txtBarCode);
            tabNuevo.Controls.Add(label24);
            tabNuevo.Controls.Add(cmbSituacion);
            tabNuevo.Controls.Add(label26);
            tabNuevo.Controls.Add(btnAgregarProveedor);
            tabNuevo.Controls.Add(btnAgregarMarca);
            tabNuevo.Controls.Add(btnAgregarCategoria);
            tabNuevo.Controls.Add(btnAgregarImpuesto);
            tabNuevo.Controls.Add(txtStock);
            tabNuevo.Controls.Add(txtColor);
            tabNuevo.Controls.Add(txtpVenta);
            tabNuevo.Controls.Add(txtpOferta);
            tabNuevo.Controls.Add(txtCosto);
            tabNuevo.Controls.Add(txtTalle);
            tabNuevo.Controls.Add(label27);
            tabNuevo.Controls.Add(label20);
            tabNuevo.Controls.Add(label19);
            tabNuevo.Controls.Add(label18);
            tabNuevo.Controls.Add(label28);
            tabNuevo.Controls.Add(cmbProveedor);
            tabNuevo.Controls.Add(label16);
            tabNuevo.Controls.Add(label17);
            tabNuevo.Controls.Add(label21);
            tabNuevo.Controls.Add(cmbMarca);
            tabNuevo.Controls.Add(label22);
            tabNuevo.Controls.Add(cmbCategoria);
            tabNuevo.Controls.Add(label23);
            tabNuevo.Controls.Add(cmbImpuesto);
            tabNuevo.Controls.Add(btnCancelar);
            tabNuevo.Controls.Add(btnGrabar);
            tabNuevo.Font = new Font("Square721 BT", 11F);
            tabNuevo.Location = new Point(4, 34);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(842, 393);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nuevo";
            tabNuevo.Click += tabNuevo_Click;
            // 
            // txtID
            // 
            txtID.BackColor = Color.Gainsboro;
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Square721 BT", 11F);
            txtID.Location = new Point(28, 65);
            txtID.Name = "txtID";
            txtID.ReadOnly = true;
            txtID.Size = new Size(287, 25);
            txtID.TabIndex = 2;
            txtID.TabStop = false;
            txtID.KeyDown += txtID_KeyDown;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(28, 47);
            label3.Name = "label3";
            label3.Size = new Size(24, 15);
            label3.TabIndex = 209;
            label3.Text = "ID:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.Gainsboro;
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Square721 BT", 10F);
            txtNombre.Location = new Point(28, 117);
            txtNombre.Multiline = true;
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(287, 82);
            txtNombre.TabIndex = 3;
            txtNombre.KeyDown += txtNombre_KeyDown;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("EngraversGothic BT", 10F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(28, 99);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 207;
            label2.Text = "Nombre:";
            // 
            // txtBarCode
            // 
            txtBarCode.BackColor = Color.Gainsboro;
            txtBarCode.BorderStyle = BorderStyle.FixedSingle;
            txtBarCode.Font = new Font("Square721 BT", 11F);
            txtBarCode.Location = new Point(28, 281);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(287, 25);
            txtBarCode.TabIndex = 5;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("EngraversGothic BT", 10F);
            label24.ForeColor = Color.FromArgb(224, 224, 224);
            label24.Location = new Point(27, 209);
            label24.Name = "label24";
            label24.Size = new Size(64, 15);
            label24.TabIndex = 205;
            label24.Text = "Situación";
            // 
            // cmbSituacion
            // 
            cmbSituacion.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbSituacion.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSituacion.BackColor = Color.Gainsboro;
            cmbSituacion.Font = new Font("Square721 BT", 11F);
            cmbSituacion.FormattingEnabled = true;
            cmbSituacion.Location = new Point(27, 225);
            cmbSituacion.Name = "cmbSituacion";
            cmbSituacion.Size = new Size(286, 27);
            cmbSituacion.TabIndex = 4;
            cmbSituacion.KeyDown += cmbSituacion_KeyDown;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("EngraversGothic BT", 10F);
            label26.ForeColor = Color.FromArgb(224, 224, 224);
            label26.Location = new Point(28, 263);
            label26.Name = "label26";
            label26.Size = new Size(60, 15);
            label26.TabIndex = 204;
            label26.Text = "BarCode";
            // 
            // btnAgregarProveedor
            // 
            btnAgregarProveedor.BackColor = Color.SteelBlue;
            btnAgregarProveedor.Cursor = Cursors.Hand;
            btnAgregarProveedor.Enabled = false;
            btnAgregarProveedor.FlatAppearance.BorderSize = 0;
            btnAgregarProveedor.FlatStyle = FlatStyle.Flat;
            btnAgregarProveedor.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarProveedor.ForeColor = Color.WhiteSmoke;
            btnAgregarProveedor.Location = new Point(346, 229);
            btnAgregarProveedor.Margin = new Padding(0);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(31, 23);
            btnAgregarProveedor.TabIndex = 201;
            btnAgregarProveedor.TabStop = false;
            btnAgregarProveedor.Text = "...";
            btnAgregarProveedor.UseVisualStyleBackColor = false;
            // 
            // btnAgregarMarca
            // 
            btnAgregarMarca.BackColor = Color.SteelBlue;
            btnAgregarMarca.Cursor = Cursors.Hand;
            btnAgregarMarca.Enabled = false;
            btnAgregarMarca.FlatAppearance.BorderSize = 0;
            btnAgregarMarca.FlatStyle = FlatStyle.Flat;
            btnAgregarMarca.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarMarca.ForeColor = Color.WhiteSmoke;
            btnAgregarMarca.Location = new Point(346, 176);
            btnAgregarMarca.Margin = new Padding(0);
            btnAgregarMarca.Name = "btnAgregarMarca";
            btnAgregarMarca.Size = new Size(31, 23);
            btnAgregarMarca.TabIndex = 200;
            btnAgregarMarca.TabStop = false;
            btnAgregarMarca.Text = "...";
            btnAgregarMarca.UseVisualStyleBackColor = false;
            // 
            // btnAgregarCategoria
            // 
            btnAgregarCategoria.BackColor = Color.SteelBlue;
            btnAgregarCategoria.Cursor = Cursors.Hand;
            btnAgregarCategoria.Enabled = false;
            btnAgregarCategoria.FlatAppearance.BorderSize = 0;
            btnAgregarCategoria.FlatStyle = FlatStyle.Flat;
            btnAgregarCategoria.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarCategoria.ForeColor = Color.WhiteSmoke;
            btnAgregarCategoria.Location = new Point(346, 118);
            btnAgregarCategoria.Margin = new Padding(0);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(31, 23);
            btnAgregarCategoria.TabIndex = 199;
            btnAgregarCategoria.TabStop = false;
            btnAgregarCategoria.Text = "...";
            btnAgregarCategoria.UseVisualStyleBackColor = false;
            // 
            // btnAgregarImpuesto
            // 
            btnAgregarImpuesto.BackColor = Color.SteelBlue;
            btnAgregarImpuesto.Cursor = Cursors.Hand;
            btnAgregarImpuesto.Enabled = false;
            btnAgregarImpuesto.FlatAppearance.BorderSize = 0;
            btnAgregarImpuesto.FlatStyle = FlatStyle.Flat;
            btnAgregarImpuesto.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnAgregarImpuesto.ForeColor = Color.WhiteSmoke;
            btnAgregarImpuesto.Location = new Point(346, 66);
            btnAgregarImpuesto.Margin = new Padding(0);
            btnAgregarImpuesto.Name = "btnAgregarImpuesto";
            btnAgregarImpuesto.Size = new Size(31, 23);
            btnAgregarImpuesto.TabIndex = 198;
            btnAgregarImpuesto.TabStop = false;
            btnAgregarImpuesto.Text = "...";
            btnAgregarImpuesto.UseVisualStyleBackColor = false;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.Gainsboro;
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Font = new Font("Square721 BT", 12F);
            txtStock.Location = new Point(675, 67);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(136, 27);
            txtStock.TabIndex = 12;
            txtStock.TextAlign = HorizontalAlignment.Center;
            txtStock.KeyDown += txtStock_KeyDown;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.Gainsboro;
            txtColor.BorderStyle = BorderStyle.FixedSingle;
            txtColor.Font = new Font("Square721 BT", 11F);
            txtColor.Location = new Point(487, 281);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(146, 25);
            txtColor.TabIndex = 11;
            txtColor.KeyDown += txtColor_KeyDown;
            // 
            // txtpVenta
            // 
            txtpVenta.BackColor = Color.Gainsboro;
            txtpVenta.BorderStyle = BorderStyle.FixedSingle;
            txtpVenta.Font = new Font("Square721 BT", 12F);
            txtpVenta.Location = new Point(675, 228);
            txtpVenta.Name = "txtpVenta";
            txtpVenta.Size = new Size(136, 27);
            txtpVenta.TabIndex = 15;
            txtpVenta.TextAlign = HorizontalAlignment.Right;
            txtpVenta.KeyDown += txtpVenta_KeyDown;
            txtpVenta.KeyPress += txtpVenta_KeyPress;
            // 
            // txtpOferta
            // 
            txtpOferta.BackColor = Color.Gainsboro;
            txtpOferta.BorderStyle = BorderStyle.FixedSingle;
            txtpOferta.Font = new Font("Square721 BT", 12F);
            txtpOferta.Location = new Point(675, 170);
            txtpOferta.Name = "txtpOferta";
            txtpOferta.Size = new Size(136, 27);
            txtpOferta.TabIndex = 14;
            txtpOferta.TextAlign = HorizontalAlignment.Right;
            txtpOferta.KeyDown += txtpOferta_KeyDown;
            txtpOferta.KeyPress += txtpOferta_KeyPress;
            // 
            // txtCosto
            // 
            txtCosto.BackColor = Color.Gainsboro;
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.Font = new Font("Square721 BT", 12F);
            txtCosto.Location = new Point(675, 118);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(136, 27);
            txtCosto.TabIndex = 13;
            txtCosto.TextAlign = HorizontalAlignment.Right;
            txtCosto.KeyDown += txtCosto_KeyDown;
            txtCosto.KeyPress += txtCosto_KeyPress;
            // 
            // txtTalle
            // 
            txtTalle.BackColor = Color.Gainsboro;
            txtTalle.BorderStyle = BorderStyle.FixedSingle;
            txtTalle.Font = new Font("Square721 BT", 11F);
            txtTalle.Location = new Point(347, 281);
            txtTalle.Name = "txtTalle";
            txtTalle.Size = new Size(114, 25);
            txtTalle.TabIndex = 10;
            txtTalle.KeyDown += txtTalle_KeyDown;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("EngraversGothic BT", 10F);
            label27.ForeColor = Color.FromArgb(224, 224, 224);
            label27.Location = new Point(675, 49);
            label27.Name = "label27";
            label27.Size = new Size(44, 15);
            label27.TabIndex = 194;
            label27.Text = "Stock";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("EngraversGothic BT", 10F);
            label20.ForeColor = Color.FromArgb(224, 224, 224);
            label20.Location = new Point(675, 100);
            label20.Name = "label20";
            label20.Size = new Size(44, 15);
            label20.TabIndex = 195;
            label20.Text = "Costo";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("EngraversGothic BT", 10F);
            label19.ForeColor = Color.FromArgb(224, 224, 224);
            label19.Location = new Point(675, 152);
            label19.Name = "label19";
            label19.Size = new Size(64, 15);
            label19.TabIndex = 196;
            label19.Text = "$ Oferta";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("EngraversGothic BT", 10F);
            label18.ForeColor = Color.FromArgb(224, 224, 224);
            label18.Location = new Point(675, 210);
            label18.Name = "label18";
            label18.Size = new Size(55, 15);
            label18.TabIndex = 197;
            label18.Text = "$ Venta";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("EngraversGothic BT", 10F);
            label28.ForeColor = Color.FromArgb(224, 224, 224);
            label28.Location = new Point(343, 209);
            label28.Name = "label28";
            label28.Size = new Size(75, 15);
            label28.TabIndex = 193;
            label28.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            cmbProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProveedor.BackColor = Color.Gainsboro;
            cmbProveedor.DropDownWidth = 335;
            cmbProveedor.Font = new Font("Square721 BT", 11F);
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(380, 227);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(276, 27);
            cmbProveedor.TabIndex = 9;
            cmbProveedor.KeyDown += cmbProveedor_KeyDown;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("EngraversGothic BT", 10F);
            label16.ForeColor = Color.FromArgb(224, 224, 224);
            label16.Location = new Point(487, 264);
            label16.Name = "label16";
            label16.Size = new Size(45, 15);
            label16.TabIndex = 192;
            label16.Text = "Color";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("EngraversGothic BT", 10F);
            label17.ForeColor = Color.FromArgb(224, 224, 224);
            label17.Location = new Point(347, 263);
            label17.Name = "label17";
            label17.Size = new Size(38, 15);
            label17.TabIndex = 191;
            label17.Text = "Talle";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("EngraversGothic BT", 10F);
            label21.ForeColor = Color.FromArgb(224, 224, 224);
            label21.Location = new Point(343, 157);
            label21.Name = "label21";
            label21.Size = new Size(45, 15);
            label21.TabIndex = 190;
            label21.Text = "Marca";
            // 
            // cmbMarca
            // 
            cmbMarca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMarca.BackColor = Color.Gainsboro;
            cmbMarca.DropDownWidth = 335;
            cmbMarca.Font = new Font("Square721 BT", 11F);
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(380, 175);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(276, 27);
            cmbMarca.TabIndex = 8;
            cmbMarca.KeyDown += cmbMarca_KeyDown;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("EngraversGothic BT", 10F);
            label22.ForeColor = Color.FromArgb(224, 224, 224);
            label22.Location = new Point(343, 100);
            label22.Name = "label22";
            label22.Size = new Size(67, 15);
            label22.TabIndex = 189;
            label22.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategoria.BackColor = Color.Gainsboro;
            cmbCategoria.DropDownWidth = 335;
            cmbCategoria.Font = new Font("Square721 BT", 11F);
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(380, 118);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(276, 27);
            cmbCategoria.TabIndex = 7;
            cmbCategoria.KeyDown += cmbCategoria_KeyDown;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("EngraversGothic BT", 10F);
            label23.ForeColor = Color.FromArgb(224, 224, 224);
            label23.Location = new Point(343, 49);
            label23.Name = "label23";
            label23.Size = new Size(61, 15);
            label23.TabIndex = 188;
            label23.Text = "Impuesto";
            // 
            // cmbImpuesto
            // 
            cmbImpuesto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbImpuesto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbImpuesto.BackColor = Color.Gainsboro;
            cmbImpuesto.DropDownWidth = 335;
            cmbImpuesto.Font = new Font("Square721 BT", 11F);
            cmbImpuesto.FormattingEnabled = true;
            cmbImpuesto.Location = new Point(380, 65);
            cmbImpuesto.Name = "cmbImpuesto";
            cmbImpuesto.Size = new Size(276, 27);
            cmbImpuesto.TabIndex = 6;
            cmbImpuesto.KeyDown += cmbImpuesto_KeyDown;
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
            btnCancelar.Location = new Point(725, 352);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 32);
            btnCancelar.TabIndex = 177;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.BackColor = Color.SteelBlue;
            btnGrabar.Cursor = Cursors.Hand;
            btnGrabar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnGrabar.FlatStyle = FlatStyle.Flat;
            btnGrabar.Font = new Font("Square721 BT", 11F);
            btnGrabar.ForeColor = Color.WhiteSmoke;
            btnGrabar.Location = new Point(617, 352);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new Size(86, 32);
            btnGrabar.TabIndex = 16;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // Frm_Productos_Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 134, 160);
            ClientSize = new Size(850, 478);
            Controls.Add(tabControlMain);
            Controls.Add(pnTituloFormulario);
            FormBorderStyle = FormBorderStyle.None;
            MaximumSize = new Size(850, 478);
            MinimumSize = new Size(850, 478);
            Name = "Frm_Productos_Compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Productos_Compras";
            Load += Frm_Productos_Compras_Load;
            KeyDown += Frm_Productos_Compras_KeyDown;
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
        private PictureBox pictureBox1;
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
        public Button btnCancelar;
        public Button btnGrabar;
        private Button btnAgregarProveedor;
        private Button btnAgregarMarca;
        private Button btnAgregarCategoria;
        private Button btnAgregarImpuesto;
        private TextBox txtColor;
        private TextBox txtTalle;
        private Label label27;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label28;
        public ComboBox cmbProveedor;
        private Label label16;
        private Label label17;
        private Label label21;
        public ComboBox cmbMarca;
        private Label label22;
        public ComboBox cmbCategoria;
        private Label label23;
        public ComboBox cmbImpuesto;
        private Label label24;
        private Label label26;
        private Label label3;
        private Label label2;
        public TextBox txtFecha;
        public TextBox txtStock;
        public TextBox txtpVenta;
        public TextBox txtpOferta;
        public TextBox txtCosto;
        public TextBox txtBarCode;
        public ComboBox cmbSituacion;
        public TextBox txtID;
        public TextBox txtNombre;
        public TextBox txtImpuesto;
        public TextBox txtMarca;
        public TextBox txtCategoria;
        public TextBox txtProveedorID;
    }
}