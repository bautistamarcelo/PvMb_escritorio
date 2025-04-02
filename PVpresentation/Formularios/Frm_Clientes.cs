using PVpresentation.Formularios.Modelos;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Implementation;
using PVservices.Interfaces;
using System.Data;

namespace PVpresentation.Formularios
{
    public partial class Frm_Clientes : FrmModeloTransaccion
    {
        // Diccionario para almacenar los colores originales de los controles
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();

        #region Funcionalidades y Constructor del formulario
        private readonly IClientesService _clientesService;
        private readonly ICaracterService _caracterService;

        public Frm_Clientes(IClientesService clientesService, ICaracterService caracterService)
        {
            InitializeComponent();
            _clientesService = clientesService;
            _caracterService = caracterService;
            dgvListado.CellClick += CustomCellClick; // Evento adicional
            // Asignar los eventos Enter y Leave solo a TextBox y ComboBox
            AssignFocusEvents(this);
        }
        private async void CustomCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                var ClienteSeleccionado = (ClienteVM)dgvListado.CurrentRow.DataBoundItem;
                txtOpcion.Text = "2"; // 1 Nuevo / 2 Edición
                txtNombre.Text = ClienteSeleccionado.Nombre.ToString();
                txtDomicilio.Text = ClienteSeleccionado.Domicilio.ToString();
                txtCuit.Text = ClienteSeleccionado.Cuit.ToString();
                txtEmail.Text = ClienteSeleccionado.Email.ToString();
                txtTelefono.Text = ClienteSeleccionado.Telefono.ToString();
                txtID.Text = ClienteSeleccionado.ID.ToString();
                cmbCaracter.EstablecerValor(ClienteSeleccionado.CaracterID);
                cmbEstado.EstablecerValor(ClienteSeleccionado.EstadoID);
                cmbHabilitadoCta.EstablecerValor(ClienteSeleccionado.CtaCte);

                //txtIDEditar.Visible = true; //Desabilitar cuando compruebe funcionamiento
                MostrarTabs(tabNuevo.Name);
            }
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

        private async Task MostrarClientes(string Buscar = "")
        {
            var listaClientes = await _clientesService.Lista(Buscar);
            var VMListaClientes = listaClientes.Select(item => new ClienteVM //Genero una lista con la estructura de la vista modelo para mostrar en el DG
            {
                ID = item.ID,
                Nombre = item.Nombre,
                Domicilio = item.Domicilio,
                Cuit = item.Cuit,
                Email = item.Email,
                Telefono = item.Telefono,
                EstadoID = item.Estado,
                Estado = item.Estado == 1 ? "Activo" : "Suspendido",
                CaracterID = item.CaracterID.ID,
                Caracter = item.CaracterID.Nombre,
                CtaCte = item.HabilitadoCtaCte,
                Habilitado = item.HabilitadoCtaCte == 1 ? "Habilitado" : "Suspendido"
            }).ToList();
            dgvListado.DataSource = VMListaClientes; //Llenar el DG con los datos armados de la listaVM

            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["EstadoID"].Visible = false;
            dgvListado.Columns["Estado"].Visible = false;
            dgvListado.Columns["CaracterID"].Visible = false;
            dgvListado.Columns["CtaCte"].Visible = false;
            dgvListado.Columns["Habilitado"].Visible = false;
        }

