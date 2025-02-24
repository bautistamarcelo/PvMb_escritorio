using PVservices.Interfaces;
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
    public partial class Frm_Cajas_Movimientos : Form
    {
        public void MostrarTabs(string tabName)
        {
            var tabsMenu = new TabPage[] { tabIngresos, tabEgresos };
            foreach (var tab in tabsMenu)
            {
                if (tab.Name != tabName)
                {
                    tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }

            }
        }
        private readonly IServiceProvider _serviceProvider;
        private readonly IClientesService _clientesService;
        
        public Frm_Cajas_Movimientos(IServiceProvider serviceProvider, IClientesService clientesService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _clientesService = clientesService;
        }

        private async void Frm_Cajas_Movimientos_Load(object sender, EventArgs e)
        {
            
        }
    }
}
