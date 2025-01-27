namespace PVpresentation.Formularios
{
    partial class Frm_Ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Ventas));
            pnTituloFormulario = new Panel();
            btnMaximizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
            lblTituloForm = new Label();
            pnMantenimiento = new Panel();
            label16 = new Label();
            txtVendedorID = new TextBox();
            label21 = new Label();
            txtSucursalID = new TextBox();
            cmbLista = new ComboBox();
            label20 = new Label();
            label17 = new Label();
            txtTctaCte = new TextBox();
            label18 = new Label();
            txtTtarjeta = new TextBox();
            label19 = new Label();
            txtTdebito = new TextBox();
            label15 = new Label();
            txtMontoFinal = new TextBox();
            label14 = new Label();
            txtDtoGral = new TextBox();
            label13 = new Label();
            txtBruto = new TextBox();
            label12 = new Label();
            txtDtoEfectivo = new TextBox();
            label11 = new Label();
            txtSubTotal = new TextBox();
            cmbTipo = new ComboBox();
            label10 = new Label();
            label2 = new Label();
            txtTefectivo = new TextBox();
            label1 = new Label();
            txtNumero = new TextBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnGrabar = new Button();
            pnListado = new Panel();
            label9 = new Label();
            txtBruto1 = new TextBox();
            label8 = new Label();
            txtDtoEfectivo1 = new TextBox();
            label7 = new Label();
            txtSubTotal1 = new TextBox();
            label6 = new Label();
            txtFecha = new TextBox();
            label5 = new Label();
            txtCantidad = new TextBox();
            label3 = new Label();
            txtBuscarProducto = new TextBox();
            btnBuscarProducto = new Button();
            dgvListado = new DataGridView();
            label4 = new Label();
            txtBuscarCliente = new TextBox();
            btnBuscarCliente = new Button();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).BeginInit();
            pnMantenimiento.SuspendLayout();
            pnListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.BackColor = Color.FromArgb(74, 134, 160);
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
            pnTituloFormulario.Size = new Size(968, 45);
            pnTituloFormulario.TabIndex = 50;
            pnTituloFormulario.Paint += pnTituloFormulario_Paint;
            pnTituloFormulario.MouseMove += pnTituloFormulario_MouseMove;
            // 
            // btnMaximizar
            // 
            btnMaximizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizar.Cursor = Cursors.Hand;
            btnMaximizar.Image = Properties.Resources.maximize3;
            btnMaximizar.Location = new Point(911, 12);
            btnMaximizar.Name = "btnMaximizar";
            btnMaximizar.Size = new Size(20, 21);
            btnMaximizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMaximizar.TabIndex = 50;
            btnMaximizar.TabStop = false;
            btnMaximizar.Click += btnMaximizar_Click;
            // 
            // btnRestaurar
            // 
            btnRestaurar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRestaurar.Cursor = Cursors.Hand;
            btnRestaurar.Image = Properties.Resources.Normal;
            btnRestaurar.Location = new Point(911, 14);
            btnRestaurar.Name = "btnRestaurar";
            btnRestaurar.Size = new Size(20, 21);
            btnRestaurar.SizeMode = PictureBoxSizeMode.Zoom;
            btnRestaurar.TabIndex = 51;
            btnRestaurar.TabStop = false;
            btnRestaurar.Visible = false;
            btnRestaurar.Click += btnRestaurar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCerrar.Cursor = Cursors.Hand;
            btnCerrar.Image = Properties.Resources.Close;
            btnCerrar.Location = new Point(937, 14);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(20, 21);
            btnCerrar.SizeMode = PictureBoxSizeMode.Zoom;
            btnCerrar.TabIndex = 49;
            btnCerrar.TabStop = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnMinimizar
            // 
            btnMinimizar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizar.Cursor = Cursors.Hand;
            btnMinimizar.Image = Properties.Resources.Minimize;
            btnMinimizar.Location = new Point(885, 14);
            btnMinimizar.Name = "btnMinimizar";
            btnMinimizar.Size = new Size(20, 21);
            btnMinimizar.SizeMode = PictureBoxSizeMode.Zoom;
            btnMinimizar.TabIndex = 48;
            btnMinimizar.TabStop = false;
            btnMinimizar.Click += btnMinimizar_Click;
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
            // lblTituloForm
            // 
            lblTituloForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTituloForm.AutoSize = true;
            lblTituloForm.Enabled = false;
            lblTituloForm.Font = new Font("EngraversGothic BT", 20F);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(326, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(289, 28);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Instancia de Venta N° 0";
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.BackColor = Color.FromArgb(4, 41, 68);
            pnMantenimiento.Controls.Add(label16);
            pnMantenimiento.Controls.Add(txtVendedorID);
            pnMantenimiento.Controls.Add(label21);
            pnMantenimiento.Controls.Add(txtSucursalID);
            pnMantenimiento.Controls.Add(cmbLista);
            pnMantenimiento.Controls.Add(label20);
            pnMantenimiento.Controls.Add(label17);
            pnMantenimiento.Controls.Add(txtTctaCte);
            pnMantenimiento.Controls.Add(label18);
            pnMantenimiento.Controls.Add(txtTtarjeta);
            pnMantenimiento.Controls.Add(label19);
            pnMantenimiento.Controls.Add(txtTdebito);
            pnMantenimiento.Controls.Add(label15);
            pnMantenimiento.Controls.Add(txtMontoFinal);
            pnMantenimiento.Controls.Add(label14);
            pnMantenimiento.Controls.Add(txtDtoGral);
            pnMantenimiento.Controls.Add(label13);
            pnMantenimiento.Controls.Add(txtBruto);
            pnMantenimiento.Controls.Add(label12);
            pnMantenimiento.Controls.Add(txtDtoEfectivo);
            pnMantenimiento.Controls.Add(label11);
            pnMantenimiento.Controls.Add(txtSubTotal);
            pnMantenimiento.Controls.Add(cmbTipo);
            pnMantenimiento.Controls.Add(label10);
            pnMantenimiento.Controls.Add(label2);
            pnMantenimiento.Controls.Add(txtTefectivo);
            pnMantenimiento.Controls.Add(label1);
            pnMantenimiento.Controls.Add(txtNumero);
            pnMantenimiento.Controls.Add(btnEliminar);
            pnMantenimiento.Controls.Add(btnCancelar);
            pnMantenimiento.Controls.Add(btnGrabar);
            pnMantenimiento.Dock = DockStyle.Right;
            pnMantenimiento.Location = new Point(650, 45);
            pnMantenimiento.Name = "pnMantenimiento";
            pnMantenimiento.Size = new Size(318, 467);
            pnMantenimiento.TabIndex = 52;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("EngraversGothic BT", 10F);
            label16.ForeColor = Color.FromArgb(224, 224, 224);
            label16.Location = new Point(26, 342);
            label16.Name = "label16";
            label16.Size = new Size(24, 15);
            label16.TabIndex = 68;
            label16.Text = "ID:";
            // 
            // txtVendedorID
            // 
            txtVendedorID.BackColor = Color.FromArgb(130, 149, 169);
            txtVendedorID.BorderStyle = BorderStyle.FixedSingle;
            txtVendedorID.Location = new Point(26, 360);
            txtVendedorID.Name = "txtVendedorID";
            txtVendedorID.ReadOnly = true;
            txtVendedorID.Size = new Size(112, 23);
            txtVendedorID.TabIndex = 67;
            txtVendedorID.TabStop = false;
            txtVendedorID.Visible = false;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("EngraversGothic BT", 10F);
            label21.ForeColor = Color.FromArgb(224, 224, 224);
            label21.Location = new Point(179, 342);
            label21.Name = "label21";
            label21.Size = new Size(24, 15);
            label21.TabIndex = 66;
            label21.Text = "ID:";
            // 
            // txtSucursalID
            // 
            txtSucursalID.BackColor = Color.FromArgb(130, 149, 169);
            txtSucursalID.BorderStyle = BorderStyle.FixedSingle;
            txtSucursalID.Location = new Point(179, 360);
            txtSucursalID.Name = "txtSucursalID";
            txtSucursalID.ReadOnly = true;
            txtSucursalID.Size = new Size(112, 23);
            txtSucursalID.TabIndex = 65;
            txtSucursalID.TabStop = false;
            txtSucursalID.Visible = false;
            // 
            // cmbLista
            // 
            cmbLista.BackColor = Color.Gainsboro;
            cmbLista.FormattingEnabled = true;
            cmbLista.Location = new Point(178, 110);
            cmbLista.Name = "cmbLista";
            cmbLista.Size = new Size(113, 23);
            cmbLista.TabIndex = 64;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("EngraversGothic BT", 10F);
            label20.ForeColor = Color.FromArgb(224, 224, 224);
            label20.Location = new Point(178, 92);
            label20.Name = "label20";
            label20.Size = new Size(109, 15);
            label20.TabIndex = 63;
            label20.Text = "Lista de Precios";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("EngraversGothic BT", 10F);
            label17.ForeColor = Color.FromArgb(224, 224, 224);
            label17.Location = new Point(179, 282);
            label17.Name = "label17";
            label17.Size = new Size(63, 15);
            label17.TabIndex = 60;
            label17.Text = "Cta. Cte.";
            // 
            // txtTctaCte
            // 
            txtTctaCte.BackColor = Color.Gainsboro;
            txtTctaCte.BorderStyle = BorderStyle.FixedSingle;
            txtTctaCte.Location = new Point(178, 300);
            txtTctaCte.Name = "txtTctaCte";
            txtTctaCte.Size = new Size(113, 23);
            txtTctaCte.TabIndex = 59;
            txtTctaCte.Text = "0";
            txtTctaCte.TextAlign = HorizontalAlignment.Right;
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("EngraversGothic BT", 10F);
            label18.ForeColor = Color.FromArgb(224, 224, 224);
            label18.Location = new Point(179, 235);
            label18.Name = "label18";
            label18.Size = new Size(52, 15);
            label18.TabIndex = 58;
            label18.Text = "Tarjeta";
            // 
            // txtTtarjeta
            // 
            txtTtarjeta.BackColor = Color.Gainsboro;
            txtTtarjeta.BorderStyle = BorderStyle.FixedSingle;
            txtTtarjeta.Location = new Point(178, 253);
            txtTtarjeta.Name = "txtTtarjeta";
            txtTtarjeta.Size = new Size(113, 23);
            txtTtarjeta.TabIndex = 57;
            txtTtarjeta.Text = "0";
            txtTtarjeta.TextAlign = HorizontalAlignment.Right;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("EngraversGothic BT", 10F);
            label19.ForeColor = Color.FromArgb(224, 224, 224);
            label19.Location = new Point(179, 187);
            label19.Name = "label19";
            label19.Size = new Size(48, 15);
            label19.TabIndex = 56;
            label19.Text = "Debito";
            // 
            // txtTdebito
            // 
            txtTdebito.BackColor = Color.Gainsboro;
            txtTdebito.BorderStyle = BorderStyle.FixedSingle;
            txtTdebito.Location = new Point(178, 205);
            txtTdebito.Name = "txtTdebito";
            txtTdebito.Size = new Size(113, 23);
            txtTdebito.TabIndex = 55;
            txtTdebito.Text = "0";
            txtTdebito.TextAlign = HorizontalAlignment.Right;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("EngraversGothic BT", 10F);
            label15.ForeColor = Color.FromArgb(224, 224, 224);
            label15.Location = new Point(26, 283);
            label15.Name = "label15";
            label15.Size = new Size(80, 15);
            label15.TabIndex = 54;
            label15.Text = "Monto Final";
            // 
            // txtMontoFinal
            // 
            txtMontoFinal.BackColor = Color.FromArgb(130, 149, 169);
            txtMontoFinal.BorderStyle = BorderStyle.FixedSingle;
            txtMontoFinal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtMontoFinal.Location = new Point(25, 301);
            txtMontoFinal.Name = "txtMontoFinal";
            txtMontoFinal.ReadOnly = true;
            txtMontoFinal.Size = new Size(113, 25);
            txtMontoFinal.TabIndex = 53;
            txtMontoFinal.TabStop = false;
            txtMontoFinal.Text = "0";
            txtMontoFinal.TextAlign = HorizontalAlignment.Right;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("EngraversGothic BT", 10F);
            label14.ForeColor = Color.FromArgb(224, 224, 224);
            label14.Location = new Point(26, 233);
            label14.Name = "label14";
            label14.Size = new Size(96, 15);
            label14.TabIndex = 52;
            label14.Text = "Dto. Adicional";
            // 
            // txtDtoGral
            // 
            txtDtoGral.BackColor = Color.Gainsboro;
            txtDtoGral.BorderStyle = BorderStyle.FixedSingle;
            txtDtoGral.Location = new Point(25, 251);
            txtDtoGral.Name = "txtDtoGral";
            txtDtoGral.Size = new Size(113, 23);
            txtDtoGral.TabIndex = 51;
            txtDtoGral.TabStop = false;
            txtDtoGral.Text = "0";
            txtDtoGral.TextAlign = HorizontalAlignment.Right;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("EngraversGothic BT", 10F);
            label13.ForeColor = Color.FromArgb(224, 224, 224);
            label13.Location = new Point(26, 186);
            label13.Name = "label13";
            label13.Size = new Size(39, 15);
            label13.TabIndex = 50;
            label13.Text = "Total";
            // 
            // txtBruto
            // 
            txtBruto.BackColor = Color.FromArgb(130, 149, 169);
            txtBruto.BorderStyle = BorderStyle.FixedSingle;
            txtBruto.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtBruto.Location = new Point(25, 204);
            txtBruto.Name = "txtBruto";
            txtBruto.ReadOnly = true;
            txtBruto.Size = new Size(113, 25);
            txtBruto.TabIndex = 49;
            txtBruto.TabStop = false;
            txtBruto.Text = "0";
            txtBruto.TextAlign = HorizontalAlignment.Right;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("EngraversGothic BT", 10F);
            label12.ForeColor = Color.FromArgb(224, 224, 224);
            label12.Location = new Point(26, 138);
            label12.Name = "label12";
            label12.Size = new Size(105, 15);
            label12.TabIndex = 48;
            label12.Text = "Dto. x Efectivo";
            // 
            // txtDtoEfectivo
            // 
            txtDtoEfectivo.BackColor = Color.FromArgb(130, 149, 169);
            txtDtoEfectivo.BorderStyle = BorderStyle.FixedSingle;
            txtDtoEfectivo.Location = new Point(25, 156);
            txtDtoEfectivo.Name = "txtDtoEfectivo";
            txtDtoEfectivo.ReadOnly = true;
            txtDtoEfectivo.Size = new Size(113, 23);
            txtDtoEfectivo.TabIndex = 47;
            txtDtoEfectivo.TabStop = false;
            txtDtoEfectivo.Text = "0";
            txtDtoEfectivo.TextAlign = HorizontalAlignment.Right;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("EngraversGothic BT", 10F);
            label11.ForeColor = Color.FromArgb(224, 224, 224);
            label11.Location = new Point(26, 92);
            label11.Name = "label11";
            label11.Size = new Size(68, 15);
            label11.TabIndex = 46;
            label11.Text = "SubTotal:";
            // 
            // txtSubTotal
            // 
            txtSubTotal.BackColor = Color.FromArgb(130, 149, 169);
            txtSubTotal.BorderStyle = BorderStyle.FixedSingle;
            txtSubTotal.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            txtSubTotal.Location = new Point(25, 110);
            txtSubTotal.Name = "txtSubTotal";
            txtSubTotal.ReadOnly = true;
            txtSubTotal.Size = new Size(113, 25);
            txtSubTotal.TabIndex = 45;
            txtSubTotal.TabStop = false;
            txtSubTotal.Text = "0";
            txtSubTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // cmbTipo
            // 
            cmbTipo.BackColor = Color.Gainsboro;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(178, 59);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(113, 23);
            cmbTipo.TabIndex = 44;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("EngraversGothic BT", 10F);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(178, 41);
            label10.Name = "label10";
            label10.Size = new Size(31, 15);
            label10.TabIndex = 43;
            label10.Text = "Tipo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("EngraversGothic BT", 10F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(178, 141);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 26;
            label2.Text = "Efectivo";
            // 
            // txtTefectivo
            // 
            txtTefectivo.BackColor = Color.Gainsboro;
            txtTefectivo.BorderStyle = BorderStyle.FixedSingle;
            txtTefectivo.Location = new Point(178, 159);
            txtTefectivo.Name = "txtTefectivo";
            txtTefectivo.Size = new Size(113, 23);
            txtTefectivo.TabIndex = 25;
            txtTefectivo.Text = "0";
            txtTefectivo.TextAlign = HorizontalAlignment.Right;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("EngraversGothic BT", 10F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(25, 41);
            label1.Name = "label1";
            label1.Size = new Size(24, 15);
            label1.TabIndex = 24;
            label1.Text = "ID:";
            // 
            // txtNumero
            // 
            txtNumero.BackColor = Color.FromArgb(130, 149, 169);
            txtNumero.BorderStyle = BorderStyle.FixedSingle;
            txtNumero.Location = new Point(25, 59);
            txtNumero.Name = "txtNumero";
            txtNumero.ReadOnly = true;
            txtNumero.Size = new Size(112, 23);
            txtNumero.TabIndex = 23;
            txtNumero.TabStop = false;
            txtNumero.TextAlign = HorizontalAlignment.Right;
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
            btnGrabar.Text = "Registrar";
            btnGrabar.UseVisualStyleBackColor = false;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // pnListado
            // 
            pnListado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnListado.BackColor = Color.FromArgb(45, 66, 91);
            pnListado.Controls.Add(label9);
            pnListado.Controls.Add(txtBruto1);
            pnListado.Controls.Add(label8);
            pnListado.Controls.Add(txtDtoEfectivo1);
            pnListado.Controls.Add(label7);
            pnListado.Controls.Add(txtSubTotal1);
            pnListado.Controls.Add(label6);
            pnListado.Controls.Add(txtFecha);
            pnListado.Controls.Add(label5);
            pnListado.Controls.Add(txtCantidad);
            pnListado.Controls.Add(label3);
            pnListado.Controls.Add(txtBuscarProducto);
            pnListado.Controls.Add(btnBuscarProducto);
            pnListado.Controls.Add(dgvListado);
            pnListado.Controls.Add(label4);
            pnListado.Controls.Add(txtBuscarCliente);
            pnListado.Controls.Add(btnBuscarCliente);
            pnListado.Location = new Point(0, 45);
            pnListado.Name = "pnListado";
            pnListado.Size = new Size(651, 467);
            pnListado.TabIndex = 51;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("EngraversGothic BT", 10F);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(516, 402);
            label9.Name = "label9";
            label9.Size = new Size(39, 15);
            label9.TabIndex = 34;
            label9.Text = "Total";
            // 
            // txtBruto1
            // 
            txtBruto1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtBruto1.BackColor = Color.FromArgb(130, 149, 169);
            txtBruto1.BorderStyle = BorderStyle.FixedSingle;
            txtBruto1.Enabled = false;
            txtBruto1.Font = new Font("Square721 BT", 12F);
            txtBruto1.ForeColor = Color.FromArgb(4, 41, 68);
            txtBruto1.Location = new Point(516, 420);
            txtBruto1.Name = "txtBruto1";
            txtBruto1.ReadOnly = true;
            txtBruto1.Size = new Size(113, 27);
            txtBruto1.TabIndex = 33;
            txtBruto1.TabStop = false;
            txtBruto1.Text = "900";
            txtBruto1.TextAlign = HorizontalAlignment.Center;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(383, 402);
            label8.Name = "label8";
            label8.Size = new Size(94, 15);
            label8.TabIndex = 32;
            label8.Text = "Dto. Efectivo";
            // 
            // txtDtoEfectivo1
            // 
            txtDtoEfectivo1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtDtoEfectivo1.BackColor = Color.FromArgb(130, 149, 169);
            txtDtoEfectivo1.BorderStyle = BorderStyle.FixedSingle;
            txtDtoEfectivo1.Enabled = false;
            txtDtoEfectivo1.Font = new Font("Square721 BT", 12F);
            txtDtoEfectivo1.ForeColor = Color.FromArgb(4, 41, 68);
            txtDtoEfectivo1.Location = new Point(383, 420);
            txtDtoEfectivo1.Name = "txtDtoEfectivo1";
            txtDtoEfectivo1.ReadOnly = true;
            txtDtoEfectivo1.Size = new Size(113, 27);
            txtDtoEfectivo1.TabIndex = 31;
            txtDtoEfectivo1.TabStop = false;
            txtDtoEfectivo1.Text = "600";
            txtDtoEfectivo1.TextAlign = HorizontalAlignment.Center;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("EngraversGothic BT", 10F);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(253, 402);
            label7.Name = "label7";
            label7.Size = new Size(63, 15);
            label7.TabIndex = 30;
            label7.Text = "SubTotal";
            // 
            // txtSubTotal1
            // 
            txtSubTotal1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            txtSubTotal1.BackColor = Color.FromArgb(130, 149, 169);
            txtSubTotal1.BorderStyle = BorderStyle.FixedSingle;
            txtSubTotal1.Enabled = false;
            txtSubTotal1.Font = new Font("Square721 BT", 12F);
            txtSubTotal1.ForeColor = Color.FromArgb(4, 41, 68);
            txtSubTotal1.Location = new Point(253, 420);
            txtSubTotal1.Name = "txtSubTotal1";
            txtSubTotal1.ReadOnly = true;
            txtSubTotal1.Size = new Size(113, 27);
            txtSubTotal1.TabIndex = 29;
            txtSubTotal1.TabStop = false;
            txtSubTotal1.Text = "1500";
            txtSubTotal1.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(13, 402);
            label6.Name = "label6";
            label6.Size = new Size(48, 15);
            label6.TabIndex = 28;
            label6.Text = "Fecha:";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = Color.FromArgb(130, 149, 169);
            txtFecha.BorderStyle = BorderStyle.FixedSingle;
            txtFecha.Enabled = false;
            txtFecha.Location = new Point(13, 420);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(147, 23);
            txtFecha.TabIndex = 27;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(13, 58);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 23;
            label5.Text = "Cantidad:";
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.Gainsboro;
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.Location = new Point(77, 55);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(49, 23);
            txtCantidad.TabIndex = 22;
            txtCantidad.Text = "1";
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(140, 58);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 21;
            label3.Text = "Artículo:";
            // 
            // txtBuscarProducto
            // 
            txtBuscarProducto.BackColor = Color.Gainsboro;
            txtBuscarProducto.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarProducto.Location = new Point(205, 55);
            txtBuscarProducto.Name = "txtBuscarProducto";
            txtBuscarProducto.Size = new Size(392, 23);
            txtBuscarProducto.TabIndex = 20;
            txtBuscarProducto.KeyDown += txtBuscarProducto_KeyDown;
            // 
            // btnBuscarProducto
            // 
            btnBuscarProducto.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscarProducto.Cursor = Cursors.Hand;
            btnBuscarProducto.FlatAppearance.BorderSize = 0;
            btnBuscarProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnBuscarProducto.FlatStyle = FlatStyle.Flat;
            btnBuscarProducto.ForeColor = Color.FromArgb(23, 54, 93);
            btnBuscarProducto.Image = (Image)resources.GetObject("btnBuscarProducto.Image");
            btnBuscarProducto.Location = new Point(603, 56);
            btnBuscarProducto.Name = "btnBuscarProducto";
            btnBuscarProducto.Size = new Size(24, 22);
            btnBuscarProducto.TabIndex = 19;
            btnBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // dgvListado
            // 
            dgvListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(13, 92);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(616, 304);
            dgvListado.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("EngraversGothic BT", 10F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(13, 17);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 15;
            label4.Text = "Cliente:";
            // 
            // txtBuscarCliente
            // 
            txtBuscarCliente.BackColor = Color.Gainsboro;
            txtBuscarCliente.BorderStyle = BorderStyle.FixedSingle;
            txtBuscarCliente.Location = new Point(77, 15);
            txtBuscarCliente.Name = "txtBuscarCliente";
            txtBuscarCliente.Size = new Size(520, 23);
            txtBuscarCliente.TabIndex = 14;
            // 
            // btnBuscarCliente
            // 
            btnBuscarCliente.BackgroundImageLayout = ImageLayout.Zoom;
            btnBuscarCliente.Cursor = Cursors.Hand;
            btnBuscarCliente.FlatAppearance.BorderSize = 0;
            btnBuscarCliente.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnBuscarCliente.FlatStyle = FlatStyle.Flat;
            btnBuscarCliente.ForeColor = Color.FromArgb(23, 54, 93);
            btnBuscarCliente.Image = (Image)resources.GetObject("btnBuscarCliente.Image");
            btnBuscarCliente.Location = new Point(603, 17);
            btnBuscarCliente.Name = "btnBuscarCliente";
            btnBuscarCliente.Size = new Size(24, 22);
            btnBuscarCliente.TabIndex = 13;
            btnBuscarCliente.UseVisualStyleBackColor = true;
            // 
            // Frm_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 134, 160);
            ClientSize = new Size(968, 512);
            Controls.Add(pnMantenimiento);
            Controls.Add(pnListado);
            Controls.Add(pnTituloFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Ventas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Ventas";
            FormClosing += Frm_Ventas_FormClosing;
            Load += Frm_Ventas_Load;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnMaximizar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnRestaurar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCerrar).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMinimizar).EndInit();
            pnMantenimiento.ResumeLayout(false);
            pnMantenimiento.PerformLayout();
            pnListado.ResumeLayout(false);
            pnListado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnTituloFormulario;
        public TextBox txtInstancia;
        public TextBox txtOpcion;
        public Label lblTituloForm;
        public Panel pnMantenimiento;
        public Label label2;
        public TextBox txtTefectivo;
        public Label label1;
        public TextBox txtNumero;
        public Button btnEliminar;
        public Button btnCancelar;
        public Button btnGrabar;
        public Panel pnListado;
        public DataGridView dgvListado;
        public Label label4;
        public TextBox txtBuscarCliente;
        public Button btnBuscarCliente;
        public Label label5;
        public TextBox txtCantidad;
        public Label label3;
        public TextBox txtBuscarProducto;
        public Button btnBuscarProducto;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        public Label label9;
        public TextBox txtBruto1;
        public Label label8;
        public TextBox txtDtoEfectivo1;
        public Label label7;
        public TextBox txtSubTotal1;
        public Label label6;
        public TextBox txtFecha;
        public Label label15;
        public TextBox txtMontoFinal;
        public Label label14;
        public TextBox txtDtoGral;
        public Label label13;
        public TextBox txtBruto;
        public Label label12;
        public TextBox txtDtoEfectivo;
        public Label label11;
        public TextBox txtSubTotal;
        private ComboBox cmbTipo;
        private Label label10;
        public Label label17;
        public TextBox txtTctaCte;
        public Label label18;
        public TextBox txtTtarjeta;
        public Label label19;
        public TextBox txtTdebito;
        public Label label16;
        public TextBox txtVendedorID;
        public Label label21;
        public TextBox txtSucursalID;
        private ComboBox cmbLista;
        private Label label20;
    }
}