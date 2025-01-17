namespace PVpresentation.Formularios
{
    partial class Frm_Usuarios
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
            cmbEsActivo = new ComboBox();
            label10 = new Label();
            cmbRol = new ComboBox();
            txtNombreFoto = new TextBox();
            label8 = new Label();
            txtUrlFoto = new TextBox();
            label9 = new Label();
            txtClave = new TextBox();
            label6 = new Label();
            txtTelefono = new TextBox();
            label5 = new Label();
            txtCorreo = new TextBox();
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
            // pnGral
            // 
            pnGral.Location = new Point(0, 0);
            pnGral.Size = new Size(984, 561);
            // 
            // btnCierreVolver
            // 
            btnCierreVolver.Click += btnCierreVolver_Click;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Location = new Point(322, 9);
            lblTituloForm.Size = new Size(311, 28);
            lblTituloForm.Text = "Mantenimiento / Usuarios";
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
            btnEditar.Click += btnEditar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnEliminar.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            btnEliminar.FlatAppearance.MouseOverBackColor = Color.Maroon;
            // 
            // btnCancelar
            // 
            btnCancelar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnCancelar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnGrabar
            // 
            btnGrabar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label2
            // 
            label2.Location = new Point(14, 58);
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(14, 76);
            txtNombre.Size = new Size(287, 22);
            // 
            // label1
            // 
            label1.Location = new Point(14, 13);
            // 
            // txtID
            // 
            txtID.Location = new Point(14, 31);
            txtID.Size = new Size(287, 22);
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pnMantenimiento.Controls.Add(label7);
            pnMantenimiento.Controls.Add(cmbEsActivo);
            pnMantenimiento.Controls.Add(label10);
            pnMantenimiento.Controls.Add(cmbRol);
            pnMantenimiento.Controls.Add(txtNombreFoto);
            pnMantenimiento.Controls.Add(label8);
            pnMantenimiento.Controls.Add(txtUrlFoto);
            pnMantenimiento.Controls.Add(label9);
            pnMantenimiento.Controls.Add(txtClave);
            pnMantenimiento.Controls.Add(label6);
            pnMantenimiento.Controls.Add(txtTelefono);
            pnMantenimiento.Controls.Add(label5);
            pnMantenimiento.Controls.Add(txtCorreo);
            pnMantenimiento.Controls.Add(label3);
            pnMantenimiento.Dock = DockStyle.None;
            pnMantenimiento.Controls.SetChildIndex(btnGrabar, 0);
            pnMantenimiento.Controls.SetChildIndex(btnCancelar, 0);
            pnMantenimiento.Controls.SetChildIndex(btnEliminar, 0);
            pnMantenimiento.Controls.SetChildIndex(txtID, 0);
            pnMantenimiento.Controls.SetChildIndex(label1, 0);
            pnMantenimiento.Controls.SetChildIndex(txtNombre, 0);
            pnMantenimiento.Controls.SetChildIndex(label2, 0);
            pnMantenimiento.Controls.SetChildIndex(label3, 0);
            pnMantenimiento.Controls.SetChildIndex(txtCorreo, 0);
            pnMantenimiento.Controls.SetChildIndex(label5, 0);
            pnMantenimiento.Controls.SetChildIndex(txtTelefono, 0);
            pnMantenimiento.Controls.SetChildIndex(label6, 0);
            pnMantenimiento.Controls.SetChildIndex(txtClave, 0);
            pnMantenimiento.Controls.SetChildIndex(label9, 0);
            pnMantenimiento.Controls.SetChildIndex(txtUrlFoto, 0);
            pnMantenimiento.Controls.SetChildIndex(label8, 0);
            pnMantenimiento.Controls.SetChildIndex(txtNombreFoto, 0);
            pnMantenimiento.Controls.SetChildIndex(cmbRol, 0);
            pnMantenimiento.Controls.SetChildIndex(label10, 0);
            pnMantenimiento.Controls.SetChildIndex(cmbEsActivo, 0);
            pnMantenimiento.Controls.SetChildIndex(label7, 0);
            // 
            // pnListado
            // 
            pnListado.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            pnListado.Dock = DockStyle.None;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("EngraversGothic BT", 10F);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(15, 315);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 49;
            label7.Text = "Situación";
            // 
            // cmbEsActivo
            // 
            cmbEsActivo.BackColor = Color.Gainsboro;
            cmbEsActivo.FormattingEnabled = true;
            cmbEsActivo.Location = new Point(15, 333);
            cmbEsActivo.Name = "cmbEsActivo";
            cmbEsActivo.Size = new Size(287, 22);
            cmbEsActivo.TabIndex = 41;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("EngraversGothic BT", 10F);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(15, 357);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 48;
            label10.Text = "Rol";
            // 
            // cmbRol
            // 
            cmbRol.BackColor = Color.Gainsboro;
            cmbRol.FormattingEnabled = true;
            cmbRol.Location = new Point(15, 374);
            cmbRol.Name = "cmbRol";
            cmbRol.Size = new Size(287, 22);
            cmbRol.TabIndex = 42;
            // 
            // txtNombreFoto
            // 
            txtNombreFoto.BackColor = Color.Gainsboro;
            txtNombreFoto.BorderStyle = BorderStyle.FixedSingle;
            txtNombreFoto.Location = new Point(14, 293);
            txtNombreFoto.Name = "txtNombreFoto";
            txtNombreFoto.Size = new Size(287, 22);
            txtNombreFoto.TabIndex = 40;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(14, 275);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 47;
            label8.Text = "Nombre Foto";
            // 
            // txtUrlFoto
            // 
            txtUrlFoto.BackColor = Color.Gainsboro;
            txtUrlFoto.BorderStyle = BorderStyle.FixedSingle;
            txtUrlFoto.Location = new Point(14, 250);
            txtUrlFoto.Name = "txtUrlFoto";
            txtUrlFoto.Size = new Size(287, 22);
            txtUrlFoto.TabIndex = 39;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("EngraversGothic BT", 10F);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(14, 232);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 46;
            label9.Text = "URL Foto";
            // 
            // txtClave
            // 
            txtClave.BackColor = Color.Gainsboro;
            txtClave.BorderStyle = BorderStyle.FixedSingle;
            txtClave.Location = new Point(14, 208);
            txtClave.Name = "txtClave";
            txtClave.PasswordChar = '*';
            txtClave.Size = new Size(287, 22);
            txtClave.TabIndex = 38;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(14, 190);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 45;
            label6.Text = "Clave";
            // 
            // txtTelefono
            // 
            txtTelefono.BackColor = Color.Gainsboro;
            txtTelefono.BorderStyle = BorderStyle.FixedSingle;
            txtTelefono.Location = new Point(14, 166);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(287, 22);
            txtTelefono.TabIndex = 37;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(14, 148);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 44;
            label5.Text = "Teléfono";
            // 
            // txtCorreo
            // 
            txtCorreo.BackColor = Color.Gainsboro;
            txtCorreo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreo.Location = new Point(14, 123);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(287, 22);
            txtCorreo.TabIndex = 36;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.WhiteSmoke;
            label3.Location = new Point(14, 105);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 43;
            label3.Text = "Correo";
            // 
            // Frm_Usuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Name = "Frm_Usuarios";
            Text = "Frm_Usuarios";
            Load += Frm_Usuarios_Load;
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

        private Label label7;
        private ComboBox cmbEsActivo;
        private Label label10;
        private ComboBox cmbRol;
        private TextBox txtNombreFoto;
        private Label label8;
        private TextBox txtUrlFoto;
        private Label label9;
        private TextBox txtClave;
        private Label label6;
        private TextBox txtTelefono;
        private Label label5;
        private TextBox txtCorreo;
        private Label label3;
    }
}