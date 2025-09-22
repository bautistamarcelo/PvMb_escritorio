using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVpresentation.Formularios
{
    public partial class Frm_Splash : Form
    {
        private readonly IServiceProvider _serviceProvider;
        public Frm_Splash(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Opcion.Text == "0") {
                var frmLogin = _serviceProvider.GetRequiredService<Frm_Login>();
                frmLogin.Show();
            };
            this.timer1.Enabled = false;
            this.Hide();
        }
    }
}
