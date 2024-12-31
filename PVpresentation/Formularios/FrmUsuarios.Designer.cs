namespace PVpresentation.Formularios
{
    partial class FrmUsuarios
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
            txtClaveNuevo = new TextBox();
            label6 = new Label();
            txtTelefonoNuevo = new TextBox();
            label5 = new Label();
            txtCorreoNuevo = new TextBox();
            label1 = new Label();
            txtNombreFotoNuevo = new TextBox();
            label8 = new Label();
            txtUrlFotoNuevo = new TextBox();
            label9 = new Label();
            label10 = new Label();
            cmbRolNuevo = new ComboBox();
            txtIDnuevo = new TextBox();
            txtFechaNuevo = new TextBox();
            label7 = new Label();
            cmbEsActivoNuevo = new ComboBox();
            label11 = new Label();
            cmbEsActivoEditar = new ComboBox();
            label12 = new Label();
            cmbRolEditar = new ComboBox();
            txtNombreFotoEditar = new TextBox();
            label13 = new Label();
            txtUrlFotoEditar = new TextBox();
            label14 = new Label();
            txtClaveEditar = new TextBox();
            label15 = new Label();
            txtTelefonoEditar = new TextBox();
            label16 = new Label();
            txtCorreoEditar = new TextBox();
            label17 = new Label();
            txtFechaEditar = new TextBox();
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
            txtBuscar.Location = new Point(203, 27);
            txtBuscar.Size = new Size(716, 22);
            // 
            // btnBuscar
            // 
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnBuscar.Location = new Point(925, 20);
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
            label4.Location = new Point(76, 67);
            label4.Size = new Size(55, 15);
            label4.Text = "Nombre";
            // 
            // txtNombreNuevo
            // 
            txtNombreNuevo.Location = new Point(76, 85);
            txtNombreNuevo.Size = new Size(379, 22);
            txtNombreNuevo.Enter += txtNombreNuevo_Enter;
            txtNombreNuevo.Leave += txtNombreNuevo_Leave;
            // 
            // btnGrabarNuevo
            // 
            btnGrabarNuevo.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnGrabarNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnGrabarNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnGrabarNuevo.TabIndex = 13;
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
            label3.Location = new Point(274, 286);
            label3.Size = new Size(19, 15);
            label3.Text = "ID";
            // 
            // label2
            // 
            label2.Location = new Point(70, 55);
            label2.Size = new Size(55, 15);
            label2.Text = "Nombre";
            // 
            // txtNombreEditar
            // 
            txtNombreEditar.Location = new Point(67, 72);
            txtNombreEditar.Size = new Size(394, 22);
            txtNombreEditar.Enter += txtNombreEditar_Enter;
            txtNombreEditar.Leave += txtNombreEditar_Leave;
            // 
            // txtIDEditar
            // 
            txtIDEditar.Location = new Point(299, 284);
            txtIDEditar.Size = new Size(59, 22);
            txtIDEditar.Visible = false;
            // 
            // btnGrabarEditar
            // 
            btnGrabarEditar.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnGrabarEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnGrabarEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnGrabarEditar.TabIndex = 17;
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
            lblTituloForm.Size = new Size(219, 20);
            lblTituloForm.Text = "Mantenimiento / Usuarios";
            // 
            // tabListado
            // 
            tabListado.Controls.Add(dgvListado);
            tabListado.Size = new Size(980, 541);
            tabListado.Controls.SetChildIndex(btnNuevo, 0);
            tabListado.Controls.SetChildIndex(btnBuscar, 0);
            tabListado.Controls.SetChildIndex(txtBuscar, 0);
            tabListado.Controls.SetChildIndex(dgvListado, 0);
            // 
            // tabNuevo
            // 
            tabNuevo.Controls.Add(label7);
            tabNuevo.Controls.Add(cmbEsActivoNuevo);
            tabNuevo.Controls.Add(txtFechaNuevo);
            tabNuevo.Controls.Add(txtIDnuevo);
            tabNuevo.Controls.Add(label10);
            tabNuevo.Controls.Add(cmbRolNuevo);
            tabNuevo.Controls.Add(txtNombreFotoNuevo);
            tabNuevo.Controls.Add(label8);
            tabNuevo.Controls.Add(txtUrlFotoNuevo);
            tabNuevo.Controls.Add(label9);
            tabNuevo.Controls.Add(txtClaveNuevo);
            tabNuevo.Controls.Add(label6);
            tabNuevo.Controls.Add(txtTelefonoNuevo);
            tabNuevo.Controls.Add(label5);
            tabNuevo.Controls.Add(txtCorreoNuevo);
            tabNuevo.Controls.Add(label1);
            tabNuevo.Size = new Size(980, 541);
            tabNuevo.Controls.SetChildIndex(txtOpcionNuevo, 0);
            tabNuevo.Controls.SetChildIndex(txtInstanciaNuevo, 0);
            tabNuevo.Controls.SetChildIndex(btnVolverNuevo, 0);
            tabNuevo.Controls.SetChildIndex(btnGrabarNuevo, 0);
            tabNuevo.Controls.SetChildIndex(txtNombreNuevo, 0);
            tabNuevo.Controls.SetChildIndex(label4, 0);
            tabNuevo.Controls.SetChildIndex(label1, 0);
            tabNuevo.Controls.SetChildIndex(txtCorreoNuevo, 0);
            tabNuevo.Controls.SetChildIndex(label5, 0);
            tabNuevo.Controls.SetChildIndex(txtTelefonoNuevo, 0);
            tabNuevo.Controls.SetChildIndex(label6, 0);
            tabNuevo.Controls.SetChildIndex(txtClaveNuevo, 0);
            tabNuevo.Controls.SetChildIndex(label9, 0);
            tabNuevo.Controls.SetChildIndex(txtUrlFotoNuevo, 0);
            tabNuevo.Controls.SetChildIndex(label8, 0);
            tabNuevo.Controls.SetChildIndex(txtNombreFotoNuevo, 0);
            tabNuevo.Controls.SetChildIndex(cmbRolNuevo, 0);
            tabNuevo.Controls.SetChildIndex(label10, 0);
            tabNuevo.Controls.SetChildIndex(txtIDnuevo, 0);
            tabNuevo.Controls.SetChildIndex(txtFechaNuevo, 0);
            tabNuevo.Controls.SetChildIndex(cmbEsActivoNuevo, 0);
            tabNuevo.Controls.SetChildIndex(label7, 0);
            // 
            // tabEditar
            // 
            tabEditar.Controls.Add(txtFechaEditar);
            tabEditar.Controls.Add(txtNombreFotoEditar);
            tabEditar.Controls.Add(label13);
            tabEditar.Controls.Add(txtUrlFotoEditar);
            tabEditar.Controls.Add(label14);
            tabEditar.Controls.Add(txtClaveEditar);
            tabEditar.Controls.Add(label15);
            tabEditar.Controls.Add(txtTelefonoEditar);
            tabEditar.Controls.Add(label16);
            tabEditar.Controls.Add(txtCorreoEditar);
            tabEditar.Controls.Add(label17);
            tabEditar.Controls.Add(label11);
            tabEditar.Controls.Add(cmbEsActivoEditar);
            tabEditar.Controls.Add(label12);
            tabEditar.Controls.Add(cmbRolEditar);
            tabEditar.Size = new Size(980, 541);
            tabEditar.Controls.SetChildIndex(txtOpcionEditar, 0);
            tabEditar.Controls.SetChildIndex(txtInstanciaEditar, 0);
            tabEditar.Controls.SetChildIndex(cmbRolEditar, 0);
            tabEditar.Controls.SetChildIndex(label12, 0);
            tabEditar.Controls.SetChildIndex(cmbEsActivoEditar, 0);
            tabEditar.Controls.SetChildIndex(label11, 0);
            tabEditar.Controls.SetChildIndex(label17, 0);
            tabEditar.Controls.SetChildIndex(txtCorreoEditar, 0);
            tabEditar.Controls.SetChildIndex(label16, 0);
            tabEditar.Controls.SetChildIndex(txtTelefonoEditar, 0);
            tabEditar.Controls.SetChildIndex(label15, 0);
            tabEditar.Controls.SetChildIndex(txtClaveEditar, 0);
            tabEditar.Controls.SetChildIndex(label14, 0);
            tabEditar.Controls.SetChildIndex(txtUrlFotoEditar, 0);
            tabEditar.Controls.SetChildIndex(label13, 0);
            tabEditar.Controls.SetChildIndex(txtNombreFotoEditar, 0);
            tabEditar.Controls.SetChildIndex(btnVolverEditar, 0);
            tabEditar.Controls.SetChildIndex(btnGrabarEditar, 0);
            tabEditar.Controls.SetChildIndex(txtIDEditar, 0);
            tabEditar.Controls.SetChildIndex(txtNombreEditar, 0);
            tabEditar.Controls.SetChildIndex(label2, 0);
            tabEditar.Controls.SetChildIndex(label3, 0);
            tabEditar.Controls.SetChildIndex(txtFechaEditar, 0);
            // 
            // tabControlMain
            // 
            tabControlMain.Location = new Point(0, 44);
            tabControlMain.Size = new Size(988, 579);
            // 
            // dgvListado
            // 
            dgvListado.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListado.Location = new Point(15, 68);
            dgvListado.Name = "dgvListado";
            dgvListado.Size = new Size(947, 459);
            dgvListado.TabIndex = 4;
            dgvListado.CellContentClick += dgvListado_CellContentClick;
            // 
            // txtClaveNuevo
            // 
            txtClaveNuevo.BackColor = Color.FromArgb(221, 217, 195);
            txtClaveNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtClaveNuevo.Location = new Point(76, 240);
            txtClaveNuevo.Name = "txtClaveNuevo";
            txtClaveNuevo.Size = new Size(379, 22);
            txtClaveNuevo.TabIndex = 8;
            txtClaveNuevo.Enter += txtClaveNuevo_Enter;
            txtClaveNuevo.Leave += txtClaveNuevo_Leave;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(76, 222);
            label6.Name = "label6";
            label6.Size = new Size(41, 15);
            label6.TabIndex = 22;
            label6.Text = "Clave";
            // 
            // txtTelefonoNuevo
            // 
            txtTelefonoNuevo.BackColor = Color.FromArgb(221, 217, 195);
            txtTelefonoNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtTelefonoNuevo.Location = new Point(76, 189);
            txtTelefonoNuevo.Name = "txtTelefonoNuevo";
            txtTelefonoNuevo.Size = new Size(379, 22);
            txtTelefonoNuevo.TabIndex = 7;
            txtTelefonoNuevo.Enter += txtTelefonoNuevo_Enter;
            txtTelefonoNuevo.Leave += txtTelefonoNuevo_Leave;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("EngraversGothic BT", 10F);
            label5.ForeColor = Color.WhiteSmoke;
            label5.Location = new Point(76, 171);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 20;
            label5.Text = "Teléfono";
            // 
            // txtCorreoNuevo
            // 
            txtCorreoNuevo.BackColor = Color.FromArgb(221, 217, 195);
            txtCorreoNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoNuevo.Location = new Point(76, 138);
            txtCorreoNuevo.Name = "txtCorreoNuevo";
            txtCorreoNuevo.Size = new Size(379, 22);
            txtCorreoNuevo.TabIndex = 6;
            txtCorreoNuevo.Enter += txtCorreoNuevo_Enter;
            txtCorreoNuevo.Leave += txtCorreoNuevo_Leave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("EngraversGothic BT", 10F);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(76, 120);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 18;
            label1.Text = "Correo";
            // 
            // txtNombreFotoNuevo
            // 
            txtNombreFotoNuevo.BackColor = Color.FromArgb(221, 217, 195);
            txtNombreFotoNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtNombreFotoNuevo.Location = new Point(493, 137);
            txtNombreFotoNuevo.Name = "txtNombreFotoNuevo";
            txtNombreFotoNuevo.Size = new Size(417, 22);
            txtNombreFotoNuevo.TabIndex = 10;
            txtNombreFotoNuevo.Enter += txtNombreFotoNuevo_Enter;
            txtNombreFotoNuevo.Leave += txtNombreFotoNuevo_Leave;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("EngraversGothic BT", 10F);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(493, 119);
            label8.Name = "label8";
            label8.Size = new Size(89, 15);
            label8.TabIndex = 26;
            label8.Text = "Nombre Foto";
            // 
            // txtUrlFotoNuevo
            // 
            txtUrlFotoNuevo.BackColor = Color.FromArgb(221, 217, 195);
            txtUrlFotoNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtUrlFotoNuevo.Location = new Point(493, 86);
            txtUrlFotoNuevo.Name = "txtUrlFotoNuevo";
            txtUrlFotoNuevo.Size = new Size(417, 22);
            txtUrlFotoNuevo.TabIndex = 9;
            txtUrlFotoNuevo.Enter += txtUrlFotoNuevo_Enter;
            txtUrlFotoNuevo.Leave += txtUrlFotoNuevo_Leave;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("EngraversGothic BT", 10F);
            label9.ForeColor = Color.WhiteSmoke;
            label9.Location = new Point(493, 68);
            label9.Name = "label9";
            label9.Size = new Size(64, 15);
            label9.TabIndex = 24;
            label9.Text = "URL Foto";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("EngraversGothic BT", 10F);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(494, 222);
            label10.Name = "label10";
            label10.Size = new Size(29, 15);
            label10.TabIndex = 31;
            label10.Text = "Rol";
            // 
            // cmbRolNuevo
            // 
            cmbRolNuevo.BackColor = Color.FromArgb(221, 217, 195);
            cmbRolNuevo.FormattingEnabled = true;
            cmbRolNuevo.Location = new Point(494, 240);
            cmbRolNuevo.Name = "cmbRolNuevo";
            cmbRolNuevo.Size = new Size(416, 22);
            cmbRolNuevo.TabIndex = 12;
            cmbRolNuevo.Enter += cmbRolNuevo_Enter;
            cmbRolNuevo.Leave += cmbRolNuevo_Leave;
            // 
            // txtIDnuevo
            // 
            txtIDnuevo.BorderStyle = BorderStyle.FixedSingle;
            txtIDnuevo.Location = new Point(343, 284);
            txtIDnuevo.Name = "txtIDnuevo";
            txtIDnuevo.Size = new Size(55, 22);
            txtIDnuevo.TabIndex = 32;
            txtIDnuevo.Visible = false;
            // 
            // txtFechaNuevo
            // 
            txtFechaNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtFechaNuevo.Location = new Point(461, 285);
            txtFechaNuevo.Name = "txtFechaNuevo";
            txtFechaNuevo.Size = new Size(97, 22);
            txtFechaNuevo.TabIndex = 33;
            txtFechaNuevo.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("EngraversGothic BT", 10F);
            label7.ForeColor = Color.WhiteSmoke;
            label7.Location = new Point(494, 171);
            label7.Name = "label7";
            label7.Size = new Size(64, 15);
            label7.TabIndex = 35;
            label7.Text = "Situación";
            // 
            // cmbEsActivoNuevo
            // 
            cmbEsActivoNuevo.BackColor = Color.FromArgb(221, 217, 195);
            cmbEsActivoNuevo.FormattingEnabled = true;
            cmbEsActivoNuevo.Location = new Point(494, 189);
            cmbEsActivoNuevo.Name = "cmbEsActivoNuevo";
            cmbEsActivoNuevo.Size = new Size(416, 22);
            cmbEsActivoNuevo.TabIndex = 11;
            cmbEsActivoNuevo.Enter += cmbEsActivoNuevo_Enter;
            cmbEsActivoNuevo.Leave += cmbEsActivoNuevo_Leave;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("EngraversGothic BT", 10F);
            label11.ForeColor = Color.WhiteSmoke;
            label11.Location = new Point(494, 158);
            label11.Name = "label11";
            label11.Size = new Size(64, 15);
            label11.TabIndex = 39;
            label11.Text = "Situación";
            // 
            // cmbEsActivoEditar
            // 
            cmbEsActivoEditar.BackColor = Color.FromArgb(221, 217, 195);
            cmbEsActivoEditar.FormattingEnabled = true;
            cmbEsActivoEditar.Location = new Point(494, 176);
            cmbEsActivoEditar.Name = "cmbEsActivoEditar";
            cmbEsActivoEditar.Size = new Size(421, 22);
            cmbEsActivoEditar.TabIndex = 15;
            cmbEsActivoEditar.Enter += cmbEsActivoEditar_Enter;
            cmbEsActivoEditar.Leave += cmbEsActivoEditar_Leave;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("EngraversGothic BT", 10F);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(494, 209);
            label12.Name = "label12";
            label12.Size = new Size(29, 15);
            label12.TabIndex = 37;
            label12.Text = "Rol";
            // 
            // cmbRolEditar
            // 
            cmbRolEditar.BackColor = Color.FromArgb(221, 217, 195);
            cmbRolEditar.FormattingEnabled = true;
            cmbRolEditar.Location = new Point(494, 227);
            cmbRolEditar.Name = "cmbRolEditar";
            cmbRolEditar.Size = new Size(421, 22);
            cmbRolEditar.TabIndex = 16;
            cmbRolEditar.Enter += cmbRolEditar_Enter;
            cmbRolEditar.Leave += cmbRolEditar_Leave;
            // 
            // txtNombreFotoEditar
            // 
            txtNombreFotoEditar.BackColor = Color.FromArgb(221, 217, 195);
            txtNombreFotoEditar.BorderStyle = BorderStyle.FixedSingle;
            txtNombreFotoEditar.Location = new Point(494, 124);
            txtNombreFotoEditar.Name = "txtNombreFotoEditar";
            txtNombreFotoEditar.Size = new Size(422, 22);
            txtNombreFotoEditar.TabIndex = 14;
            txtNombreFotoEditar.Enter += txtNombreFotoEditar_Enter;
            txtNombreFotoEditar.Leave += txtNombreFotoEditar_Leave;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("EngraversGothic BT", 10F);
            label13.ForeColor = Color.WhiteSmoke;
            label13.Location = new Point(494, 106);
            label13.Name = "label13";
            label13.Size = new Size(89, 15);
            label13.TabIndex = 48;
            label13.Text = "Nombre Foto";
            // 
            // txtUrlFotoEditar
            // 
            txtUrlFotoEditar.BackColor = Color.FromArgb(221, 217, 195);
            txtUrlFotoEditar.BorderStyle = BorderStyle.FixedSingle;
            txtUrlFotoEditar.Location = new Point(494, 73);
            txtUrlFotoEditar.Name = "txtUrlFotoEditar";
            txtUrlFotoEditar.Size = new Size(422, 22);
            txtUrlFotoEditar.TabIndex = 13;
            txtUrlFotoEditar.Enter += txtUrlFotoEditar_Enter;
            txtUrlFotoEditar.Leave += txtUrlFotoEditar_Leave;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("EngraversGothic BT", 10F);
            label14.ForeColor = Color.WhiteSmoke;
            label14.Location = new Point(494, 55);
            label14.Name = "label14";
            label14.Size = new Size(64, 15);
            label14.TabIndex = 46;
            label14.Text = "URL Foto";
            // 
            // txtClaveEditar
            // 
            txtClaveEditar.BackColor = Color.FromArgb(221, 217, 195);
            txtClaveEditar.BorderStyle = BorderStyle.FixedSingle;
            txtClaveEditar.Location = new Point(67, 227);
            txtClaveEditar.Name = "txtClaveEditar";
            txtClaveEditar.Size = new Size(395, 22);
            txtClaveEditar.TabIndex = 12;
            txtClaveEditar.Enter += txtClaveEditar_Enter;
            txtClaveEditar.Leave += txtClaveEditar_Leave;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("EngraversGothic BT", 10F);
            label15.ForeColor = Color.WhiteSmoke;
            label15.Location = new Point(67, 209);
            label15.Name = "label15";
            label15.Size = new Size(41, 15);
            label15.TabIndex = 44;
            label15.Text = "Clave";
            // 
            // txtTelefonoEditar
            // 
            txtTelefonoEditar.BackColor = Color.FromArgb(221, 217, 195);
            txtTelefonoEditar.BorderStyle = BorderStyle.FixedSingle;
            txtTelefonoEditar.Location = new Point(67, 176);
            txtTelefonoEditar.Name = "txtTelefonoEditar";
            txtTelefonoEditar.Size = new Size(395, 22);
            txtTelefonoEditar.TabIndex = 11;
            txtTelefonoEditar.Enter += txtTelefonoEditar_Enter;
            txtTelefonoEditar.Leave += txtTelefonoEditar_Leave;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("EngraversGothic BT", 10F);
            label16.ForeColor = Color.WhiteSmoke;
            label16.Location = new Point(67, 158);
            label16.Name = "label16";
            label16.Size = new Size(63, 15);
            label16.TabIndex = 42;
            label16.Text = "Teléfono";
            // 
            // txtCorreoEditar
            // 
            txtCorreoEditar.BackColor = Color.FromArgb(221, 217, 195);
            txtCorreoEditar.BorderStyle = BorderStyle.FixedSingle;
            txtCorreoEditar.Location = new Point(67, 125);
            txtCorreoEditar.Name = "txtCorreoEditar";
            txtCorreoEditar.Size = new Size(395, 22);
            txtCorreoEditar.TabIndex = 10;
            txtCorreoEditar.Enter += txtCorreoEditar_Enter;
            txtCorreoEditar.Leave += txtCorreoEditar_Leave;
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("EngraversGothic BT", 10F);
            label17.ForeColor = Color.WhiteSmoke;
            label17.Location = new Point(67, 107);
            label17.Name = "label17";
            label17.Size = new Size(54, 15);
            label17.TabIndex = 40;
            label17.Text = "Correo";
            // 
            // txtFechaEditar
            // 
            txtFechaEditar.BorderStyle = BorderStyle.FixedSingle;
            txtFechaEditar.Location = new Point(364, 284);
            txtFechaEditar.Name = "txtFechaEditar";
            txtFechaEditar.Size = new Size(97, 22);
            txtFechaEditar.TabIndex = 50;
            txtFechaEditar.Visible = false;
            // 
            // FrmUsuarios
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 625);
            MinimumSize = new Size(764, 407);
            Name = "FrmUsuarios";
            Text = "FrmUsuarios";
            Load += FrmUsuarios_Load;
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

        private DataGridView dgvListado;
        private TextBox txtNombreFotoNuevo;
        private Label label8;
        private TextBox txtUrlFotoNuevo;
        private Label label9;
        private TextBox txtClaveNuevo;
        private Label label6;
        private TextBox txtTelefonoNuevo;
        private Label label5;
        private TextBox txtCorreoNuevo;
        private Label label1;
        private Label label10;
        private ComboBox cmbRolNuevo;
        private TextBox txtFechaNuevo;
        private TextBox txtIDnuevo;
        private Label label7;
        private ComboBox cmbEsActivoNuevo;
        private Label label11;
        private ComboBox cmbEsActivoEditar;
        private Label label12;
        private ComboBox cmbRolEditar;
        private TextBox txtFechaEditar;
        private TextBox txtNombreFotoEditar;
        private Label label13;
        private TextBox txtUrlFotoEditar;
        private Label label14;
        private TextBox txtClaveEditar;
        private Label label15;
        private TextBox txtTelefonoEditar;
        private Label label16;
        private TextBox txtCorreoEditar;
        private Label label17;
    }
}