using Microsoft.Extensions.Hosting;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVservices.Implementation;
using PVservices.Interfaces;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
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

        #region METODOS PARA ARRASTRAR EL FORMULARIO
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        #endregion


        #region SERVICIOS REQUERIDOAS Y CONSTRUCTOR
        private readonly IServiceProvider _serviceProvider;
        private readonly IVenta_E_Service _venta_E_Service;
        private readonly IEmpresaService _empresaService;
        private readonly IClientesService _clienteService;
        private readonly IProductosService _productoService;
        private readonly IListasService _listasService;
        private BindingList<Venta_D_VM> _VentaDetalle = new BindingList<Venta_D_VM>();

        public Frm_Ventas(IListasService listasService,
                          IServiceProvider serviceProvider,
                          IVenta_E_Service venta_E_Service,
                          IEmpresaService empresaService,
                          IClientesService clientesService,
                          IProductosService productosService)
        {
            InitializeComponent();
            _listasService = listasService;
            _serviceProvider = serviceProvider;
            _venta_E_Service = venta_E_Service;
            _empresaService = empresaService;
            _clienteService = clientesService;
            _productoService = productosService;
        }

        #endregion

        private async Task AgregarProducto(int ProductoID)
        {
            var producto = await _productoService.Obtener(ProductoID);
            if (producto.ID == 0)
            {
                txtBuscarProducto.BackColor = Color.FromArgb(255, 227, 227);
                return;
            }
            txtBuscarProducto.BackColor = Color.FromArgb(220, 220, 220);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Producto: " + producto.Nombre);
            sb.AppendLine("OfertaCdo: " + producto.pOferta);
            sb.AppendLine("OfertaCdo: " + producto.pVenta);
            sb.AppendLine("Cantidad: " + txtCantidad.Text.Trim());

            var encontrado = _VentaDetalle.FirstOrDefault(x => x.ProductoID == ProductoID);
            if (encontrado == null)
            {
                _VentaDetalle.Add(new Venta_D_VM
                {
                    ProductoID = producto.ID,
                    ProductoNombre = producto.Nombre,
                    Cantidad = Convert.ToInt32(txtCantidad.Text.Trim()),
                    pOferta = producto.pOferta,
                    pVenta = producto.pVenta,
                    pTotalOferta = producto.pOferta * Convert.ToInt32(txtCantidad.Text.Trim()),
                    pTotalVenta = producto.pVenta * Convert.ToInt32(txtCantidad.Text.Trim())
                });
            }
            else
            {
                encontrado.Cantidad += Convert.ToInt32(txtCantidad.Text.Trim());
                encontrado.pTotalOferta = encontrado.pOferta * encontrado.Cantidad;
                encontrado.pTotalVenta = encontrado.pVenta * encontrado.Cantidad;
            }
            int SubTotal = _VentaDetalle.Sum(x => x.pTotalVenta);
            txtSubTotal.Text = SubTotal.ToString("N2");
            txtSubTotal1.Text = SubTotal.ToString("N2");
            txtBuscarProducto.Text = "";
        }

        private void LimpiarMantenimiento()
        {
            txtSubTotal.Text = (0 / 1.0).ToString("N2");
            txtSubTotal1.Text = (0 / 1.0).ToString("N2");
            txtDtoEfectivo.Text = (0 / 1.0).ToString("N2");
            txtDtoEfectivo1.Text = (0 / 1.0).ToString("N2");
            txtBruto.Text = (0 / 1.0).ToString("N2");
            txtBruto1.Text = (0 / 1.0).ToString("N2");
            txtDtoGral.Text = (0 / 1.0).ToString("N2");
            txtMontoFinal.Text = (0 / 1.0).ToString("N2");
            txtTefectivo.Text = (0 / 1.0).ToString("N2");
            txtTdebito.Text = (0 / 1.0).ToString("N2");
            txtTtarjeta.Text = (0 / 1.0).ToString("N2");
            txtTctaCte.Text = (0 / 1.0).ToString("N2");
            cmbLista.SelectedIndex = 0;
            cmbTipo.SelectedIndex = 0;

        }

        private async void Frm_Ventas_Load(object sender, EventArgs e)
        {
            //Completo los datos del comboBox no enlazado con otra tabla
            OpcionesComboBox[] itemsTipos = new OpcionesComboBox[]
            {
                new OpcionesComboBox{Texto="Contado",Valor=1},
                new OpcionesComboBox{Texto="Cuenta Corriente",Valor=2}
            };
            cmbTipo.InsertarItems(itemsTipos);

            //Completo los datos del comboBox enlazado con otra tabla
            var ListaPrecios = await _listasService.Lista();
            var items = ListaPrecios.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();

            cmbLista.InsertarItems(items);
            LimpiarMantenimiento();

            #region PERSONALIZACION DEL DATAGRIDVIEW
            dgvListado.ImplementarConfiguracion("Eliminar");
            dgvListado.DataSource = _VentaDetalle;
            dgvListado.Columns["ProductoID"].Visible = false;
            dgvListado.Columns["ProductoNombre"].FillWeight = 350;
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            #endregion


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

        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBuscarProducto.Text.Trim() != "")
                {
                    AgregarProducto(Convert.ToInt32(txtBuscarProducto.Text.Trim()));
                }
            }
        }
        //1;"Contado";2;"Cuenta Corriente"


    }
}
