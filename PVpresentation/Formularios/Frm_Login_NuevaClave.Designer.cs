namespace PVpresentation.Formularios
{
    partial class Frm_Login_NuevaClave
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
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
            lblTituloForm = new Label();
            pnMantenimiento = new Panel();
            label3 = new Label();
            label2 = new Label();
            txtClave = new TextBox();
            label1 = new Label();
            txtUsuario = new TextBox();
            btnCancelar = new Button();
            btnLogin = new Button();
            textBox1 = new TextBox();
            pnTituloFormulario.SuspendLayout();
            pnMantenimiento.SuspendLayout();
            SuspendLayout();
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.BackColor = Color.FromArgb(74, 134, 160);
            pnTituloFormulario.Controls.Add(txtInstancia);
            pnTituloFormulario.Controls.Add(txtOpcion);
            pnTituloFormulario.Controls.Add(lblTituloForm);
            pnTituloFormulario.Dock = DockStyle.Top;
            pnTituloFormulario.Location = new Point(0, 0);
            pnTituloFormulario.Margin = new Padding(0);
            pnTituloFormulario.Name = "pnTituloFormulario";
            pnTituloFormulario.Size = new Size(304, 50);
            pnTituloFormulario.TabIndex = 51;
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
            lblTituloForm.Location = new Point(12, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(276, 28);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Cambio de Contraseña";
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.BackColor = Color.FromArgb(4, 41, 68);
            pnMantenimiento.Controls.Add(textBox1);
            pnMantenimiento.Controls.Add(label3);
            pnMantenimiento.Controls.Add(label2);
            pnMantenimiento.Controls.Add(txtClave);
            pnMantenimiento.Controls.Add(label1);
            pnMantenimiento.Controls.Add(txtUsuario);
            pnMantenimiento.Controls.Add(btnCancelar);
            pnMantenimiento.Controls.Add(btnLogin);
            pnMantenimiento.Dock = DockStyle.Top;
            pnMantenimiento.Location = new Point(0, 50);
            pnMantenimiento.Name = "pnMantenimiento";
            pnMantenimiento.Size = new Size(304, 251);
            pnMantenimiento.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(17, 127);
            label3.Name = "label3";
            label3.Size = new Size(139, 15);
            label3.TabIndex = 37;
            label3.Text = "Repetir Nueva Clave:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("EngraversGothic BT", 10F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(17, 74);
            label2.Name = "label2";
            label2.Size = new Size(88, 15);
            label2.TabIndex = 26;
            label2.Text = "Nueva Clave:";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.Gainsboro;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Location = new Point(17, 92);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(269, 23);
            txtClave.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("EngraversGothic BT", 10F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(17, 21);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 24;
            label1.Text = "Clave Actual:";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.Gainsboro;
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Location = new Point(17, 39);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(269, 23);
            txtUsuario.TabIndex = 23;
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
            btnCancelar.Location = new Point(175, 196);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 32);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.SteelBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnLogin.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnLogin.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.ForeColor = Color.WhiteSmoke;
            btnLogin.Location = new Point(34, 197);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(86, 32);
            btnLogin.TabIndex = 20;
            btnLogin.Text = "Ingresar";
            btnLogin.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.BorderStyle = BorderStyle.FixedSingle;
            textBox1.Location = new Point(17, 145);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(269, 23);
            textBox1.TabIndex = 39;
            // 
            // Frm_Login_NuevaClave
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 300);
            Controls.Add(pnMantenimiento);
            Controls.Add(pnTituloFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Login_NuevaClave";
            Text = "Frm_Login_NuevaClave";
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
        public Label label3;
        public Label label2;
        public TextBox txtClave;
        public Label label1;
        public TextBox txtUsuario;
        public Button btnCancelar;
        public Button btnLogin;
        public TextBox textBox1;
    }
}