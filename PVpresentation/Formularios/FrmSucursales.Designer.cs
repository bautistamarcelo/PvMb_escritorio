namespace PVpresentation.Formularios
{
    partial class FrmSucursales
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
            dgvListado = new DataGridView();
            label12 = new Label();
            cmbEmpresaEditar = new ComboBox();
            txtTelefonoEditar = new TextBox();
            label15 = new Label();
            txtEmailEditar = new TextBox();
            label16 = new Label();
            txtDireccionEditar = new TextBox();
            label17 = new Label();
            label8 = new Label();
            cmbEmpresaNuevo = new ComboBox();
            txtTelefonoNuevo = new TextBox();
            label6 = new Label();
            txtEmailNuevo = new TextBox();
            label5 = new Label();
            txtDireccionNuevo = new TextBox();
            label1 = new Label();
            txtIDnuevo = new TextBox();
            pnTituloFormulario.SuspendLayout();
            tabListado.SuspendLayout();
            tabNuevo.SuspendLayout();
            tabEditar.SuspendLayout();
            tabControlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvListado).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Size = new Size(713, 22);
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnBuscar.Location = new Point(926, 24);
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNuevo
            // 
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnNuevo.Click += btnNuevo_Click;
            // 
            // label4
            // 
            label4.Location = new Point(55, 63);
            // 
            // txtNombreNuevo
            // 
            txtNombreNuevo.Location = new Point(55, 81);
            txtNombreNuevo.Size = new Size(389, 22);
            txtNombreNuevo.Enter += txtNombreNuevo_Enter;
            txtNombreNuevo.Leave += txtNombreNuevo_Leave;
            // 
            // btnGrabarNuevo
            // 
            btnGrabarNuevo.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnGrabarNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnGrabarNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnGrabarNuevo.TabIndex = 10;
            btnGrabarNuevo.Click += btnGrabarNuevo_Click;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnVolverNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnVolverNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnVolverNuevo.Click += btnVolverNuevo_Click;
            // 
            // label3
            // 
            label3.Location = new Point(371, 251);
            label3.Size = new Size(19, 15);
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.Location = new Point(58, 64);
            // 
            // txtNombreEditar
            // 
            txtNombreEditar.Location = new Point(58, 82);
            txtNombreEditar.Size = new Size(386, 22);
            txtNombreEditar.Enter += txtNombreEditar_Enter;
            txtNombreEditar.Leave += txtNombreEditar_Leave;
            // 
            // txtIDEditar
            // 
            txtIDEditar.Location = new Point(368, 268);
            txtIDEditar.Size = new Size(25, 22);
            // 
            // btnGrabarEditar
            // 
            btnGrabarEditar.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnGrabarEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnGrabarEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnGrabarEditar.TabIndex = 14;
            btnGrabarEditar.Click += btnGrabarEditar_Click;
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnVolverEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnVolverEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnVolverEditar.Click += btnVolverEditar_Click;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Size = new Size(244, 20);
            lblTituloForm.Text = "Mantenimiento / Sucursales";
            // 
            // tabListado
            // 
            tabListado.Controls.Add(dgvListado);
            tabListado.Size = new Size(992, 541);
            tabListado.Controls.SetChildIndex(btnNuevo, 0);
            tabListado.Controls.SetChildIndex(btnBuscar, 0);
            tabListado.Controls.SetChildIndex(txtBuscar, 0);
            tabListado.Controls.SetChildIndex(dgvListado, 0);
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(txtIDnuevo);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(cmbEmpresaNuevo);
            tabNuevo.Controls.Add(txtTelefonoNuevo);
            tabNuevo.Controls.Add(label6);
            tabNuevo.Controls.Add(txtEmailNuevo);
            tabNuevo.Controls.Add(label5);
            tabNuevo.Controls.Add(txtDireccionNuevo);
            tabNuevo.Controls.Add(label1);
            tabNuevo.Size = new Size(992, 541);
            tabNuevo.Controls.SetChildIndex(txtOpcionNuevo, 0);
            tabNuevo.Controls.SetChildIndex(txtInstanciaNuevo, 0);
            tabNuevo.Controls.SetChildIndex(btnVolverNuevo, 0);
            tabNuevo.Controls.SetChildIndex(btnGrabarNuevo, 0);
            tabNuevo.Controls.SetChildIndex(txtNombreNuevo, 0);
            tabNuevo.Controls.SetChildIndex(label4, 0);
            tabNuevo.Controls.SetChildIndex(label1, 0);
            tabNuevo.Controls.SetChildIndex(txtDireccionNuevo, 0);
            tabNuevo.Controls.SetChildIndex(label5, 0);
            tabNuevo.Controls.SetChildIndex(txtEmailNuevo, 0);
            tabNuevo.Controls.SetChildIndex(label6, 0);
            tabNuevo.Controls.SetChildIndex(txtTelefonoNuevo, 0);
            tabNuevo.Controls.SetChildIndex(cmbEmpresaNuevo, 0);
            tabNuevo.Controls.SetChildIndex(label8, 0);
            tabNuevo.Controls.SetChildIndex(txtIDnuevo, 0);
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(label12);
            tabEditar.Controls.Add(cmbEmpresaEditar);
            tabEditar.Controls.Add(txtTelefonoEditar);
            tabEditar.Controls.Add(label15);
            tabEditar.Controls.Add(txtEmailEditar);
            tabEditar.Controls.Add(label16);
            tabEditar.Controls.Add(txtDireccionEditar);
            tabEditar.Controls.Add(label17);
            tabEditar.Controls.SetChildIndex(txtOpcionEditar, 0);
            tabEditar.Controls.SetChildIndex(txtInstanciaEditar, 0);
            tabEditar.Controls.SetChildIndex(btnVolverEditar, 0);
            tabEditar.Controls.SetChildIndex(btnGrabarEditar, 0);
            tabEditar.Controls.SetChildIndex(txtIDEditar, 0);
            tabEditar.Controls.SetChildIndex(txtNombreEditar, 0);
            tabEditar.Controls.SetChildIndex(label2, 0);
            tabEditar.Controls.SetChildIndex(label3, 0);
            tabEditar.Controls.SetChildIndex(label17, 0);
            tabEditar.Controls.SetChildIndex(txtDireccionEditar, 0);
            tabEditar.Controls.SetChildIndex(label16, 0);
            tabEditar.Controls.SetChildIndex(txtEmailEditar, 0);
            tabEditar.Controls.SetChildIndex(label15, 0);
            tabEditar.Controls.SetChildIndex(txtTelefonoEditar, 0);
            tabEditar.Controls.SetChildIndex(cmbEmpresaEditar, 0);
            tabEditar.Controls.SetChildIndex(label12, 0);
            // 
            // tabControlMain
            // 
            tabControlMain.Location = new Point(0, 44);
            tabControlMain.Size = new Size(1000, 579);
            // 
            // dgvListado
            // 
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(17, 72);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(946, 446);
            dgvListado.TabIndex = 5;
            dgvListado.CellContentClick += dgvListado_CellContentClick;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("EngraversGothic BT", 10F);
            label12.ForeColor = Color.FromArgb(224, 224, 224);
            label12.Location = new Point(478, 118);
            label12.Name = "label12";
            label12.Size = new Size(58, 15);
            label12.TabIndex = 62;
            label12.Text = "Empresa";
            // 
            // cmbEmpresaEditar
            // 
            cmbEmpresaEditar.BackColor = Color.FromArgb(221, 217, 195);
            cmbEmpresaEditar.FormattingEnabled = true;
            cmbEmpresaEditar.Location = new Point(478, 137);
            cmbEmpresaEditar.Name = "cmbEmpresaEditar";
            cmbEmpresaEditar.Size = new Size(458, 22);
            cmbEmpresaEditar.TabIndex = 13;
            cmbEmpresaEditar.Enter += cmbEmpresaEditar_Enter;
            cmbEmpresaEditar.Leave += cmbEmpresaEditar_Leave;
            // 
            // txtTelefonoEditar
            // 
            txtTelefonoEditar.BackColor = Color.FromArgb(221, 217, 195);
            txtTelefonoEditar.BorderStyle = BorderStyle.FixedSingle;
            txtTelefonoEditar.Location = new Point(58, 200);
            txtTelefonoEditar.Name = "txtTelefonoEditar";
            txtTelefonoEditar.Size = new Size(386, 22);
            txtTelefonoEditar.TabIndex = 11;
            txtTelefonoEditar.Enter += txtTelefonoEditar_Enter;
            txtTelefonoEditar.Leave += txtTelefonoEditar_Leave;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("EngraversGothic BT", 10F);
            label15.ForeColor = Color.FromArgb(224, 224, 224);
            label15.Location = new Point(58, 182);
            label15.Name = "label15";
            label15.Size = new Size(74, 15);
            label15.TabIndex = 61;
            label15.Text = "Teléfono/s";
            // 
            // txtEmailEditar
            // 
            txtEmailEditar.BackColor = Color.FromArgb(221, 217, 195);
            txtEmailEditar.BorderStyle = BorderStyle.FixedSingle;
            txtEmailEditar.Location = new Point(478, 80);
            txtEmailEditar.Name = "txtEmailEditar";
            txtEmailEditar.Size = new Size(459, 22);
            txtEmailEditar.TabIndex = 12;
            txtEmailEditar.Enter += txtEmailEditar_Enter;
            txtEmailEditar.Leave += txtEmailEditar_Leave;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("EngraversGothic BT", 10F);
            label16.ForeColor = Color.FromArgb(224, 224, 224);
            label16.Location = new Point(478, 62);
            label16.Name = "label16";
            label16.Size = new Size(38, 15);
            label16.TabIndex = 60;
            label16.Text = "Email";
            // 
            // txtDireccionEditar
            // 
            txtDireccionEditar.BackColor = Color.FromArgb(221, 217, 195);
            txtDireccionEditar.BorderStyle = BorderStyle.FixedSingle;
            txtDireccionEditar.Location = new Point(58, 138);
            txtDireccionEditar.Name = "txtDireccionEditar";
            txtDireccionEditar.Size = new Size(386, 22);
            txtDireccionEditar.TabIndex = 10;
            txtDireccionEditar.Enter += txtDireccionEditar_Enter;
            txtDireccionEditar.Leave += txtDireccionEditar_Leave;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("EngraversGothic BT", 10F);
            label17.ForeColor = Color.FromArgb(224, 224, 224);
            label17.Location = new Point(58, 120);
            label17.Name = "label17";
            label17.Size = new Size(68, 15);
            label17.TabIndex = 59;
            label17.Text = "Direccion";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(55, 256);
            label8.Name = "label8";
            label8.Size = new Size(58, 15);
            label8.TabIndex = 47;
            label8.Text = "Empresa";
            // 
            // cmbEmpresaNuevo
            // 
            cmbEmpresaNuevo.BackColor = Color.FromArgb(221, 217, 195);
            cmbEmpresaNuevo.FormattingEnabled = true;
            cmbEmpresaNuevo.Location = new Point(55, 275);
            cmbEmpresaNuevo.Name = "cmbEmpresaNuevo";
            cmbEmpresaNuevo.Size = new Size(244, 22);
            cmbEmpresaNuevo.TabIndex = 9;
            cmbEmpresaNuevo.Enter += cmbEmpresaNuevo_Enter;
            cmbEmpresaNuevo.Leave += cmbEmpresaNuevo_Leave;
            // 
            // txtTelefonoNuevo
            // 
            txtTelefonoNuevo.BackColor = Color.FromArgb(221, 217, 195);
            txtTelefonoNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtTelefonoNuevo.Location = new Point(55, 179);
            txtTelefonoNuevo.Name = "txtTelefonoNuevo";
            txtTelefonoNuevo.Size = new Size(244, 22);
            txtTelefonoNuevo.TabIndex = 7;
            txtTelefonoNuevo.Enter += txtTelefonoNuevo_Enter;
            txtTelefonoNuevo.Leave += txtTelefonoNuevo_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(55, 161);
            label6.Name = "label6";
            label6.Size = new Size(74, 15);
            label6.TabIndex = 46;
            label6.Text = "Teléfono/s";
            // 
            // txtEmailNuevo
            // 
            txtEmailNuevo.BackColor = Color.FromArgb(221, 217, 195);
            txtEmailNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtEmailNuevo.Location = new Point(55, 224);
            txtEmailNuevo.Name = "txtEmailNuevo";
            txtEmailNuevo.Size = new Size(245, 22);
            txtEmailNuevo.TabIndex = 8;
            txtEmailNuevo.Enter += txtEmailNuevo_Enter;
            txtEmailNuevo.Leave += txtEmailNuevo_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(55, 206);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 45;
            label5.Text = "Email";
            // 
            // txtDireccionNuevo
            // 
            txtDireccionNuevo.BackColor = Color.FromArgb(221, 217, 195);
            txtDireccionNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtDireccionNuevo.Location = new Point(55, 132);
            txtDireccionNuevo.Name = "txtDireccionNuevo";
            txtDireccionNuevo.Size = new Size(244, 22);
            txtDireccionNuevo.TabIndex = 6;
            txtDireccionNuevo.Enter += txtDireccionNuevo_Enter;
            txtDireccionNuevo.Leave += txtDireccionNuevo_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("EngraversGothic BT", 10F);
            label1.ForeColor = Color.FromArgb(224, 224, 224);
            label1.Location = new Point(55, 114);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 44;
            label1.Text = "Direccion";
            // 
            // txtIDnuevo
            // 
            txtIDnuevo.BorderStyle = BorderStyle.FixedSingle;
            txtIDnuevo.Location = new Point(618, 441);
            txtIDnuevo.Name = "txtIDnuevo";
            txtIDnuevo.Size = new Size(34, 22);
            txtIDnuevo.TabIndex = 48;
            txtIDnuevo.Visible = false;
            // 
            // FrmSucursales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 625);
            MinimumSize = new Size(764, 407);
            Name = "FrmSucursales";
            Text = "FrmSucursales";
            Load += FrmSucursales_Load;
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            tabListado.ResumeLayout(false);
            tabListado.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            tabControlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvListado).EndInit();
            ResumeLayout(false);
        }

        #endregion

        public DataGridView dgvListado;
        public Label label12;
        public ComboBox cmbEmpresaEditar;
        public TextBox txtTelefonoEditar;
        public Label label15;
        public TextBox txtEmailEditar;
        public Label label16;
        public TextBox txtDireccionEditar;
        public Label label17;
        public Label label8;
        public ComboBox cmbEmpresaNuevo;
        public TextBox txtTelefonoNuevo;
        public Label label6;
        public TextBox txtEmailNuevo;
        public Label label5;
        public TextBox txtDireccionNuevo;
        public Label label1;
        public TextBox txtIDnuevo;
    }
}