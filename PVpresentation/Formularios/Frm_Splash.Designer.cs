namespace PVpresentation.Formularios
{
    partial class Frm_Splash
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Splash));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            pictureBox3 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            Opcion = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Logo_MB_Blanco_SF;
            pictureBox1.Location = new Point(130, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(300, 176);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Logo_PV_blanco_SF;
            pictureBox2.Location = new Point(213, 265);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(122, 99);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("EngraversGothic BT", 26F);
            label1.ForeColor = Color.FromArgb(4, 41, 68);
            label1.Location = new Point(70, 173);
            label1.Name = "label1";
            label1.Size = new Size(419, 89);
            label1.TabIndex = 2;
            label1.Text = "Bienvenido al Sistema Punto de Venta";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.Font = new Font("EngraversGothic BT", 16F);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(69, 367);
            label2.Name = "label2";
            label2.Size = new Size(419, 44);
            label2.TabIndex = 3;
            label2.Text = "Control de Ventas | Stock | Almacén";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(147, 427);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(53, 38);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // label3
            // 
            label3.Font = new Font("EngraversGothic BT", 12F);
            label3.ForeColor = Color.FromArgb(4, 41, 68);
            label3.Location = new Point(155, 422);
            label3.Name = "label3";
            label3.Size = new Size(303, 27);
            label3.TabIndex = 5;
            label3.Text = "Versión Ensamblado: 01 -01";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.Font = new Font("EngraversGothic BT", 12F);
            label4.ForeColor = Color.FromArgb(4, 41, 68);
            label4.Location = new Point(130, 449);
            label4.Name = "label4";
            label4.Size = new Size(328, 27);
            label4.TabIndex = 6;
            label4.Text = "MB IT Solutions © 2025\r\n";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 3600;
            timer1.Tick += timer1_Tick;
            // 
            // Opcion
            // 
            Opcion.Location = new Point(389, 12);
            Opcion.Name = "Opcion";
            Opcion.Size = new Size(100, 23);
            Opcion.TabIndex = 7;
            Opcion.Text = "0";
            Opcion.Visible = false;
            // 
            // Frm_Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(74, 134, 160);
            ClientSize = new Size(562, 487);
            Controls.Add(Opcion);
            Controls.Add(pictureBox3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label3);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Frm_Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Frm_Splash";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label label2;
        private PictureBox pictureBox3;
        private System.Windows.Forms.Timer timer1;
        public TextBox Opcion;
        public Label label1;
        public Label label3;
        public Label label4;
    }
}