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
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
            btnCierreVolver = new PictureBox();
            lblTituloForm = new Label();
            pnMantenimiento = new Panel();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            txtID = new TextBox();
            btnEliminar = new Button();
            btnCancelar = new Button();
            btnGrabar = new Button();
            pnListado = new Panel();
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            btnEditar = new Button();
            btnNuevo = new Button();
            dgvListado = new DataGridView();
            label4 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).BeginInit();
            pnMantenimiento.SuspendLayout();
            pnListado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
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
            pnTituloFormulario.MouseMove += pnTituloFormulario_MouseMove;
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
            lblTituloForm.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("EngraversGothic BT", 20F);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(816, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(140, 28);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Venta N° 0";
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.BackColor = Color.FromArgb(4, 41, 68);
            pnMantenimiento.Controls.Add(label2);
            pnMantenimiento.Controls.Add(txtNombre);
            pnMantenimiento.Controls.Add(label1);
            pnMantenimiento.Controls.Add(txtID);
            pnMantenimiento.Controls.Add(btnEliminar);
            pnMantenimiento.Controls.Add(btnCancelar);
            pnMantenimiento.Controls.Add(btnGrabar);
            pnMantenimiento.Location = new Point(650, 51);
            pnMantenimiento.Name = "pnMantenimiento";
            pnMantenimiento.Size = new Size(318, 467);
            pnMantenimiento.TabIndex = 52;
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
            txtNombre.Size = new Size(288, 23);
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
            txtID.Size = new Size(288, 23);
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
            pnListado.BackColor = Color.FromArgb(45, 66, 91);
            pnListado.Controls.Add(label5);
            pnListado.Controls.Add(textBox2);
            pnListado.Controls.Add(label3);
            pnListado.Controls.Add(textBox1);
            pnListado.Controls.Add(button1);
            pnListado.Controls.Add(btnEditar);
            pnListado.Controls.Add(btnNuevo);
            pnListado.Controls.Add(dgvListado);
            pnListado.Controls.Add(label4);
            pnListado.Controls.Add(txtBuscar);
            pnListado.Controls.Add(btnBuscar);
            pnListado.Location = new Point(0, 50);
            pnListado.Name = "pnListado";
            pnListado.Size = new Size(651, 459);
            pnListado.TabIndex = 51;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(466, 61);
            label5.Name = "label5";
            label5.Size = new Size(62, 15);
            label5.TabIndex = 23;
            label5.Text = "Cantidad:";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(530, 58);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(99, 23);
            textBox2.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(12, 62);
            label3.Name = "label3";
            label3.Size = new Size(67, 15);
            label3.TabIndex = 21;
            label3.Text = "Artículo:";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(77, 59);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(334, 23);
            textBox1.TabIndex = 20;
            // 
            // button1
            // 
            button1.BackgroundImageLayout = ImageLayout.Zoom;
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.FromArgb(23, 54, 93);
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(417, 60);
            button1.Name = "button1";
            button1.Size = new Size(24, 22);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
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
            btnEditar.Location = new Point(106, 411);
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
            dgvListado.Location = new Point(13, 93);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(616, 303);
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
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Gainsboro;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(77, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(511, 23);
            txtBuscar.TabIndex = 14;
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
            btnBuscar.Location = new Point(594, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(24, 22);
            btnBuscar.TabIndex = 13;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Frm_Ventas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 134, 160);
            ClientSize = new Size(968, 511);
            Controls.Add(pnMantenimiento);
            Controls.Add(pnListado);
            Controls.Add(pnTituloFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Ventas";
            Text = "Frm_Ventas";
            FormClosing += Frm_Ventas_FormClosing;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).EndInit();
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
        public PictureBox btnCierreVolver;
        public Label lblTituloForm;
        public Panel pnMantenimiento;
        public Label label2;
        public TextBox txtNombre;
        public Label label1;
        public TextBox txtID;
        public Button btnEliminar;
        public Button btnCancelar;
        public Button btnGrabar;
        public Panel pnListado;
        public Button btnEditar;
        public Button btnNuevo;
        public DataGridView dgvListado;
        public Label label4;
        public TextBox txtBuscar;
        public Button btnBuscar;
        public Label label5;
        public TextBox textBox2;
        public Label label3;
        public TextBox textBox1;
        public Button button1;
    }
}