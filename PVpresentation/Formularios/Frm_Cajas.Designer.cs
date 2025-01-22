namespace PVpresentation.Formularios
{
    partial class Frm_Cajas
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
            cmbCondicion = new ComboBox();
            txtSaldoInicial = new TextBox();
            label6 = new Label();
            txtFechaCierre = new TextBox();
            label5 = new Label();
            txtFechaApertura = new TextBox();
            label3 = new Label();
            txtSaldoFinal = new TextBox();
            label7 = new Label();
            txtResultado = new TextBox();
            label9 = new Label();
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
            lblTituloForm.Location = new Point(337, 12);
            lblTituloForm.Size = new Size(270, 28);
            lblTituloForm.Text = "Mantenimiento / Cajas";
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
            btnGrabar.Enabled = false;
            btnGrabar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnGrabar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnGrabar.Click += btnGrabar_Click;
            // 
            // label2
            // 
            label2.Location = new Point(14, 61);
            // 
            // txtNombre
            // 
            txtNombre.Enabled = false;
            txtNombre.Location = new Point(14, 79);
            // 
            // label1
            // 
            label1.Location = new Point(14, 15);
            // 
            // txtID
            // 
            txtID.Enabled = false;
            txtID.Location = new Point(14, 33);
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.Controls.Add(txtResultado);
            pnMantenimiento.Controls.Add(label9);
            pnMantenimiento.Controls.Add(txtSaldoFinal);
            pnMantenimiento.Controls.Add(label7);
            pnMantenimiento.Controls.Add(label8);
            pnMantenimiento.Controls.Add(cmbCondicion);
            pnMantenimiento.Controls.Add(txtSaldoInicial);
            pnMantenimiento.Controls.Add(label6);
            pnMantenimiento.Controls.Add(txtFechaCierre);
            pnMantenimiento.Controls.Add(label5);
            pnMantenimiento.Controls.Add(txtFechaApertura);
            pnMantenimiento.Controls.Add(label3);
            pnMantenimiento.Controls.SetChildIndex(btnGrabar, 0);
            pnMantenimiento.Controls.SetChildIndex(btnCancelar, 0);
            pnMantenimiento.Controls.SetChildIndex(btnEliminar, 0);
            pnMantenimiento.Controls.SetChildIndex(txtID, 0);
            pnMantenimiento.Controls.SetChildIndex(label1, 0);
            pnMantenimiento.Controls.SetChildIndex(txtNombre, 0);
            pnMantenimiento.Controls.SetChildIndex(label2, 0);
            pnMantenimiento.Controls.SetChildIndex(label3, 0);
            pnMantenimiento.Controls.SetChildIndex(txtFechaApertura, 0);
            pnMantenimiento.Controls.SetChildIndex(label5, 0);
            pnMantenimiento.Controls.SetChildIndex(txtFechaCierre, 0);
            pnMantenimiento.Controls.SetChildIndex(label6, 0);
            pnMantenimiento.Controls.SetChildIndex(txtSaldoInicial, 0);
            pnMantenimiento.Controls.SetChildIndex(cmbCondicion, 0);
            pnMantenimiento.Controls.SetChildIndex(label8, 0);
            pnMantenimiento.Controls.SetChildIndex(label7, 0);
            pnMantenimiento.Controls.SetChildIndex(txtSaldoFinal, 0);
            pnMantenimiento.Controls.SetChildIndex(label9, 0);
            pnMantenimiento.Controls.SetChildIndex(txtResultado, 0);
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(12, 295);
            label8.Name = "label8";
            label8.Size = new Size(66, 15);
            label8.TabIndex = 63;
            label8.Text = "Condición";
            // 
            // cmbCondicion
            // 
            cmbCondicion.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCondicion.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCondicion.BackColor = Color.Gainsboro;
            cmbCondicion.Enabled = false;
            cmbCondicion.FormattingEnabled = true;
            cmbCondicion.Location = new Point(12, 314);
            cmbCondicion.Name = "cmbCondicion";
            cmbCondicion.Size = new Size(285, 22);
            cmbCondicion.TabIndex = 59;
            // 
            // txtSaldoInicial
            // 
            txtSaldoInicial.BackColor = Color.Gainsboro;
            txtSaldoInicial.BorderStyle = BorderStyle.FixedSingle;
            txtSaldoInicial.Location = new Point(12, 171);
            txtSaldoInicial.Name = "txtSaldoInicial";
            txtSaldoInicial.Size = new Size(285, 22);
            txtSaldoInicial.TabIndex = 57;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(12, 153);
            label6.Name = "label6";
            label6.Size = new Size(83, 15);
            label6.TabIndex = 62;
            label6.Text = "Saldo Inicial";
            // 
            // txtFechaCierre
            // 
            txtFechaCierre.BackColor = Color.Gainsboro;
            txtFechaCierre.BorderStyle = BorderStyle.FixedSingle;
            txtFechaCierre.Enabled = false;
            txtFechaCierre.Location = new Point(12, 216);
            txtFechaCierre.Name = "txtFechaCierre";
            txtFechaCierre.Size = new Size(286, 22);
            txtFechaCierre.TabIndex = 58;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(12, 198);
            label5.Name = "label5";
            label5.Size = new Size(89, 15);
            label5.TabIndex = 61;
            label5.Text = "Fecha Cierre";
            // 
            // txtFechaApertura
            // 
            txtFechaApertura.BackColor = Color.Gainsboro;
            txtFechaApertura.BorderStyle = BorderStyle.FixedSingle;
            txtFechaApertura.Enabled = false;
            txtFechaApertura.Location = new Point(12, 124);
            txtFechaApertura.Name = "txtFechaApertura";
            txtFechaApertura.Size = new Size(285, 22);
            txtFechaApertura.TabIndex = 56;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(12, 106);
            label3.Name = "label3";
            label3.Size = new Size(106, 15);
            label3.TabIndex = 60;
            label3.Text = "Fecha Apertura";
            // 
            // txtSaldoFinal
            // 
            txtSaldoFinal.BackColor = Color.Gainsboro;
            txtSaldoFinal.BorderStyle = BorderStyle.FixedSingle;
            txtSaldoFinal.Enabled = false;
            txtSaldoFinal.Location = new Point(12, 265);
            txtSaldoFinal.Name = "txtSaldoFinal";
            txtSaldoFinal.Size = new Size(285, 22);
            txtSaldoFinal.TabIndex = 64;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("EngraversGothic BT", 10F);
            label7.ForeColor = Color.FromArgb(224, 224, 224);
            label7.Location = new Point(12, 247);
            label7.Name = "label7";
            label7.Size = new Size(76, 15);
            label7.TabIndex = 65;
            label7.Text = "Saldo Final";
            // 
            // txtResultado
            // 
            txtResultado.BackColor = Color.Gainsboro;
            txtResultado.BorderStyle = BorderStyle.FixedSingle;
            txtResultado.Enabled = false;
            txtResultado.Location = new Point(12, 364);
            txtResultado.Name = "txtResultado";
            txtResultado.ReadOnly = true;
            txtResultado.Size = new Size(285, 22);
            txtResultado.TabIndex = 66;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("EngraversGothic BT", 10F);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(12, 346);
            label9.Name = "label9";
            label9.Size = new Size(70, 15);
            label9.TabIndex = 67;
            label9.Text = "Resultado";
            // 
            // Frm_Cajas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Name = "Frm_Cajas";
            Text = "Frm_Cajas";
            Load += Frm_Cajas_Load;
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
        public ComboBox cmbCondicion;
        public TextBox txtSaldoInicial;
        public Label label6;
        public TextBox txtFechaCierre;
        public Label label5;
        public TextBox txtFechaApertura;
        public Label label3;
        public TextBox txtSaldoFinal;
        public Label label7;
        public TextBox txtResultado;
        public Label label9;
    }
}