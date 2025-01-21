using PVpresentation.Formularios.Modelos;
using PVpresentation.Resources;
using PVrepository.Entities;
using PVservices.Interfaces;
using System.Data;


namespace PVpresentation.Formularios
{
    public partial class Frm_Cajas : FrmModeloCRUD
    {
        #region Funcionalidades y Constructor del formulario
        private readonly ICajasService _cajasService;
        private readonly ICajas_VMservice _cajas_VMservice;

        public Frm_Cajas(ICajasService cajasService,
                        ICajas_VMservice cajas_VMservice)
        {
            InitializeComponent();
            _cajasService = cajasService;
            _cajas_VMservice = cajas_VMservice;
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
            var VMListaCajas = await Task.WhenAll(listaCajas_VM.Select(async item => new Cajas_VM
            {
                Id = item.Id,
                CajaNombre = item.CajaNombre,
                FechaApertura = item.FechaApertura,
                SaldoInicial = item.SaldoInicial,
                FechaCierre = item.FechaCierre,
                SaldoFinal = item.SaldoFinal,
                Condicion = item.Condicion,
                UsuarioNombre = item.UsuarioNombre,
                UsuarioID = item.UsuarioID,
                SucursalNombre = item.SucursalNombre,
                SucursalID = item.SucursalID,
            }));

            // Asignar el resultado a la fuente de datos
            dgvListado.DataSource = VMListaCajas.ToList();
            dgvListado.Columns["ID"].Visible = false;
            dgvListado.Columns["UsuarioID"].Visible = false;
            dgvListado.Columns["SucursalID"].Visible = false;
        }

        #endregion

        private async void Frm_Cajas_Load(object sender, EventArgs e)
        {
            var fechaIn = DateTime.Parse("2001/01/01");
            var fechaFi = DateTime.Parse("2025/01/18");
            dgvListado.ImplementarConfiguracion("Editar");
            MostrarTabs(tabListado.Name);
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

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {

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
    }
}
