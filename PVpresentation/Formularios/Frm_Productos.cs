using Microsoft.Extensions.DependencyInjection;
using PVpresentation.Formularios.Modelos;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Implementation;
using PVservices.Interfaces;
using System.Data;
using System.Drawing.Printing;
using System.Threading.Tasks;
using Application = System.Windows.Forms.Application;
using ComboBox = System.Windows.Forms.ComboBox;
using Control = System.Windows.Forms.Control;
//using MessageBox = System.Windows.MessageBox;
using TextBox = System.Windows.Forms.TextBox;

namespace PVpresentation.Formularios
{
    public partial class Frm_Productos : FrmModeloTransaccion
    {
        // Diccionario para almacenar los colores originales de los controles
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();

        #region Funcionalidades y Constructor del formulario
        private readonly IProductosService _productosService;
        private readonly IImpuestosService _impuestosService;
        private readonly ICategoriaService _categoriaService;
        private readonly IMarcasService _marcasService;
        private readonly IProveedoresService _proveedoresService;
        private readonly IServiceProvider _serviceProvider;

        public Frm_Productos(IProductosService productosService,
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
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)// || control is ComboBox)
                {
                    control.KeyDown += new KeyEventHandler(OnKeyDownHandler);
                }
            }
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(OnKeyDownHandler);
            dgvListado.CellClick += CustomCellClick; // Evento adicional
            // Asignar los eventos Enter y Leave solo a TextBox y ComboBox
            AssignFocusEvents(this);

        }

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
                MostrarTabs(tabNuevo.Name);
                btnAgregarImpuesto.Enabled = true;
                btnAgregarCategoria.Enabled = true;
                btnAgregarMarca.Enabled = true;
                btnAgregarProveedor.Enabled = true;
                btnGrabar.Enabled = true;
                btnEditar.Enabled = false;
            }
        }

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Acción a realizar cuando se presiona Enter
                SelectNextControl((Control)sender, true, true, true, true);
                e.Handled = true; // Para evitar que el evento se propague }
            }
        }

        private void MostrarFormulario<TForm>() where TForm : Form
        {
            var newForm = _serviceProvider.GetRequiredService<TForm>();
            newForm.TopLevel = false;//Esto a False
            newForm.TopMost = false;//Esto a False
            pnGral.Controls.Add(newForm);
            pnGral.BringToFront();
            pnTituloFormulario.Visible = false;
            newForm.Show();
        }

        private void MostrarFormularioEmergente<TForm>() where TForm : Form
        {
            var fCate2 = _serviceProvider.GetRequiredService<TForm>();
            fCate2.ShowDialog();
        }

        private Frm_Categorias ObFormularioAbiertoCategoria()
        {
            foreach (Form formHijo in Application.OpenForms)
            {
                if (formHijo is Frm_Categorias)
                {
                    return (Frm_Categorias)formHijo;
                }
            }
            return null; // No se encontró un formulario abierto de tipo Frm_Categorias
        }
        private Frm_Marcas ObFormularioAbiertoMarca()
        {
            foreach (Form formHijo in Application.OpenForms)
            {
                if (formHijo is Frm_Marcas)
                {
                    return (Frm_Marcas)formHijo;
                }
            }
            return null; // No se encontró un formulario abierto de tipo Frm_Categorias
        }
        private Frm_Proveedores ObFormularioAbiertoProveedor()
        {
            foreach (Form formHijo in Application.OpenForms)
            {
                if (formHijo is Frm_Proveedores)
                {
                    return (Frm_Proveedores)formHijo;
                }
            }
            return null; // No se encontró un formulario abierto de tipo Frm_Categorias
        }

        public void CambiarVisibilidadControles()
        {
            // Cambiar visibilidad de paneles
            pnTituloFormulario.Visible = !pnTituloFormulario.Visible;
            pnGral.SendToBack();
            //pnlContenedorPrincipal.BringToFront();

            // Añade otros controles que desees manipular
        }

        private async Task MostrarProductos(string Buscar = "")
        {
            // Crear una lista vacía de productos
            List<Productos> listaProductos = new List<Productos>();

            if (txtInstancia.Text == "1")
            {
                listaProductos = await _productosService.ListaSF();
            }
            else
            {
                listaProductos = await _productosService.Lista(Buscar);
            }

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
            })  .OrderByDescending(x => x.ID) // ← Orden descendente por BarCode
                .ToList();
            dgvListado.DataSource = VMListaProductos; //Llenar el DG con los datos armados de la listaVM

            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["ID"].Visible = false;
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
        }

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

        private async Task LimpiarMantenimiento()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtBarCode.Text = "";
            cmbSituacion.SelectedIndex = 0;
            txtStock.Text = "0";
            txtCosto.Text = "0";
            txtpOferta.Text = "0";
            txtpVenta.Text = "0";
            cmbImpuesto.SelectedIndex = 0;
            cmbCategoria.SelectedIndex = 0;
            cmbMarca.SelectedIndex = 0;
            cmbProveedor.SelectedIndex = 0;
            txtTalle.Text = "";
            txtColor.Text = "";
            txtID.Enabled = false;
            //txtNombre.Enabled = false;
            txtBuscar.Select();
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = true;
            btnAgregarImpuesto.Enabled = false;
            btnAgregarCategoria.Enabled = false;
            btnAgregarMarca.Enabled = false;
            btnAgregarProveedor.Enabled = false;
            await MostrarProductos(txtBuscar.Text.Trim());
            //MostrarTabs(tabListado.Name);
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

        public async Task agregarCategoriaComboBox(string nombre)
        {
            var ListaCategoria = await _categoriaService.Lista(nombre);
            var itemsCategoria = ListaCategoria.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbCategoria.InsertarItems(itemsCategoria);

            // Obtén el valor del único registro devuelto 
            if (itemsCategoria.Length > 0)
            {
                int valorBuscado = itemsCategoria[0].Valor;
                cmbCategoria.Select();
                cmbCategoria.SelectedIndex = Array.IndexOf(itemsCategoria, itemsCategoria.FirstOrDefault(item => item.Valor == valorBuscado));
            }
        }

        public async Task agregarMarcaComboBox(string nombre)
        {
            var ListaMarca = await _marcasService.Lista(nombre);
            var itemsMarca = ListaMarca.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbMarca.InsertarItems(itemsMarca);

        }

        public async Task agregarProveedorComboBox(string nombre)
        {
            var ListaProveedor = await _proveedoresService.Lista(nombre);
            var itemsProveedor = ListaProveedor.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbProveedor.InsertarItems(itemsProveedor);
        }

        public void evaluarComboBox(ComboBox cmb, string formDependiente)
        {

            string enteredText = cmb.Text;
            bool exists = false;
            foreach (var item in cmb.Items)
            {
                if ((item as OpcionesComboBox).Texto.Equals(enteredText, StringComparison.OrdinalIgnoreCase))
                {
                    exists = true;
                    break;
                }
            }
            if (!exists)
            {
                MessageBox.Show("El texto ingresado no es un elemento de la lista.", "Advertencia");
                // Cancela el evento de validación

                // El elemento no está en la lista, abrir el formulario para agregarlo
                if (formDependiente == "Frm_Categorias")
                {
                    MostrarFormulario<Frm_Categorias>();
                    // Agregar el nuevo elemento a la lista y seleccionarlo
                    Frm_Categorias fCate = ObFormularioAbiertoCategoria();
                    if (fCate != null)
                    {
                        fCate.LimpiarMantenimiento();
                        fCate.txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
                        fCate.txtNombre.Text = cmbCategoria.Text.ToString();
                        fCate.txtNombre.Enabled = true;
                        fCate.txtNombre.Select();
                        fCate.btnGrabar.Enabled = true;
                    }
                }
                else if (formDependiente == "Frm_Marcas")
                {
                    MostrarFormulario<Frm_Marcas>();
                    // Agregar el nuevo elemento a la lista y seleccionarlo
                    Frm_Marcas fCate = ObFormularioAbiertoMarca();
                    if (fCate != null)
                    {
                        fCate.LimpiarMantenimiento();
                        fCate.txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
                        fCate.txtNombre.Text = cmbMarca.Text.ToString();
                        fCate.txtNombre.Enabled = true;
                        fCate.txtNombre.Select();
                        fCate.btnGrabar.Enabled = true;
                    }
                }
                else if (formDependiente == "Frm_Proveedores")
                {
                    MostrarFormulario<Frm_Proveedores>();
                    // Agregar el nuevo elemento a la lista y seleccionarlo
                    Frm_Proveedores fCate = ObFormularioAbiertoProveedor();
                    if (fCate != null)
                    {
                        fCate.LimpiarMantenimiento();
                        fCate.txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
                        fCate.txtNombre.Text = cmbProveedor.Text.ToString();
                        fCate.txtNombre.Enabled = true;
                        fCate.txtNombre.Select();
                        fCate.btnGrabar.Enabled = true;
                    }

                }
            }
        }

        #endregion

        private async void Frm_Productos_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);
            txtInstancia.Text = "1";
            await MostrarProductos();

            //Completar los datos de los comboBox
            await llenarComboBox();
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            txtInstancia.Text = "2";
            await MostrarProductos(txtBuscar.Text.Trim());
        }

        private async void btnNuevo_Click(object sender, EventArgs e)
        {
            await LimpiarMantenimiento();
            MostrarTabs(tabNuevo.Name);
            txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
            tabControlMain.SelectedTab = tabControlMain.TabPages[tabNuevo.Name];
            txtNombre.Select();
            btnAgregarImpuesto.Enabled = true;
            btnAgregarCategoria.Enabled = true;
            btnAgregarMarca.Enabled = true;
            btnAgregarProveedor.Enabled = true;
            btnGrabar.Enabled = true;
        }

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            await LimpiarMantenimiento();
            MostrarTabs(tabListado.Name);
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
                Stock = Convert.ToInt32(txtStock.Text.Trim()),
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
            }
            else //Si la opcion es 1: Nueva
            {
                respuesta = await _productosService.crear(objeTo);
            }

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarProductos();
                MostrarTabs(tabListado.Name);
            }
        }

        private void btnCierreVolver_Click(object sender, EventArgs e)
        {
            if (tabControlMain.SelectedTab != tabListado)
            {
                MostrarTabs(tabListado.Name);
            }
            else
            {
                Close();
            }
        }

        private void btnAgregarImpuesto_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            MostrarFormularioEmergente<Frm_Categorias>();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MostrarFormularioEmergente<Frm_Marcas>();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            MostrarFormularioEmergente<Frm_Proveedores>();
        }

        private async void cmbMarca_Leave(object sender, EventArgs e)
        {
            evaluarComboBox(cmbMarca, "Frm_Marcas");
        }

        private void cmbCategoria_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Acción a realizar cuando se presiona Enter

                evaluarComboBox(cmbCategoria, "Frm_Categorias");
                e.Handled = true; // Para evitar que el evento se propague
                cmbMarca.Focus();
            }
            if (e.KeyCode == Keys.F3)
            { // Código para abrir el formulario deseado
                MostrarFormularioEmergente<Frm_Categorias>();
            }

        }

        private void cmbMarca_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            { // Código para abrir el formulario deseado
                MostrarFormularioEmergente<Frm_Marcas>();
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                cmbProveedor.Focus();
            }
        }

        private void cmbProveedor_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F3)
            { // Código para abrir el formulario deseado
                MostrarFormularioEmergente<Frm_Proveedores>();
            }
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                if (txtOpcion.Text.Trim() == "1")
                {
                    txtStock.Focus();
                }
                else
                {
                    txtCosto.Focus();
                }
            }
        }

        private async void btnEliminar_Click(object sender, EventArgs e)
        {
            var respuesta = "";

            if (MessageBox.Show("¿Está seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                respuesta = await _productosService.eliminar(Convert.ToInt32(txtID.Text.Trim()), 2);
                if (respuesta != "")
                {
                    MessageBox.Show(respuesta);
                }
                else
                {
                    txtInstancia.Text = "1";
                    await MostrarProductos();
                    MostrarTabs(tabListado.Name);
                }
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
                txtBarCode.Text = string.Empty;
                txtBarCode.Focus();
            }
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
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

        private void txtCosto_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtpOferta.Focus();
            }
        }

        private void txtpOferta_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
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

        private void btnEtiquetas_Click(object sender, EventArgs e)
        {
            if(txtID.Text == "")
            {
                MessageBox.Show("Seleccione un producto para imprimir la etiqueta");
                return;
            }

            VariablesGlobales.vProductoID = Convert.ToInt32(txtID.Text.Trim());
            VariablesGlobales.vProductoBarCode = txtBarCode.Text.ToString();
            VariablesGlobales.vProductoNombre = txtNombre.Text.Trim();
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

        }
    }
}
