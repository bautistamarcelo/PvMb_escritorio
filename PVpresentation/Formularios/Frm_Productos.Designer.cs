using System.Threading.Tasks;

namespace PVpresentation.Formularios
{
    partial class Frm_Productos
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
        private async Task InitializeComponent()
        {
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
            txtBarCode = new TextBox();
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
            label24 = new Label();
            cmbSituacion = new ComboBox();
            label26 = new Label();
            txtFecha = new TextBox();
            btnEtiquetas = new FontAwesome.Sharp.IconButton();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).BeginInit();
            pnlContenedorPrincipal.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabListado.SuspendLayout();
            tabNuevo.SuspendLayout();
            SuspendLayout();
            // 
            // pnGral
            // 
            pnGral.Size = new Size(973, 523);
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.Controls.Add(txtFecha);
            pnTituloFormulario.Size = new Size(973, 50);
            pnTituloFormulario.Controls.SetChildIndex(lblTituloForm, 0);
            pnTituloFormulario.Controls.SetChildIndex(btnCierreVolver, 0);
            pnTituloFormulario.Controls.SetChildIndex(txtOpcion, 0);
            pnTituloFormulario.Controls.SetChildIndex(txtInstancia, 0);
            pnTituloFormulario.Controls.SetChildIndex(txtFecha, 0);
            // 
            // btnCierreVolver
            // 
            btnCierreVolver.Click += btnCierreVolver_Click;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Location = new Point(308, 12);
            lblTituloForm.Size = new Size(336, 28);
            lblTituloForm.Text = "Mantenimiento / Productos";
            // 
            // pnlContenedorPrincipal
            // 
            pnlContenedorPrincipal.Size = new Size(971, 470);
            // 
            // tabControlMain
            // 
            tabControlMain.Size = new Size(971, 470);
            // 
            // tabListado
            // 
            tabListado.Size = new Size(963, 432);
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(btnEtiquetas);
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
            tabNuevo.Controls.Add(txtBarCode);
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
            tabNuevo.Controls.Add(label24);
            tabNuevo.Controls.Add(cmbSituacion);
            tabNuevo.Controls.Add(label26);
            tabNuevo.Size = new Size(963, 432);
            tabNuevo.Controls.SetChildIndex(btnGrabar, 0);
            tabNuevo.Controls.SetChildIndex(btnCancelar, 0);
            tabNuevo.Controls.SetChildIndex(btnEliminar, 0);
            tabNuevo.Controls.SetChildIndex(txtID, 0);
            tabNuevo.Controls.SetChildIndex(label1, 0);
            tabNuevo.Controls.SetChildIndex(txtNombre, 0);
            tabNuevo.Controls.SetChildIndex(label2, 0);
            tabNuevo.Controls.SetChildIndex(label26, 0);
            tabNuevo.Controls.SetChildIndex(cmbSituacion, 0);
            tabNuevo.Controls.SetChildIndex(label24, 0);
            tabNuevo.Controls.SetChildIndex(cmbImpuesto, 0);
            tabNuevo.Controls.SetChildIndex(label23, 0);
            tabNuevo.Controls.SetChildIndex(cmbCategoria, 0);
            tabNuevo.Controls.SetChildIndex(label22, 0);
            tabNuevo.Controls.SetChildIndex(cmbMarca, 0);
            tabNuevo.Controls.SetChildIndex(label21, 0);
            tabNuevo.Controls.SetChildIndex(label17, 0);
            tabNuevo.Controls.SetChildIndex(label16, 0);
            tabNuevo.Controls.SetChildIndex(cmbProveedor, 0);
            tabNuevo.Controls.SetChildIndex(label28, 0);
            tabNuevo.Controls.SetChildIndex(label18, 0);
            tabNuevo.Controls.SetChildIndex(label19, 0);
            tabNuevo.Controls.SetChildIndex(label20, 0);
            tabNuevo.Controls.SetChildIndex(label27, 0);
            tabNuevo.Controls.SetChildIndex(txtBarCode, 0);
            tabNuevo.Controls.SetChildIndex(txtTalle, 0);
            tabNuevo.Controls.SetChildIndex(txtCosto, 0);
            tabNuevo.Controls.SetChildIndex(txtpOferta, 0);
            tabNuevo.Controls.SetChildIndex(txtpVenta, 0);
            tabNuevo.Controls.SetChildIndex(txtColor, 0);
            tabNuevo.Controls.SetChildIndex(txtStock, 0);
            tabNuevo.Controls.SetChildIndex(btnAgregarImpuesto, 0);
            tabNuevo.Controls.SetChildIndex(btnAgregarCategoria, 0);
            tabNuevo.Controls.SetChildIndex(btnAgregarMarca, 0);
            tabNuevo.Controls.SetChildIndex(btnAgregarProveedor, 0);
            tabNuevo.Controls.SetChildIndex(btnEtiquetas, 0);
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnEditar.Font = new Font("Square721 BT", 11F);
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnNuevo.Font = new Font("Square721 BT", 11F);
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnBuscar.Click += btnBuscar_Click;
            // 
            // label2
            // 
            label2.Location = new Point(36, 125);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 143);
            txtNombre.Size = new Size(397, 22);
            txtNombre.KeyDown += txtNombre_KeyDown;
            // 
            // label1
            // 
            label1.Location = new Point(36, 70);
            // 
            // txtID
            // 
            txtID.Location = new Point(36, 88);
            txtID.Size = new Size(397, 22);
            txtID.TabStop = false;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnEliminar.Font = new Font("Square721 BT", 11F);
            btnEliminar.Location = new Point(838, 382);
            btnEliminar.TabStop = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnCancelar.Font = new Font("Square721 BT", 11F);
            btnCancelar.Location = new Point(684, 382);
            btnCancelar.TabIndex = 46;
            btnCancelar.TabStop = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Enabled = false;
            btnGrabar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnGrabar.Font = new Font("Square721 BT", 11F);
            btnGrabar.Location = new Point(535, 382);
            btnGrabar.TabIndex = 45;
            btnGrabar.Click += btnGrabar_Click;
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
            btnAgregarProveedor.Location = new Point(456, 250);
            btnAgregarProveedor.Margin = new Padding(0);
            btnAgregarProveedor.Name = "btnAgregarProveedor";
            btnAgregarProveedor.Size = new Size(31, 23);
            btnAgregarProveedor.TabIndex = 133;
            btnAgregarProveedor.TabStop = false;
            btnAgregarProveedor.Text = "...";
            btnAgregarProveedor.UseVisualStyleBackColor = false;
            btnAgregarProveedor.Click += btnAgregarProveedor_Click;
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
            btnAgregarMarca.Location = new Point(456, 197);
            btnAgregarMarca.Margin = new Padding(0);
            btnAgregarMarca.Name = "btnAgregarMarca";
            btnAgregarMarca.Size = new Size(31, 23);
            btnAgregarMarca.TabIndex = 132;
            btnAgregarMarca.TabStop = false;
            btnAgregarMarca.Text = "...";
            btnAgregarMarca.UseVisualStyleBackColor = false;
            btnAgregarMarca.Click += btnAgregarMarca_Click;
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
            btnAgregarCategoria.Location = new Point(456, 139);
            btnAgregarCategoria.Margin = new Padding(0);
            btnAgregarCategoria.Name = "btnAgregarCategoria";
            btnAgregarCategoria.Size = new Size(31, 23);
            btnAgregarCategoria.TabIndex = 131;
            btnAgregarCategoria.TabStop = false;
            btnAgregarCategoria.Text = "...";
            btnAgregarCategoria.UseVisualStyleBackColor = false;
            btnAgregarCategoria.Click += btnAgregarCategoria_Click;
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
            btnAgregarImpuesto.Location = new Point(456, 87);
            btnAgregarImpuesto.Margin = new Padding(0);
            btnAgregarImpuesto.Name = "btnAgregarImpuesto";
            btnAgregarImpuesto.Size = new Size(31, 23);
            btnAgregarImpuesto.TabIndex = 130;
            btnAgregarImpuesto.TabStop = false;
            btnAgregarImpuesto.Text = "...";
            btnAgregarImpuesto.UseVisualStyleBackColor = false;
            btnAgregarImpuesto.Click += btnAgregarImpuesto_Click;
            // 
            // txtStock
            // 
            txtStock.BackColor = Color.Gainsboro;
            txtStock.BorderStyle = BorderStyle.FixedSingle;
            txtStock.Location = new Point(807, 88);
            txtStock.Name = "txtStock";
            txtStock.ReadOnly = true;
            txtStock.Size = new Size(117, 22);
            txtStock.TabIndex = 41;
            txtStock.KeyPress += txtStock_KeyPress;
            // 
            // txtColor
            // 
            txtColor.BackColor = Color.Gainsboro;
            txtColor.BorderStyle = BorderStyle.FixedSingle;
            txtColor.Location = new Point(277, 303);
            txtColor.Name = "txtColor";
            txtColor.Size = new Size(155, 22);
            txtColor.TabIndex = 40;
            txtColor.KeyDown += txtColor_KeyDown;
            // 
            // txtpVenta
            // 
            txtpVenta.BackColor = Color.Gainsboro;
            txtpVenta.BorderStyle = BorderStyle.FixedSingle;
            txtpVenta.Location = new Point(807, 249);
            txtpVenta.Name = "txtpVenta";
            txtpVenta.Size = new Size(117, 22);
            txtpVenta.TabIndex = 44;
            txtpVenta.KeyDown += txtpVenta_KeyDown;
            txtpVenta.KeyPress += txtpVenta_KeyPress;
            // 
            // txtpOferta
            // 
            txtpOferta.BackColor = Color.Gainsboro;
            txtpOferta.BorderStyle = BorderStyle.FixedSingle;
            txtpOferta.Location = new Point(807, 191);
            txtpOferta.Name = "txtpOferta";
            txtpOferta.Size = new Size(117, 22);
            txtpOferta.TabIndex = 43;
            txtpOferta.KeyDown += txtpOferta_KeyDown;
            txtpOferta.KeyPress += txtpOferta_KeyPress;
            // 
            // txtCosto
            // 
            txtCosto.BackColor = Color.Gainsboro;
            txtCosto.BorderStyle = BorderStyle.FixedSingle;
            txtCosto.Location = new Point(807, 139);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(117, 22);
            txtCosto.TabIndex = 42;
            txtCosto.KeyDown += txtCosto_KeyDown;
            txtCosto.KeyPress += txtCosto_KeyPress;
            // 
            // txtTalle
            // 
            txtTalle.BackColor = Color.Gainsboro;
            txtTalle.BorderStyle = BorderStyle.FixedSingle;
            txtTalle.Location = new Point(34, 303);
            txtTalle.Name = "txtTalle";
            txtTalle.Size = new Size(145, 22);
            txtTalle.TabIndex = 39;
            txtTalle.KeyDown += txtTalle_KeyDown;
            // 
            // txtBarCode
            // 
            txtBarCode.BackColor = Color.Gainsboro;
            txtBarCode.BorderStyle = BorderStyle.FixedSingle;
            txtBarCode.Location = new Point(34, 245);
            txtBarCode.Name = "txtBarCode";
            txtBarCode.Size = new Size(399, 22);
            txtBarCode.TabIndex = 34;
            txtBarCode.KeyDown += txtBarCode_KeyDown;
            // 
            // label27
            // 
            label27.AutoSize = true;
            label27.Font = new Font("EngraversGothic BT", 10F);
            label27.ForeColor = Color.FromArgb(224, 224, 224);
            label27.Location = new Point(807, 70);
            label27.Name = "label27";
            label27.Size = new Size(44, 15);
            label27.TabIndex = 126;
            label27.Text = "Stock";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("EngraversGothic BT", 10F);
            label20.ForeColor = Color.FromArgb(224, 224, 224);
            label20.Location = new Point(807, 121);
            label20.Name = "label20";
            label20.Size = new Size(44, 15);
            label20.TabIndex = 127;
            label20.Text = "Costo";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("EngraversGothic BT", 10F);
            label19.ForeColor = Color.FromArgb(224, 224, 224);
            label19.Location = new Point(807, 173);
            label19.Name = "label19";
            label19.Size = new Size(64, 15);
            label19.TabIndex = 128;
            label19.Text = "$ Oferta";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("EngraversGothic BT", 10F);
            label18.ForeColor = Color.FromArgb(224, 224, 224);
            label18.Location = new Point(807, 231);
            label18.Name = "label18";
            label18.Size = new Size(55, 15);
            label18.TabIndex = 129;
            label18.Text = "$ Venta";
            // 
            // label28
            // 
            label28.AutoSize = true;
            label28.Font = new Font("EngraversGothic BT", 10F);
            label28.ForeColor = Color.FromArgb(224, 224, 224);
            label28.Location = new Point(453, 231);
            label28.Name = "label28";
            label28.Size = new Size(75, 15);
            label28.TabIndex = 125;
            label28.Text = "Proveedor";
            // 
            // cmbProveedor
            // 
            cmbProveedor.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbProveedor.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbProveedor.BackColor = Color.Gainsboro;
            cmbProveedor.DropDownWidth = 335;
            cmbProveedor.FormattingEnabled = true;
            cmbProveedor.Location = new Point(490, 249);
            cmbProveedor.Name = "cmbProveedor";
            cmbProveedor.Size = new Size(292, 22);
            cmbProveedor.TabIndex = 38;
            cmbProveedor.KeyDown += cmbProveedor_KeyDown;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("EngraversGothic BT", 10F);
            label16.ForeColor = Color.FromArgb(224, 224, 224);
            label16.Location = new Point(277, 286);
            label16.Name = "label16";
            label16.Size = new Size(45, 15);
            label16.TabIndex = 124;
            label16.Text = "Color";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("EngraversGothic BT", 10F);
            label17.ForeColor = Color.FromArgb(224, 224, 224);
            label17.Location = new Point(34, 285);
            label17.Name = "label17";
            label17.Size = new Size(38, 15);
            label17.TabIndex = 123;
            label17.Text = "Talle";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("EngraversGothic BT", 10F);
            label21.ForeColor = Color.FromArgb(224, 224, 224);
            label21.Location = new Point(453, 179);
            label21.Name = "label21";
            label21.Size = new Size(45, 15);
            label21.TabIndex = 122;
            label21.Text = "Marca";
            // 
            // cmbMarca
            // 
            cmbMarca.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbMarca.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbMarca.BackColor = Color.Gainsboro;
            cmbMarca.DropDownWidth = 335;
            cmbMarca.FormattingEnabled = true;
            cmbMarca.Location = new Point(490, 197);
            cmbMarca.Name = "cmbMarca";
            cmbMarca.Size = new Size(292, 22);
            cmbMarca.TabIndex = 37;
            cmbMarca.KeyDown += cmbMarca_KeyDown;
            cmbMarca.Leave += cmbMarca_Leave;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Font = new Font("EngraversGothic BT", 10F);
            label22.ForeColor = Color.FromArgb(224, 224, 224);
            label22.Location = new Point(453, 122);
            label22.Name = "label22";
            label22.Size = new Size(67, 15);
            label22.TabIndex = 121;
            label22.Text = "Categoria";
            // 
            // cmbCategoria
            // 
            cmbCategoria.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbCategoria.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCategoria.BackColor = Color.Gainsboro;
            cmbCategoria.DropDownWidth = 335;
            cmbCategoria.FormattingEnabled = true;
            cmbCategoria.Location = new Point(490, 140);
            cmbCategoria.Name = "cmbCategoria";
            cmbCategoria.Size = new Size(292, 22);
            cmbCategoria.TabIndex = 36;
            cmbCategoria.KeyDown += cmbCategoria_KeyDown;
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("EngraversGothic BT", 10F);
            label23.ForeColor = Color.FromArgb(224, 224, 224);
            label23.Location = new Point(453, 71);
            label23.Name = "label23";
            label23.Size = new Size(61, 15);
            label23.TabIndex = 120;
            label23.Text = "Impuesto";
            // 
            // cmbImpuesto
            // 
            cmbImpuesto.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbImpuesto.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbImpuesto.BackColor = Color.Gainsboro;
            cmbImpuesto.DropDownWidth = 335;
            cmbImpuesto.FormattingEnabled = true;
            cmbImpuesto.Location = new Point(490, 87);
            cmbImpuesto.Name = "cmbImpuesto";
            cmbImpuesto.Size = new Size(292, 22);
            cmbImpuesto.TabIndex = 35;
            cmbImpuesto.KeyDown += cmbImpuesto_KeyDown;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Font = new Font("EngraversGothic BT", 10F);
            label24.ForeColor = Color.FromArgb(224, 224, 224);
            label24.Location = new Point(34, 178);
            label24.Name = "label24";
            label24.Size = new Size(64, 15);
            label24.TabIndex = 119;
            label24.Text = "Situación";
            // 
            // cmbSituacion
            // 
            cmbSituacion.AutoCompleteMode = AutoCompleteMode.Suggest;
            cmbSituacion.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbSituacion.BackColor = Color.Gainsboro;
            cmbSituacion.FormattingEnabled = true;
            cmbSituacion.Location = new Point(34, 194);
            cmbSituacion.Name = "cmbSituacion";
            cmbSituacion.Size = new Size(398, 22);
            cmbSituacion.TabIndex = 33;
            cmbSituacion.KeyDown += cmbSituacion_KeyDown;
            // 
            // label26
            // 
            label26.AutoSize = true;
            label26.Font = new Font("EngraversGothic BT", 10F);
            label26.ForeColor = Color.FromArgb(224, 224, 224);
            label26.Location = new Point(34, 227);
            label26.Name = "label26";
            label26.Size = new Size(60, 15);
            label26.TabIndex = 118;
            label26.Text = "BarCode";
            // 
            // txtFecha
            // 
            txtFecha.BackColor = Color.Gainsboro;
            txtFecha.BorderStyle = BorderStyle.FixedSingle;
            txtFecha.Location = new Point(834, 12);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(66, 23);
            txtFecha.TabIndex = 110;
            txtFecha.Visible = false;
            // 
            // btnEtiquetas
            // 
            btnEtiquetas.BackColor = Color.SteelBlue;
            btnEtiquetas.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEtiquetas.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnEtiquetas.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnEtiquetas.FlatStyle = FlatStyle.Flat;
            btnEtiquetas.Font = new Font("Square721 BT", 11F);
            btnEtiquetas.ForeColor = Color.White;
            btnEtiquetas.IconChar = FontAwesome.Sharp.IconChar.None;
            btnEtiquetas.IconColor = Color.Black;
            btnEtiquetas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnEtiquetas.Location = new Point(391, 382);
            btnEtiquetas.Name = "btnEtiquetas";
            btnEtiquetas.Size = new Size(96, 32);
            btnEtiquetas.TabIndex = 134;
            btnEtiquetas.TabStop = false;
            btnEtiquetas.Text = "Etiquetas";
            btnEtiquetas.UseVisualStyleBackColor = false;
            btnEtiquetas.Click += btnEtiquetas_Click;
            // 
            // Frm_Productos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(973, 523);
            Name = "Frm_Productos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Productos";
            Load += Frm_Productos_Load;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).EndInit();
            pnlContenedorPrincipal.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            tabListado.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarProveedor;
        private Button btnAgregarMarca;
        private Button btnAgregarCategoria;
        private Button btnAgregarImpuesto;
        private TextBox txtStock;
        private TextBox txtColor;
        private TextBox txtpVenta;
        private TextBox txtpOferta;
        private TextBox txtCosto;
        private TextBox txtTalle;
        private TextBox txtBarCode;
        private Label label27;
        private Label label20;
        private Label label19;
        private Label label18;
        private Label label28;
        private Label label16;
        private Label label17;
        private Label label21;
        private Label label22;
        private Label label23;
        private Label label24;
        private ComboBox cmbSituacion;
        private Label label26;
        private TextBox txtFecha;
        public ComboBox cmbProveedor;
        public ComboBox cmbMarca;
        public ComboBox cmbCategoria;
        public ComboBox cmbImpuesto;
        private FontAwesome.Sharp.IconButton btnEtiquetas;
    }
}