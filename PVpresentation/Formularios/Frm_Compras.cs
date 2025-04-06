using Microsoft.Extensions.DependencyInjection;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Implementation;
using PVservices.Interfaces;
using System.ComponentModel;
using System.Drawing.Printing;
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
        private readonly IComprasService _comprasService;
        // Diccionario para almacenar los colores originales de los controles
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();
        public Productos vProducTo { get; set; } = null!;
        private BindingList<Compra_D_VM> _CompraDetalle = new BindingList<Compra_D_VM>();

        public Frm_Compras(IServiceProvider serviceProvider,
                                       IProductosService productosService,
                                       IProveedoresService proveedoresService,
                                       IImpuestosService impuestosService,
                                       IComprasService comprasService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _productoService = productosService;
            _proveedoresService = proveedoresService;
            _impuestosService = impuestosService;
            // Asignar los eventos Enter y Leave solo a TextBox y ComboBox
            AssignFocusEvents(this);
            _comprasService = comprasService;
        }

        #endregion


        // Método para asignar los eventos Enter y Leave solo a TextBox y ComboBox
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

        public void ActualizaMontos()
        {
            int? _SubTotal = 0; // 
            int? _Impuestos = 0; // 
            int? _TotalFinal = 0;

            _SubTotal = _CompraDetalle.Sum(x => x.TotalCompra);
            _TotalFinal = _CompraDetalle.Sum(x => x.TotalCosto);
            _Impuestos = _TotalFinal - _SubTotal;

            txtSubTotal.Text = _SubTotal.ToString();
            txtMontoTotal.Text = _TotalFinal.ToString();
            txtImpuestosGral.Text = _Impuestos.ToString();
        }

        private async Task AgregarProducto(int ProductoID)
        {
            var producto = await _productoService.Obtener(ProductoID);
            if (producto.ID == 0)
            {
                txtProductoID.BackColor = Color.FromArgb(255, 227, 227);
                return;
            }
            txtProductoID.BackColor = Color.FromArgb(220, 220, 220);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Producto: " + producto.Nombre);
            sb.AppendLine("Costo: " + producto.Costo);
            sb.AppendLine("OfertaCdo: " + producto.pOferta);
            sb.AppendLine("VentaCdo: " + producto.pVenta);
            sb.AppendLine("pCompra: " + txtpCompra.Text.Trim());
            sb.AppendLine("Impuesto: " + txtImpuestoMonto.Text.Trim());
            sb.AppendLine("Cantidad: " + txtCantidad.Text.Trim());

            var encontrado = _CompraDetalle.FirstOrDefault(x => x.ProductoID == ProductoID);
            if (encontrado == null)
            {
                _CompraDetalle.Add(new Compra_D_VM
                {
                    ProductoID = producto.ID,
                    ProductoNombre = producto.Nombre,
                    Cantidad = Convert.ToInt32(txtCantidad.Text.Trim()),
                    pCompra = Convert.ToInt32(txtpCompra.Text.Trim()),
                    Impuesto = Convert.ToInt32(txtImpuestoMonto.Text.Trim()),
                    Costo = Convert.ToInt32(txtpCosto.Text.Trim()),
                    TotalCompra = Convert.ToInt32(txtpCompra.Text.Trim()) * Convert.ToInt32(txtCantidad.Text.Trim()),
                    TotalCosto = Convert.ToInt32(txtpCosto.Text.Trim()) * Convert.ToInt32(txtCantidad.Text.Trim()),
                    pOferta = Convert.ToInt32(txtpOferta.Text.Trim()),
                    pVenta = Convert.ToInt32(txtpVenta.Text.Trim())
                });
            }
            else
            {
                encontrado.Cantidad += Convert.ToInt32(txtCantidad.Text.Trim());

                encontrado.TotalCompra = Convert.ToInt32(txtpCompra.Text.Trim()) * Convert.ToInt32(txtCantidad.Text.Trim());
                encontrado.TotalCosto = Convert.ToInt32(txtpCosto.Text.Trim()) * Convert.ToInt32(txtCantidad.Text.Trim());
            }
            ActualizaMontos();
            dgvListado.Refresh();
        }

        public async Task ObtenerProducto(int ProductoID)
        {

            vProducTo = await _productoService.Obtener(ProductoID);
            if (vProducTo.ID == 0)
            {
                txtProductoID.BackColor = Color.FromArgb(255, 227, 227);
                return;
            }
            txtProductoID.BackColor = Color.FromArgb(220, 220, 220);

            txtProductoID.Text = vProducTo.ID.ToString();
            txtBarCode.Text = vProducTo.BarCode.ToString();
            txtProductoNombre.Text = vProducTo.Nombre.ToString();
            txtpOferta.Text = vProducTo.pOferta.ToString();
            txtpVenta.Text = vProducTo.pVenta.ToString();

            txtpCosto.Text = vProducTo.Costo.ToString();
            txtProveedor.Text = vProducTo.Proveedor.ID.ToString();
            txtCategoria.Text = vProducTo.Categoria.ID.ToString();
            txtMarca.Text = vProducTo.Marca.ID.ToString();
            txtImpuesto.Text = vProducTo.Impuesto.ID.ToString();

            if (vProducTo.ID == VariablesGlobales.vProductoID)
            {
                txtCantidad.Text = VariablesGlobales.vProductoStock.ToString();
            }
            else
            {
                txtCantidad.Text = "1";
            }
            txtCantidad.Select();
        }

        private void Frm_Compras_Load(object sender, EventArgs e)
        {
            #region Completo los datos del comboBox no enlazado con otra tabla
            OpcionesComboBox[] itemsTipos = new OpcionesComboBox[]
            {
                new OpcionesComboBox{Texto="Contado",Valor=1},
                new OpcionesComboBox{Texto="Cuenta Corriente",Valor=2}
            };
            cmbFormaPago.InsertarItems(itemsTipos);

            OpcionesComboBox[] itemsPagos = new OpcionesComboBox[]
            {
                new OpcionesComboBox{Texto="Remito",Valor=1},
                new OpcionesComboBox{Texto="Presupuesto",Valor=2},
                new OpcionesComboBox{Texto="Factura B",Valor=3},
                new OpcionesComboBox{Texto="Factura A",Valor=4}
            };
            cmbTipo.InsertarItems(itemsPagos);
            #endregion

            #region Personalizacion del DataGridView
            dgvListado.ImplementarConfiguracion("Eliminar");
            dgvListado.DataSource = _CompraDetalle;
            dgvListado.Columns["ProductoID"].Visible = false;
            dgvListado.Columns["ProductoNombre"].FillWeight = 350;
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            #endregion

            txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtProveedorID.Text = "1"!; // Proveedor por defecto
            txtProveedorNombre.Text = "** Sin Asignar **";
            cmbFormaPago.SelectedIndex = 1;
            cmbTipo.SelectedIndex = 0;
            txtProductoID.Select();
        }

        private void btnCierreVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void txtProductoID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (txtProductoID.Text.Trim() != "")
                {
                    await ObtenerProducto(Convert.ToInt32(txtProductoID.Text.Trim()));
                }
            }
            if (e.KeyCode == Keys.F3)
            {
                var frmBuscarProducto = _serviceProvider.GetRequiredService<Frm_Productos_Compras>();
                var resultadobusqueda = frmBuscarProducto.ShowDialog();
                if (resultadobusqueda == DialogResult.OK)
                {
                    var _ProductoSeleccionado = frmBuscarProducto._ProductoSeleccionado;
                    txtProductoID.Text = _ProductoSeleccionado.ID.ToString();
                    await ObtenerProducto(Convert.ToInt32(txtProductoID.Text.Trim()));
                }
            }
        }

        private async void btnAgregarItem_Click(object sender, EventArgs e)
        {
            await AgregarProducto(Convert.ToInt32(txtProductoID.Text.Trim()));

            VariablesGlobales.vProductoID = Convert.ToInt32(txtProductoID.Text.Trim());
            VariablesGlobales.vProductoBarCode = txtBarCode.Text.ToString();
            VariablesGlobales.vProductoPoferta = Convert.ToInt32(txtpOferta.Text.Trim());
            VariablesGlobales.vProductoPventa = Convert.ToInt32(txtpVenta.Text.Trim());
            Impresiones imPresiones = new Impresiones();
            PrintDocument printEtiqueta = new PrintDocument();

            #region Crear y enviar la impresión del comprobante
            var frmCantidadEtiquetas = _serviceProvider.GetRequiredService<Frm_EtiquetasCantidad>();
            var resultadoCantidad = frmCantidadEtiquetas.ShowDialog();
            if (resultadoCantidad == DialogResult.OK)
            {
                for (int i = 0; i < VariablesGlobales.vEtiquetasCantidad; i++)
                {
                    PrinterSettings ps = new PrinterSettings();
                    printEtiqueta.PrinterSettings = ps;
                    printEtiqueta.PrintPage += imPresiones.ImprimirEtiqueta;
                    printEtiqueta.Print();
                }
            }
            #endregion

            txtProductoID.Text = "";
            txtProductoNombre.Text = "";
            txtCantidad.Text = "1";
            txtpCompra.Text = "";
            txtImpuestoMonto.Text = "";
            txtpCosto.Text = "";
            txtpOferta.Text = "";
            txtpVenta.Text = "";

            txtProductoID.Select();
        }

        private async void btnEditarProducto_Click(object sender, EventArgs e)
        {
            if (txtProductoID.Text.Trim() == "")
            {
                return;
            }
            await ObtenerProducto(Convert.ToInt32(txtProductoID.Text.Trim()));
            var frmBuscarProducto = _serviceProvider.GetRequiredService<Frm_Productos_Compras>();
            frmBuscarProducto.MostrarTabs(frmBuscarProducto.tabNuevo.Name);
            frmBuscarProducto.txtID.Text = vProducTo.ID.ToString();
            frmBuscarProducto.txtNombre.Text = vProducTo.Nombre.ToString();
            frmBuscarProducto.txtBarCode.Text = vProducTo.BarCode.ToString();
            frmBuscarProducto.txtStock.Text = vProducTo.Stock.ToString();
            frmBuscarProducto.txtCosto.Text = vProducTo.Costo.ToString();
            frmBuscarProducto.txtpOferta.Text = vProducTo.pOferta.ToString();
            frmBuscarProducto.txtpVenta.Text = vProducTo.pVenta.ToString();
            frmBuscarProducto.txtOpcion.Text = "2"; // 1 Nuevo | 2 Edicion
            frmBuscarProducto.txtInstancia.Text = "CompraEditar";
            frmBuscarProducto.txtProveedorID.Text = vProducTo.Proveedor.ID.ToString();
            frmBuscarProducto.txtImpuesto.Text = vProducTo.Impuesto.ID.ToString();
            frmBuscarProducto.txtCategoria.Text = vProducTo.Categoria.ID.ToString();
            frmBuscarProducto.txtMarca.Text = vProducTo.Marca.ID.ToString();

            var resultadobusqueda = frmBuscarProducto.ShowDialog();
            if (resultadobusqueda == DialogResult.OK)
            {
                var _ProductoSeleccionado = frmBuscarProducto._ProductoSeleccionado;
                txtProductoID.Text = VariablesGlobales.vProductoID.ToString();
                await ObtenerProducto(Convert.ToInt32(txtProductoID.Text.Trim()));
            }
        }

        private async void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            var frmBuscarProducto = _serviceProvider.GetRequiredService<Frm_Productos_Compras>();
            frmBuscarProducto.MostrarTabs(frmBuscarProducto.tabNuevo.Name);
            frmBuscarProducto.txtOpcion.Text = "1"; // 1 Nuevo | 2 Edicion
            frmBuscarProducto.txtInstancia.Text = "CompraNuevo";
            var resultadobusqueda = frmBuscarProducto.ShowDialog();
            if (resultadobusqueda == DialogResult.OK)
            {
                var _ProductoSeleccionado = frmBuscarProducto._ProductoSeleccionado;
                txtProductoID.Text = VariablesGlobales.vProductoID.ToString();
                await ObtenerProducto(Convert.ToInt32(txtProductoID.Text.Trim()));
            }
        }

        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            var frmBuscarProveedor = _serviceProvider.GetRequiredService<Frm_Proveedores>();

            frmBuscarProveedor.txtOpcion.Text = "1"; // 1 Nuevo | 2 Edicion
            frmBuscarProveedor.txtInstancia.Text = "CompraBuscar";
            var resultadobusqueda = frmBuscarProveedor.ShowDialog();
            if (resultadobusqueda == DialogResult.OK)
            {
                txtProveedorID.Text = VariablesGlobales.vProveedorID.ToString();
                txtProveedorNombre.Text = VariablesGlobales.vProveedorNombre.ToString();
                txtProductoID.Select();
            }
        }

        private async void btnBuscarProducto_Click(object sender, EventArgs e)
        {
            var frmBuscarProducto = _serviceProvider.GetRequiredService<Frm_Productos_Compras>();
            var resultadobusqueda = frmBuscarProducto.ShowDialog();
            if (resultadobusqueda == DialogResult.OK)
            {
                var _ProductoSeleccionado = frmBuscarProducto._ProductoSeleccionado;
                txtProductoID.Text = _ProductoSeleccionado.ID.ToString();
                await ObtenerProducto(Convert.ToInt32(txtProductoID.Text.Trim()));
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var filaSeleccionada = (Compra_D_VM)dgvListado.CurrentRow.DataBoundItem;
                var index = _CompraDetalle.IndexOf(filaSeleccionada);
                _CompraDetalle.RemoveAt(index);

                ActualizaMontos();
            }
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            #region CREAR Y GUARDAR EL ARCHIVO COMPRAS XML
            //Variables según lo seleccionado para incorporar al archivo xml
            int _Tipo = cmbTipo.SelectedIndex + 1;
            int _Pago = cmbFormaPago.SelectedIndex + 1;
            int _Efectivo = 0;
            int _Debito = 0;
            int _Tarjeta = 0;
            int _Credito = 0;

            if (_Pago == 1)
            {
                _Efectivo = Convert.ToInt32(txtMontoTotal.Text.Trim());
            }
            else
            {
                _Credito = Convert.ToInt32(txtMontoTotal.Text.Trim());
            }

            XElement Compra = new XElement("Compra",
                new XElement("Fecha", txtFecha.Text.Trim()),
                new XElement("Tipo", _Pago.ToString()), //Values: 1 Contado | 2 Cuenta Corriente
                new XElement("Numero", "001-1025"),
                new XElement("pCompra", Convert.ToInt32(txtSubTotal.Text.Trim())),
                new XElement("ImpuestoMonto", Convert.ToInt32(txtImpuestosGral.Text.Trim())),
                new XElement("Costo", txtMontoTotal.Text.Trim()),
                new XElement("ImpuestoID", 1), //Convert.ToInt32(txtImpuestoMonto.Text.Trim())
                new XElement("Situacion", Convert.ToInt32(3)), //Values: 1 Grabada | 2 Anulada | 3 Pendiente
                new XElement("ProveedorID", Convert.ToInt32(txtProveedorID.Text.Trim())),
                new XElement("Comprobante", Convert.ToInt32(_Tipo)), //Values: 1;"Remito";2;"Presupuesto";3;"Factura B";4;"Factura A"
                new XElement("Estado", Convert.ToInt32(1)), //Values: 1 Habilitado | 2 Deshabilitado
                new XElement("Tefectivo", _Efectivo),
                new XElement("Tdebito", _Debito),
                new XElement("Ttarjeta", _Tarjeta),
                new XElement("Tcredito", _Credito),
                new XElement("VendedorID", VariablesGlobales.UsuarioID),
                new XElement("SucursalID", VariablesGlobales.SucursalID),
                new XElement("CajaID", VariablesGlobales.CajaID)
                );
            XElement CompraDetalle = new XElement("CompraDetalle");
            foreach (Compra_D_VM item in _CompraDetalle)
            {
                CompraDetalle.Add(new XElement("Item",
                    new XElement("ProductoID", item.ProductoID),
                    new XElement("Cantidad", item.Cantidad),
                    new XElement("pCompra", item.pCompra),
                    new XElement("Costo", item.Costo),
                    new XElement("pOferta", item.pOferta),
                    new XElement("pVenta", item.pVenta),
                    new XElement("Impuesto", item.Impuesto),
                    new XElement("pTotalLinea", item.TotalCosto),
                    new XElement("TramiteID", VariablesGlobales.SucursalID) //Values: 2 Salida por Compra
                    )
                 );
            }
            Compra.Add(CompraDetalle);

            #region Guardar XML
            string folderPath = @"D:\Base de Datos\"; // Ruta de la carpeta
            string fileName = "Compra.xml"; // Nombre del archivo
            string fullPath = Path.Combine(folderPath, fileName); // Ruta completa del archivo

            File.WriteAllText(fullPath, Compra.ToString());

            #endregion
            #endregion

            var CompraNumero = await _comprasService.Registrar(Compra.ToString());
            if (CompraNumero != "" || CompraNumero != null)
            {

                MessageBox.Show("Compra registrada con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _CompraDetalle.Clear();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar la Compra", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void txtProductoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCantidad_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtpCompra.Text = string.Empty;
                txtpCompra.Focus();
            }
        }

        private void txtpCompra_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                //txtImpuestoMonto.Text = string.Empty;
                txtImpuestoMonto.Focus();
            }
        }

        private void txtImpuestoMonto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                if (txtImpuestoMonto.Text.Trim() == "")
                    txtpCosto.Text = string.Empty;
                else if (txtpCompra.Text.Trim() != "" && txtImpuestoMonto.Text.Trim() != "") // && para "y" o || para "o"
                {
                    txtpCosto.Text = (Convert.ToInt32(txtpCompra.Text.Trim()) + Convert.ToInt32(txtImpuestoMonto.Text.Trim())).ToString();
                }
                txtpCosto.Focus();
            }
        }

        private void txtpCosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                //txtpOferta.Text = string.Empty;
                txtpOferta.Focus();
            }
        }

        private void txtpOferta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                //txtpVenta.Text = string.Empty;
                txtpVenta.Focus();
            }
        }

        private void txtpVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                btnAgregarItem.Focus();
            }
        }

        private void txtCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }

        private void txtpCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }

        private void txtImpuestoMonto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }

        private void txtpCosto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }

        private void txtpOferta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }

        private void txtpVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
