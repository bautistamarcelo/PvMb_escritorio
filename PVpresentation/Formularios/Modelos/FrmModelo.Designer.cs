namespace PVpresentation
{
    partial class FrmModelo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControlMain = new MiTabControl();
            tabListado = new TabPage();
            txtBuscar = new TextBox();
            btnBuscar = new Button();
            btnNuevo = new Button();
            tabNuevo = new TabPage();
            txtInstanciaNuevo = new TextBox();
            txtOpcionNuevo = new TextBox();
            label4 = new Label();
            txtNombreNuevo = new TextBox();
            btnGrabarNuevo = new Button();
            btnVolverNuevo = new Button();
            tabEditar = new TabPage();
            txtInstanciaEditar = new TextBox();
            txtOpcionEditar = new TextBox();
            label3 = new Label();
            label2 = new Label();
            txtNombreEditar = new TextBox();
            txtIDEditar = new TextBox();
            btnGrabarEditar = new Button();
            btnVolverEditar = new Button();
            pnTituloFormulario = new Panel();
            btnCierreVolver = new PictureBox();
            lblTituloForm = new Label();
            tabControlMain.SuspendLayout();
            tabListado.SuspendLayout();
            tabNuevo.SuspendLayout();
            tabEditar.SuspendLayout();
            pnTituloFormulario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).BeginInit();
            SuspendLayout();
            // 
            // tabControlMain
            // 
            tabControlMain.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tabControlMain.BottomBackColor = Color.Black;
            tabControlMain.BottomForeColor = Color.White;
            tabControlMain.Controls.Add(tabListado);
            tabControlMain.Controls.Add(tabNuevo);
            tabControlMain.Controls.Add(tabEditar);
            tabControlMain.Cursor = Cursors.Hand;
            tabControlMain.Font = new Font("EngraversGothic BT", 10F);
            tabControlMain.ItemSize = new Size(200, 30);
            tabControlMain.LineBackColor = Color.FromArgb(74, 134, 160);
            tabControlMain.LineForeColor = Color.White;
            tabControlMain.Location = new Point(12, 44);
            tabControlMain.Name = "tabControlMain";
            tabControlMain.Padding = new Point(3, 3);
            tabControlMain.SelectedIndex = 0;
            tabControlMain.Size = new Size(976, 569);
            tabControlMain.SizeMode = TabSizeMode.Fixed;
            tabControlMain.TabIndex = 4;
            tabControlMain.TabStyle = MiTabControl.Style.Line;
            // 
            // tabListado
            // 
            tabListado.BackColor = Color.FromArgb(74, 134, 160);
            tabListado.Controls.Add(txtBuscar);
            tabListado.Controls.Add(btnBuscar);
            tabListado.Controls.Add(btnNuevo);
            tabListado.Location = new Point(4, 34);
            tabListado.Name = "tabListado";
            tabListado.Padding = new Padding(3);
            tabListado.Size = new Size(968, 531);
            tabListado.TabIndex = 0;
            tabListado.Text = "Listado";
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = Color.FromArgb(221, 217, 195);
            txtBuscar.BorderStyle = BorderStyle.FixedSingle;
            txtBuscar.Location = new Point(207, 31);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(677, 22);
            txtBuscar.TabIndex = 2;
            txtBuscar.Enter += txtBuscar_Enter;
            txtBuscar.Leave += txtBuscar_Leave;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImageLayout = ImageLayout.Stretch;
            btnBuscar.Cursor = Cursors.Hand;
            btnBuscar.FlatAppearance.BorderSize = 0;
            btnBuscar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnBuscar.FlatStyle = FlatStyle.Flat;
            btnBuscar.ForeColor = Color.FromArgb(23, 54, 93);
            btnBuscar.Image = Properties.Resources.Lupa;
            btnBuscar.Location = new Point(890, 24);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(37, 32);
            btnBuscar.TabIndex = 1;
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.BackColor = Color.FromArgb(221, 217, 195);
            btnNuevo.Cursor = Cursors.Hand;
            btnNuevo.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnNuevo.FlatStyle = FlatStyle.Flat;
            btnNuevo.ForeColor = Color.FromArgb(23, 54, 93);
            btnNuevo.Location = new Point(17, 24);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(86, 32);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = false;
            // 
            // tabNuevo
            // 
            tabNuevo.BackColor = Color.FromArgb(74, 134, 160);
            tabNuevo.Controls.Add(txtInstanciaNuevo);
            tabNuevo.Controls.Add(txtOpcionNuevo);
            tabNuevo.Controls.Add(label4);
            tabNuevo.Controls.Add(txtNombreNuevo);
            tabNuevo.Controls.Add(btnGrabarNuevo);
            tabNuevo.Controls.Add(btnVolverNuevo);
            tabNuevo.Location = new Point(4, 34);
            tabNuevo.Name = "tabNuevo";
            tabNuevo.Padding = new Padding(3);
            tabNuevo.Size = new Size(968, 531);
            tabNuevo.TabIndex = 1;
            tabNuevo.Text = "Nueva";
            // 
            // txtInstanciaNuevo
            // 
            txtInstanciaNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtInstanciaNuevo.Location = new Point(365, 489);
            txtInstanciaNuevo.Name = "txtInstanciaNuevo";
            txtInstanciaNuevo.Size = new Size(34, 22);
            txtInstanciaNuevo.TabIndex = 43;
            txtInstanciaNuevo.Text = "0";
            txtInstanciaNuevo.Visible = false;
            // 
            // txtOpcionNuevo
            // 
            txtOpcionNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtOpcionNuevo.Location = new Point(325, 489);
            txtOpcionNuevo.Name = "txtOpcionNuevo";
            txtOpcionNuevo.Size = new Size(34, 22);
            txtOpcionNuevo.TabIndex = 42;
            txtOpcionNuevo.Text = "0";
            txtOpcionNuevo.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("EngraversGothic BT", 10F);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(24, 38);
            label4.Name = "label4";
            label4.Size = new Size(120, 15);
            label4.TabIndex = 11;
            label4.Text = "Nombre Categoría";
            // 
            // txtNombreNuevo
            // 
            txtNombreNuevo.BackColor = Color.FromArgb(221, 217, 195);
            txtNombreNuevo.BorderStyle = BorderStyle.FixedSingle;
            txtNombreNuevo.Location = new Point(21, 55);
            txtNombreNuevo.Name = "txtNombreNuevo";
            txtNombreNuevo.Size = new Size(923, 22);
            txtNombreNuevo.TabIndex = 5;
            txtNombreNuevo.Enter += txtNombreNuevo_Enter;
            txtNombreNuevo.Leave += txtNombreNuevo_Leave;
            // 
            // btnGrabarNuevo
            // 
            btnGrabarNuevo.BackColor = Color.FromArgb(221, 217, 195);
            btnGrabarNuevo.Cursor = Cursors.Hand;
            btnGrabarNuevo.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnGrabarNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnGrabarNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnGrabarNuevo.FlatStyle = FlatStyle.Flat;
            btnGrabarNuevo.Font = new Font("EngraversGothic BT", 11F);
            btnGrabarNuevo.ForeColor = Color.FromArgb(23, 54, 93);
            btnGrabarNuevo.Location = new Point(858, 482);
            btnGrabarNuevo.Name = "btnGrabarNuevo";
            btnGrabarNuevo.Size = new Size(86, 32);
            btnGrabarNuevo.TabIndex = 4;
            btnGrabarNuevo.Text = "Grabar";
            btnGrabarNuevo.UseVisualStyleBackColor = true;
            // 
            // btnVolverNuevo
            // 
            btnVolverNuevo.BackColor = Color.FromArgb(221, 217, 195);
            btnVolverNuevo.Cursor = Cursors.Hand;
            btnVolverNuevo.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnVolverNuevo.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnVolverNuevo.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnVolverNuevo.FlatStyle = FlatStyle.Flat;
            btnVolverNuevo.Font = new Font("EngraversGothic BT", 11F);
            btnVolverNuevo.ForeColor = Color.FromArgb(23, 54, 93);
            btnVolverNuevo.Location = new Point(23, 482);
            btnVolverNuevo.Name = "btnVolverNuevo";
            btnVolverNuevo.Size = new Size(86, 32);
            btnVolverNuevo.TabIndex = 3;
            btnVolverNuevo.Text = "Volver";
            btnVolverNuevo.UseVisualStyleBackColor = true;
            btnVolverNuevo.Click += btnVolverNuevo_Click;
            // 
            // tabEditar
            // 
            tabEditar.BackColor = Color.FromArgb(74, 134, 160);
            tabEditar.Controls.Add(txtInstanciaEditar);
            tabEditar.Controls.Add(txtOpcionEditar);
            tabEditar.Controls.Add(label3);
            tabEditar.Controls.Add(label2);
            tabEditar.Controls.Add(txtNombreEditar);
            tabEditar.Controls.Add(txtIDEditar);
            tabEditar.Controls.Add(btnGrabarEditar);
            tabEditar.Controls.Add(btnVolverEditar);
            tabEditar.Location = new Point(4, 34);
            tabEditar.Name = "tabEditar";
            tabEditar.Padding = new Padding(3);
            tabEditar.Size = new Size(968, 531);
            tabEditar.TabIndex = 2;
            tabEditar.Text = "Editar";
            // 
            // txtInstanciaEditar
            // 
            txtInstanciaEditar.BorderStyle = BorderStyle.FixedSingle;
            txtInstanciaEditar.Location = new Point(364, 487);
            txtInstanciaEditar.Name = "txtInstanciaEditar";
            txtInstanciaEditar.Size = new Size(34, 22);
            txtInstanciaEditar.TabIndex = 43;
            txtInstanciaEditar.Text = "0";
            txtInstanciaEditar.Visible = false;
            // 
            // txtOpcionEditar
            // 
            txtOpcionEditar.BorderStyle = BorderStyle.FixedSingle;
            txtOpcionEditar.Location = new Point(324, 487);
            txtOpcionEditar.Name = "txtOpcionEditar";
            txtOpcionEditar.Size = new Size(34, 22);
            txtOpcionEditar.TabIndex = 42;
            txtOpcionEditar.Text = "0";
            txtOpcionEditar.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("EngraversGothic BT", 10F);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(24, 38);
            label3.Name = "label3";
            label3.Size = new Size(84, 15);
            label3.TabIndex = 11;
            label3.Text = "ID Categoría";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("EngraversGothic BT", 10F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(24, 96);
            label2.Name = "label2";
            label2.Size = new Size(120, 15);
            label2.TabIndex = 10;
            label2.Text = "Nombre Categoría";
            // 
            // txtNombreEditar
            // 
            txtNombreEditar.BackColor = Color.FromArgb(221, 217, 195);
            txtNombreEditar.BorderStyle = BorderStyle.FixedSingle;
            txtNombreEditar.Location = new Point(21, 113);
            txtNombreEditar.Name = "txtNombreEditar";
            txtNombreEditar.Size = new Size(915, 22);
            txtNombreEditar.TabIndex = 9;
            // 
            // txtIDEditar
            // 
            txtIDEditar.BackColor = Color.FromArgb(221, 217, 195);
            txtIDEditar.BorderStyle = BorderStyle.FixedSingle;
            txtIDEditar.Location = new Point(21, 55);
            txtIDEditar.Name = "txtIDEditar";
            txtIDEditar.Size = new Size(915, 22);
            txtIDEditar.TabIndex = 8;
            // 
            // btnGrabarEditar
            // 
            btnGrabarEditar.BackColor = Color.FromArgb(221, 217, 195);
            btnGrabarEditar.Cursor = Cursors.Hand;
            btnGrabarEditar.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnGrabarEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnGrabarEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnGrabarEditar.FlatStyle = FlatStyle.Flat;
            btnGrabarEditar.Font = new Font("EngraversGothic BT", 11F);
            btnGrabarEditar.ForeColor = Color.FromArgb(23, 54, 93);
            btnGrabarEditar.Location = new Point(850, 480);
            btnGrabarEditar.Name = "btnGrabarEditar";
            btnGrabarEditar.Size = new Size(86, 32);
            btnGrabarEditar.TabIndex = 7;
            btnGrabarEditar.Text = "Grabar";
            btnGrabarEditar.UseVisualStyleBackColor = true;
            // 
            // btnVolverEditar
            // 
            btnVolverEditar.BackColor = Color.FromArgb(221, 217, 195);
            btnVolverEditar.Cursor = Cursors.Hand;
            btnVolverEditar.FlatAppearance.BorderColor = Color.FromArgb(168, 158, 100);
            btnVolverEditar.FlatAppearance.MouseDownBackColor = Color.FromArgb(84, 141, 212);
            btnVolverEditar.FlatAppearance.MouseOverBackColor = Color.FromArgb(161, 192, 100);
            btnVolverEditar.FlatStyle = FlatStyle.Flat;
            btnVolverEditar.Font = new Font("EngraversGothic BT", 11F);
            btnVolverEditar.ForeColor = Color.FromArgb(23, 54, 93);
            btnVolverEditar.Location = new Point(21, 477);
            btnVolverEditar.Name = "btnVolverEditar";
            btnVolverEditar.Size = new Size(86, 32);
            btnVolverEditar.TabIndex = 6;
            btnVolverEditar.Text = "Volver";
            btnVolverEditar.UseVisualStyleBackColor = true;
            btnVolverEditar.Click += btnVolverEditar_Click;
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.BackColor = Color.FromArgb(84, 141, 212);
            pnTituloFormulario.Controls.Add(btnCierreVolver);
            pnTituloFormulario.Controls.Add(lblTituloForm);
            pnTituloFormulario.Dock = DockStyle.Top;
            pnTituloFormulario.Location = new Point(0, 0);
            pnTituloFormulario.Margin = new Padding(0);
            pnTituloFormulario.Name = "pnTituloFormulario";
            pnTituloFormulario.Size = new Size(1000, 41);
            pnTituloFormulario.TabIndex = 7;
            // 
            // btnCierreVolver
            // 
            btnCierreVolver.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCierreVolver.Cursor = Cursors.Hand;
            btnCierreVolver.Image = Properties.Resources.left_arrow__1_;
            btnCierreVolver.Location = new Point(957, 3);
            btnCierreVolver.Name = "btnCierreVolver";
            btnCierreVolver.Size = new Size(31, 35);
            btnCierreVolver.SizeMode = PictureBoxSizeMode.Zoom;
            btnCierreVolver.TabIndex = 6;
            btnCierreVolver.TabStop = false;
            btnCierreVolver.Click += btnCierreVolver_Click;
            // 
            // lblTituloForm
            // 
            lblTituloForm.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lblTituloForm.AutoSize = true;
            lblTituloForm.Font = new Font("EngraversGothic BT", 14F);
            lblTituloForm.ForeColor = Color.White;
            lblTituloForm.Location = new Point(16, 9);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(300, 20);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Formulario Modelo Mantenimiento";
            // 
            // FrmModelo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 134, 160);
            ClientSize = new Size(1000, 625);
            Controls.Add(pnTituloFormulario);
            Controls.Add(tabControlMain);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmModelo";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += FrmModelo_Load;
            tabControlMain.ResumeLayout(false);
            tabListado.ResumeLayout(false);
            tabListado.PerformLayout();
            tabNuevo.ResumeLayout(false);
            tabNuevo.PerformLayout();
            tabEditar.ResumeLayout(false);
            tabEditar.PerformLayout();
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnCierreVolver).EndInit();
            ResumeLayout(false);
        }

        #endregion
        public TextBox textBox1;
        public TextBox txtBuscar;
        public Button btnBuscar;
        public Button btnNuevo;
        public Label label4;
        public TextBox txtNombreNuevo;
        public Button btnGrabarNuevo;
        public Button btnVolverNuevo;
        public Label label3;
        public Label label2;
        public TextBox txtNombreEditar;
        public TextBox txtIDEditar;
        public Button btnGrabarEditar;
        public Button btnVolverEditar;
        public Panel pnTituloFormulario;
        public Label lblTituloForm;
        public TabPage tabListado;
        public TabPage tabNuevo;
        public TabPage tabEditar;
        public MiTabControl tabControlMain;
        private PictureBox btnCierreVolver;
        public TextBox txtInstanciaNuevo;
        public TextBox txtOpcionNuevo;
        public TextBox txtOpcionEditar;
        public TextBox txtInstanciaEditar;
    }
}
