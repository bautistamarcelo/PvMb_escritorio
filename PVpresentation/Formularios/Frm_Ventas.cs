using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Identity.Client;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Implementation;
using PVservices.Interfaces;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;
using System.IO;


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
            ActualizaMontos();
            dgvListado.Refresh();
        }

        private void LimpiarMantenimiento()
        {
            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtSubTotal.Text = "0";//(0 / 1.0).ToString("N0");
            txtBuscarCliente.Text = VariablesGlobales.Venta01_ClienteNombre;
            txtSubTotal.Text = "0";// (0 / 1.0).ToString("N0");
            txtDtoEfectivo.Text = "0";// (0 / 1.0).ToString("N0");
            txtDtoEfectivo.Text = "0";// (0 / 1.0).ToString("N0");
            txtBruto.Text = "0";// (0 / 1.0).ToString("N0");
            txtBruto.Text = "0";// (0 / 1.0).ToString("N0");
            txtDtoGral.Text = "0";// (0 / 1.0).ToString("N0");
            txtMontoFinal.Text = "0";// (0 / 1.0).ToString("N0");
            txtTefectivo.Text = "0";// (0 / 1.0).ToString("N0");
            txtTdebito.Text = "0";// (0 / 1.0).ToString("N0");
            txtTtarjeta.Text = "0";// (0 / 1.0).ToString("N0");
            txtTctaCte.Text = "0";// (0 / 1.0).ToString("N0");
            cmbLista.SelectedIndex = 1;// 1;"Oferta Contado";2;"Mayorista"
            cmbTipo.SelectedIndex = 0;// 1;"Contado";2;"Cuenta Corriente"

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

            //Completo los datos del cliente por defecto en la clase de variables globales
            VariablesGlobales.Venta01_ClienteID = 1;
            VariablesGlobales.Venta01_ClienteNombre = "***Consumidor Final***";
            VariablesGlobales.Venta01_ClienteDomicilio = "***No Especificado***";
            VariablesGlobales.Venta01_ClienteCUIT = "";

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

        public void ActualizaMontos()
        {
            int _SubTotal = _VentaDetalle.Sum(x => x.pTotalVenta);
            int _Bruto = _VentaDetalle.Sum(x => x.pTotalOferta);
            int _TotalFinal;
            if (txtDtoGral.Text.Trim() == "0")
            {
                _TotalFinal = _Bruto;
            }
            else
            {
                _TotalFinal = _Bruto - Convert.ToInt32(txtDtoGral.Text);
            }
            //int _TotalFinal = _Bruto - Convert.ToInt32(txtDtoGral.Text);
            int _SumaPagos = Convert.ToInt32(txtTefectivo.Text.Trim()) + Convert.ToInt32(txtTdebito.Text.Trim()) + Convert.ToInt32(txtTtarjeta.Text.Trim()) + Convert.ToInt32(txtTctaCte.Text.Trim());
            int _Diferencia = _TotalFinal - _SumaPagos;
            txtSubTotal.Text = _SubTotal.ToString();
            txtDtoEfectivo.Text = (_SubTotal - _Bruto).ToString();
            txtBruto.Text = _Bruto.ToString();
            txtMontoFinal.Text = _TotalFinal.ToString();
            txtSaldoPago.Text = _Diferencia.ToString();
        }

        private void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBuscarProducto.Text.Trim() != "")
                {
                    AgregarProducto(Convert.ToInt32(txtBuscarProducto.Text.Trim()));
                    txtBuscarProducto.Text = "";
                }
            }
        }

        private async void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var frmBuscarProducto = _serviceProvider.GetRequiredService<Frm_Productos_BuscaDeInstancia>();
            var resultadobusqueda = frmBuscarProducto.ShowDialog();
            if (resultadobusqueda == DialogResult.OK)
            {
                var _ProductoSeleccionado = frmBuscarProducto._ProductoSeleccionado;
                txtBuscarProducto.Text = _ProductoSeleccionado.ID.ToString();
                await AgregarProducto(_ProductoSeleccionado.ID);
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var filaSeleccionada = (Venta_D_VM)dgvListado.CurrentRow.DataBoundItem;
                var index = _VentaDetalle.IndexOf(filaSeleccionada);
                _VentaDetalle.RemoveAt(index);

                ActualizaMontos();
            }
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES PREVIAS

            if (_VentaDetalle.Count == 0)
            {
                MessageBox.Show("No hay productos en la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un tipo de venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cmbLista.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar una lista de precios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtTefectivo.Text.Trim() == "0" && txtTdebito.Text.Trim() == "0" && txtTtarjeta.Text.Trim() == "0" && txtTctaCte.Text.Trim() == "0")
            {
                MessageBox.Show("Debe ingresar al menos un medio de pago", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            int _tipo = cmbTipo.SelectedIndex + 1;
            int _lista = cmbLista.SelectedIndex + 1;

            XElement Venta = new XElement("Venta",
                new XElement("Fecha", txtFecha.Text.Trim()),
                new XElement("Tipo", _tipo.ToString()),
                new XElement("Numero", "001-1025"),
                new XElement("SubTotal", Convert.ToInt32( txtSubTotal.Text.Trim())),
                new XElement("DtoEfectivo", Convert.ToInt32(txtDtoEfectivo.Text.Trim())),
                new XElement("Bruto", Convert.ToInt32(txtBruto.Text.Trim())),
                new XElement("DtoGeneral", Convert.ToInt32(txtDtoGral.Text.Trim())),
                new XElement("Monto", Convert.ToInt32(txtMontoFinal.Text.Trim())),
                new XElement("Tefectivo",Convert.ToInt32( txtTefectivo.Text.Trim())),
                new XElement("Tdebito", Convert.ToInt32(txtTdebito.Text.Trim())),
                new XElement("Ttarjeta", txtTtarjeta.Text.Trim()),
                new XElement("Tcredito", Convert.ToInt32(txtTctaCte.Text.Trim())),
                new XElement("Situacion", 0),//Values: 0;"Grabada";1;"Pendiente";2;"Facturada";3;"Anulada"
                new XElement("ClienteID", VariablesGlobales.Venta01_ClienteID),
                new XElement("VendedorID", VariablesGlobales.UsuarioID),
                new XElement("SucursalID", VariablesGlobales.SucursalID),
                new XElement("CajaID",VariablesGlobales.CajaID),
                new XElement("ListaID", _lista.ToString())
                );
            XElement VentaDetalle = new XElement("VentaDetalle");
            foreach (Venta_D_VM item in _VentaDetalle)
            {
                VentaDetalle.Add(new XElement("Item",
                    new XElement("ProductoID", item.ProductoID),
                    new XElement("Cantidad", item.Cantidad),
                    new XElement("pOferta", item.pOferta),
                    new XElement("pVenta", item.pVenta),
                    new XElement("pTotalOferta", item.pTotalOferta),
                    new XElement("pTotalVenta", item.pTotalVenta),
                    new XElement("SucursalID", VariablesGlobales.SucursalID)
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

            var VentaNumero = await _venta_E_Service.Registrar(Venta.ToString());
            if (VentaNumero != "" || VentaNumero != null )
            {
                MessageBox.Show("Venta registrada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarMantenimiento();
                _VentaDetalle.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar la venta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtDtoGral_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActualizaMontos();
                txtTefectivo.Focus();
            }
        }

        private void txtTefectivo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActualizaMontos();
                txtTdebito.Focus();
            }
        }

        private void txtTdebito_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActualizaMontos();
                txtTtarjeta.Focus();
            }
        }

        private void txtTtarjeta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActualizaMontos();
                txtTctaCte.Focus();
            }
        }

        private void txtTctaCte_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ActualizaMontos();
                btnGrabar.Focus();
            }
        }
    }
}
