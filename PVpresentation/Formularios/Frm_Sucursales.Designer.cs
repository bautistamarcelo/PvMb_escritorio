namespace PVpresentation.Formularios
{
    partial class Frm_Sucursales
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
            cmbEmpresa = new ComboBox();
            txtTelefono = new TextBox();
            label6 = new Label();
            txtEmail = new TextBox();
            label5 = new Label();
            txtDireccion = new TextBox();
            label3 = new Label();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).BeginInit();
            pnlContenedorPrincipal.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabListado.SuspendLayout();
            pnMantenimiento.SuspendLayout();
            pnListado.SuspendLayout();
            SuspendLayout();
            // 
            // btnCierreVolver
            // 
            btnCierreVolver.Click += btnCierreVolver_Click;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Location = new Point(305, 9);
            lblTituloForm.Size = new Size(345, 28);
            lblTituloForm.Text = "Mantenimiento / Sucursales";
            // 
            // tabNuevo
            // 
            tabNuevo.Size = new Size(965, 462);
            // 
            // tabEditar
            // 
            tabEditar.Size = new Size(965, 462);
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnEditar.Location = new Point(108, 413);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnNuevo.Location = new Point(16, 413);
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnEliminar.Location = new Point(213, 413);
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnCancelar.Location = new Point(111, 413);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnGrabar.Location = new Point(11, 413);
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label2
            // 
            label2.Location = new Point(14, 86);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(14, 104);
            // 
            // label1
            // 
            label1.Location = new Point(14, 38);
            // 
            // txtID
            // 
            txtID.Location = new Point(14, 56);
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.Controls.Add(label8);
            pnMantenimiento.Controls.Add(cmbEmpresa);
            pnMantenimiento.Controls.Add(txtTelefono);
            pnMantenimiento.Controls.Add(label6);
            pnMantenimiento.Controls.Add(txtEmail);
            pnMantenimiento.Controls.Add(label5);
            pnMantenimiento.Controls.Add(txtDireccion);
            pnMantenimiento.Controls.Add(label3);
            pnMantenimiento.Controls.SetChildIndex(btnGrabar, 0);
            pnMantenimiento.Controls.SetChildIndex(btnCancelar, 0);
            pnMantenimiento.Controls.SetChildIndex(btnEliminar, 0);
            pnMantenimiento.Controls.SetChildIndex(txtID, 0);
            pnMantenimiento.Controls.SetChildIndex(label1, 0);
            pnMantenimiento.Controls.SetChildIndex(txtNombre, 0);
            pnMantenimiento.Controls.SetChildIndex(label2, 0);
            pnMantenimiento.Controls.SetChildIndex(label3, 0);
            pnMantenimiento.Controls.SetChildIndex(txtDireccion, 0);
            pnMantenimiento.Controls.SetChildIndex(label5, 0);
            pnMantenimiento.Controls.SetChildIndex(txtEmail, 0);
            pnMantenimiento.Controls.SetChildIndex(label6, 0);
            pnMantenimiento.Controls.SetChildIndex(txtTelefono, 0);
            pnMantenimiento.Controls.SetChildIndex(cmbEmpresa, 0);
            pnMantenimiento.Controls.SetChildIndex(label8, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(14, 278);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 55;
            label8.Text = "Empresa";
            // 
            // cmbEmpresa
            // 
            cmbEmpresa.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbEmpresa.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbEmpresa.BackColor = Color.Gainsboro;
            cmbEmpresa.FormattingEnabled = true;
            cmbEmpresa.Location = new Point(14, 297);
            cmbEmpresa.Name = "cmbEmpresa";
            cmbEmpresa.Size = new Size(285, 22);
            cmbEmpresa.TabIndex = 51;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Gainsboro;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(14, 201);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(285, 22);
            txtTelefono.TabIndex = 49;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(14, 183);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 54;
            label6.Text = "Teléfono/s";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(14, 246);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(286, 22);
            txtEmail.TabIndex = 50;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(14, 228);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 53;
            label5.Text = "Email";
            // 
            // txtDireccion
            // 
            txtDireccion.BackColor = Color.Gainsboro;
            txtDireccion.BorderStyle = BorderStyle.FixedSingle;
            txtDireccion.Location = new Point(14, 154);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(285, 22);
            txtDireccion.TabIndex = 48;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(14, 136);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 52;
            label3.Text = "Direccion";
            // 
            // Frm_Sucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Name = "Frm_Sucursales";
            Text = "Frm_Sucursales";
            Load += Frm_Sucursales_Load;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).EndInit();
            pnlContenedorPrincipal.ResumeLayout(false);
            tabControlMain.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            pnMantenimiento.ResumeLayout(false);
            pnMantenimiento.PerformLayout();
            pnListado.ResumeLayout(false);
            pnListado.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Label label8;
        public ComboBox cmbEmpresa;
        public TextBox txtTelefono;
        public Label label6;
        public TextBox txtEmail;
        public Label label5;
        public TextBox txtDireccion;
        public Label label3;
    }
}