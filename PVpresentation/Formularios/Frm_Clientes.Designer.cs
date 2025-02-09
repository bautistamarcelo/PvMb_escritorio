namespace PVpresentation.Formularios
{
    partial class Frm_Clientes
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
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label9 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            cmbHabilitadoCta = new ComboBox();
            cmbCaracter = new ComboBox();
            cmbEstado = new ComboBox();
            txtTelefono = new TextBox();
            txtEmail = new TextBox();
            txtCuit = new TextBox();
            txtDomicilio = new TextBox();
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
            pnGral.Size = new Size(984, 532);
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.Size = new Size(984, 50);
            // 
            // btnCierreVolver
            // 
            btnCierreVolver.Click += btnCierreVolver_Click;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Location = new Point(330, 12);
            lblTituloForm.Size = new Size(305, 28);
            lblTituloForm.Text = "Mantenimiento / Clientes";
            // 
            // pnlContenedorPrincipal
            // 
            pnlContenedorPrincipal.Size = new Size(984, 480);
            // 
            // tabControlMain
            // 
            tabControlMain.Size = new Size(979, 480);
            // 
            // tabListado
            // 
            tabListado.Size = new Size(971, 442);
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txtTelefono);
            tabNuevo.Controls.Add(txtEmail);
            tabNuevo.Controls.Add(txtCuit);
            tabNuevo.Controls.Add(txtDomicilio);
            tabNuevo.Controls.Add(cmbHabilitadoCta);
            tabNuevo.Controls.Add(cmbCaracter);
            tabNuevo.Controls.Add(cmbEstado);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(label10);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(label6);
            tabNuevo.Controls.Add(label5);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Size = new Size(971, 442);
            tabNuevo.Controls.SetChildIndex(btnGrabar, 0);
            tabNuevo.Controls.SetChildIndex(btnCancelar, 0);
            tabNuevo.Controls.SetChildIndex(btnEliminar, 0);
            tabNuevo.Controls.SetChildIndex(txtID, 0);
            tabNuevo.Controls.SetChildIndex(label1, 0);
            tabNuevo.Controls.SetChildIndex(txtNombre, 0);
            tabNuevo.Controls.SetChildIndex(label2, 0);
            tabNuevo.Controls.SetChildIndex(label3, 0);
            tabNuevo.Controls.SetChildIndex(label5, 0);
            tabNuevo.Controls.SetChildIndex(label6, 0);
            tabNuevo.Controls.SetChildIndex(label9, 0);
            tabNuevo.Controls.SetChildIndex(label10, 0);
            tabNuevo.Controls.SetChildIndex(label8, 0);
            tabNuevo.Controls.SetChildIndex(label7, 0);
            tabNuevo.Controls.SetChildIndex(cmbEstado, 0);
            tabNuevo.Controls.SetChildIndex(cmbCaracter, 0);
            tabNuevo.Controls.SetChildIndex(cmbHabilitadoCta, 0);
            tabNuevo.Controls.SetChildIndex(txtDomicilio, 0);
            tabNuevo.Controls.SetChildIndex(txtCuit, 0);
            tabNuevo.Controls.SetChildIndex(txtEmail, 0);
            tabNuevo.Controls.SetChildIndex(txtTelefono, 0);
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnEditar.FlatAppearance.BorderSize = 0;
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnNuevo.FlatAppearance.BorderSize = 0;
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
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
            label2.Location = new Point(36, 90);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(36, 108);
            txtNombre.Size = new Size(423, 22);
            txtNombre.TabIndex = 31;
            // 
            // label1
            // 
            label1.Location = new Point(36, 35);
            // 
            // txtID
            // 
            txtID.Location = new Point(36, 53);
            txtID.Size = new Size(423, 22);
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnEliminar.FlatAppearance.BorderSize = 0;
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnEliminar.Location = new Point(355, 376);
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnCancelar.FlatAppearance.BorderSize = 0;
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnCancelar.Location = new Point(201, 376);
            btnCancelar.TabIndex = 40;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.FlatAppearance.BorderColor = Color.FromArgb(4, 41, 68);
            btnGrabar.FlatAppearance.BorderSize = 0;
            btnGrabar.FlatAppearance.MouseDownBackColor = Color.FromArgb(13, 93, 142);
            btnGrabar.FlatAppearance.MouseOverBackColor = Color.FromArgb(74, 134, 160);
            btnGrabar.Location = new Point(52, 376);
            btnGrabar.TabIndex = 39;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("EngraversGothic BT", 10F);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(516, 200);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 40;
            label7.Text = "Situación";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(516, 146);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 39;
            label8.Text = "Caracter";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("EngraversGothic BT", 10F);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(516, 95);
            label10.Name = "label10";
            label10.Size = new Size(49, 15);
            label10.TabIndex = 38;
            label10.Text = "Estado";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("EngraversGothic BT", 10F);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(516, 35);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 37;
            label9.Text = "Teléfono/s";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(38, 253);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 36;
            label6.Text = "E-mail";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(38, 199);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 35;
            label5.Text = "D.N.I. / C.U.I.T.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(38, 145);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 34;
            label3.Text = "Domicilio";
            // 
            // cmbHabilitadoCta
            // 
            cmbHabilitadoCta.BackColor = Color.Gainsboro;
            cmbHabilitadoCta.FormattingEnabled = true;
            cmbHabilitadoCta.Location = new Point(516, 216);
            cmbHabilitadoCta.Name = "cmbHabilitadoCta";
            cmbHabilitadoCta.Size = new Size(413, 22);
            cmbHabilitadoCta.TabIndex = 38;
            // 
            // cmbCaracter
            // 
            cmbCaracter.BackColor = Color.Gainsboro;
            cmbCaracter.FormattingEnabled = true;
            cmbCaracter.Location = new Point(516, 163);
            cmbCaracter.Name = "cmbCaracter";
            cmbCaracter.Size = new Size(413, 22);
            cmbCaracter.TabIndex = 37;
            // 
            // cmbEstado
            // 
            cmbEstado.BackColor = Color.Gainsboro;
            cmbEstado.FormattingEnabled = true;
            cmbEstado.Location = new Point(516, 113);
            cmbEstado.Name = "cmbEstado";
            cmbEstado.Size = new Size(413, 22);
            cmbEstado.TabIndex = 36;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Gainsboro;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(516, 53);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(414, 22);
            txtTelefono.TabIndex = 35;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(38, 271);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(421, 22);
            txtEmail.TabIndex = 34;
            // 
            // txtCuit
            // 
            txtCuit.BackColor = Color.Gainsboro;
            txtCuit.BorderStyle = BorderStyle.FixedSingle;
            txtCuit.Location = new Point(38, 217);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(421, 22);
            txtCuit.TabIndex = 33;
            // 
            // txtDomicilio
            // 
            txtDomicilio.BackColor = Color.Gainsboro;
            txtDomicilio.BorderStyle = BorderStyle.FixedSingle;
            txtDomicilio.Location = new Point(38, 163);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(421, 22);
            txtDomicilio.TabIndex = 32;
            // 
            // Frm_Clientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 532);
            Name = "Frm_Clientes";
            Text = "Frm_Clientes";
            Load += Frm_Clientes_Load;
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

        private Label label7;
        private Label label8;
        private Label label10;
        private Label label9;
        private Label label6;
        private Label label5;
        private Label label3;
        private ComboBox cmbHabilitadoCta;
        private ComboBox cmbCaracter;
        public ComboBox cmbEstado;
        private TextBox txtTelefono;
        private TextBox txtEmail;
        private TextBox txtCuit;
        private TextBox txtDomicilio;
    }
}