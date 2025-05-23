﻿using Microsoft.Extensions.DependencyInjection;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using FiscalPrinterLib;
using PVservices.Interfaces;
using System.ComponentModel;
using System.Drawing.Printing;
using System.Runtime.InteropServices;
using System.Text;
using System.Xml.Linq;



namespace PVpresentation.Formularios
{
    public partial class Frm_Ventas : Form
    {

        // Diccionario para almacenar los colores originales de los controles
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();

        #region METODOS PARA ARRASTRAR y MINIMIZAR/RESTAURAR EL FORMULARIO
        //Variables para maximizar y minimizar formulario
        private int lx;
        private int ly;
        private int sw;
        private int sh;

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
            // Asignar los eventos Enter y Leave solo a TextBox y ComboBox
            AssignFocusEvents(this);
        }

        #endregion

        #region Métodos para asignar los eventos Enter y Leave solo a TextBox y ComboBox
        private void AssignFocusEvents(Control parent)
        {
            foreach (Control control in parent.Controls)
            {
                // Verificar si el control es un TextBox o ComboBox
                if (control is TextBox || control is ComboBox)
                {
                    // Guardar el color original del control
                    originalColors[control] = control.BackColor;

                    // Asignar los eventos Enter y Leave
                    control.Enter += Control_Enter;
                    control.Leave += Control_Leave;
                }

                // Si el control tiene controles hijos (por ejemplo, un Panel), aplicar recursivamente
                if (control.HasChildren)
                {
                    AssignFocusEvents(control);
                }
            }
        }

        // Evento Enter: Cambia el BackColor cuando el control recibe el foco
        private void Control_Enter(object sender, EventArgs e)
        {
            if (sender is Control control)
            {
                control.BackColor = Color.YellowGreen; // Color cuando recibe el foco
            }
        }

        // Evento Leave: Restaura el BackColor original cuando el control pierde el foco
        private void Control_Leave(object sender, EventArgs e)
        {
            if (sender is Control control && originalColors.ContainsKey(control))
            {
                control.BackColor = originalColors[control]; // Restaurar el color original
            }
        }
        #endregion

        private int detalleIndex = 0; // Para controlar la posición en la lista
       
        private async Task AgregarProducto(string ProductoID)
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
            sb.AppendLine("VentaCdo: " + producto.pVenta);
            sb.AppendLine("Cantidad: " + txtCantidad.Text.Trim());

