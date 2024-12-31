namespace PVpresentation.Formularios
{
    partial class Frm_Empresas
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
            cmbCaracter = new ComboBox();
            label8 = new Label();
            txtTelefono = new TextBox();
            txtCuit = new TextBox();
            txtDomicilio = new TextBox();
            label9 = new Label();
            label5 = new Label();
            label3 = new Label();
            txtLogoUrl = new TextBox();
            label6 = new Label();
            txtLogoNombre = new TextBox();
            label7 = new Label();
            txtMoneda = new TextBox();
            label10 = new Label();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).BeginInit();
            pnlContenedorPrincipal.SuspendLayout();
            tabControlMain.SuspendLayout();
            tabListado.SuspendLayout();
            tabNuevo.SuspendLayout();
            SuspendLayout();
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
            lblTituloForm.Location = new Point(314, 12);
            lblTituloForm.Size = new Size(317, 28);
            lblTituloForm.Text = "Mantenimiento / Empresas";
            // 
            // pnlContenedorPrincipal
            // 
            pnlContenedorPrincipal.Size = new Size(984, 479);
            // 
            // tabControlMain
            // 
            tabControlMain.Size = new Size(979, 479);
            // 
            // tabListado
            // 
            tabListado.Size = new Size(971, 441);
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txtMoneda);
            tabNuevo.Controls.Add(label10);
            tabNuevo.Controls.Add(txtLogoNombre);
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(txtLogoUrl);
            tabNuevo.Controls.Add(label6);
            tabNuevo.Controls.Add(txtTelefono);
            tabNuevo.Controls.Add(txtCuit);
            tabNuevo.Controls.Add(txtDomicilio);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(label5);
            tabNuevo.Controls.Add(label3);
            tabNuevo.Controls.Add(cmbCaracter);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Size = new Size(971, 441);
            tabNuevo.Controls.SetChildIndex(btnGrabar, 0);
            tabNuevo.Controls.SetChildIndex(btnCancelar, 0);
            tabNuevo.Controls.SetChildIndex(btnEliminar, 0);
            tabNuevo.Controls.SetChildIndex(txtID, 0);
            tabNuevo.Controls.SetChildIndex(label1, 0);
            tabNuevo.Controls.SetChildIndex(txtNombre, 0);
            tabNuevo.Controls.SetChildIndex(label2, 0);
            tabNuevo.Controls.SetChildIndex(label8, 0);
            tabNuevo.Controls.SetChildIndex(cmbCaracter, 0);
            tabNuevo.Controls.SetChildIndex(label3, 0);
            tabNuevo.Controls.SetChildIndex(label5, 0);
            tabNuevo.Controls.SetChildIndex(label9, 0);
            tabNuevo.Controls.SetChildIndex(txtDomicilio, 0);
            tabNuevo.Controls.SetChildIndex(txtCuit, 0);
            tabNuevo.Controls.SetChildIndex(txtTelefono, 0);
            tabNuevo.Controls.SetChildIndex(label6, 0);
            tabNuevo.Controls.SetChildIndex(txtLogoUrl, 0);
            tabNuevo.Controls.SetChildIndex(label7, 0);
            tabNuevo.Controls.SetChildIndex(txtLogoNombre, 0);
            tabNuevo.Controls.SetChildIndex(label10, 0);
            tabNuevo.Controls.SetChildIndex(txtMoneda, 0);
            // 
            // btnEditar
            // 
            btnEditar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
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
            label2.Location = new Point(35, 99);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(35, 117);
            txtNombre.Size = new Size(421, 22);
            // 
            // label1
            // 
            label1.Location = new Point(35, 44);
            // 
            // txtID
            // 
            txtID.Location = new Point(35, 62);
            txtID.Size = new Size(421, 22);
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Maroon;
            btnEliminar.Location = new Point(341, 379);
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnCancelar.Location = new Point(187, 379);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnGrabar.Location = new Point(38, 379);
            btnGrabar.Click += btnGrabar_Click;
            // 
            // cmbCaracter
            // 
            cmbCaracter.BackColor = Color.Gainsboro;
            cmbCaracter.FormattingEnabled = true;
            cmbCaracter.Location = new Point(514, 173);
            cmbCaracter.Name = "cmbCaracter";
            cmbCaracter.Size = new Size(421, 22);
            cmbCaracter.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(514, 156);
            label8.Name = "label8";
            label8.Size = new Size(64, 15);
            label8.TabIndex = 43;
            label8.Text = "Caracter";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Gainsboro;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(35, 285);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(421, 22);
            txtTelefono.TabIndex = 53;
            // 
            // txtCuit
            // 
            txtCuit.BackColor = Color.Gainsboro;
            txtCuit.BorderStyle = BorderStyle.FixedSingle;
            txtCuit.Location = new Point(35, 227);
            txtCuit.Name = "txtCuit";
            txtCuit.Size = new Size(421, 22);
            txtCuit.TabIndex = 52;
            // 
            // txtDomicilio
            // 
            txtDomicilio.BackColor = Color.Gainsboro;
            txtDomicilio.BorderStyle = BorderStyle.FixedSingle;
            txtDomicilio.Location = new Point(35, 173);
            txtDomicilio.Name = "txtDomicilio";
            txtDomicilio.Size = new Size(421, 22);
            txtDomicilio.TabIndex = 51;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("EngraversGothic BT", 10F);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(35, 267);
            label9.Name = "label9";
            label9.Size = new Size(74, 15);
            label9.TabIndex = 50;
            label9.Text = "Teléfono/s";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(35, 209);
            label5.Name = "label5";
            label5.Size = new Size(102, 15);
            label5.TabIndex = 49;
            label5.Text = "D.N.I. / C.U.I.T.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(35, 155);
            label3.Name = "label3";
            label3.Size = new Size(63, 15);
            label3.TabIndex = 48;
            label3.Text = "Domicilio";
            // 
            // txtLogoUrl
            // 
            txtLogoUrl.BackColor = Color.Gainsboro;
            txtLogoUrl.BorderStyle = BorderStyle.FixedSingle;
            txtLogoUrl.Location = new Point(514, 62);
            txtLogoUrl.Name = "txtLogoUrl";
            txtLogoUrl.Size = new Size(421, 22);
            txtLogoUrl.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(514, 44);
            label6.Name = "label6";
            label6.Size = new Size(66, 15);
            label6.TabIndex = 54;
            label6.Text = "Logo URL";
            // 
            // txtLogoNombre
            // 
            txtLogoNombre.BackColor = Color.Gainsboro;
            txtLogoNombre.BorderStyle = BorderStyle.FixedSingle;
            txtLogoNombre.Location = new Point(514, 117);
            txtLogoNombre.Name = "txtLogoNombre";
            txtLogoNombre.Size = new Size(421, 22);
            txtLogoNombre.TabIndex = 57;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("EngraversGothic BT", 10F);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(514, 99);
            label7.Name = "label7";
            label7.Size = new Size(91, 15);
            label7.TabIndex = 56;
            label7.Text = "Logo Nombre";
            // 
            // txtMoneda
            // 
            txtMoneda.BackColor = Color.Gainsboro;
            txtMoneda.BorderStyle = BorderStyle.FixedSingle;
            txtMoneda.Location = new Point(514, 227);
            txtMoneda.Name = "txtMoneda";
            txtMoneda.Size = new Size(421, 22);
            txtMoneda.TabIndex = 59;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("EngraversGothic BT", 10F);
            label10.ForeColor = Color.FromArgb(224, 224, 224);
            label10.Location = new Point(514, 209);
            label10.Name = "label10";
            label10.Size = new Size(106, 15);
            label10.TabIndex = 58;
            label10.Text = "Símbolo Moneda";
            // 
            // Frm_Empresas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 532);
            Name = "Frm_Empresas";
            Text = "Frm_Empresas";
            Load += Frm_Empresas_Load;
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

        private ComboBox cmbCaracter;
        private Label label8;
        private TextBox txtTelefono;
        private TextBox txtCuit;
        private TextBox txtDomicilio;
        private Label label9;
        private Label label5;
        private Label label3;
        private TextBox txtMoneda;
        private Label label10;
        private TextBox txtLogoNombre;
        private Label label7;
        private TextBox txtLogoUrl;
        private Label label6;
    }
}