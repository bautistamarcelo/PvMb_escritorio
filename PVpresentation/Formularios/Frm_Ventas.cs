using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVpresentation.Formularios
{
    public partial class Frm_Ventas : Form
    {
        //METODOS PARA ARRASTRAR EL FORMULARIO------------------------------------------------------------------------------------------------------------------------------------------------------------
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        //CONSTRUCTOR
        public Frm_Ventas()
        {
            InitializeComponent();
        }

        private void pnTituloFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCierreVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_Ventas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(txtInstancia.Text == "1")
            {
                Resources.VariablesGlobales.Frm_Venta01 = 0;
            }
            else if (txtInstancia.Text == "2")
            {
                Resources.VariablesGlobales.Frm_Venta02 = 0;
            }
            else if (txtInstancia.Text == "3")
            {
                Resources.VariablesGlobales.Frm_Venta03 = 0;
            }
        }
    }
}
