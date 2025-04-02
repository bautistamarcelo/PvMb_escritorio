namespace PVpresentation.Formularios
{
    partial class Frm_Cajas_Abrir
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
            pnTituloFormulario = new Panel();
            txtCondicion = new TextBox();
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
            lblTituloForm = new Label();
            pnMantenimiento = new Panel();
            label4 = new Label();
            cmbSucursales = new ComboBox();
            txtNombre = new TextBox();
            label2 = new Label();
            txtID = new TextBox();
            label1 = new Label();
            label8 = new Label();
            cmbCondicion = new ComboBox();
            txtSaldoInicial = new TextBox();
            label6 = new Label();
            txtFechaApertura = new TextBox();
            label3 = new Label();
            btnCancelar = new Button();
            btnAbrirCaja = new Button();
            pnTituloFormulario.SuspendLayout();
            pnMantenimiento.SuspendLayout();
            SuspendLayout();
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.BackColor = Color.FromArgb(74, 134, 160);
            pnTituloFormulario.Controls.Add(txtCondicion);
            pnTituloFormulario.Controls.Add(txtInstancia);
            pnTituloFormulario.Controls.Add(txtOpcion);
            pnTituloFormulario.Controls.Add(lblTituloForm);
            pnTituloFormulario.Dock = DockStyle.Top;
            pnTituloFormulario.Location = new Point(0, 0);
            pnTituloFormulario.Margin = new Padding(0);
            pnTituloFormulario.Name = "pnTituloFormulario";
            pnTituloFormulario.Size = new Size(316, 50);
            pnTituloFormulario.TabIndex = 52;
            // 
            // txtCondicion
            // 
            txtCondicion.BorderStyle = BorderStyle.FixedSingle;
            txtCondicion.Location = new Point(263, 12);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(34, 23);
            txtCondicion.TabIndex = 48;
            txtCondicion.Text = "0";
            txtCondicion.Visible = false;
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
            lblTituloForm.Font = new Font("EngraversGothic BT", 20F);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(45, 10);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(220, 28);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Abrir Nueva Caja";
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.BackColor = Color.FromArgb(4, 41, 68);
            pnMantenimiento.Controls.Add(label4);
            pnMantenimiento.Controls.Add(cmbSucursales);
            pnMantenimiento.Controls.Add(txtNombre);
            pnMantenimiento.Controls.Add(label2);
            pnMantenimiento.Controls.Add(txtID);
            pnMantenimiento.Controls.Add(label1);
            pnMantenimiento.Controls.Add(label8);
            pnMantenimiento.Controls.Add(cmbCondicion);
            pnMantenimiento.Controls.Add(txtSaldoInicial);
            pnMantenimiento.Controls.Add(label6);
            pnMantenimiento.Controls.Add(txtFechaApertura);
            pnMantenimiento.Controls.Add(label3);
            pnMantenimiento.Controls.Add(btnCancelar);
            pnMantenimiento.Controls.Add(btnAbrirCaja);
            pnMantenimiento.Dock = DockStyle.Top;
            pnMantenimiento.Location = new Point(0, 50);
            pnMantenimiento.Name = "pnMantenimiento";
            pnMantenimiento.Size = new Size(316, 400);
            pnMantenimiento.TabIndex = 53;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("EngraversGothic BT", 10F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(12, 104);
            label4.Name = "label4";
            label4.Size = new Size(66, 15);
            label4.TabIndex = 81;
            label4.Text = "Sucursal";
            // 
            // cmbSucursales
            // 
            cmbSucursales.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbSucursales.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSucursales.BackColor = Color.FromArgb(4, 41, 68);
            cmbSucursales.Enabled = false;
            cmbSucursales.Font = new Font("Copperplate Gothic Light", 12F);
            cmbSucursales.ForeColor = Color.White;
            cmbSucursales.FormattingEnabled = true;
            cmbSucursales.Location = new Point(12, 123);
            cmbSucursales.Name = "cmbSucursales";
            cmbSucursales.Size = new Size(285, 25);
            cmbSucursales.TabIndex = 80;
            cmbSucursales.TabStop = false;
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(4, 41, 68);
            txtNombre.BorderStyle = BorderStyle.FixedSingle;
            txtNombre.Font = new Font("Copperplate Gothic Light", 12F);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(12, 75);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(285, 25);
            txtNombre.TabIndex = 78;
            txtNombre.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("EngraversGothic BT", 10F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(12, 57);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 79;
            label2.Text = "Nombre";
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(4, 41, 68);
            txtID.BorderStyle = BorderStyle.FixedSingle;
            txtID.Font = new Font("Copperplate Gothic Light", 12F);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(12, 30);
            txtID.Name = "txtID";
            txtID.Size = new Size(285, 25);
            txtID.TabIndex = 76;
            txtID.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("EngraversGothic BT", 10F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(19, 15);
            label1.TabIndex = 77;
            label1.Text = "ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(12, 244);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 73;
            label8.Text = "Condición";
            // 
            // cmbCondicion
            // 
            cmbCondicion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCondicion.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCondicion.BackColor = Color.FromArgb(4, 41, 68);
            cmbCondicion.Enabled = false;
            cmbCondicion.Font = new Font("Copperplate Gothic Light", 12F);
            cmbCondicion.ForeColor = Color.White;
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Location = new Point(12, 263);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(285, 25);
            cmbCondicion.TabIndex = 69;
            cmbCondicion.TabStop = false;
            // 
            // txtSaldoInicial
            // 
            txtSaldoInicial.BackColor = Color.FromArgb(224, 224, 224);
            txtSaldoInicial.BorderStyle = BorderStyle.FixedSingle;
            txtSaldoInicial.Font = new Font("Copperplate Gothic Light", 12F);
            txtSaldoInicial.ForeColor = Color.Black;
            txtSaldoInicial.Location = new Point(12, 216);
            txtSaldoInicial.Name = "txtSaldoInicial";
            txtSaldoInicial.Size = new Size(285, 25);
            txtSaldoInicial.TabIndex = 67;
            txtSaldoInicial.KeyPress += txtSaldoInicial_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(12, 198);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 72;
            label6.Text = "Saldo Inicial";
            // 
            // txtFechaApertura
            // 
            txtFechaApertura.BackColor = Color.FromArgb(4, 41, 68);
            txtFechaApertura.BorderStyle = BorderStyle.FixedSingle;
            txtFechaApertura.Font = new Font("Copperplate Gothic Light", 12F);
            txtFechaApertura.ForeColor = Color.White;
            txtFechaApertura.Location = new Point(12, 169);
            txtFechaApertura.Name = "txtFechaApertura";
            txtFechaApertura.Size = new Size(285, 25);
            txtFechaApertura.TabIndex = 66;
            txtFechaApertura.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 70;
            label3.Text = "Fecha Apertura";
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
            btnCancelar.Location = new Point(176, 315);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 32);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAbrirCaja
            // 
            btnAbrirCaja.BackColor = Color.SteelBlue;
            btnAbrirCaja.Cursor = Cursors.Hand;
            btnAbrirCaja.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnAbrirCaja.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnAbrirCaja.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnAbrirCaja.FlatStyle = FlatStyle.Flat;
            btnAbrirCaja.ForeColor = Color.WhiteSmoke;
            btnAbrirCaja.Location = new Point(35, 316);
            btnAbrirCaja.Name = "btnAbrirCaja";
            btnAbrirCaja.Size = new Size(86, 32);
            btnAbrirCaja.TabIndex = 20;
            btnAbrirCaja.Text = "Ingresar";
            btnAbrirCaja.UseVisualStyleBackColor = false;
            btnAbrirCaja.Click += btnAbrirCaja_Click;
            // 
            // Frm_Cajas_Abrir
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 412);
            Controls.Add(pnMantenimiento);
            Controls.Add(pnTituloFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Cajas_Abrir";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Cajas_Abrir";
            Load += Frm_Cajas_Abrir_Load;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            pnMantenimiento.ResumeLayout(false);
            pnMantenimiento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnTituloFormulario;
        public TextBox txtInstancia;
        public TextBox txtOpcion;
        public Label lblTituloForm;
        public Panel pnMantenimiento;
        public Button btnCancelar;
        public Button btnAbrirCaja;
        public Label label4;
        public ComboBox cmbSucursales;
        public TextBox txtNombre;
        public Label label2;
        public TextBox txtID;
        public Label label1;
        public Label label8;
        public ComboBox cmbCondicion;
        public TextBox txtSaldoInicial;
        public Label label6;
        public TextBox txtFechaApertura;
        public Label label3;
        public TextBox txtCondicion;
    }
}