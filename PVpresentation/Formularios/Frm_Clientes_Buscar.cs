using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Implementation;
using PVservices.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PVpresentation.Formularios
{
    public partial class Frm_Clientes_Buscar : Form
    {
        // Diccionario para almacenar los colores originales de los controles
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();

        private readonly IClientesService _clientesService;
        private readonly ICaracterService _caracterService;
        public ClienteVM _ClienteSeleccionado { get; set; } = null!;

        public Frm_Clientes_Buscar(IClientesService clientesService, ICaracterService caracterService)
        {
            InitializeComponent();
            _clientesService = clientesService;
            _caracterService = caracterService;
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
            
            dgvListado.Columns["Nombre"].FillWeight = 350;
            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["ID"].Visible = false;
            dgvListado.Columns["EstadoID"].Visible = false;
            dgvListado.Columns["Estado"].Visible = false;
            dgvListado.Columns["CaracterID"].Visible = false;
            dgvListado.Columns["CtaCte"].Visible = false;
            dgvListado.Columns["Habilitado"].Visible = false;
        }

        private async void Frm_Clientes_Buscar_Load(object sender, EventArgs e)
        {
            dgvListado.ImplementarConfiguracion("Seleccionar");
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

            if (txtInstancia.Text == "5")// Llamado desde Formulario Recibos
            {
                btnNuevo.Enabled=false;
            }

        }

        private async void txtBuscar_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await MostrarClientes(txtBuscar.Text.Trim());
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarClientes(txtBuscar.Text.Trim());
        }

        private void dgvListado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListado.Columns[e.ColumnIndex].Name == "ColumnaAccion")
            {
                _ClienteSeleccionado = (ClienteVM)dgvListado.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void dgvListado_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (txtInstancia.Text == "5")// Llamado desde Formulario Recibos
            {
                return;
            }
            _ClienteSeleccionado = (ClienteVM)dgvListado.CurrentRow.DataBoundItem;
            txtOpcion.Text = "2"; // 1 Nuevo / 2 Edición
            txtNombre.Text = _ClienteSeleccionado.Nombre.ToString();
            txtDomicilio.Text = _ClienteSeleccionado.Domicilio.ToString();
            txtCuit.Text = _ClienteSeleccionado.Cuit.ToString();
            txtEmail.Text = _ClienteSeleccionado.Email.ToString();
            txtTelefono.Text = _ClienteSeleccionado.Telefono.ToString();
            txtID.Text = _ClienteSeleccionado.ID.ToString();
            cmbCaracter.EstablecerValor(_ClienteSeleccionado.CaracterID);
            cmbEstado.EstablecerValor(_ClienteSeleccionado.EstadoID);
            cmbHabilitadoCta.EstablecerValor(_ClienteSeleccionado.CtaCte);

            //txtIDEditar.Visible = true; //Desabilitar cuando compruebe funcionamiento
            MostrarTabs(tabNuevo.Name);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (txtInstancia.Text == "5")// Llamado desde Formulario Recibos
            {
                return;
            }
            txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
            MostrarTabs(tabNuevo.Name);
            txtNombre.Select();
        }

        private async  void btnGrabar_Click(object sender, EventArgs e)
        {
            #region VALIDACIONES
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
            #endregion

            #region Creo las variables con los valores de los comboBox
            var itemEstado = (OpcionesComboBox)cmbEstado.SelectedItem!;
            var itemCaracter = (OpcionesComboBox)cmbCaracter.SelectedItem!;
            var itemSituacion = (OpcionesComboBox)cmbHabilitadoCta.SelectedItem!;
            #endregion

            #region Cargo los datos en el objeto Cliente para guardarlo después
            var _objeTo = new Clientes
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
            #endregion

            //Evalúo si es nuevo o edición
            if (txtOpcion.Text.Trim() == "2") // Si la opcion es 2: Editar
            {
                respuesta = await _clientesService.editar(_objeTo);
            }
            else //Si la opcion es 1: Nueva
            {
                respuesta = await _clientesService.crear(_objeTo);
            }

            //Evalúo si se produjo un error 
            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                
                if (txtOpcion.Text.Trim() == "1") // Si la opcion es 1: Nuevo
                {
                    _objeTo.ID = Convert.ToInt32(await _clientesService.Buscar(respuesta));
                }

                _ClienteSeleccionado.ID = _objeTo.ID;
                _ClienteSeleccionado.Nombre = _objeTo.Nombre;
                _ClienteSeleccionado.Domicilio = _objeTo.Domicilio;
                _ClienteSeleccionado.Cuit = _objeTo.Cuit;
                _ClienteSeleccionado.Email = _objeTo.Email;
                _ClienteSeleccionado.Telefono = _objeTo.Telefono;
                _ClienteSeleccionado.EstadoID = _objeTo.Estado;
                _ClienteSeleccionado.CaracterID = _objeTo.CaracterID.ID;
                _ClienteSeleccionado.CtaCte = _objeTo.HabilitadoCtaCte;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        
    }
}
