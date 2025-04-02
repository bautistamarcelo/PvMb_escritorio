using Microsoft.Extensions.DependencyInjection;
using PVpresentation.Resources;
using PVrepository.Entities;
using PVrepository.Entities.ViewModels;
using PVservices.Interfaces;
using System.Data;

namespace PVpresentation.Formularios
{
    public partial class Frm_Cajas_Movimientos : Form
    {
        public void MostrarTabs(string tabName)
        {
            var tabsMenu = new TabPage[] { tabIngresos, tabEgresos };
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
        private readonly IServiceProvider _serviceProvider;
        private readonly IClientesService _clientesService;
        private readonly ICuentaClienteService _cuentaClienteService;

        public Frm_Cajas_Movimientos(IServiceProvider serviceProvider, IClientesService clientesService, ICuentaClienteService cuentaClienteService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _clientesService = clientesService;
            _cuentaClienteService = cuentaClienteService;
        }

        public async Task MostrarCuentaCliente(DateTime FechaIni, DateTime FechaFin, int Buscar = 0)
        {
            Cuenta_Cliente_E _SaldoEncontrado = await _cuentaClienteService.ObtenerSaldo(Buscar);
            var _Saldo = _SaldoEncontrado.Saldo.ToString();
            txtSaldoActual.Text = _Saldo.ToString();

            #region LLENAR DGV DEL ENCABEZADO
            var listaCuenta_VM = await _cuentaClienteService.Lista(FechaIni, FechaFin, Buscar);

            // Usar Task.WhenAll para esperar a que todas las tareas se completen
            var VMListaCuentas = await Task.WhenAll(listaCuenta_VM.Select(async item => new Cuenta_Cliente_E
            {
                ID = item.ID,
                ComprobanteID = item.ComprobanteID,
                TipoID = item.TipoID,
                Descripcion = item.Descripcion,
                Credito = item.Credito,
                Fecha = item.Fecha,
                Pagos = item.Pagos,
                Estado = item.Estado,
                Saldo = item.Saldo,
                ClienteID = item.ClienteID
            }));

            // Asignar el resultado a la fuente de datos
            dgvCuentaE.DataSource = VMListaCuentas.ToList();
            dgvCuentaE.Columns["Descripcion"].FillWeight = 350;

            dgvCuentaE.Columns["ID"].Visible = false;
            dgvCuentaE.Columns["TipoID"].Visible = false;
            dgvCuentaE.Columns["Estado"].Visible = false;
            dgvCuentaE.Columns["ClienteID"].Visible = false;
            dgvCuentaE.Columns["ComprobanteID"].Visible = false;

            #endregion

            #region LLENAR DGV DEL DETALLE
            var listaCuentaDetalle = await _cuentaClienteService.ListaDetalle(Buscar);
            var VMlistaCuentaDetalle = await Task.WhenAll(listaCuentaDetalle.Select(async item => new Cuenta_Cliente_VM
            {
                ID = item.ID,
                CuentaID = item.CuentaID,
                FechaD = item.FechaD,
                ComprobanteNumero = item.ComprobanteNumero,
                DescripcionD = item.DescripcionD,
                Ingreso = item.Ingreso,
                Salida = item.Salida,
                TipoD = item.TipoD
            }));
            dgvCuentaD.DataSource = VMlistaCuentaDetalle.ToList();
            dgvCuentaD.Columns["DescripcionD"].FillWeight = 350;
            dgvCuentaD.Columns["ID"].Visible = false;
            dgvCuentaD.Columns["CuentaID"].Visible = false;
            dgvCuentaD.Columns["TipoD"].Visible = false;
            dgvCuentaD.Columns["ComprobanteNumero"].Visible = false;
            dgvCuentaD.Columns["ComprobanteID"].Visible = false;
            dgvCuentaD.Columns["TipoE"].Visible = false;
            dgvCuentaD.Columns["ClienteID"].Visible = false;
            dgvCuentaD.Columns["ClienteNombre"].Visible = false;
            dgvCuentaD.Columns["FechaE"].Visible = false;
            dgvCuentaD.Columns["DescripcionE"].Visible = false;
            dgvCuentaD.Columns["Credito"].Visible = false;
            dgvCuentaD.Columns["Pagos"].Visible = false;
            dgvCuentaD.Columns["Saldo"].Visible = false;
            dgvCuentaD.Columns["Estado"].Visible = false;
            dgvCuentaD.Columns["Detalle"].Visible = false;


            #endregion

        }

        private async void Frm_Cajas_Movimientos_Load(object sender, EventArgs e)
        {
            dgvCuentaE.ImplementarConfiguracion("");
            dgvCuentaD.ImplementarConfiguracion("");
            dgvListado.ImplementarConfiguracion("");
            if (txtOpcion.Text == "1")
            {
                MostrarTabs("tabIngresos");

            }
            else
            {
                MostrarTabs("tabEgresos");
            }
        }

        private async void btnBuscar_Click(object sender, EventArgs e)
        {
            var frmBuscarCliente = _serviceProvider.GetRequiredService<Frm_Clientes_Buscar>();
            var resultadobusqueda = frmBuscarCliente.ShowDialog();
            frmBuscarCliente.txtInstancia.Text = "5";// Valor para llamadado desde recibos
            if (resultadobusqueda == DialogResult.OK)
            {
                var _clienteSeleccionado = frmBuscarCliente._ClienteSeleccionado;
                txtBuscarCliente.Text = _clienteSeleccionado.Nombre.ToString();
                txtNombre.Text = _clienteSeleccionado.Nombre.ToString();
                txtID.Text = _clienteSeleccionado.ID.ToString();
                var fechaIn = DateTime.Parse("2001/01/01");
                var fechaFi = DateTime.Parse("2925/12/31");
                await MostrarCuentaCliente(fechaIn, fechaFi, _clienteSeleccionado.ID);
            }

        }

        private void btnCierreVolver_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtImporteRecibo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }
    }
}
