namespace PVpresentation.Formularios
{
    partial class Frm_EtiquetasCantidad
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
            txtCondicion = new TextBox();
            txtInstancia = new TextBox();
            txtOpcion = new TextBox();
            lblTituloForm = new Label();
            pnMantenimiento = new Panel();
            txtCantidad = new TextBox();
            label6 = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            pnTituloFormulario.SuspendLayout();
            pnMantenimiento.SuspendLayout();
            SuspendLayout();
            // 
            // pnTituloFormulario
            // 
            pnTituloFormulario.BackColor = Color.FromArgb(74, 134, 160);
            pnTituloFormulario.Controls.Add(txtCondicion);
            pnTituloFormulario.Controls.Add(txtInstancia);
            pnTituloFormulario.Controls.Add(txtOpcion);
            pnTituloFormulario.Controls.Add(lblTituloForm);
            pnTituloFormulario.Dock = DockStyle.Top;
            pnTituloFormulario.Location = new Point(0, 0);
            pnTituloFormulario.Margin = new Padding(0);
            pnTituloFormulario.Name = "pnTituloFormulario";
            pnTituloFormulario.Size = new Size(445, 50);
            pnTituloFormulario.TabIndex = 53;
            // 
            // txtCondicion
            // 
            txtCondicion.BorderStyle = BorderStyle.FixedSingle;
            txtCondicion.Location = new Point(408, 0);
            txtCondicion.Name = "txtCondicion";
            txtCondicion.Size = new Size(34, 23);
            txtCondicion.TabIndex = 48;
            txtCondicion.Text = "0";
            txtCondicion.Visible = false;
            // 
            // txtInstancia
            // 
            txtInstancia.BorderStyle = BorderStyle.FixedSingle;
            txtInstancia.Location = new Point(408, 24);
            txtInstancia.Name = "txtInstancia";
            txtInstancia.Size = new Size(34, 23);
            txtInstancia.TabIndex = 47;
            txtInstancia.Text = "0";
            txtInstancia.Visible = false;
            // 
            // txtOpcion
            // 
            txtOpcion.BorderStyle = BorderStyle.FixedSingle;
            txtOpcion.Location = new Point(408, 10);
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
            lblTituloForm.Location = new Point(20, 10);
            lblTituloForm.Name = "lblTituloForm";
            lblTituloForm.Size = new Size(413, 28);
            lblTituloForm.TabIndex = 4;
            lblTituloForm.Text = "Ingrese la Cantidad de Etiquetas ";
            // 
            // pnMantenimiento
            // 
            pnMantenimiento.BackColor = Color.FromArgb(4, 41, 68);
            pnMantenimiento.Controls.Add(txtCantidad);
            pnMantenimiento.Controls.Add(label6);
            pnMantenimiento.Controls.Add(btnCancelar);
            pnMantenimiento.Controls.Add(btnAceptar);
            pnMantenimiento.Dock = DockStyle.Top;
            pnMantenimiento.Location = new Point(0, 50);
            pnMantenimiento.Name = "pnMantenimiento";
            pnMantenimiento.Size = new Size(445, 364);
            pnMantenimiento.TabIndex = 54;
            // 
            // txtCantidad
            // 
            txtCantidad.BackColor = Color.FromArgb(224, 224, 224);
            txtCantidad.BorderStyle = BorderStyle.FixedSingle;
            txtCantidad.Font = new Font("Copperplate Gothic Light", 12F);
            txtCantidad.ForeColor = Color.Black;
            txtCantidad.Location = new Point(137, 19);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(228, 25);
            txtCantidad.TabIndex = 0;
            txtCantidad.Text = "1";
            txtCantidad.TextAlign = HorizontalAlignment.Center;
            txtCantidad.KeyDown += txtCantidad_KeyDown;
            txtCantidad.KeyPress += txtCantidad_KeyPress;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("EngraversGothic BT", 10F);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(69, 24);
            label6.Name = "label6";
            label6.Size = new Size(62, 15);
            label6.TabIndex = 72;
            label6.Text = "Cantidad:";
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
            btnCancelar.Location = new Point(279, 76);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(86, 32);
            btnCancelar.TabIndex = 21;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.BackColor = Color.SteelBlue;
            btnAceptar.Cursor = Cursors.Hand;
            btnAceptar.FlatAppearance.BorderColor = Color.FromArgb(45, 45, 48);
            btnAceptar.FlatAppearance.MouseDownBackColor = Color.FromArgb(45, 45, 48);
            btnAceptar.FlatAppearance.MouseOverBackColor = Color.FromArgb(84, 141, 212);
            btnAceptar.FlatStyle = FlatStyle.Flat;
            btnAceptar.ForeColor = Color.WhiteSmoke;
            btnAceptar.Location = new Point(69, 76);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(86, 32);
            btnAceptar.TabIndex = 20;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = false;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // Frm_EtiquetasCantidad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 186);
            Controls.Add(pnMantenimiento);
            Controls.Add(pnTituloFormulario);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_EtiquetasCantidad";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_EtiquetasCantidad";
            pnTituloFormulario.ResumeLayout(false);
            pnTituloFormulario.PerformLayout();
            pnMantenimiento.ResumeLayout(false);
            pnMantenimiento.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        public Panel pnTituloFormulario;
        public TextBox txtCondicion;
        public TextBox txtInstancia;
        public TextBox txtOpcion;
        public Label lblTituloForm;
        public Panel pnMantenimiento;
        public TextBox txtCantidad;
        public Label label6;
        public Button btnCancelar;
        public Button btnAceptar;
    }
}