        private async void LimpiarMantenimiento()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtCuit.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            txtOpcion.Text = "0"; // 1 Nuevo / 2 Edición
            cmbCaracter.SelectedIndex = 0;
            cmbEstado.SelectedIndex = 0;
            cmbHabilitadoCta.SelectedIndex = 0;
            txtID.Enabled = false;
            //txtNombre.Enabled = false;
            txtBuscar.Select();
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = true;
            await MostrarClientes(txtBuscar.Text.Trim());
            //MostrarTabs(tabListado.Name);
        }
        #endregion

        #region CRUD y Navegación del formulario

        private async void Frm_Clientes_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);
            await MostrarClientes(txtBuscar.Text.Trim());

            //Completo los datos de los comboBox no enlazados con otras tablas
            OpcionesComboBox[] itemsEstados = new OpcionesComboBox[]
            {
                new OpcionesComboBox{Texto="Activo",Valor=1},
                new OpcionesComboBox{Texto="Suspendido",Valor=2}
            };
            cmbEstado.InsertarItems(itemsEstados);

            OpcionesComboBox[] itemsHabilitado = new OpcionesComboBox[]
           {
                new OpcionesComboBox{Texto="Si",Valor=1},
                new OpcionesComboBox{Texto="No",Valor=2}
           };
            cmbHabilitadoCta.InsertarItems(itemsHabilitado);

            var ListaCaracter = await _caracterService.Lista();
            var items = ListaCaracter.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();

            cmbCaracter.InsertarItems(items);
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarClientes(txtBuscar.Text.Trim());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            MostrarTabs(tabListado.Name);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            txtID.Enabled = false;
            txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
            MostrarTabs(tabNuevo.Name);
            txtNombre.Select();
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

        private async void btnGrabar_Click(object sender, EventArgs e)
        {
            var respuesta = "";
            //Validamos que los campos no se encuentren vacíos
            if (txtNombre.Text.Trim() == "")
            {
                MessageBox.Show("El Nombre del Cliente es obligatorio");
                return;
            }
            if (txtDomicilio.Text.Trim() == "")
            {
                MessageBox.Show("El Domicilio del Cliente es obligatorio");
                return;
            }
            if (txtCuit.Text.Trim() == "")
            {
                MessageBox.Show("El DNI ó CUIT del Cliente es obligatorio");
                return;
            }

            //Creo las variables con los valores de los comboBox
            var itemEstado = (OpcionesComboBox)cmbEstado.SelectedItem!;
            var itemCaracter = (OpcionesComboBox)cmbCaracter.SelectedItem!;
            var itemSituacion = (OpcionesComboBox)cmbHabilitadoCta.SelectedItem!;

            //Cargo los datos en el objeto Cliente para guardarlo después
            var objeTo = new Clientes
            {
                ID = Convert.ToInt32(txtID.Text.Trim()),
                Nombre = txtNombre.Text.Trim(),
                Domicilio = txtDomicilio.Text.Trim(),
                Cuit = txtCuit.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                Estado = itemEstado.Valor,
                CaracterID = new Caracter { ID = itemCaracter.Valor },
                HabilitadoCtaCte = itemSituacion.Valor
            };

            //Evalúo si es nuevo o edición
            if (txtOpcion.Text.Trim() == "2") // Si la opcion es 2: Editar
            {
                respuesta = await _clientesService.editar(objeTo);
            }
            else //Si la opcion es 1: Nueva
            {
                respuesta = await _clientesService.crear(objeTo);
            }

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarClientes();
                MostrarTabs(tabListado.Name);

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "" || txtID.Text.Trim() == "0" || txtID.Text.Trim() == "1")
            {
                MessageBox.Show("Debe seleccionar un cliente diferente a la selección actual para eliminar");
                return;
            }
            else
            {
                if (MessageBox.Show("¿Está seguro de eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    _clientesService.Eliminar(Convert.ToInt32(txtID.Text.Trim()), 2);
                    MostrarClientes();
                    MostrarTabs(tabListado.Name);
                }
            }
        }

        #endregion|

        private void txtNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtDomicilio.Text = string.Empty;
                txtDomicilio.Focus();
            }
        }

        private void txtDomicilio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtCuit.Text = string.Empty;
                txtCuit.Focus();
            }
        }

        private void txtCuit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtEmail.Text = string.Empty;
                txtEmail.Focus();
            }
        }

        private void txtEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtTelefono.Text = string.Empty;
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                cmbEstado.Focus();
            }
        }

        private void cmbEstado_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                cmbCaracter.Focus();
            }
        }

        private void cmbCaracter_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                cmbHabilitadoCta.Focus();
            }
        }
    }
}
