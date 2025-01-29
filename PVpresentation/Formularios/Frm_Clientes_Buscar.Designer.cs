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
            label1 = new Label();
            btnMaximizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
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
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            txtBarCode = new TextBox();
            label24 = new Label();
            cmbSituacion = new ComboBox();
            label26 = new Label();
            txtStock = new TextBox();
            txtpVenta = new TextBox();
            txtpOferta = new TextBox();
            txtCosto = new TextBox();
            label27 = new Label();
            label20 = new Label();
            label19 = new Label();
            label18 = new Label();
            btnAgregarProveedor = new Button();
            btnAgregarMarca = new Button();
            btnAgregarCategoria = new Button();
            btnAgregarImpuesto = new Button();
            label28 = new Label();
            cmbProveedor = new ComboBox();
            label21 = new Label();
            cmbMarca = new ComboBox();
            label22 = new Label();
            cmbCategoria = new ComboBox();
            label23 = new Label();
            cmbImpuesto = new ComboBox();
            pictureBox1 = new PictureBox();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            tabControlMain.SuspendLayout();
            tabListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            tabNuevo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.BackColor = Color.FromArgb(74, 134, 160);
            pnTituloFormulario.Controls.Add(pictureBox1);
            pnTituloFormulario.Controls.Add(label1);
            pnTituloFormulario.Controls.Add(btnMaximizar);
            pnTituloFormulario.Controls.Add(btnRestaurar);
            pnTituloFormulario.Controls.Add(btnCerrar);
            pnTituloFormulario.Controls.Add(btnMinimizar);
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
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("EngraversGothic BT", 20F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(286, 12);
            label1.Name = "label1";
            label1.Size = new Size(232, 28);
            label1.TabIndex = 52;
            label1.Text = "Buscar | Clientes";
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = Properties.Resources.maximize3;
            btnMaximizar.Location = new Point(762, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(20, 21);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 50;
            btnMaximizar.TabStop = false;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Properties.Resources.Normal;
            btnRestaurar.Location = new Point(762, 12);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(20, 21);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 51;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
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
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.Minimize;
            btnMinimizar.Location = new Point(737, 12);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(20, 21);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 48;
            btnMinimizar.TabStop = false;
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
            btnNuevo.Location = new Point(45, 22);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(31, 28);
            btnNuevo.TabIndex = 55;
            btnNuevo.UseVisualStyleBackColor = true;
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
            btnBuscar.Location = new Point(726, 21);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(30, 30);
            btnBuscar.TabIndex = 54;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("EngraversGothic BT", 10F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(84, 32);
            label4.Name = "label4";
            label4.Size = new Size(67, 15);
            label4.TabIndex = 23;
            label4.Text = "Artículo:";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Gainsboro;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(154, 25);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(570, 22);
            txtBuscar.TabIndex = 22;
            // 
            // dgvListado
            // 
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(20, 61);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(784, 229);
            dgvListado.TabIndex = 17;
            // 
            // tabNuevo
            // 
            tabNuevo.BackColor = Color.FromArgb(4, 41, 68);
            tabNuevo.Controls.Add(textBox2);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(textBox1);
            tabNuevo.Controls.Add(label2);
            tabNuevo.Controls.Add(txtBarCode);
            tabNuevo.Controls.Add(label24);
            tabNuevo.Controls.Add(cmbSituacion);
            tabNuevo.Controls.Add(label26);
            tabNuevo.Controls.Add(txtStock);
            tabNuevo.Controls.Add(txtpVenta);
            tabNuevo.Controls.Add(txtpOferta);
            tabNuevo.Controls.Add(txtCosto);
            tabNuevo.Controls.Add(label27);
            tabNuevo.Controls.Add(label20);
            tabNuevo.Controls.Add(label19);
            tabNuevo.Controls.Add(label18);
            tabNuevo.Controls.Add(btnAgregarProveedor);
            tabNuevo.Controls.Add(btnAgregarMarca);
            tabNuevo.Controls.Add(btnAgregarCategoria);
            tabNuevo.Controls.Add(btnAgregarImpuesto);
            tabNuevo.Controls.Add(label28);
            tabNuevo.Controls.Add(cmbProveedor);
            tabNuevo.Controls.Add(label21);
            tabNuevo.Controls.Add(cmbMarca);
            tabNuevo.Controls.Add(label22);
            tabNuevo.Controls.Add(cmbCategoria);
            tabNuevo.Controls.Add(label23);
            tabNuevo.Controls.Add(cmbImpuesto);
            tabNuevo.Location = new Point(4, 34);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(817, 309);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nueva";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(31, 113);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(294, 22);
            textBox2.TabIndex = 160;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(34, 98);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 161;
            label3.Text = "BarCode";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(31, 61);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(294, 22);
            textBox1.TabIndex = 158;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("EngraversGothic BT", 10F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(34, 46);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 159;
            label2.Text = "BarCode";
            // 
            // txtBarCode
            // 
            txtBarCode.BackColor = Color.Gainsboro;
            txtBarCode.BorderStyle = BorderStyle.FixedSingle;
            txtBarCode.Location = new Point(31, 219);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(294, 22);
            txtBarCode.TabIndex = 155;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("EngraversGothic BT", 10F);
            label24.ForeColor = Color.FromArgb(224, 224, 224);
            label24.Location = new Point(34, 155);
            label24.Name = "label24";
            label24.Size = new Size(64, 15);
            label24.TabIndex = 157;
            label24.Text = "Situación";
            // 
            // cmbSituacion
            // 
            cmbSituacion.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbSituacion.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSituacion.BackColor = Color.Gainsboro;
            cmbSituacion.FormattingEnabled = true;
            cmbSituacion.Location = new Point(31, 168);
            cmbSituacion.Name = "cmbSituacion";
            cmbSituacion.Size = new Size(293, 22);
            cmbSituacion.TabIndex = 154;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("EngraversGothic BT", 10F);
            label26.ForeColor = Color.FromArgb(224, 224, 224);
            label26.Location = new Point(34, 204);
            label26.Name = "label26";
            label26.Size = new Size(60, 15);
            label26.TabIndex = 156;
            label26.Text = "BarCode";
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.Gainsboro;
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Location = new Point(642, 57);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(117, 22);
            txtStock.TabIndex = 146;
            txtStock.Text = "9";
            // 
            // txtpVenta
            // 
            txtpVenta.BackColor = Color.Gainsboro;
            txtpVenta.BorderStyle = BorderStyle.FixedSingle;
            txtpVenta.Location = new Point(642, 218);
            txtpVenta.Name = "txtpVenta";
            txtpVenta.Size = new Size(117, 22);
            txtpVenta.TabIndex = 149;
            txtpVenta.Text = "12";
            // 
            // txtpOferta
            // 
            txtpOferta.BackColor = Color.Gainsboro;
            txtpOferta.BorderStyle = BorderStyle.FixedSingle;
            txtpOferta.Location = new Point(642, 167);
            txtpOferta.Name = "txtpOferta";
            txtpOferta.Size = new Size(117, 22);
            txtpOferta.TabIndex = 148;
            txtpOferta.Text = "11";
            // 
            // txtCosto
            // 
            txtCosto.BackColor = Color.Gainsboro;
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.Location = new Point(642, 113);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(117, 22);
            txtCosto.TabIndex = 147;
            txtCosto.Text = "10";
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("EngraversGothic BT", 10F);
            label27.ForeColor = Color.FromArgb(224, 224, 224);
            label27.Location = new Point(645, 42);
            label27.Name = "label27";
            label27.Size = new Size(44, 15);
            label27.TabIndex = 150;
            label27.Text = "Stock";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("EngraversGothic BT", 10F);
            label20.ForeColor = Color.FromArgb(224, 224, 224);
            label20.Location = new Point(645, 98);
            label20.Name = "label20";
            label20.Size = new Size(44, 15);
            label20.TabIndex = 151;
            label20.Text = "Costo";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("EngraversGothic BT", 10F);
            label19.ForeColor = Color.FromArgb(224, 224, 224);
            label19.Location = new Point(645, 152);
            label19.Name = "label19";
            label19.Size = new Size(64, 15);
            label19.TabIndex = 152;
            label19.Text = "$ Oferta";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("EngraversGothic BT", 10F);
            label18.ForeColor = Color.FromArgb(224, 224, 224);
            label18.Location = new Point(645, 203);
            label18.Name = "label18";
            label18.Size = new Size(55, 15);
            label18.TabIndex = 153;
            label18.Text = "$ Venta";
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
            btnAgregarProveedor.Location = new Point(345, 219);
            btnAgregarProveedor.Margin = new Padding(0);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(31, 23);
            btnAgregarProveedor.TabIndex = 145;
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
            btnAgregarMarca.Location = new Point(345, 166);
            btnAgregarMarca.Margin = new Padding(0);
            btnAgregarMarca.Name = "btnAgregarMarca";
            btnAgregarMarca.Size = new Size(31, 23);
            btnAgregarMarca.TabIndex = 144;
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
            btnAgregarCategoria.Location = new Point(345, 108);
            btnAgregarCategoria.Margin = new Padding(0);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(31, 23);
            btnAgregarCategoria.TabIndex = 143;
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
            btnAgregarImpuesto.Location = new Point(345, 56);
            btnAgregarImpuesto.Margin = new Padding(0);
            btnAgregarImpuesto.Name = "btnAgregarImpuesto";
            btnAgregarImpuesto.Size = new Size(31, 23);
            btnAgregarImpuesto.TabIndex = 142;
            btnAgregarImpuesto.TabStop = false;
            btnAgregarImpuesto.Text = "...";
            btnAgregarImpuesto.UseVisualStyleBackColor = false;
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("EngraversGothic BT", 10F);
            label28.ForeColor = Color.FromArgb(224, 224, 224);
            label28.Location = new Point(345, 203);
            label28.Name = "label28";
            label28.Size = new Size(75, 15);
            label28.TabIndex = 141;
            label28.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            cmbProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProveedor.BackColor = Color.Gainsboro;
            cmbProveedor.DropDownWidth = 335;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(379, 218);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(240, 22);
            cmbProveedor.TabIndex = 137;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("EngraversGothic BT", 10F);
            label21.ForeColor = Color.FromArgb(224, 224, 224);
            label21.Location = new Point(345, 151);
            label21.Name = "label21";
            label21.Size = new Size(45, 15);
            label21.TabIndex = 140;
            label21.Text = "Marca";
            // 
            // cmbMarca
            // 
            cmbMarca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMarca.BackColor = Color.Gainsboro;
            cmbMarca.DropDownWidth = 335;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(379, 166);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(240, 22);
            cmbMarca.TabIndex = 136;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("EngraversGothic BT", 10F);
            label22.ForeColor = Color.FromArgb(224, 224, 224);
            label22.Location = new Point(345, 94);
            label22.Name = "label22";
            label22.Size = new Size(67, 15);
            label22.TabIndex = 139;
            label22.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategoria.BackColor = Color.Gainsboro;
            cmbCategoria.DropDownWidth = 335;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(379, 109);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(240, 22);
            cmbCategoria.TabIndex = 135;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("EngraversGothic BT", 10F);
            label23.ForeColor = Color.FromArgb(224, 224, 224);
            label23.Location = new Point(345, 43);
            label23.Name = "label23";
            label23.Size = new Size(61, 15);
            label23.TabIndex = 138;
            label23.Text = "Impuesto";
            // 
            // cmbImpuesto
            // 
            cmbImpuesto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbImpuesto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbImpuesto.BackColor = Color.Gainsboro;
            cmbImpuesto.DropDownWidth = 335;
            cmbImpuesto.FormattingEnabled = true;
            cmbImpuesto.Location = new Point(379, 56);
            cmbImpuesto.Name = "cmbImpuesto";
            cmbImpuesto.Size = new Size(240, 22);
            cmbImpuesto.TabIndex = 134;
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
            Text = "Frm_Clientes_Buscar";
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            tabControlMain.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            tabListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public Panel pnTituloFormulario;
        public Label label1;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
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
        private TextBox textBox2;
        private Label label3;
        private TextBox textBox1;
        private Label label2;
        private TextBox txtBarCode;
        private Label label24;
        private ComboBox cmbSituacion;
        private Label label26;
        private TextBox txtStock;
        private TextBox txtpVenta;
        private TextBox txtpOferta;
        private TextBox txtCosto;
        private Label label27;
        private Label label20;
        private Label label19;
        private Label label18;
        private Button btnAgregarProveedor;
        private Button btnAgregarMarca;
        private Button btnAgregarCategoria;
        private Button btnAgregarImpuesto;
        private Label label28;
        public ComboBox cmbProveedor;
        private Label label21;
        public ComboBox cmbMarca;
        private Label label22;
        public ComboBox cmbCategoria;
        private Label label23;
        public ComboBox cmbImpuesto;
        private PictureBox pictureBox1;
    }
}