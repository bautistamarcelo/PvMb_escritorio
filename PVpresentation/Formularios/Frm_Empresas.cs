using PVpresentation.Formularios.Modelos;
using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVservices.Implementation;
using PVservices.Interfaces;
using System.Data;


namespace PVpresentation.Formularios
{
    public partial class Frm_Empresas : FrmModeloTransaccion
    {
        // Diccionario para almacenar los colores originales de los controles
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();

        private readonly IEmpresaService _empresaService;
        private readonly ICaracterService _caracterService;
        OpenFileDialog _openFileDialog = new OpenFileDialog();

        public Frm_Empresas(IEmpresaService empresaService, ICaracterService caracterService)
        {
            InitializeComponent();
            _empresaService = empresaService;
            _caracterService = caracterService;
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
                var EmpresaSeleccionada = (EmpresaVM)dgvListado.CurrentRow.DataBoundItem;
                txtNombre.Text = EmpresaSeleccionada.Nombre.ToString();
                txtDomicilio.Text = EmpresaSeleccionada.Direccion.ToString();
                txtCuit.Text = EmpresaSeleccionada.Cuit.ToString();
                txtLogoUrl.Text = EmpresaSeleccionada.LogoUrl.ToString();
                txtLogoNombre.Text = EmpresaSeleccionada.LogoNombre.ToString();
                txtTelefono.Text = EmpresaSeleccionada.Telefono.ToString();
                txtID.Text = EmpresaSeleccionada.ID.ToString();
                cmbCaracter.EstablecerValor(EmpresaSeleccionada.CaracterID);
                txtMoneda.Text = EmpresaSeleccionada.SimboloMoneda.ToString();
                txtOpcion.Text = "2"; // 1 Nuevo / 2 Edición
                txtID.Visible = true; //Desabilitar cuando compruebe funcionamiento
                MostrarTabs(tabNuevo.Name);

                if (txtLogoUrl.Text != "")
                    ImagenLogo.ImageLocation = txtLogoUrl.Text;

            }
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

        private async Task MostrarEmpresas(string Buscar = "")
        {

            var listaEmpresas = await _empresaService.Lista(Buscar);
            var VMListaEmpresas = listaEmpresas.Select(item => new EmpresaVM //Genero una lista con la estructura de la vista modelo para mostrar en el DG
            {
                ID = item.ID,
                Nombre = item.Nombre,
                Direccion = item.Direccion,
                Cuit = item.Cuit,
                Telefono = item.Telefono,
                LogoUrl = item.LogoUrl,
                LogoNombre = item.LogoNombre,
                CaracterID = item.CaracterID.ID,
                Caracter = item.CaracterID.Nombre,
                SimboloMoneda = item.SimboloMoneda
            }).ToList();
            dgvListado.DataSource = VMListaEmpresas; //Llenar el DG con los datos armados de la listaVM

            //Selecciono las columnas que no deseo mostrar en el formulario
            dgvListado.Columns["ID"].Visible = false;
            dgvListado.Columns["LogoUrl"].Visible = false;
            dgvListado.Columns["LogoNombre"].Visible = false;
            dgvListado.Columns["CaracterID"].Visible = false;
            dgvListado.Columns["SimboloMoneda"].Visible = false;

        }

        private async void LimpiarMantenimiento()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtDomicilio.Text = "";
            txtCuit.Text = "";
            txtTelefono.Text = "";
            txtOpcion.Text = "0"; // 1 Nuevo / 2 Edición
            cmbCaracter.SelectedIndex = 0;
            txtLogoUrl.Text = "";
            txtLogoNombre.Text = "";
            txtID.Enabled = false;
            //txtNombre.Enabled = false;
            txtBuscar.Select();
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = true;
            await MostrarEmpresas(txtBuscar.Text.Trim());
            //MostrarTabs(tabListado.Name);
        }

        private async void Frm_Empresas_Load(object sender, EventArgs e)
        {

            dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);
            await MostrarEmpresas();
            _openFileDialog.Filter = "Escoger Imagen Logo (*.JPG;*.PNG)|*.jpg;*.png";
            ImagenLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            btnEditar.Enabled = false;
            btnEditar.Visible = false;

            //Completo los datos de los comboBox no enlazados con otras tablas

            var ListaCaracter = await _caracterService.Lista();
            var items = ListaCaracter.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();

            cmbCaracter.InsertarItems(items);

        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            await MostrarEmpresas(txtBuscar.Text.Trim());
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            MostrarTabs(tabListado.Name);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarMantenimiento();
            txtOpcion.Text = "1"; // 1 Nuevo / 2 Edición
            txtID.Enabled = false;
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
                MessageBox.Show("El Nombre de la Empresa es obligatorio");
                return;
            }
            if (txtDomicilio.Text.Trim() == "")
            {
                MessageBox.Show("El Domicilio de la Empresa es obligatorio");
                return;
            }
            if (txtCuit.Text.Trim() == "")
            {
                MessageBox.Show("El DNI ó CUIT de la Empresa es obligatorio");
                return;
            }

            //Creo las variables con los valores de los comboBox            
            var itemCaracter = (OpcionesComboBox)cmbCaracter.SelectedItem!;

            //Cargo los datos en el objeto Cliente para guardarlo después
            var objeTo = new Empresa
            {
                ID = Convert.ToInt32(txtID.Text.Trim()),
                Nombre = txtNombre.Text.Trim(),
                Direccion = txtDomicilio.Text.Trim(),
                Cuit = txtCuit.Text.Trim(),
                LogoUrl = txtLogoUrl.Text.Trim(),
                LogoNombre = txtLogoNombre.Text.Trim(),
                Telefono = txtTelefono.Text.Trim(),
                CaracterID = new Caracter { ID = itemCaracter.Valor },
                SimboloMoneda = txtMoneda.Text.Trim()
            };

            //Evalúo si es nuevo o edición
            if (txtOpcion.Text.Trim() == "2") // Si la opcion es 2: Editar
            {
                respuesta = await _empresaService.editar(objeTo);
            }
            else //Si la opcion es 1: Nueva
            {
                respuesta = await _empresaService.crear(objeTo);
            }

            if (respuesta != "")
            {
                MessageBox.Show(respuesta);
            }
            else
            {
                await MostrarEmpresas();
                MostrarTabs(tabListado.Name);
            }

        }

        private void btnAgregarLogo_Click(object sender, EventArgs e)
        {
            if (_openFileDialog.ShowDialog() == DialogResult.OK)
            {
                _openFileDialog.OpenFile();
                ImagenLogo.Image = Image.FromFile(_openFileDialog.FileName);
                txtLogoUrl.Text = _openFileDialog.FileName;
            }
        }

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
                txtTelefono.Text = string.Empty;
                txtTelefono.Focus();
            }
        }

        private void txtTelefono_KeyDown(object sender, KeyEventArgs e)
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
                txtMoneda.Text = string.Empty;
                txtMoneda.Focus();
            }
        }

        private void txtMoneda_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtLogoNombre.Text = string.Empty;
                txtLogoNombre.Focus();
            }
        }

        private void txtLogoNombre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                txtLogoUrl.Text = string.Empty;
                txtLogoUrl.Focus();
            }
        }

        private void txtLogoUrl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // Evita el sonido de "beep" en el TextBox
                btnAgregarLogo.Focus();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
