using PVpresentation.Formularios.Modelos;
using PVpresentation.Resources;
using PVrepository.Entities;
using PVservices.Interfaces;
using System.Data;
using PVpresentation.ViewModels;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;
using PVrepository.Entities.ViewModels;
using PVrepository.Interfaces;
using PVservices.Implementation;
using System.Drawing.Printing;



namespace PVpresentation.Formularios
{
    public partial class Frm_Cajas : FrmModeloCRUD
    {
        // Diccionario para almacenar los colores originales de los controles
        private Dictionary<Control, Color> originalColors = new Dictionary<Control, Color>();

        #region Funcionalidades y Constructor del formulario
        private readonly IServiceProvider _serviceProvider;
        private readonly ICajasService _cajasService;
        private readonly ICajas_VMservice _cajas_VMservice;
        private readonly ICajas_Detalle_VMservice _cajas_Detalle_VMservice;
        private readonly ICajasMovimientosService _cajasMovimientosService;
        private readonly ICajasMonedaMservice _cajasMonedaMservice;

        public Frm_Cajas(ICajasService cajasService,
                        ICajas_VMservice cajas_VMservice,
                        IServiceProvider serviceProvider,
                        ICajas_Detalle_VMservice cajas_Detalle_VMservice,
                        ICajasMovimientosService cajasMovimientosService,
                        ICajasMonedaMservice cajasMonedaMservice)
        {
            InitializeComponent();
            _cajasService = cajasService;
            _cajas_VMservice = cajas_VMservice;
            _serviceProvider = serviceProvider;
            _cajas_Detalle_VMservice = cajas_Detalle_VMservice;
            _cajasMovimientosService = cajasMovimientosService;
            _cajasMonedaMservice = cajasMonedaMservice;
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
                var CajaSeleccionada = (CajasVM)dgvListado.CurrentRow.DataBoundItem;
                if (CajaSeleccionada == null)
                {
                    MessageBox.Show("Debe seleccionar una caja para editar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                txtID.Text = CajaSeleccionada.ID.ToString();
                txtNombre.Text = CajaSeleccionada.Nombre;
                txtFechaApertura.Text = CajaSeleccionada.Apertura.ToString();
                txtSaldoInicial.Text = CajaSeleccionada.SaldoInicial.ToString();
                txtFechaCierre.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
                txtSaldoFinal.Text = CajaSeleccionada.SaldoFinal.ToString();
                cmbCondicion.SelectedIndex = CajaSeleccionada.Condicion == "Abierta" ? 0 : 1;
                txtResultado.Text = "";

                var SaldoActual = await _cajasMovimientosService.ObtenerSaldo(CajaSeleccionada.ID);
                var SaldoMonedas = await _cajasMonedaMservice.ObtenerSaldo(CajaSeleccionada.ID);

                txtSaldoFinal.Text = SaldoActual.Monto.ToString();
                txtEfectivo.Text = SaldoMonedas.Efectivo.ToString();
                txtDebito.Text = SaldoMonedas.Debito.ToString();
                txtTarjeta.Text = SaldoMonedas.Tarjeta.ToString();
                txtResultado.Text = (Convert.ToInt32(txtSaldoFinal.Text.Trim()) - Convert.ToInt32(txtSaldoInicial.Text.Trim())).ToString();

                if (Convert.ToInt32(txtResultado.Text.Trim()) > 0)
                    txtResultado.ForeColor = Color.Green;
                else if (Convert.ToInt32(txtResultado.Text.Trim()) < 0)
                    txtResultado.ForeColor = Color.Red;

                cmbCondicion.Enabled = true;
                btnGrabar.Enabled = true;
            }
        }

        public void LimpiarMantenimiento()
        {
            txtID.Text = "";
            txtNombre.Text = "";
            txtFechaApertura.Text = "";
            txtFechaCierre.Text = "";
            txtSaldoInicial.Text = "";
            txtSaldoFinal.Text = "";
            cmbCondicion.SelectedIndex = 0;
            txtResultado.Text = "";
            txtID.Enabled = false;

            txtBuscar.Select();
            btnGrabar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        public async Task MostrarCajas(DateTime FechaIni, DateTime FechaFin, string Buscar = "")
        {
            var listaCajas_VM = await _cajas_VMservice.Lista(FechaIni, FechaFin, Buscar);

            // Usar Task.WhenAll para esperar a que todas las tareas se completen
            var VMListaCajas = await Task.WhenAll(listaCajas_VM.Select(async item => new CajasVM
            {
                ID = item.Id,
                Usuario = item.UsuarioNombre,
                Nombre = item.CajaNombre,
                Apertura = item.FechaApertura,
                SaldoInicial = item.SaldoInicial,
                Cierre = item.FechaCierre,
                SaldoFinal = item.SaldoFinal,
                Condicion = item.Condicion,
                UsuarioID = item.UsuarioID,
                Sucursal = item.SucursalNombre,
                SucursalID = item.SucursalID,
            }));

            // Asignar el resultado a la fuente de datos
            dgvListado.DataSource = VMListaCajas.ToList();
            dgvListado.Columns["ID"].Visible = false;
            dgvListado.Columns["UsuarioID"].Visible = false;
            dgvListado.Columns["Nombre"].Visible = false;
            dgvListado.Columns["Cierre"].Visible = false;
            dgvListado.Columns["SucursalID"].Visible = false;
            dgvListado.Columns["Sucursal"].Visible = false;
            btnEditar.Enabled = false;
            btnEditar.Visible = false;
        }

        public async Task MostrarDetalleCajas(int cajaID = 0)
        {
            var listaCajasDetalle_VM = await _cajas_Detalle_VMservice.Lista(cajaID);

            // Usar Task.WhenAll para esperar a que todas las tareas se completen
            var VMListaCajasDetalle = await Task.WhenAll(listaCajasDetalle_VM.Select(async item => new Cajas_Detalle_VM
            {
                CajaID = item.CajaID,
                Descripcion = item.Descripcion,
                Monto = item.Monto,
                Efectivo = item.Efectivo,
                Debito = item.Debito,
                Tarjeta = item.Tarjeta
            }));
            var SaldoActual = await _cajasMovimientosService.ObtenerSaldo(cajaID);
            var SaldoMonedas = await _cajasMonedaMservice.ObtenerSaldo(cajaID);

            // Asignar el resultado a la fuente de datos
            dgvDetalle.DataSource = VMListaCajasDetalle.ToList();
            dgvDetalle.Columns["CajaID"].Visible = false;
            dgvDetalle.Columns["Descripcion"].FillWeight = 350;

            if (VariablesGlobales.cajaSeleccionadaID == null)
            {
                MessageBox.Show("Debe seleccionar una caja para ver el detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            txtMuestraSaldoInicial.Text = VariablesGlobales.cajaSeleccionadaSaldoInicial.ToString();
            txtMuestraSaldoFinal.Text = SaldoActual.Monto.ToString();
            txtEfectivo.Text = SaldoMonedas.Efectivo.ToString();
            txtDebito.Text = SaldoMonedas.Debito.ToString();
            txtTarjeta.Text = SaldoMonedas.Tarjeta.ToString();
            txtMuestraResultado.Text = (Convert.ToInt32(txtMuestraSaldoFinal.Text.Trim()) - Convert.ToInt32(txtMuestraSaldoInicial.Text.Trim())).ToString();
        }

        #endregion

        private async void Frm_Cajas_Load(object sender, EventArgs e)
        {
            var fechaIn = DateTime.Parse("2001/01/01");
            var fechaFi = DateTime.Parse("2925/12/31");
            dgvListado.ImplementarConfiguracion("Editar");
            dgvDetalle.ImplementarConfiguracion("");
            MostrarTabs(tabListado.Name);
            btnDetalles.Visible = true;
            await MostrarCajas(fechaIn, fechaFi);

            //Completo los datos de los comboBox no enlazados con otras tablas
            OpcionesComboBox[] itemsSituacion = new OpcionesComboBox[]
            {
                new OpcionesComboBox{Texto="Abierta",Valor=1},
                new OpcionesComboBox{Texto="Cerrada",Valor=2}
            };
            cmbCondicion.InsertarItems(itemsSituacion);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (VariablesGlobales.CajaID != 0)
            {
                MessageBox.Show("Ya posee una caja abierta. Cierre la caja Antes de abrir una nueva", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Frm_Cajas_Abrir frmCajasAbrir = (Frm_Cajas_Abrir)_serviceProvider.GetService(typeof(Frm_Cajas_Abrir))!;
            frmCajasAbrir.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void btnCierreVolver_Click(object sender, EventArgs e)
        {

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {

        }

        private async void btnDetalles_Click(object sender, EventArgs e)
        {
            var CajaSeleccionada = (CajasVM)dgvListado.CurrentRow.DataBoundItem;
            if (CajaSeleccionada == null)
            {
                MessageBox.Show("Debe seleccionar una caja para ver del Detalle", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            VariablesGlobales.cajaSeleccionadaID = CajaSeleccionada.ID;
            VariablesGlobales.cajaSeleccionadaSaldoInicial = CajaSeleccionada.SaldoInicial;
            MostrarTabs(tabEditar.Name);
            await MostrarDetalleCajas(VariablesGlobales.cajaSeleccionadaID);
        }

        private void btnCancelarDetalle_Click(object sender, EventArgs e)
        {
            MostrarTabs(tabListado.Name);
        }
    }
}
