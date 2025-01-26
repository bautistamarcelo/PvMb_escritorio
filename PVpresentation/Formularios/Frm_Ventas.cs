﻿using PVpresentation.Resources;
using System.Runtime.InteropServices;
using System.Xml.Linq;



namespace PVpresentation.Formularios
{
    public partial class Frm_Ventas : Form
    {
        //Variables para maximizar y minimizar formulario
        private int lx;
        private int ly;
        private int sw;
        private int sh;

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
            if (txtInstancia.Text == "1")
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

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;

            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnTituloFormulario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

            //    XElement Venta = new XElement(this.Name.ToString(),
            //        new XElement("Fecha", txtFecha.Text.Trim()),
            //        new XElement("Tipo", cmbTipo.Text.Trim()),
            //        new XElement("Numero", txtNumero.Text.Trim()),
            //        new XElement("SubTotal", txtSubTotal.Text.Trim()),
            //        new XElement("DtoEfectivo", txtDtoEfectivo.Text.Trim()),
            //        new XElement("Bruto", txtTotal.Text.Trim()),
            //        new XElement("DtoGeneral", txtDtoGral.Text.Trim()),
            //        new XElement("Monto", txtMontoFinal.Text.Trim()),
            //        new XElement("Tefectivo", txtTefectivo.Text.Trim()),
            //        new XElement("Tdebito", txtTdebito.Text.Trim()),
            //        new XElement("Ttarjeta", txtTtarjeta.Text.Trim()),
            //        new XElement("Tcredito", txtTctaCte.Text.Trim()),
            //        new XElement("Situacion",0),//Values: 0;"Grabada";1;"Pendiente";2;"Facturada";3;"Anulada"
            //        new XElement("ClienteID", VariablesGlobales.Venta01_ClienteID),
            //        new XElement("VendedorID", VariablesGlobales.UsuarioID),
            //        new XElement("SucursalID", VariablesGlobales.SucursalID),
            //        new XElement("ListaID", cmbLista.SelectedIndex)
            //        );
            //    XElement VentaDetalle = new XElement("VentaDetalle");
            //    foreach (Venta_Dvm item in _VentaDetalle)
            //    {
            //        VentaDetalle.Add(new XElement("Item",
            //            new XElement("ProductoID", item.ProductoID),
            //            new XElement("Cantidad", item.Cantidad),
            //            new XElement("pOferta", item.pOferta),
            //            new XElement("pVenta", item.pVenta),
            //            new XElement("pTotalOferta", item.pTotalOferta),
            //            new XElement("pTotalVenta", item.pTotalVenta)
            //            )
            //         );
            //    }
            //    Venta.Add(VentaDetalle);
        }
    }
}
