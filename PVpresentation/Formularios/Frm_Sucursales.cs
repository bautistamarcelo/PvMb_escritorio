using PVpresentation.Formularios.Modelos;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Interfaces;
using System.Data;

namespace PVpresentation.Formularios
{
    public partial class Frm_Sucursales : FrmModeloCRUD
    {
        // Diccionario para almacenar los colores originales de los controles
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();

        #region Funcionalidades y Constructor del formulario
        private readonly IEmpresaService _empresaService;
        private readonly ISucursalesService _sucursalesService;

        public Frm_Sucursales(ISucursalesService sucursalesService, IEmpresaService empresaService)
        {
            InitializeComponent();
            _sucursalesService = sucursalesService;
            _empresaService = empresaService;
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

        private async Task MostrarSucursales(string Buscar = "")
        {
            var listaSucursales = await _sucursalesService.Lista(Buscar);
            var VMListaSucursales = listaSucursales.Select(item => new SucursalesVM //Genero una lista con la estructura de la vista modelo para mostrar en el DG
            {
                ID = item.ID,
                Nombre = item.Nombre,
                Direccion = item.Direccion,
                Telefono = item.Telefono,
                Email = item.Email,
                EmpresaID = item.EmpresaID.ID,
                EmpresaNombre = item.EmpresaID.Nombre,
            }).ToList();
            dgvListado.DataSource = VMListaSucursales; //Llenar el DG con los datos armados de la listaVM

            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["ID"].Visible = false;
            dgvListado.Columns["EmpresaID"].Visible = false;
        }

        public async void LimpiarMantenimiento()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtOpcion.Text = "0"; // 1 Nuevo / 2 Edición
            cmbEmpresa.SelectedIndex = 0;
            txtID.Enabled = false;
            txtBuscar.Select();
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = true;
            await MostrarSucursales(txtBuscar.Text.Trim());
            //MostrarTabs(tabListado.Name);
        }
        #endregion

        #region CRUD y Navegación del formulario
        private async void Frm_Sucursales_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);
            await MostrarSucursales();

            //Completo los datos de los comboBox no enlazados con otras tablas
            var listaEmpresas = await _empresaService.Lista();
            var items = listaEmpresas.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();

            cmbEmpresa.InsertarItems(items);

        }

        private void btnCierreVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarSucursales(txtBuscar.Text.Trim());
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
            txtID.Enabled = false;
            btnGrabar.Enabled = true;
            //MostrarTabs(tabNuevo.Name);
            txtNombre.Select();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            txtOpcion.Text = "2"; // 1 Nuevo / 2 Edición
            txtID.Enabled = false;
            btnGrabar.Enabled = true;
            //MostrarTabs(tabEditar.Name);
            var SucursalSeleccionada = (SucursalesVM)dgvListado.CurrentRow.DataBoundItem;
            txtNombre.Text = SucursalSeleccionada.Nombre.ToString();
            txtDireccion.Text = SucursalSeleccionada.Direccion.ToString();
            txtEmail.Text = SucursalSeleccionada.Email.ToString();
            txtTelefono.Text = SucursalSeleccionada.Telefono.ToString();
            txtID.Text = SucursalSeleccionada.ID.ToString();
            cmbEmpresa.EstablecerValor(SucursalSeleccionada.EmpresaID);
            txtID.Visible = true; //Desabilitar cuando compruebe funcionamiento
            MostrarTabs(tabEditar.Name);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            //MostrarTabs(tabListado.Name);
            btnGrabar.Enabled = false;
        }

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            //Validamos que los campos no se encuentren vacíos
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre de la sucursal es obligatorio");
                return;
            }
            if (txtDireccion.Text.Trim() == "")
            {
                MessageBox.Show("El Domicilio de la sucursal es obligatorio");
                return;
            }
            if (cmbEmpresa.SelectedIndex == 0)
            {
                MessageBox.Show("La selección de la empresa es obligatoria");
                return;
            }

            //Creo las variables con los valores de los comboBox
            var itemEmpresas = (OpcionesComboBox)cmbEmpresa.SelectedItem!;

            //Cargo los datos en el objeto Empresa para guardarlo después
            var objeTo = new Sucursales
            {
                ID = Convert.ToInt32(txtID.Text.Trim()),
                Nombre = txtNombre.Text.Trim(),
                Direccion = txtDireccion.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                EmpresaID = new Empresa { ID = itemEmpresas.Valor }
            };

            //Evalúo si es nuevo o edición
            if (txtOpcion.Text.Trim() == "2") // Si la opcion es 2: Editar
            {
                respuesta = await _sucursalesService.editar(objeTo);
            }
            else //Si la opcion es 1: Nueva
            {
                respuesta = await _sucursalesService.crear(objeTo);
            }

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarSucursales();
                MostrarTabs(tabListado.Name);
                btnGrabar.Enabled = false;
            }
        }
        #endregion
    }
}
