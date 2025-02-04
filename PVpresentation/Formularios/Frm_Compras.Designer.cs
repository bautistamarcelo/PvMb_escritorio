namespace PVpresentation.Formularios
{
    partial class Frm_Compras
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Compras));
            pnTituloFormulario = new Panel();
            btnMaximizar = new PictureBox();
            btnRestaurar = new PictureBox();
            btnCerrar = new PictureBox();
            btnMinimizar = new PictureBox();
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
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
            label9 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            textBox1 = new TextBox();
            button1 = new Button();
            dgvListado = new DataGridView();
            label4 = new Label();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
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
            lblTituloForm.Location = new Point(374, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(181, 28);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Nueva Compra";
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
            pnMantenimiento.Dock = DockStyle.Right;
            pnMantenimiento.Location = new Point(650, 45);
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
            txtNombre.Size = new Size(113, 23);
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
            txtID.Size = new Size(113, 23);
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
            pnListado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            pnListado.BackColor = Color.FromArgb(45, 66, 91);
            pnListado.Controls.Add(label9);
            pnListado.Controls.Add(textBox6);
            pnListado.Controls.Add(label8);
            pnListado.Controls.Add(textBox5);
            pnListado.Controls.Add(label7);
            pnListado.Controls.Add(textBox4);
            pnListado.Controls.Add(label6);
            pnListado.Controls.Add(textBox3);
            pnListado.Controls.Add(label5);
            pnListado.Controls.Add(textBox2);
            pnListado.Controls.Add(label3);
            pnListado.Controls.Add(textBox1);
            pnListado.Controls.Add(button1);
            pnListado.Controls.Add(dgvListado);
            pnListado.Controls.Add(label4);
            pnListado.Controls.Add(txtBuscar);
            pnListado.Controls.Add(btnBuscar);
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
            // textBox6
            // 
            textBox6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox6.BackColor = Color.Silver;
            textBox6.BorderStyle = BorderStyle.FixedSingle;
            textBox6.Enabled = false;
            textBox6.Font = new Font("Square721 BT", 12F);
            textBox6.ForeColor = Color.FromArgb(4, 41, 68);
            textBox6.Location = new Point(516, 420);
            textBox6.Name = "textBox6";
            textBox6.ReadOnly = true;
            textBox6.Size = new Size(113, 27);
            textBox6.TabIndex = 33;
            textBox6.TabStop = false;
            textBox6.Text = "900";
            textBox6.TextAlign = HorizontalAlignment.Center;
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
            // textBox5
            // 
            textBox5.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox5.BackColor = Color.Silver;
            textBox5.BorderStyle = BorderStyle.FixedSingle;
            textBox5.Enabled = false;
            textBox5.Font = new Font("Square721 BT", 12F);
            textBox5.ForeColor = Color.FromArgb(4, 41, 68);
            textBox5.Location = new Point(383, 420);
            textBox5.Name = "textBox5";
            textBox5.ReadOnly = true;
            textBox5.Size = new Size(113, 27);
            textBox5.TabIndex = 31;
            textBox5.TabStop = false;
            textBox5.Text = "600";
            textBox5.TextAlign = HorizontalAlignment.Center;
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
            // textBox4
            // 
            textBox4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox4.BackColor = Color.Silver;
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Enabled = false;
            textBox4.Font = new Font("Square721 BT", 12F);
            textBox4.ForeColor = Color.FromArgb(4, 41, 68);
            textBox4.Location = new Point(253, 420);
            textBox4.Name = "textBox4";
            textBox4.ReadOnly = true;
            textBox4.Size = new Size(113, 27);
            textBox4.TabIndex = 29;
            textBox4.TabStop = false;
            textBox4.Text = "1500";
            textBox4.TextAlign = HorizontalAlignment.Center;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(13, 402);
            label6.Name = "label6";
            label6.Size = new Size(60, 15);
            label6.TabIndex = 28;
            label6.Text = "Nombre:";
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.Silver;
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Enabled = false;
            textBox3.Location = new Point(13, 420);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(113, 23);
            textBox3.TabIndex = 27;
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
            // textBox2
            // 
            textBox2.BackColor = Color.Gainsboro;
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(77, 55);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(49, 23);
            textBox2.TabIndex = 22;
            textBox2.Text = "1";
            textBox2.TextAlign = HorizontalAlignment.Center;
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
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(205, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(392, 23);
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
            button1.Location = new Point(603, 56);
            button1.Name = "button1";
            button1.Size = new Size(24, 22);
            button1.TabIndex = 19;
            button1.UseVisualStyleBackColor = true;
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
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.Gainsboro;
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(77, 15);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(520, 23);
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
            btnBuscar.Location = new Point(603, 17);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(24, 22);
            btnBuscar.TabIndex = 13;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // Frm_Compras
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 134, 160);
            ClientSize = new Size(968, 512);
            Controls.Add(pnMantenimiento);
            Controls.Add(pnListado);
            Controls.Add(pnTituloFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Compras";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Compras";
            FormClosing += Frm_Ventas_FormClosing;
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
        public TextBox txtNombre;
        public Label label1;
        public TextBox txtID;
        public Button btnEliminar;
        public Button btnCancelar;
        public Button btnGrabar;
        public Panel pnListado;
        public DataGridView dgvListado;
        public Label label4;
        public TextBox txtBuscar;
        public Button btnBuscar;
        public Label label5;
        public TextBox textBox2;
        public Label label3;
        public TextBox textBox1;
        public Button button1;
        private PictureBox btnMaximizar;
        private PictureBox btnRestaurar;
        private PictureBox btnCerrar;
        private PictureBox btnMinimizar;
        public Label label9;
        public TextBox textBox6;
        public Label label8;
        public TextBox textBox5;
        public Label label7;
        public TextBox textBox4;
        public Label label6;
        public TextBox textBox3;
    }
}