using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVservices.Implementation;
using PVservices.Interfaces;

namespace PVpresentation.Formularios
{
    public partial class Frm_Productos_BuscaDeInstancia : Form
    {
        private readonly IProductosService _productosService;
        public ProductosVM _ProductoSeleccionado { get; set; } = null!;

        public Frm_Productos_BuscaDeInstancia(IProductosService productoService)
        {
            InitializeComponent();
            _productosService = productoService;
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

        private async void Frm_Productos_BuscaDeInstancia_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Seleccionar");


            await MostrarProductos();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarProductos(txtBuscar.Text.Trim());
        }

        private void dgvListado_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _ProductoSeleccionado = (ProductosVM)dgvListado.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                _ProductoSeleccionado = (ProductosVM)dgvListado.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
