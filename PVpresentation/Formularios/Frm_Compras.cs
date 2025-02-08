using Microsoft.Extensions.DependencyInjection;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVservices.Interfaces;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;


namespace PVpresentation.Formularios
{
    public partial class Frm_Compras : Form
    {
        #region METODOS PARA ARRASTRAR y MINIMIZAR/RESTAURAR EL FORMULARIO
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

        private void pnTituloFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        #endregion

        #region SERVICIOS REQUERIDOAS Y CONSTRUCTOR
        private readonly IServiceProvider _serviceProvider;
        private readonly IProductosService _productoService;
        private readonly IProveedoresService _proveedoresService;
        private readonly IImpuestosService _impuestosService;
        private BindingList<Compra_D_VM> _CompraDetalle = new BindingList<Compra_D_VM>();

        public Frm_Compras(IServiceProvider serviceProvider,
                                       IProductosService productosService,
                                       IProveedoresService proveedoresService,
                                       IImpuestosService impuestosService )
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _productoService = productosService;
            _proveedoresService = proveedoresService;
            _impuestosService = impuestosService;
        }

        #endregion


        private void btnCierreVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            XElement Venta = new XElement("Venta",
                new XElement("Fecha", txtFecha.Text.Trim()),
                new XElement("Tipo", _tipo.ToString()), //Values: 1 Contado | 2 Cuenta Corriente
                new XElement("Numero", "001-1025"),
                new XElement("pCompra", Convert.ToInt32(txtSubTotal.Text.Trim())),
                new XElement("ImpuestoID", Convert.ToInt32(txtDtoEfectivo.Text.Trim())),
                new XElement("ImpuestoMonto", Convert.ToInt32(txtBruto.Text.Trim())),
                new XElement("Situación", Convert.ToInt32(txtDtoGral.Text.Trim())), //Values: 1 Grabada | 2 Anulada | 3 Pendiente
                new XElement("ProveedorID", Convert.ToInt32(txtMontoFinal.Text.Trim())),
                new XElement("Comprobante", Convert.ToInt32(txtTefectivo.Text.Trim())),
                new XElement("Estado", Convert.ToInt32(txtTdebito.Text.Trim())), //Values: 1 Habilitado | 2 Deshabilitado
                new XElement("Costo", txtTtarjeta.Text.Trim()),
                new XElement("Tefectivo", Convert.ToInt32(txtTctaCte.Text.Trim())),
                new XElement("Tdebito", Convert.ToInt32(txtTctaCte.Text.Trim())),
                new XElement("Ttarjeta", Convert.ToInt32(txtTctaCte.Text.Trim())),
                new XElement("Tcredito", Convert.ToInt32(txtTctaCte.Text.Trim())),
                new XElement("Situacion", 0),//Values: 0;"Grabada";1;"Pendiente";2;"Facturada";3;"Anulada"
                new XElement("ClienteID", _ClienteID),
                new XElement("ClienteNombre", _ClienteNombre),
                new XElement("ClienteDomicilio", _ClienteDomicilio),
                new XElement("VendedorID", VariablesGlobales.UsuarioID),
                new XElement("SucursalID", VariablesGlobales.SucursalID),
                new XElement("CajaID", VariablesGlobales.CajaID),
                new XElement("ListaID", _lista.ToString())
                );
            XElement VentaDetalle = new XElement("VentaDetalle");
            foreach (Venta_D_VM item in _VentaDetalle)
            {
                VentaDetalle.Add(new XElement("Item",
                    new XElement("ProductoID", item.ProductoID),
                    new XElement("Cantidad", item.Cantidad),
                    new XElement("pCosto", item.pOferta),
                    new XElement("pTotalLinea", item.pTotalVenta),
                    new XElement("TramiteID", VariablesGlobales.SucursalID) //Values: 2 Salida por Compra
                    )
                 );
            }
            Venta.Add(VentaDetalle);

            #region Guardar XML
            string folderPath = @"D:\Base de Datos\"; // Ruta de la carpeta
            string fileName = "venta.xml"; // Nombre del archivo
            string fullPath = Path.Combine(folderPath, fileName); // Ruta completa del archivo

            File.WriteAllText(fullPath, Venta.ToString());

            #endregion
        }
    }
}
