using PVpresentation.Resources;
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
    public partial class Frm_Cajas_Abrir : Form
    {
        #region VARIABLES Y CONSTRUCTOR DE SERVICIOS QUE NECESITO EN EL FORMULARIO 
        private readonly IServiceProvider _serviceProvider;
        private readonly ISucursalesService _sucursalesService;

        public Frm_Cajas_Abrir(IServiceProvider serviceProvider, ISucursalesService sucursalesService)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _sucursalesService = sucursalesService;
        }
        #endregion


        private async void Frm_Cajas_Abrir_Load(object sender, EventArgs e)
        {
            //Completo los datos de los comboBox no enlazados con otras tablas
            OpcionesComboBox[] itemsSituacion = new OpcionesComboBox[]
            {
                new OpcionesComboBox{Texto="Abierta",Valor=1},
                new OpcionesComboBox{Texto="Cerrada",Valor=2}
            };
            cmbCondicion.InsertarItems(itemsSituacion);

            //Llenar el combobox de sucursales
            var ListaSucursales = await _sucursalesService.Lista();
            var itemsSucursal = ListaSucursales.Select(item => new OpcionesComboBox { Texto = item.Nombre, Valor = item.ID }).ToArray();
            cmbSucursales.InsertarItems(itemsSucursal);


            //Asignar valores a los controles
            txtID.Text = VariablesGlobales.CajaID.ToString();
            txtNombre.Text = VariablesGlobales.UsuarioNombre + DateTime.Now.ToString(" yyyy-MM-dd HH:mm");
            cmbCondicion.SelectedIndex = 0; //VariablesGlobales.CajaCondicion == "Abierta" ? 0 : 1;
            txtFechaApertura.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            txtSaldoInicial.Text = "0";
            txtID.Enabled = false;
            txtNombre.Enabled = false;
            cmbCondicion.Enabled = false;
            cmbSucursales.Enabled = false;
            txtFechaApertura.Enabled = false;
            txtSaldoInicial.Focus();
            cmbSucursales.SelectedIndex = VariablesGlobales.SucursalID;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
