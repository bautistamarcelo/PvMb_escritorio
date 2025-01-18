using PVpresentation.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVpresentation.Formularios.Modelos
{
    public partial class FrmModeloCRUD : Form
    {
        public void MostrarTabs(string tabName)
        {
            var tabsMenu = new TabPage[] { tabListado, tabNuevo, tabEditar };
            foreach (var tab in tabsMenu)
            {
                if (tab.Name != tabName)
                {
                    //tab.Parent = null;
                }
                else
                {
                    tab.Parent = tabControlMain;
                }

            }
        }

        public FrmModeloCRUD()
        {
            InitializeComponent();
            dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);
        }

        private void btnCierreVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnEditar.Enabled = true;
        }
    }
}
