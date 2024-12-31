using PVpresentation.Formularios;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace PVpresentation
{
    public partial class FrmModelo : Form
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

        private Color _focusColor = Color.FromArgb(161, 192, 100); // Color para el enfoque private Color _originalColor;
        private Color _originalColor = Color.FromArgb(221, 217, 195);

        public void ApplyFocusEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Solo aplica a los controles que pueden recibir enfoque
                if (control is TextBox || control is ComboBox)
                {
                    control.Enter += Control_Enter;
                    control.Leave += Control_Leave;
                }
                // Llama recursivamente para los controles hijos
                if (control.HasChildren)
                {
                    ApplyFocusEvents(control);
                }
            }
        }

        private void Control_Enter(object sender, EventArgs e)
        {
            // Cambia el color de fondo al recibir el enfoque
            Control control = sender as Control;
            if (control != null)
            {
                _originalColor = Color.FromArgb(255, 255, 255);
                control.BackColor = _focusColor;
            }
        }

        private void Control_Leave(object sender, EventArgs e)
        {
            // Restablece el color de fondo al perder el enfoque
            Control control = sender as Control;
            if (control != null)
            {
                control.BackColor = _originalColor;
            }
        }


        public FrmModelo()
        {
            InitializeComponent();
            // Aplica los eventos a cada control en el formulario
            ApplyFocusEvents(this);
        }

        private void FrmModelo_Load(object sender, EventArgs e)
        {

            //dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);
        }

        private void txtBuscar_Enter(object sender, EventArgs e)
        {
            txtBuscar.ColorFondoFoco();
        }

        private void txtBuscar_Leave(object sender, EventArgs e)
        {
            txtBuscar.ColorFondoNormal();
        }

        private void txtNombreNuevo_Enter(object sender, EventArgs e)
        {
            txtNombreNuevo.ColorFondoFoco();
        }

        private void txtNombreNuevo_Leave(object sender, EventArgs e)
        {
            txtNombreNuevo.ColorFondoNormal();
        }


        private void btnVolverNuevo_Click(object sender, EventArgs e)
        {
            MostrarTabs(tabListado.Name);
            tabControlMain.SelectedTab = tabControlMain.TabPages[tabListado.Name];
            txtBuscar.Select();
        }

        private void btnVolverEditar_Click(object sender, EventArgs e)
        {
            MostrarTabs(tabListado.Name);
            tabControlMain.SelectedTab = tabControlMain.TabPages[tabListado.Name];
            txtBuscar.Select();
        }

        private void btnCierreVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
