namespace PVpresentation.Formularios
{
    partial class Frm_Cajas
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
            label8 = new Label();
            cmbCondicion = new ComboBox();
            txtSaldoInicial = new TextBox();
            label6 = new Label();
            txtFechaCierre = new TextBox();
            label5 = new Label();
            txtFechaApertura = new TextBox();
            label3 = new Label();
            txtSaldoFinal = new TextBox();
            label7 = new Label();
            txtResultado = new TextBox();
            label9 = new Label();
            btnCancelarDetalle = new Button();
            dgvDetalle = new DataGridView();
            pnMuestraDetalle = new Panel();
            txtMuestraResultado = new TextBox();
            label15 = new Label();
            label14 = new Label();
            label13 = new Label();
            label12 = new Label();
            txtMuestraSaldoFinal = new TextBox();
            label11 = new Label();
            txtMuestraSaldoInicial = new TextBox();
            label10 = new Label();
            txtTarjeta = new TextBox();
            txtDebito = new TextBox();
            txtEfectivo = new TextBox();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).BeginInit();
            pnlContenedorPrincipal.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabListado.SuspendLayout();
            tabEditar.SuspendLayout();
            pnMantenimiento.SuspendLayout();
            pnListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).BeginInit();
            pnMuestraDetalle.SuspendLayout();
            SuspendLayout();
            // 
            // pnGral
            // 
            pnGral.BackColor = Color.FromArgb(74, 134, 160);
            // 
            // txtInstancia
            // 
            txtInstancia.Location = new Point(284, 17);
            // 
            // txtOpcion
            // 
            txtOpcion.Location = new Point(233, 17);
            // 
            // btnCierreVolver
            // 
            btnCierreVolver.Click += btnCierreVolver_Click;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Location = new Point(337, 12);
            lblTituloForm.Size = new Size(270, 28);
            lblTituloForm.Text = "Mantenimiento / Cajas";
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(pnMuestraDetalle);
            tabEditar.Controls.Add(dgvDetalle);
            tabEditar.Text = "Detalle";
            // 
            // txtBuscar
            // 
            txtBuscar.TabIndex = 0;
            // 
            // btnBuscar
            // 
            btnBuscar.Enabled = false;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnBuscar.TabStop = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnEditar.TabIndex = 2;
            btnEditar.TabStop = false;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnNuevo.TabIndex = 1;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Enabled = false;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnEliminar.TabStop = false;
            // 
            // btnCancelar
            // 
            btnCancelar.Enabled = false;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnCancelar.TabIndex = 12;
            btnCancelar.TabStop = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Enabled = false;
            btnGrabar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnGrabar.TabIndex = 11;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label2
            // 
            label2.ForeColor = Color.Silver;
            label2.Location = new Point(14, 61);
            // 
            // txtNombre
            // 
            txtNombre.BackColor = Color.FromArgb(4, 41, 68);
            txtNombre.Font = new Font("Copperplate Gothic Light", 12F);
            txtNombre.ForeColor = Color.White;
            txtNombre.Location = new Point(14, 79);
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(283, 25);
            txtNombre.TabIndex = 4;
            txtNombre.TabStop = false;
            // 
            // label1
            // 
            label1.ForeColor = Color.Silver;
            label1.Location = new Point(14, 15);
            // 
            // txtID
            // 
            txtID.BackColor = Color.FromArgb(4, 41, 68);
            txtID.Font = new Font("Copperplate Gothic Light", 12F);
            txtID.ForeColor = Color.White;
            txtID.Location = new Point(14, 33);
            txtID.ReadOnly = true;
            txtID.Size = new Size(283, 25);
            txtID.TabIndex = 3;
            txtID.TabStop = false;
            txtID.TextAlign = HorizontalAlignment.Right;
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.Controls.Add(txtResultado);
            pnMantenimiento.Controls.Add(label9);
            pnMantenimiento.Controls.Add(txtSaldoFinal);
            pnMantenimiento.Controls.Add(label7);
            pnMantenimiento.Controls.Add(label8);
            pnMantenimiento.Controls.Add(cmbCondicion);
            pnMantenimiento.Controls.Add(txtSaldoInicial);
            pnMantenimiento.Controls.Add(label6);
            pnMantenimiento.Controls.Add(txtFechaCierre);
            pnMantenimiento.Controls.Add(label5);
            pnMantenimiento.Controls.Add(txtFechaApertura);
            pnMantenimiento.Controls.Add(label3);
            pnMantenimiento.Controls.SetChildIndex(btnGrabar, 0);
            pnMantenimiento.Controls.SetChildIndex(btnCancelar, 0);
            pnMantenimiento.Controls.SetChildIndex(btnEliminar, 0);
            pnMantenimiento.Controls.SetChildIndex(txtID, 0);
            pnMantenimiento.Controls.SetChildIndex(label1, 0);
            pnMantenimiento.Controls.SetChildIndex(txtNombre, 0);
            pnMantenimiento.Controls.SetChildIndex(label2, 0);
            pnMantenimiento.Controls.SetChildIndex(label3, 0);
            pnMantenimiento.Controls.SetChildIndex(txtFechaApertura, 0);
            pnMantenimiento.Controls.SetChildIndex(label5, 0);
            pnMantenimiento.Controls.SetChildIndex(txtFechaCierre, 0);
            pnMantenimiento.Controls.SetChildIndex(label6, 0);
            pnMantenimiento.Controls.SetChildIndex(txtSaldoInicial, 0);
            pnMantenimiento.Controls.SetChildIndex(cmbCondicion, 0);
            pnMantenimiento.Controls.SetChildIndex(label8, 0);
            pnMantenimiento.Controls.SetChildIndex(label7, 0);
            pnMantenimiento.Controls.SetChildIndex(txtSaldoFinal, 0);
            pnMantenimiento.Controls.SetChildIndex(label9, 0);
            pnMantenimiento.Controls.SetChildIndex(txtResultado, 0);
            // 
            // btnDetalles
            // 
            btnDetalles.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnDetalles.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnDetalles.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnDetalles.Click += btnDetalles_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(12, 295);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 63;
            label8.Text = "Condición";
            // 
            // cmbCondicion
            // 
            cmbCondicion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCondicion.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCondicion.BackColor = Color.Gainsboro;
            cmbCondicion.Enabled = false;
            cmbCondicion.Font = new Font("Copperplate Gothic Light", 12F);
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Location = new Point(12, 314);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(285, 25);
            cmbCondicion.TabIndex = 9;
            // 
            // txtSaldoInicial
            // 
            txtSaldoInicial.BackColor = Color.FromArgb(4, 41, 68);
            txtSaldoInicial.BorderStyle = BorderStyle.FixedSingle;
            txtSaldoInicial.Font = new Font("Copperplate Gothic Bold", 14.25F);
            txtSaldoInicial.ForeColor = Color.White;
            txtSaldoInicial.Location = new Point(12, 171);
            txtSaldoInicial.Name = "txtSaldoInicial";
            txtSaldoInicial.ReadOnly = true;
            txtSaldoInicial.Size = new Size(285, 29);
            txtSaldoInicial.TabIndex = 6;
            txtSaldoInicial.TabStop = false;
            txtSaldoInicial.TextAlign = HorizontalAlignment.Right;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(12, 153);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 62;
            label6.Text = "Saldo Inicial";
            // 
            // txtFechaCierre
            // 
            txtFechaCierre.BackColor = Color.FromArgb(4, 41, 68);
            txtFechaCierre.BorderStyle = BorderStyle.FixedSingle;
            txtFechaCierre.Font = new Font("Copperplate Gothic Light", 12F);
            txtFechaCierre.ForeColor = Color.White;
            txtFechaCierre.Location = new Point(12, 216);
            txtFechaCierre.Name = "txtFechaCierre";
            txtFechaCierre.ReadOnly = true;
            txtFechaCierre.Size = new Size(286, 25);
            txtFechaCierre.TabIndex = 7;
            txtFechaCierre.TabStop = false;
            txtFechaCierre.TextAlign = HorizontalAlignment.Right;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.Silver;
            label5.Location = new Point(12, 198);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 61;
            label5.Text = "Fecha Cierre";
            // 
            // txtFechaApertura
            // 
            txtFechaApertura.BackColor = Color.FromArgb(4, 41, 68);
            txtFechaApertura.BorderStyle = BorderStyle.FixedSingle;
            txtFechaApertura.Font = new Font("Copperplate Gothic Light", 12F);
            txtFechaApertura.ForeColor = Color.White;
            txtFechaApertura.Location = new Point(12, 124);
            txtFechaApertura.Name = "txtFechaApertura";
            txtFechaApertura.ReadOnly = true;
            txtFechaApertura.Size = new Size(285, 25);
            txtFechaApertura.TabIndex = 5;
            txtFechaApertura.TabStop = false;
            txtFechaApertura.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.Silver;
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 60;
            label3.Text = "Fecha Apertura";
            // 
            // txtSaldoFinal
            // 
            txtSaldoFinal.BackColor = Color.FromArgb(4, 41, 68);
            txtSaldoFinal.BorderStyle = BorderStyle.FixedSingle;
            txtSaldoFinal.Font = new Font("Copperplate Gothic Bold", 14.25F);
            txtSaldoFinal.ForeColor = Color.White;
            txtSaldoFinal.Location = new Point(12, 265);
            txtSaldoFinal.Name = "txtSaldoFinal";
            txtSaldoFinal.ReadOnly = true;
            txtSaldoFinal.Size = new Size(285, 29);
            txtSaldoFinal.TabIndex = 8;
            txtSaldoFinal.TabStop = false;
            txtSaldoFinal.TextAlign = HorizontalAlignment.Right;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("EngraversGothic BT", 10F);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(12, 247);
            label7.Name = "label7";
            label7.Size = new Size(89, 15);
            label7.TabIndex = 65;
            label7.Text = "Saldo Actual";
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.FromArgb(4, 41, 68);
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Font = new Font("Copperplate Gothic Bold", 14.25F);
            txtResultado.ForeColor = Color.White;
            txtResultado.Location = new Point(12, 364);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(285, 29);
            txtResultado.TabIndex = 10;
            txtResultado.TabStop = false;
            txtResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("EngraversGothic BT", 10F);
            label9.ForeColor = Color.Silver;
            label9.Location = new Point(12, 346);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 67;
            label9.Text = "Resultado";
            // 
            // btnCancelarDetalle
            // 
            btnCancelarDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCancelarDetalle.BackColor = Color.SteelBlue;
            btnCancelarDetalle.Cursor = Cursors.Hand;
            btnCancelarDetalle.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnCancelarDetalle.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnCancelarDetalle.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnCancelarDetalle.FlatStyle = FlatStyle.Flat;
            btnCancelarDetalle.ForeColor = Color.WhiteSmoke;
            btnCancelarDetalle.Location = new Point(144, 392);
            btnCancelarDetalle.Name = "btnCancelarDetalle";
            btnCancelarDetalle.Size = new Size(86, 32);
            btnCancelarDetalle.TabIndex = 22;
            btnCancelarDetalle.Text = "Volver";
            btnCancelarDetalle.UseVisualStyleBackColor = false;
            btnCancelarDetalle.Click += btnCancelarDetalle_Click;
            // 
            // dgvDetalle
            // 
            dgvDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalle.Location = new Point(-1, 10);
            dgvDetalle.Name = "dgvDetalle";
            dgvDetalle.ReadOnly = true;
            dgvDetalle.Size = new Size(727, 438);
            dgvDetalle.TabIndex = 23;
            // 
            // pnMuestraDetalle
            // 
            pnMuestraDetalle.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnMuestraDetalle.BackColor = Color.FromArgb(4, 41, 68);
            pnMuestraDetalle.Controls.Add(txtMuestraResultado);
            pnMuestraDetalle.Controls.Add(label15);
            pnMuestraDetalle.Controls.Add(btnCancelarDetalle);
            pnMuestraDetalle.Controls.Add(label14);
            pnMuestraDetalle.Controls.Add(label13);
            pnMuestraDetalle.Controls.Add(label12);
            pnMuestraDetalle.Controls.Add(txtMuestraSaldoFinal);
            pnMuestraDetalle.Controls.Add(label11);
            pnMuestraDetalle.Controls.Add(txtMuestraSaldoInicial);
            pnMuestraDetalle.Controls.Add(label10);
            pnMuestraDetalle.Controls.Add(txtTarjeta);
            pnMuestraDetalle.Controls.Add(txtDebito);
            pnMuestraDetalle.Controls.Add(txtEfectivo);
            pnMuestraDetalle.Location = new Point(724, 10);
            pnMuestraDetalle.Name = "pnMuestraDetalle";
            pnMuestraDetalle.Size = new Size(249, 438);
            pnMuestraDetalle.TabIndex = 73;
            // 
            // txtMuestraResultado
            // 
            txtMuestraResultado.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMuestraResultado.BackColor = Color.FromArgb(4, 41, 68);
            txtMuestraResultado.BorderStyle = BorderStyle.FixedSingle;
            txtMuestraResultado.Font = new Font("Copperplate Gothic Bold", 14.25F);
            txtMuestraResultado.ForeColor = Color.White;
            txtMuestraResultado.Location = new Point(26, 347);
            txtMuestraResultado.Name = "txtMuestraResultado";
            txtMuestraResultado.ReadOnly = true;
            txtMuestraResultado.Size = new Size(204, 29);
            txtMuestraResultado.TabIndex = 83;
            txtMuestraResultado.TabStop = false;
            txtMuestraResultado.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label15.AutoSize = true;
            label15.Font = new Font("EngraversGothic BT", 10F);
            label15.ForeColor = Color.Silver;
            label15.Location = new Point(26, 329);
            label15.Name = "label15";
            label15.Size = new Size(70, 15);
            label15.TabIndex = 84;
            label15.Text = "Resultado";
            // 
            // label14
            // 
            label14.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label14.AutoSize = true;
            label14.Font = new Font("EngraversGothic BT", 10F);
            label14.ForeColor = Color.Silver;
            label14.Location = new Point(27, 258);
            label14.Name = "label14";
            label14.Size = new Size(52, 15);
            label14.TabIndex = 82;
            label14.Text = "Tarjeta";
            // 
            // label13
            // 
            label13.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label13.AutoSize = true;
            label13.Font = new Font("EngraversGothic BT", 10F);
            label13.ForeColor = Color.Silver;
            label13.Location = new Point(26, 198);
            label13.Name = "label13";
            label13.Size = new Size(48, 15);
            label13.TabIndex = 81;
            label13.Text = "Debito";
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label12.AutoSize = true;
            label12.Font = new Font("EngraversGothic BT", 10F);
            label12.ForeColor = Color.Silver;
            label12.Location = new Point(26, 143);
            label12.Name = "label12";
            label12.Size = new Size(61, 15);
            label12.TabIndex = 80;
            label12.Text = "Efectivo";
            // 
            // txtMuestraSaldoFinal
            // 
            txtMuestraSaldoFinal.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMuestraSaldoFinal.BackColor = Color.FromArgb(4, 41, 68);
            txtMuestraSaldoFinal.BorderStyle = BorderStyle.FixedSingle;
            txtMuestraSaldoFinal.Font = new Font("Copperplate Gothic Bold", 14.25F);
            txtMuestraSaldoFinal.ForeColor = Color.White;
            txtMuestraSaldoFinal.Location = new Point(26, 88);
            txtMuestraSaldoFinal.Name = "txtMuestraSaldoFinal";
            txtMuestraSaldoFinal.ReadOnly = true;
            txtMuestraSaldoFinal.Size = new Size(204, 29);
            txtMuestraSaldoFinal.TabIndex = 78;
            txtMuestraSaldoFinal.TabStop = false;
            txtMuestraSaldoFinal.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label11.AutoSize = true;
            label11.Font = new Font("EngraversGothic BT", 10F);
            label11.ForeColor = Color.Silver;
            label11.Location = new Point(26, 70);
            label11.Name = "label11";
            label11.Size = new Size(89, 15);
            label11.TabIndex = 79;
            label11.Text = "Saldo Actual";
            // 
            // txtMuestraSaldoInicial
            // 
            txtMuestraSaldoInicial.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtMuestraSaldoInicial.BackColor = Color.FromArgb(4, 41, 68);
            txtMuestraSaldoInicial.BorderStyle = BorderStyle.FixedSingle;
            txtMuestraSaldoInicial.Font = new Font("Copperplate Gothic Bold", 14.25F);
            txtMuestraSaldoInicial.ForeColor = Color.White;
            txtMuestraSaldoInicial.Location = new Point(26, 32);
            txtMuestraSaldoInicial.Name = "txtMuestraSaldoInicial";
            txtMuestraSaldoInicial.ReadOnly = true;
            txtMuestraSaldoInicial.Size = new Size(204, 29);
            txtMuestraSaldoInicial.TabIndex = 76;
            txtMuestraSaldoInicial.TabStop = false;
            txtMuestraSaldoInicial.TextAlign = HorizontalAlignment.Right;
            // 
            // label10
            // 
            label10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label10.AutoSize = true;
            label10.Font = new Font("EngraversGothic BT", 10F);
            label10.ForeColor = Color.Silver;
            label10.Location = new Point(26, 14);
            label10.Name = "label10";
            label10.Size = new Size(83, 15);
            label10.TabIndex = 77;
            label10.Text = "Saldo Inicial";
            // 
            // txtTarjeta
            // 
            txtTarjeta.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtTarjeta.BackColor = Color.FromArgb(4, 41, 68);
            txtTarjeta.BorderStyle = BorderStyle.FixedSingle;
            txtTarjeta.Font = new Font("Copperplate Gothic Bold", 14.25F);
            txtTarjeta.ForeColor = Color.White;
            txtTarjeta.Location = new Point(26, 276);
            txtTarjeta.Name = "txtTarjeta";
            txtTarjeta.ReadOnly = true;
            txtTarjeta.Size = new Size(204, 29);
            txtTarjeta.TabIndex = 75;
            txtTarjeta.TabStop = false;
            txtTarjeta.TextAlign = HorizontalAlignment.Right;
            // 
            // txtDebito
            // 
            txtDebito.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDebito.BackColor = Color.FromArgb(4, 41, 68);
            txtDebito.BorderStyle = BorderStyle.FixedSingle;
            txtDebito.Font = new Font("Copperplate Gothic Bold", 14.25F);
            txtDebito.ForeColor = Color.White;
            txtDebito.Location = new Point(27, 216);
            txtDebito.Name = "txtDebito";
            txtDebito.ReadOnly = true;
            txtDebito.Size = new Size(203, 29);
            txtDebito.TabIndex = 74;
            txtDebito.TabStop = false;
            txtDebito.TextAlign = HorizontalAlignment.Right;
            // 
            // txtEfectivo
            // 
            txtEfectivo.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtEfectivo.BackColor = Color.FromArgb(4, 41, 68);
            txtEfectivo.BorderStyle = BorderStyle.FixedSingle;
            txtEfectivo.Font = new Font("Copperplate Gothic Bold", 14.25F);
            txtEfectivo.ForeColor = Color.White;
            txtEfectivo.Location = new Point(26, 161);
            txtEfectivo.Name = "txtEfectivo";
            txtEfectivo.ReadOnly = true;
            txtEfectivo.Size = new Size(204, 29);
            txtEfectivo.TabIndex = 73;
            txtEfectivo.TabStop = false;
            txtEfectivo.TextAlign = HorizontalAlignment.Right;
            // 
            // Frm_Cajas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Name = "Frm_Cajas";
            Text = "Frm_Cajas";
            Load += Frm_Cajas_Load;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).EndInit();
            pnlContenedorPrincipal.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            tabEditar.ResumeLayout(false);
            pnMantenimiento.ResumeLayout(false);
            pnMantenimiento.PerformLayout();
            pnListado.ResumeLayout(false);
            pnListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDetalle).EndInit();
            pnMuestraDetalle.ResumeLayout(false);
            pnMuestraDetalle.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label label8;
        public ComboBox cmbCondicion;
        public TextBox txtSaldoInicial;
        public Label label6;
        public TextBox txtFechaCierre;
        public Label label5;
        public TextBox txtFechaApertura;
        public Label label3;
        public TextBox txtSaldoFinal;
        public Label label7;
        public TextBox txtResultado;
        public Label label9;
        public Button btnCancelarDetalle;
        private DataGridView dgvDetalle;
        private Panel pnMuestraDetalle;
        public TextBox txtMuestraResultado;
        public Label label15;
        public Label label14;
        public Label label13;
        public Label label12;
        public TextBox txtMuestraSaldoFinal;
        public Label label11;
        public TextBox txtMuestraSaldoInicial;
        public Label label10;
        public TextBox txtTarjeta;
        public TextBox txtDebito;
        public TextBox txtEfectivo;
    }
}