            var encontrado = _VentaDetalle.FirstOrDefault(x => x.ProductoBarCode == ProductoID);
            if (encontrado == null)
            {
                _VentaDetalle.Add(new Venta_D_VM
                {
                    ProductoID = producto.ID,
                    ProductoBarCode = producto.BarCode,
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
            int _SubTotal = 0; // 
            int _Bruto = 0; // 
            int _TotalFinal = 0;

            if (cmbLista.SelectedIndex == 0)
            {
                _SubTotal = _VentaDetalle.Sum(x => x.pTotalVenta);
                _Bruto = _VentaDetalle.Sum(x => x.pTotalOferta);
            }
            else if (cmbLista.SelectedIndex == 1)
            {
                _SubTotal = _VentaDetalle.Sum(x => x.pTotalVenta);
                _Bruto = _VentaDetalle.Sum(x => x.pTotalVenta);
            }

            if (txtDtoGral.Text.Trim() == "0")
            {
                _TotalFinal = _Bruto;
            }
            else
            {
                _TotalFinal = _Bruto - Convert.ToInt32(txtDtoGral.Text);
            }

            int _SumaPagos = Convert.ToInt32(txtTefectivo.Text.Trim()) + Convert.ToInt32(txtTdebito.Text.Trim()) + Convert.ToInt32(txtTtarjeta.Text.Trim()) + Convert.ToInt32(txtTctaCte.Text.Trim());
            int _Diferencia = _TotalFinal - _SumaPagos;
            txtSubTotal.Text = _SubTotal.ToString();
            txtDtoEfectivo.Text = (_SubTotal - _Bruto).ToString();
            txtBruto.Text = _Bruto.ToString();
            txtMontoFinal.Text = _TotalFinal.ToString();
            txtSaldoPago.Text = _Diferencia.ToString();
        }

        private async void txtBuscarProducto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtBuscarProducto.Text.Trim() != "")
                {
                    await AgregarProducto(txtBuscarProducto.Text.Trim());
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
                txtBuscarProducto.Text = _ProductoSeleccionado.BarCode.ToString();
                await AgregarProducto(_ProductoSeleccionado.BarCode);
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

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            var frmBuscarCliente = _serviceProvider.GetRequiredService<Frm_Clientes_Buscar>();
            var resultadobusqueda = frmBuscarCliente.ShowDialog();
            frmBuscarCliente.txtInstancia.Text = txtInstancia.Text;
            if (resultadobusqueda == DialogResult.OK)
            {
                var _clienteSeleccionado = frmBuscarCliente._ClienteSeleccionado;
                txtBuscarCliente.Text = _clienteSeleccionado.Nombre.ToString();

                #region VALIDAR LOS DATOS DEL CLIENTE SEGÚN LA INSTANCIA DEL FORMULARIO DE VENTAS ABIERTO

                if (txtInstancia.Text == "1")
                {
                    VariablesGlobales.Venta01_ClienteID = _clienteSeleccionado.ID;
                    VariablesGlobales.Venta01_ClienteNombre = _clienteSeleccionado.Nombre;
                    VariablesGlobales.Venta01_ClienteDomicilio = _clienteSeleccionado.Domicilio;

                }
                if (txtInstancia.Text == "2")
                {
                    VariablesGlobales.Venta02_ClienteID = _clienteSeleccionado.ID;
                    VariablesGlobales.Venta02_ClienteNombre = _clienteSeleccionado.Nombre;
                    VariablesGlobales.Venta02_ClienteDomicilio = _clienteSeleccionado.Domicilio;
                }
                if (txtInstancia.Text == "3")
                {
                    VariablesGlobales.Venta03_ClienteID = _clienteSeleccionado.ID;
                    VariablesGlobales.Venta03_ClienteNombre = _clienteSeleccionado.Nombre;
                    VariablesGlobales.Venta03_ClienteDomicilio = _clienteSeleccionado.Domicilio;
                }
                #endregion
            }
        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            ActualizaMontos();
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

            #region VALIDAR LOS DATOS DEL CLIENTE SEGÚN LA INSTANCIA DEL FORMULARIO DE VENTAS ABIERTO
            string _ClienteNombre = "";
            int _ClienteID = 0;
            string _ClienteDomicilio = "";

            if (txtInstancia.Text == "1")
            {
                _ClienteID = VariablesGlobales.Venta01_ClienteID;
                _ClienteNombre = VariablesGlobales.Venta01_ClienteNombre;
                _ClienteDomicilio = VariablesGlobales.Venta01_ClienteDomicilio;

                if (cmbTipo.SelectedIndex == 1 && _ClienteID == 1) //Values: 0 Contado | 1 Cuenta Corriente
                {
                    MessageBox.Show("Debe seleccionar un cliente para generar una venta en Cuenta Corriente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            if (txtInstancia.Text == "2")
            {
                _ClienteID = VariablesGlobales.Venta02_ClienteID;
                _ClienteNombre = VariablesGlobales.Venta02_ClienteNombre;
                _ClienteDomicilio = VariablesGlobales.Venta02_ClienteDomicilio;

                if (cmbTipo.SelectedIndex == 1 && _ClienteID == 1) //Values: 0 Contado | 1 Cuenta Corriente
                {
                    MessageBox.Show("Debe seleccionar un cliente para generar una venta en Cuenta Corriente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txtInstancia.Text == "3")
            {
                _ClienteID = VariablesGlobales.Venta03_ClienteID;
                _ClienteNombre = VariablesGlobales.Venta03_ClienteNombre;
                _ClienteDomicilio = VariablesGlobales.Venta03_ClienteDomicilio;

                if (cmbTipo.SelectedIndex == 1 && _ClienteID == 1) //Values: 0 Contado | 1 Cuenta Corriente
                {
                    MessageBox.Show("Debe seleccionar un cliente para generar una venta en Cuenta Corriente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            #endregion



            #endregion

            int _tipo = cmbTipo.SelectedIndex + 1;
            int _lista = cmbLista.SelectedIndex + 1;

            #region CREAR Y GUARDAR EL ARCHIVO XML 
            XElement Venta = new XElement("Venta",
                new XElement("Fecha", txtFecha.Text.Trim()),
                new XElement("Tipo", _tipo.ToString()),
                new XElement("Numero", "001-1025"),
                new XElement("SubTotal", Convert.ToInt32(txtSubTotal.Text.Trim())),
                new XElement("DtoEfectivo", Convert.ToInt32(txtDtoEfectivo.Text.Trim())),
                new XElement("Bruto", Convert.ToInt32(txtBruto.Text.Trim())),
                new XElement("DtoGeneral", Convert.ToInt32(txtDtoGral.Text.Trim())),
                new XElement("Monto", Convert.ToInt32(txtMontoFinal.Text.Trim())),
                new XElement("Tefectivo", Convert.ToInt32(txtTefectivo.Text.Trim())),
                new XElement("Tdebito", Convert.ToInt32(txtTdebito.Text.Trim())),
                new XElement("Ttarjeta", txtTtarjeta.Text.Trim()),
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
            #endregion

            var VentaNumero = await _venta_E_Service.Registrar(Venta.ToString());
            if (VentaNumero != "" || VentaNumero != null)
            {
                MessageBox.Show("Venta registrada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Impresiones imPresiones = new Impresiones();
                #region Obtener los valores del comprobante de venta a impirmir y enviar la impresión
                int _IDventa = Convert.ToInt32(VentaNumero);
                VariablesGlobales.oEmpresa = await _empresaService.Obtener(VariablesGlobales.EmpresaID);
                VariablesGlobales.oVentaE = await _venta_E_Service.Obtener(_IDventa);
                VariablesGlobales.oVentaD = await _venta_E_Service.ObtenerDetalleVenta(_IDventa);
                VariablesGlobales.oVentaE.VentaDetalle = VariablesGlobales.oVentaD;

                #region Crear y enviar la impresión del comprobante
                printVenta = new PrintDocument();
                PrinterSettings ps = new PrinterSettings();
                printVenta.PrinterSettings = ps;
                printVenta.PrintPage += imPresiones.ImprimirPresupuesto;
                printVenta.Print();
                #endregion

                #endregion

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

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private async void btnReimprimir_Click(object sender, EventArgs e)
        {
            Impresiones imPresiones = new Impresiones();
            #region Obtener los valores del comprobante de venta a impirmir y enviar la impresión
            int _IDventa = Convert.ToInt32(txtVentaReimpresion.Text.Trim());
            VariablesGlobales.oEmpresa = await _empresaService.Obtener(VariablesGlobales.EmpresaID);
            VariablesGlobales.oVentaE = await _venta_E_Service.Obtener(_IDventa);
            VariablesGlobales.oVentaD = await _venta_E_Service.ObtenerDetalleVenta(_IDventa);
            VariablesGlobales.oVentaE.VentaDetalle = VariablesGlobales.oVentaD;

            #region Crear y enviar la impresión del comprobante
            printVenta = new PrintDocument();
            PrinterSettings ps = new PrinterSettings();
            printVenta.PrinterSettings = ps;
            printVenta.PrintPage += imPresiones.ImprimirPresupuesto;
            printVenta.Print();
            #endregion
            #endregion
        }
    }
}
