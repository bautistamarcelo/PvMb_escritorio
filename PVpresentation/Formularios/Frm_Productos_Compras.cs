using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Interfaces;
using System.Data;
using System.Runtime.InteropServices;

namespace PVpresentation.Formularios
{
    public partial class Frm_Productos_Compras : Form
    {
        #region Funcionalidades y Constructor del formulario
        // Diccionario para almacenar los colores originales de los controles
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();
        private readonly IProductosService _productosService;
        private readonly IImpuestosService _impuestosService;
        private readonly ICategoriaService _categoriaService;
        private readonly IMarcasService _marcasService;
        private readonly IProveedoresService _proveedoresService;
        private readonly IServiceProvider _serviceProvider;
        public ProductosVM _ProductoSeleccionado { get; set; } = null!;

        public Frm_Productos_Compras(IProductosService productosService,
                                                        IImpuestosService impuestosService,
                                                        ICategoriaService categoriaService,
                                                        IMarcasService marcasService,
                                                        IProveedoresService proveedoresService,
                                                        IServiceProvider serviceProvider)
        {
            InitializeComponent();
            _productosService = productosService;
            _impuestosService = impuestosService;
            _categoriaService = categoriaService;
            _marcasService = marcasService;
            _proveedoresService = proveedoresService;
            _serviceProvider = serviceProvider;
            _productosService = productosService;
            dgvListado.CellClick += CustomCellClick; // Evento adicional
            // Asignar los eventos Enter y Leave solo a TextBox y ComboBox
            AssignFocusEvents(this);

        }
        private async void CustomCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var ProductoSeleccionado = (ProductosVM)dgvListado.CurrentRow.DataBoundItem;
                txtOpcion.Text = "2"; // 1 Nuevo / 2 Edición
                txtID.Text = ProductoSeleccionado.ID.ToString();
                txtNombre.Text = ProductoSeleccionado.Nombre.ToString();
                cmbSituacion.EstablecerValor(ProductoSeleccionado.Situacion);
                txtBarCode.Text = ProductoSeleccionado.BarCode.ToString();
                txtStock.Text = ProductoSeleccionado.Stock.ToString();
                txtStock.ReadOnly = true;
                txtCosto.Text = ProductoSeleccionado.Costo.ToString();
                txtpOferta.Text = ProductoSeleccionado.pOferta.ToString();
                txtpVenta.Text = ProductoSeleccionado.pVenta.ToString();
                cmbImpuesto.EstablecerValor(ProductoSeleccionado.ImpuestoID);
                cmbCategoria.EstablecerValor(ProductoSeleccionado.CategoriaID);
                cmbMarca.EstablecerValor(ProductoSeleccionado.MarcaID);
                cmbProveedor.EstablecerValor(ProductoSeleccionado.ProveedorID);
                txtTalle.Text = ProductoSeleccionado.Talle.ToString();
                txtColor.Text = ProductoSeleccionado.Color.ToString();
                txtID.Visible = true; //Desabilitar cuando compruebe funcionamiento
                txtNombre.Select();
                btnAgregarImpuesto.Enabled = true;
                btnAgregarCategoria.Enabled = true;
                btnAgregarMarca.Enabled = true;
                btnAgregarProveedor.Enabled = true;
                btnGrabar.Enabled = true;
            }
        }
        public async Task llenarComboBox()
        {
            //Completo los datos de los comboBox no enlazados con otras tablas
            OpcionesComboBox[] itemsSituacion = new OpcionesComboBox[]
            {
                new OpcionesComboBox{Texto="Activo",Valor=1},
                new OpcionesComboBox{Texto="Suspendido",Valor=2}
            };
            cmbSituacion.InsertarItems(itemsSituacion);

            //Completo los datos de los comboBox enlazados con otras tablas
            var ListaImpuesto = await _impuestosService.Lista();
            var itemsImpuesto = ListaImpuesto.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbImpuesto.InsertarItems(itemsImpuesto);
            cmbImpuesto.Sorted = true;

            var ListaCategoria = await _categoriaService.Lista();
            var itemsCategoria = ListaCategoria.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbCategoria.InsertarItems(itemsCategoria);
            cmbCategoria.Sorted = true;

            var ListaMarca = await _marcasService.Lista();
            var itemsMarca = ListaMarca.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbMarca.InsertarItems(itemsMarca);
            cmbMarca.Sorted = true;

            var ListaProveedor = await _proveedoresService.Lista();
            var itemsProveedor = ListaProveedor.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbProveedor.InsertarItems(itemsProveedor);
            cmbProveedor.Sorted = true;
        }

        #endregion

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

        public void MostrarTabs(string tabName)
        {
            var tabsMenu = new TabPage[] { tabListado, tabNuevo }; //, tabEditar
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

        private async Task MostrarProductos(string Buscar = "")
        {

            var listaProductos = await _productosService.Lista(Buscar);
            var VMListaProductos = listaProductos.Select(item => new ProductosVM //Genero una lista con la estructura de la vista modelo para mostrar en el DG
            {
                ID = item.ID,
                Nombre = item.Nombre,
                Situacion = item.Situacion,
                BarCode = item.BarCode,
                Stock = item.Stock,
                Costo = item.Costo,
                pOferta = item.pOferta,
                pVenta = item.pVenta,
                ImpuestoID = item.Impuesto.ID,
                CategoriaID = item.Categoria.ID,
                CategoriaN = item.Categoria.Nombre,
                MarcaID = item.Marca.ID,
                MarcaN = item.Marca.Nombre,
                ProveedorID = item.Proveedor.ID,
                ProveedorN = item.Proveedor.Nombre,
                Talle = item.Talle,
                Color = item.Color
            }).ToList();
            dgvListado.DataSource = VMListaProductos; //Llenar el DG con los datos armados de la listaVM

            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["ID"].Visible = false;
            dgvListado.Columns["BarCode"].Visible = false;
            dgvListado.Columns["Situacion"].Visible = false;
            dgvListado.Columns["ImpuestoID"].Visible = false;
            dgvListado.Columns["CategoriaID"].Visible = false;
            dgvListado.Columns["CategoriaN"].Visible = false;
            dgvListado.Columns["MarcaID"].Visible = false;
            dgvListado.Columns["MarcaN"].Visible = false;
            dgvListado.Columns["ProveedorID"].Visible = false;
            dgvListado.Columns["ProveedorN"].Visible = false;
            dgvListado.Columns["Talle"].Visible = false;
            dgvListado.Columns["Color"].Visible = false;
            dgvListado.Columns["Nombre"].FillWeight = 350;
            dgvListado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private async void Frm_Productos_Compras_Load(object sender, EventArgs e)
        {
            await llenarComboBox();
            if (tabControlMain.SelectedTab == tabListado)
            {
                dgvListado.ImplementarConfiguracion("Editar");
                await MostrarProductos();
            }
            else
            {
                if (txtInstancia.Text == "CompraEditar")
                {
                    cmbImpuesto.EstablecerValor(Convert.ToInt32(txtImpuesto.Text));
                    cmbCategoria.EstablecerValor(Convert.ToInt32(txtCategoria.Text));
                    cmbMarca.EstablecerValor(Convert.ToInt32(txtMarca.Text));
                    cmbProveedor.EstablecerValor(Convert.ToInt32(txtProveedorID.Text));
                }
                if (txtInstancia.Text == "CompraNuevo")
                {
                    txtID.Text = "0";
                    txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
                    txtNombre.Text = "";
                    cmbSituacion.SelectedIndex = 0;
                    txtBarCode.Text = "";
                    txtStock.Text = "0";
                    //txtStock.ReadOnly = true;
                    txtCosto.Text = "0";
                    txtpOferta.Text = "0";
                    txtpVenta.Text = "0";
                    cmbImpuesto.SelectedIndex = 0;
                    cmbCategoria.SelectedIndex = 0;
                    cmbMarca.SelectedIndex = 0;
                    cmbProveedor.SelectedIndex = 0;
                    txtTalle.Text = "";
                    txtColor.Text = "";
                    txtID.Visible = true; //Desabilitar cuando compruebe funcionamiento
                    txtNombre.Select();
                    btnAgregarImpuesto.Enabled = true;
                    btnAgregarCategoria.Enabled = true;
                    btnAgregarMarca.Enabled = true;
                    btnAgregarProveedor.Enabled = true;
                    btnGrabar.Enabled = true;
                }
            }

        }

        private void tabNuevo_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Productos_Compras_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            var respuesta = "";
            var miID = 0;
            if (txtID.Text == "")
            {
                miID = 0;
            }
            else
            {
                miID = Convert.ToInt32(txtID.Text.Trim());
            }
            txtFecha.Text = DateTime.Now.ToString();

            #region Validación de Campos obligatorios
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre del Producto es obligatorio");
                return;
            }
            if (cmbSituacion.Text == null)
            {
                MessageBox.Show("Seleccione la Situación para este producto");
                return;
            }
            if (cmbImpuesto.Text == null)
            {
                MessageBox.Show("Seleccione el impuesto para este producto");
                return;
            }
            if (cmbCategoria.Text == null)
            {
                MessageBox.Show("Seleccione la Categoría para este producto");
                return;
            }
            if (cmbMarca.Text == null)
            {
                MessageBox.Show("Seleccione la Marca para este producto");
                return;
            }
            if (cmbProveedor.Text == null)
            {
                MessageBox.Show("Seleccione el proveedor para este producto");
                return;
            }
            if (txtStock.Text.Trim() == "")
            {
                txtStock.Text = "0";
            }
            if (txtCosto.Text.Trim() == "")
            {
                MessageBox.Show("El Costo del Producto es obligatorio");
                return;
            }
            if (txtpOferta.Text.Trim() == "")
            {
                MessageBox.Show("El Precio de Oferta del Producto es obligatorio");
                return;
            }
            if (txtpVenta.Text.Trim() == "")
            {
                MessageBox.Show("El Precio de Venta del Producto es obligatorio");
                return;
            }
            #endregion

            //Creo las variables con los valores de los comboBox
            #region Variables de los ComboBox
            var itemSituación = (OpcionesComboBox)cmbSituacion.SelectedItem!;
            var itemImpuesto = (OpcionesComboBox)cmbImpuesto.SelectedItem!;
            var itemCategoria = (OpcionesComboBox)cmbCategoria.SelectedItem!;
            var itemMarca = (OpcionesComboBox)cmbMarca.SelectedItem!;
            var itemProveedor = (OpcionesComboBox)cmbProveedor.SelectedItem!;
            #endregion

            //Cargo los datos en el objeto Productos para guardarlo después
            var objeTo = new Productos
            {
                ID = miID,
                Nombre = txtNombre.Text.Trim(),
                Situacion = itemSituación.Valor,
                BarCode = txtBarCode.Text.Trim(),
                Stock = 0,
                Costo = Convert.ToInt32(txtCosto.Text.Trim()),
                pOferta = Convert.ToInt32(txtpOferta.Text.Trim()),
                pVenta = Convert.ToInt32(txtpVenta.Text.Trim()),
                fechaRegistro = Convert.ToDateTime(txtFecha.Text),
                Impuesto = new Impuestos { ID = itemImpuesto.Valor },
                Categoria = new Categorias { ID = itemCategoria.Valor },
                Marca = new Marcas { ID = itemMarca.Valor },
                Proveedor = new Proveedores { ID = itemProveedor.Valor },
                Talle = txtTalle.Text.Trim(),
                Color = txtColor.Text.Trim()
            };

            //Evalúo si es nuevo o edición
            if (txtOpcion.Text.Trim() == "2") // Si la opcion es 2: Editar
            {
                respuesta = await _productosService.editar(objeTo);

                VariablesGlobales.vProductoID = objeTo.ID;
                VariablesGlobales.vProductoNombre = objeTo.Nombre;
                VariablesGlobales.vProductoPcosto = objeTo.Costo;
                VariablesGlobales.vProductoPoferta = objeTo.pOferta;
                VariablesGlobales.vProductoPventa = objeTo.pVenta;

            }
            else //Si la opcion es 1: Nueva
            {
                respuesta = await _productosService.crear(objeTo);
                Productos _producto = await _productosService.ObtenerXnombre(objeTo.Nombre);
                if (_producto != null)
                {
                    VariablesGlobales.vProductoID = _producto.ID;
                    VariablesGlobales.vProductoNombre = _producto.Nombre;
                    VariablesGlobales.vProductoPcosto = _producto.Costo;
                    VariablesGlobales.vProductoPoferta = _producto.pOferta;
                    VariablesGlobales.vProductoPventa = _producto.pVenta;
                    VariablesGlobales.vProductoStock = Convert.ToInt32(txtStock.Text.Trim());
                }
            }

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
                //MostrarTabs(tabListado.Name);
            }
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                _ProductoSeleccionado = (ProductosVM)dgvListado.CurrentRow.DataBoundItem;
                txtID.Text = _ProductoSeleccionado.ID.ToString();
                txtOpcion.Text = "2"; // 1 Nuevo / 2 Edición
                txtNombre.Text = _ProductoSeleccionado.Nombre.ToString();
                cmbSituacion.EstablecerValor(_ProductoSeleccionado.Situacion);
                txtBarCode.Text = _ProductoSeleccionado.BarCode.ToString();
                txtStock.Text = _ProductoSeleccionado.Stock.ToString();
                txtStock.ReadOnly = true;
                txtCosto.Text = _ProductoSeleccionado.Costo.ToString();
                txtpOferta.Text = _ProductoSeleccionado.pOferta.ToString();
                txtpVenta.Text = _ProductoSeleccionado.pVenta.ToString();
                cmbImpuesto.EstablecerValor(_ProductoSeleccionado.ImpuestoID);
                cmbCategoria.EstablecerValor(_ProductoSeleccionado.CategoriaID);
                cmbMarca.EstablecerValor(_ProductoSeleccionado.MarcaID);
                cmbProveedor.EstablecerValor(_ProductoSeleccionado.ProveedorID);
                txtTalle.Text = _ProductoSeleccionado.Talle.ToString();
                txtColor.Text = _ProductoSeleccionado.Color.ToString();
                txtID.Visible = true; //Desabilitar cuando compruebe funcionamiento
                txtNombre.Select();
                MostrarTabs(tabNuevo.Name);
                btnAgregarImpuesto.Enabled = true;
                btnAgregarCategoria.Enabled = true;
                btnAgregarMarca.Enabled = true;
                btnAgregarProveedor.Enabled = true;
                btnGrabar.Enabled = true;

            }
        }

        private void dgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ProductoSeleccionado = (ProductosVM)dgvListado.CurrentRow.DataBoundItem;
            VariablesGlobales.vProductoID = _ProductoSeleccionado.ID;
            VariablesGlobales.vProductoNombre = _ProductoSeleccionado.Nombre;
            VariablesGlobales.vProductoPcosto = _ProductoSeleccionado.Costo;
            VariablesGlobales.vProductoPoferta = _ProductoSeleccionado.pOferta;
            VariablesGlobales.vProductoPventa = _ProductoSeleccionado.pVenta;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarProductos(txtBuscar.Text);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtID.Text = "0";
            txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
            txtNombre.Text = "";
            cmbSituacion.SelectedIndex = 0;
            txtBarCode.Text = "";
            txtStock.Text = "0";
            //txtStock.ReadOnly = true;
            txtCosto.Text = "0";
            txtpOferta.Text = "0";
            txtpVenta.Text = "0";
            cmbImpuesto.SelectedIndex = 0;
            cmbCategoria.SelectedIndex = 0;
            cmbMarca.SelectedIndex = 0;
            cmbProveedor.SelectedIndex = 0;
            txtTalle.Text = "";
            txtColor.Text = "";
            txtID.Visible = true; //Desabilitar cuando compruebe funcionamiento
            txtNombre.Select();
            MostrarTabs(tabNuevo.Name);
            btnAgregarImpuesto.Enabled = true;
            btnAgregarCategoria.Enabled = true;
            btnAgregarMarca.Enabled = true;
            btnAgregarProveedor.Enabled = true;
            btnGrabar.Enabled = true;
        }

        private void pnTituloFormulario_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void txtID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtNombre.Text = string.Empty;
                txtNombre.Focus();
            }
        }

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                cmbSituacion.Focus();
            }
        }

        private void cmbSituacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                cmbImpuesto.Focus();
            }
        }

        private void cmbImpuesto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                cmbCategoria.Focus();
            }
        }

        private void cmbCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                cmbMarca.Focus();
            }
        }

        private void cmbMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                cmbProveedor.Focus();
            }
        }

        private void cmbProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtTalle.Text = string.Empty;
                txtTalle.Focus();
            }
        }

        private void txtTalle_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtColor.Text = string.Empty;
                txtColor.Focus();
            }
        }

        private void txtColor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtStock.Text = string.Empty;
                txtStock.Focus();
            }
        }

        private void txtStock_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtCosto.Text = string.Empty;
                txtCosto.Focus();
            }
        }

        private void txtCosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtpOferta.Text = string.Empty;
                txtpOferta.Focus();
            }
        }

        private void txtpOferta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtpVenta.Text = string.Empty;
                txtpVenta.Focus();
            }
        }

        private void txtpVenta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                btnGrabar.Focus();
            }
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }

        private void txtCosto_KeyPress(object sender, KeyPressEventArgs e)
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
    }
}
