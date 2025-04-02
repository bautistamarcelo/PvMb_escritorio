namespace PVpresentation.Formularios
{
    partial class Frm_Cajas_Movimientos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Cajas_Movimientos));
            pnTituloFormulario = new Panel();
            txtID = new TextBox();
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
            btnCierreVolver = new PictureBox();
            lblTituloForm = new Label();
            tabControlMain = new MiTabControl();
            tabIngresos = new TabPage();
            pnMantenimiento = new Panel();
            label13 = new Label();
            txtDescripcion = new TextBox();
            txtImporteRecibo = new TextBox();
            label6 = new Label();
            txtFechaRecibo = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtSaldoActual = new TextBox();
            btnCancelar = new Button();
            btnGrabar = new Button();
            pnListado = new Panel();
            dgvCuentaD = new DataGridView();
            dgvCuentaE = new DataGridView();
            label4 = new Label();
            txtBuscarCliente = new TextBox();
            btnBuscar = new Button();
            tabEgresos = new TabPage();
            panel1 = new Panel();
            label5 = new Label();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            label7 = new Label();
            txtFechaGasto = new TextBox();
            label9 = new Label();
            label10 = new Label();
            textBox3 = new TextBox();
            label11 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            panel2 = new Panel();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            dgvListado = new DataGridView();
            label12 = new Label();
            textBox5 = new TextBox();
            button7 = new Button();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).BeginInit();
            tabControlMain.SuspendLayout();
            tabIngresos.SuspendLayout();
            pnMantenimiento.SuspendLayout();
            pnListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuentaD).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentaE).BeginInit();
            tabEgresos.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.BackColor = Color.FromArgb(74, 134, 160);
            pnTituloFormulario.Controls.Add(txtID);
            pnTituloFormulario.Controls.Add(txtInstancia);
            pnTituloFormulario.Controls.Add(txtOpcion);
            pnTituloFormulario.Controls.Add(btnCierreVolver);
            pnTituloFormulario.Controls.Add(lblTituloForm);
            pnTituloFormulario.Dock = DockStyle.Top;
            pnTituloFormulario.Location = new Point(0, 0);
            pnTituloFormulario.Margin = new Padding(0);
            pnTituloFormulario.Name = "pnTituloFormulario";
            pnTituloFormulario.Size = new Size(984, 50);
            pnTituloFormulario.TabIndex = 50;
            // 
            // txtID
            // 
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Location = new Point(831, 12);
            txtID.Name = "txtID";
            txtID.Size = new Size(34, 23);
            txtID.TabIndex = 48;
            txtID.Text = "0";
            txtID.Visible = false;
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
            lblTituloForm.Location = new Point(367, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(262, 28);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Ingresos | Egresos ";
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.BottomBackColor = Color.Black;
            tabControlMain.BottomForeColor = Color.White;
            tabControlMain.Controls.Add(tabIngresos);
            tabControlMain.Controls.Add(tabEgresos);
            tabControlMain.Cursor = Cursors.Hand;
            tabControlMain.Font = new Font("EngraversGothic BT", 10F);
            tabControlMain.ItemSize = new Size(200, 30);
            tabControlMain.LineBackColor = Color.FromArgb(74, 134, 160);
            tabControlMain.LineForeColor = Color.White;
            tabControlMain.Location = new Point(0, 53);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.Padding = new Point(3, 3);
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(984, 505);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 51;
            tabControlMain.TabStyle = MiTabControl.Style.Line;
            // 
            // tabIngresos
            // 
            tabIngresos.BackColor = Color.FromArgb(74, 134, 160);
            tabIngresos.Controls.Add(pnMantenimiento);
            tabIngresos.Controls.Add(pnListado);
            tabIngresos.Location = new Point(4, 34);
            tabIngresos.Name = "tabIngresos";
            tabIngresos.Padding = new Padding(3);
            tabIngresos.Size = new Size(976, 467);
            tabIngresos.TabIndex = 0;
            tabIngresos.Text = "Ingresos | Recibos";
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnMantenimiento.BackColor = Color.FromArgb(4, 41, 68);
            pnMantenimiento.Controls.Add(label13);
            pnMantenimiento.Controls.Add(txtDescripcion);
            pnMantenimiento.Controls.Add(txtImporteRecibo);
            pnMantenimiento.Controls.Add(label6);
            pnMantenimiento.Controls.Add(txtFechaRecibo);
            pnMantenimiento.Controls.Add(label3);
            pnMantenimiento.Controls.Add(label2);
            pnMantenimiento.Controls.Add(txtNombre);
            pnMantenimiento.Controls.Add(label1);
            pnMantenimiento.Controls.Add(txtSaldoActual);
            pnMantenimiento.Controls.Add(btnCancelar);
            pnMantenimiento.Controls.Add(btnGrabar);
            pnMantenimiento.Location = new Point(661, 6);
            pnMantenimiento.Name = "pnMantenimiento";
            pnMantenimiento.Size = new Size(310, 456);
            pnMantenimiento.TabIndex = 1;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("EngraversGothic BT", 10F);
            label13.ForeColor = Color.FromArgb(224, 224, 224);
            label13.Location = new Point(11, 238);
            label13.Name = "label13";
            label13.Size = new Size(87, 15);
            label13.TabIndex = 82;
            label13.Text = "Descripción:";
            // 
            // txtDescripcion
            // 
            txtDescripcion.BackColor = Color.FromArgb(224, 224, 224);
            txtDescripcion.BorderStyle = BorderStyle.FixedSingle;
            txtDescripcion.Font = new Font("Square721 BT", 12F);
            txtDescripcion.ForeColor = Color.White;
            txtDescripcion.Location = new Point(11, 256);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(288, 109);
            txtDescripcion.TabIndex = 81;
            txtDescripcion.TextAlign = HorizontalAlignment.Center;
            // 
            // txtImporteRecibo
            // 
            txtImporteRecibo.BackColor = Color.FromArgb(224, 224, 224);
            txtImporteRecibo.BorderStyle = BorderStyle.FixedSingle;
            txtImporteRecibo.Font = new Font("Copperplate Gothic Light", 12F);
            txtImporteRecibo.ForeColor = Color.Black;
            txtImporteRecibo.Location = new Point(10, 200);
            txtImporteRecibo.Name = "txtImporteRecibo";
            txtImporteRecibo.Size = new Size(285, 25);
            txtImporteRecibo.TabIndex = 75;
            txtImporteRecibo.KeyPress += txtImporteRecibo_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(10, 182);
            label6.Name = "label6";
            label6.Size = new Size(67, 17);
            label6.TabIndex = 78;
            label6.Text = "Importe:";
            // 
            // txtFechaRecibo
            // 
            txtFechaRecibo.BackColor = Color.FromArgb(4, 41, 68);
            txtFechaRecibo.BorderStyle = BorderStyle.FixedSingle;
            txtFechaRecibo.Font = new Font("Copperplate Gothic Light", 12F);
            txtFechaRecibo.ForeColor = Color.White;
            txtFechaRecibo.Location = new Point(10, 32);
            txtFechaRecibo.Name = "txtFechaRecibo";
            txtFechaRecibo.Size = new Size(285, 25);
            txtFechaRecibo.TabIndex = 74;
            txtFechaRecibo.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(10, 14);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 77;
            label3.Text = "Fecha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("EngraversGothic BT", 10F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(8, 69);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 26;
            label2.Text = "Cliente:";
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(4, 41, 68);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Copperplate Gothic Light", 12F);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(8, 87);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(288, 25);
            txtNombre.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("EngraversGothic BT", 10F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(10, 122);
            label1.Name = "label1";
            label1.Size = new Size(94, 15);
            label1.TabIndex = 24;
            label1.Text = "Saldo Actual:";
            // 
            // txtSaldoActual
            // 
            txtSaldoActual.BackColor = Color.FromArgb(4, 41, 68);
            txtSaldoActual.BorderStyle = BorderStyle.FixedSingle;
            txtSaldoActual.Font = new Font("Square721 BT", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSaldoActual.ForeColor = Color.White;
            txtSaldoActual.Location = new Point(10, 140);
            txtSaldoActual.Name = "txtSaldoActual";
            txtSaldoActual.Size = new Size(288, 31);
            txtSaldoActual.TabIndex = 23;
            txtSaldoActual.TextAlign = HorizontalAlignment.Center;
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
            btnCancelar.Location = new Point(209, 411);
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
            pnListado.Controls.Add(dgvCuentaD);
            pnListado.Controls.Add(dgvCuentaE);
            pnListado.Controls.Add(label4);
            pnListado.Controls.Add(txtBuscarCliente);
            pnListado.Controls.Add(btnBuscar);
            pnListado.Location = new Point(6, 6);
            pnListado.Name = "pnListado";
            pnListado.Size = new Size(661, 458);
            pnListado.TabIndex = 0;
            // 
            // dgvCuentaD
            // 
            dgvCuentaD.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCuentaD.BackgroundColor = Color.FromArgb(4, 41, 68);
            dgvCuentaD.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentaD.Location = new Point(14, 225);
            dgvCuentaD.Name = "dgvCuentaD";
            dgvCuentaD.Size = new Size(631, 218);
            dgvCuentaD.TabIndex = 17;
            // 
            // dgvCuentaE
            // 
            dgvCuentaE.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvCuentaE.BackgroundColor = Color.FromArgb(4, 41, 68);
            dgvCuentaE.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentaE.Location = new Point(14, 55);
            dgvCuentaE.Name = "dgvCuentaE";
            dgvCuentaE.Size = new Size(631, 164);
            dgvCuentaE.TabIndex = 16;
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
            // txtBuscarCliente
            // 
            txtBuscarCliente.BackColor = Color.Gainsboro;
            txtBuscarCliente.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarCliente.Location = new Point(85, 19);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(511, 22);
            txtBuscarCliente.TabIndex = 14;
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
            btnBuscar.Click += btnBuscar_Click;
            // 
            // tabEgresos
            // 
            tabEgresos.BackColor = Color.FromArgb(74, 134, 160);
            tabEgresos.Controls.Add(panel1);
            tabEgresos.Controls.Add(panel2);
            tabEgresos.Location = new Point(4, 34);
            tabEgresos.Name = "tabEgresos";
            tabEgresos.Padding = new Padding(3);
            tabEgresos.Size = new Size(976, 467);
            tabEgresos.TabIndex = 1;
            tabEgresos.Text = "Gastos | Salidas";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(4, 41, 68);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(txtFechaGasto);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label11);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button3);
            panel1.Location = new Point(661, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(310, 456);
            panel1.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(13, 253);
            label5.Name = "label5";
            label5.Size = new Size(66, 15);
            label5.TabIndex = 79;
            label5.Text = "Condición";
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.AutoCompleteSource = AutoCompleteSource.ListItems;
            comboBox1.BackColor = Color.FromArgb(4, 41, 68);
            comboBox1.Enabled = false;
            comboBox1.Font = new Font("Copperplate Gothic Light", 12F);
            comboBox1.ForeColor = Color.White;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(13, 272);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(285, 25);
            comboBox1.TabIndex = 76;
            comboBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Font = new Font("Copperplate Gothic Light", 12F);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(13, 225);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(285, 25);
            textBox1.TabIndex = 75;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("EngraversGothic BT", 10F);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(13, 207);
            label7.Name = "label7";
            label7.Size = new Size(83, 15);
            label7.TabIndex = 78;
            label7.Text = "Saldo Inicial";
            // 
            // txtFechaGasto
            // 
            txtFechaGasto.BackColor = Color.FromArgb(4, 41, 68);
            txtFechaGasto.BorderStyle = BorderStyle.FixedSingle;
            txtFechaGasto.Font = new Font("Copperplate Gothic Light", 12F);
            txtFechaGasto.ForeColor = Color.White;
            txtFechaGasto.Location = new Point(12, 36);
            txtFechaGasto.Name = "txtFechaGasto";
            txtFechaGasto.Size = new Size(285, 25);
            txtFechaGasto.TabIndex = 74;
            txtFechaGasto.TabStop = false;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("EngraversGothic BT", 10F);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(12, 18);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 77;
            label9.Text = "Fecha:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("EngraversGothic BT", 10F);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(9, 125);
            label10.Name = "label10";
            label10.Size = new Size(60, 15);
            label10.TabIndex = 26;
            label10.Text = "Nombre:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(4, 41, 68);
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Font = new Font("Copperplate Gothic Light", 12F);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(9, 143);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(288, 25);
            textBox3.TabIndex = 25;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("EngraversGothic BT", 10F);
            label11.ForeColor = Color.FromArgb(224, 224, 224);
            label11.Location = new Point(9, 70);
            label11.Name = "label11";
            label11.Size = new Size(24, 15);
            label11.TabIndex = 24;
            label11.Text = "ID:";
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(4, 41, 68);
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Font = new Font("Copperplate Gothic Light", 12F);
            textBox4.ForeColor = Color.White;
            textBox4.Location = new Point(9, 88);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(288, 25);
            textBox4.TabIndex = 23;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.WhiteSmoke;
            button1.Location = new Point(216, 411);
            button1.Name = "button1";
            button1.Size = new Size(86, 32);
            button1.TabIndex = 22;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.SteelBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.WhiteSmoke;
            button2.Location = new Point(114, 411);
            button2.Name = "button2";
            button2.Size = new Size(86, 32);
            button2.TabIndex = 21;
            button2.Text = "Cancelar";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SteelBlue;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            button3.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.WhiteSmoke;
            button3.Location = new Point(14, 411);
            button3.Name = "button3";
            button3.Size = new Size(86, 32);
            button3.TabIndex = 20;
            button3.Text = "Grabar";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.FromArgb(45, 66, 91);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button6);
            panel2.Controls.Add(dgvListado);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(textBox5);
            panel2.Controls.Add(button7);
            panel2.Location = new Point(6, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(661, 458);
            panel2.TabIndex = 2;
            // 
            // button4
            // 
            button4.BackColor = Color.SteelBlue;
            button4.Cursor = Cursors.Hand;
            button4.Enabled = false;
            button4.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            button4.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.WhiteSmoke;
            button4.Location = new Point(116, 411);
            button4.Name = "button4";
            button4.Size = new Size(86, 32);
            button4.TabIndex = 20;
            button4.Text = "Detalles";
            button4.UseVisualStyleBackColor = false;
            button4.Visible = false;
            // 
            // button5
            // 
            button5.BackColor = Color.SteelBlue;
            button5.Cursor = Cursors.Hand;
            button5.Enabled = false;
            button5.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            button5.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.WhiteSmoke;
            button5.Location = new Point(222, 411);
            button5.Name = "button5";
            button5.Size = new Size(86, 32);
            button5.TabIndex = 18;
            button5.Text = "Editar";
            button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            button6.BackColor = Color.SteelBlue;
            button6.Cursor = Cursors.Hand;
            button6.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            button6.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            button6.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            button6.FlatStyle = FlatStyle.Flat;
            button6.ForeColor = Color.WhiteSmoke;
            button6.Location = new Point(14, 411);
            button6.Name = "button6";
            button6.Size = new Size(86, 32);
            button6.TabIndex = 17;
            button6.Text = "Nuevo";
            button6.UseVisualStyleBackColor = false;
            // 
            // dgvListado
            // 
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.BackgroundColor = Color.FromArgb(4, 41, 68);
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(14, 55);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(625, 345);
            dgvListado.TabIndex = 16;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("EngraversGothic BT", 10F);
            label12.ForeColor = Color.FromArgb(224, 224, 224);
            label12.Location = new Point(21, 21);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 15;
            label12.Text = "Buscar:";
            // 
            // textBox5
            // 
            textBox5.BackColor = Color.Gainsboro;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Location = new Point(85, 19);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(511, 22);
            textBox5.TabIndex = 14;
            // 
            // button7
            // 
            button7.BackgroundImageLayout = ImageLayout.Stretch;
            button7.Cursor = Cursors.Hand;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            button7.FlatStyle = FlatStyle.Flat;
            button7.ForeColor = Color.FromArgb(23, 54, 93);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(602, 12);
            button7.Name = "button7";
            button7.Size = new Size(37, 32);
            button7.TabIndex = 13;
            button7.UseVisualStyleBackColor = true;
            // 
            // Frm_Cajas_Movimientos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 134, 160);
            ClientSize = new Size(984, 561);
            Controls.Add(tabControlMain);
            Controls.Add(pnTituloFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Cajas_Movimientos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Cajas_Movimientos";
            Load += Frm_Cajas_Movimientos_Load;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).EndInit();
            tabControlMain.ResumeLayout(false);
            tabIngresos.ResumeLayout(false);
            pnMantenimiento.ResumeLayout(false);
            pnMantenimiento.PerformLayout();
            pnListado.ResumeLayout(false);
            pnListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvCuentaD).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCuentaE).EndInit();
            tabEgresos.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnTituloFormulario;
        public TextBox txtInstancia;
        public TextBox txtOpcion;
        public PictureBox btnCierreVolver;
        public Label lblTituloForm;
        public MiTabControl tabControlMain;
        public TabPage tabIngresos;
        public Panel pnMantenimiento;
        public Label label2;
        public TextBox txtNombre;
        public Label label1;
        public TextBox txtSaldoActual;
        public Button btnCancelar;
        public Button btnGrabar;
        public Panel pnListado;
        public DataGridView dgvCuentaE;
        public Label label4;
        public TextBox txtBuscarCliente;
        public Button btnBuscar;
        public TabPage tabEgresos;
        public TextBox txtImporteRecibo;
        public Label label6;
        public TextBox txtFechaRecibo;
        public Label label3;
        public Panel panel1;
        public Label label5;
        public ComboBox comboBox1;
        public TextBox textBox1;
        public Label label7;
        public TextBox txtFechaGasto;
        public Label label9;
        public Label label10;
        public TextBox textBox3;
        public Label label11;
        public TextBox textBox4;
        public Button button1;
        public Button button2;
        public Button button3;
        public Panel panel2;
        public Button button4;
        public Button button5;
        public Button button6;
        public DataGridView dgvListado;
        public Label label12;
        public TextBox textBox5;
        public Button button7;
        public TextBox txtID;
        public DataGridView dgvCuentaD;
        public Label label13;
        public TextBox txtDescripcion;
    }
}