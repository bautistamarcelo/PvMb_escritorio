namespace PVpresentation.Formularios
{
    partial class Frm_Proveedores
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
            txtRenta = new TextBox();
            label7 = new Label();
            txtCuit = new TextBox();
            label5 = new Label();
            txtDomicilio = new TextBox();
            label3 = new Label();
            label8 = new Label();
            cmbCaracter = new ComboBox();
            txtTelefono = new TextBox();
            label9 = new Label();
            txtEmail = new TextBox();
            label6 = new Label();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).BeginInit();
            pnlContenedorPrincipal.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabListado.SuspendLayout();
            pnMantenimiento.SuspendLayout();
            pnListado.SuspendLayout();
            SuspendLayout();
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.MouseMove += pnTituloFormulario_MouseMove;
            // 
            // btnCierreVolver
            // 
            btnCierreVolver.Click += btnCierreVolver_Click;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Location = new Point(306, 12);
            lblTituloForm.Size = new Size(365, 28);
            lblTituloForm.Text = "Mantenimiento / Proveedores";
            // 
            // txtBuscar
            // 
            txtBuscar.TabIndex = 0;
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
            btnEditar.TabIndex = 2;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnNuevo.TabIndex = 3;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Cursor = Cursors.Hand;
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Maroon;
            // 
            // btnCancelar
            // 
            btnCancelar.Cursor = Cursors.Hand;
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnCancelar.TabIndex = 13;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.Cursor = Cursors.Hand;
            btnGrabar.Enabled = false;
            btnGrabar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnGrabar.TabIndex = 12;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label2
            // 
            label2.Location = new Point(14, 55);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(14, 73);
            txtNombre.TabIndex = 5;
            // 
            // label1
            // 
            label1.Location = new Point(14, 8);
            // 
            // txtID
            // 
            txtID.Location = new Point(14, 26);
            txtID.TabIndex = 4;
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.Controls.Add(label8);
            pnMantenimiento.Controls.Add(cmbCaracter);
            pnMantenimiento.Controls.Add(txtTelefono);
            pnMantenimiento.Controls.Add(label9);
            pnMantenimiento.Controls.Add(txtEmail);
            pnMantenimiento.Controls.Add(label6);
            pnMantenimiento.Controls.Add(txtRenta);
            pnMantenimiento.Controls.Add(label7);
            pnMantenimiento.Controls.Add(txtCuit);
            pnMantenimiento.Controls.Add(label5);
            pnMantenimiento.Controls.Add(txtDomicilio);
            pnMantenimiento.Controls.Add(label3);
            pnMantenimiento.Controls.SetChildIndex(btnGrabar, 0);
            pnMantenimiento.Controls.SetChildIndex(btnCancelar, 0);
            pnMantenimiento.Controls.SetChildIndex(btnEliminar, 0);
            pnMantenimiento.Controls.SetChildIndex(txtID, 0);
            pnMantenimiento.Controls.SetChildIndex(label1, 0);
            pnMantenimiento.Controls.SetChildIndex(txtNombre, 0);
            pnMantenimiento.Controls.SetChildIndex(label2, 0);
            pnMantenimiento.Controls.SetChildIndex(label3, 0);
            pnMantenimiento.Controls.SetChildIndex(txtDomicilio, 0);
            pnMantenimiento.Controls.SetChildIndex(label5, 0);
            pnMantenimiento.Controls.SetChildIndex(txtCuit, 0);
            pnMantenimiento.Controls.SetChildIndex(label7, 0);
            pnMantenimiento.Controls.SetChildIndex(txtRenta, 0);
            pnMantenimiento.Controls.SetChildIndex(label6, 0);
            pnMantenimiento.Controls.SetChildIndex(txtEmail, 0);
            pnMantenimiento.Controls.SetChildIndex(label9, 0);
            pnMantenimiento.Controls.SetChildIndex(txtTelefono, 0);
            pnMantenimiento.Controls.SetChildIndex(cmbCaracter, 0);
            pnMantenimiento.Controls.SetChildIndex(label8, 0);
            // 
            // btnDetalles
            // 
            btnDetalles.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnDetalles.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnDetalles.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            // 
            // txtRenta
            // 
            txtRenta.BackColor = Color.Gainsboro;
            txtRenta.BorderStyle = BorderStyle.FixedSingle;
            txtRenta.Location = new Point(14, 216);
            txtRenta.Name = "txtRenta";
            txtRenta.Size = new Size(288, 22);
            txtRenta.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("EngraversGothic BT", 10F);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(14, 198);
            label7.Name = "label7";
            label7.Size = new Size(81, 15);
            label7.TabIndex = 44;
            label7.Text = "Rentabilidad";
            // 
            // txtCuit
            // 
            txtCuit.BackColor = Color.Gainsboro;
            txtCuit.BorderStyle = BorderStyle.FixedSingle;
            txtCuit.Location = new Point(14, 169);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(288, 22);
            txtCuit.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(14, 151);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 42;
            label5.Text = "D.N.I. / C.U.I.T.";
            // 
            // txtDomicilio
            // 
            txtDomicilio.BackColor = Color.Gainsboro;
            txtDomicilio.BorderStyle = BorderStyle.FixedSingle;
            txtDomicilio.Location = new Point(14, 121);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(288, 22);
            txtDomicilio.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(14, 103);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 40;
            label3.Text = "Domicilio";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(14, 342);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 51;
            label8.Text = "Caracter";
            // 
            // cmbCaracter
            // 
            cmbCaracter.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCaracter.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCaracter.BackColor = Color.Gainsboro;
            cmbCaracter.FormattingEnabled = true;
            cmbCaracter.Location = new Point(14, 361);
            cmbCaracter.Name = "cmbCaracter";
            cmbCaracter.Size = new Size(288, 22);
            cmbCaracter.TabIndex = 11;
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Gainsboro;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(14, 265);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(289, 22);
            txtTelefono.TabIndex = 9;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("EngraversGothic BT", 10F);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(14, 247);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 48;
            label9.Text = "Teléfono/s";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.Gainsboro;
            txtEmail.BorderStyle = BorderStyle.FixedSingle;
            txtEmail.Location = new Point(14, 312);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(289, 22);
            txtEmail.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(14, 294);
            label6.Name = "label6";
            label6.Size = new Size(42, 15);
            label6.TabIndex = 46;
            label6.Text = "E-mail";
            // 
            // Frm_Proveedores
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Name = "Frm_Proveedores";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Proveedores";
            FormClosing += Frm_Proveedores_FormClosing;
            Load += Frm_Proveedores_Load;
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

        private TextBox txtRenta;
        private Label label7;
        private TextBox txtCuit;
        private Label label5;
        private TextBox txtDomicilio;
        private Label label3;
        private Label label8;
        private ComboBox cmbCaracter;
        private TextBox txtTelefono;
        private Label label9;
        private TextBox txtEmail;
        private Label label6;
    }
}