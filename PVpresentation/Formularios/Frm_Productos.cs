using PVpresentation.Formularios.Modelos;
using PVpresentation.ViewModels;
using PVservices.Interfaces;
using PVpresentation.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using PVrepository.Entities;
using PVservices.Implementation;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Identity.Client;
using System.Windows;
using MessageBox = System.Windows.MessageBox;
using Application = System.Windows.Forms.Application;



namespace PVpresentation.Formularios
{
    public partial class Frm_Productos : FrmModeloTransaccion
    {
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
        }

        private void MostrarFormulario<TForm>() where TForm : Form
        {
            var newForm = _serviceProvider.GetRequiredService<TForm>();
            newForm.TopLevel = false;
            newForm.TopMost = false;
            pnGral.Controls.Add(newForm);
            pnGral.BringToFront();
            pnTituloFormulario.Visible = false;
            newForm.Show();
        }

        private Frm_Categorias ObtenerFormularioAbierto()
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

        public void CambiarVisibilidadControles()
        {
            // Cambiar visibilidad de paneles
            pnTituloFormulario.Visible = !pnTituloFormulario.Visible;
            pnGral.SendToBack();
            // Añade otros controles que desees manipular
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

            var ListaCategoria = await _categoriaService.Lista();
            var itemsCategoria = ListaCategoria.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbCategoria.InsertarItems(itemsCategoria);

            var ListaMarca = await _marcasService.Lista();
            var itemsMarca = ListaMarca.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbMarca.InsertarItems(itemsMarca);

            var ListaProveedor = await _proveedoresService.Lista();
            var itemsProveedor = ListaProveedor.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbProveedor.InsertarItems(itemsProveedor);
        }

        #endregion

        private async void Frm_Productos_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);
            await MostrarProductos();

            //Completar los datos de los comboBox
            await llenarComboBox();
            cmbCategoria.Validating += cmbCategoria_Validating;
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var ProductoSeleccionado = (ProductosVM)dgvListado.CurrentRow.DataBoundItem;
            txtOpcion.Text = "2"; // 1 Nuevo / 2 Edición
            txtID.Text = ProductoSeleccionado.ID.ToString();
            txtNombre.Text = ProductoSeleccionado.Nombre.ToString();
            cmbSituacion.EstablecerValor(ProductoSeleccionado.Situacion);
            txtBarCode.Text = ProductoSeleccionado.BarCode.ToString();
            txtStock.Text = ProductoSeleccionado.Stock.ToString();
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

        private async void btnCancelar_Click(object sender, EventArgs e)
        {
            await LimpiarMantenimiento();
            MostrarTabs(tabListado.Name);
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            var respuesta = "";
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
            Close();
        }

        private void btnAgregarImpuesto_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            MostrarFormulario<Frm_Categorias>();
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            MostrarFormulario<Frm_Marcas>();
        }

        private void btnAgregarProveedor_Click(object sender, EventArgs e)
        {
            MostrarFormulario<Frm_Proveedores>();
        }

        
        private void cmbCategoria_Validating(object sender, CancelEventArgs e)
        {
            ComboBox cCategoria = sender as ComboBox;
            string textoIngresado = cCategoria.Text.ToString();
            
            bool existe = cCategoria.Items.Cast<string>().Any(item => item.Equals(textoIngresado, StringComparison.OrdinalIgnoreCase));
            if (!existe)
            {
                // El elemento no está en la lista, abrir el formulario para agregarlo
                MostrarFormulario<Frm_Categorias>();
                  
                // Agregar el nuevo elemento a la lista y seleccionarlo
                Frm_Categorias fCate = ObtenerFormularioAbierto();
                if (fCate != null)
                {
                    fCate.LimpiarMantenimiento();
                    fCate.txtNombre.Text = textoIngresado;
                    fCate.btnGrabar.Enabled = true;
                }
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
