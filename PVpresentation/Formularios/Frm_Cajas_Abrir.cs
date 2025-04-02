using PVpresentation.Resources;
using PVpresentation.ViewModels;
using PVrepository.Entities;
using PVrepository.Interfaces;
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
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.AxHost;
using System.Xml.Linq;

namespace PVpresentation.Formularios
{
    public partial class Frm_Cajas_Abrir : Form
    {
        #region VARIABLES Y CONSTRUCTOR DE SERVICIOS QUE NECESITO EN EL FORMULARIO 
        private readonly IServiceProvider _serviceProvider;
        private readonly ISucursalesService _sucursalesService;
        private readonly ICajasService _cajasService;
        private readonly IUsuariosService _usuariosService;
        private readonly ICajasTransaccionesService _cajasTransaccionesService;
        private readonly ICajasMonedaTservice _cajasMonedaTservice;
        private readonly ICajasMovimientosService _cajasMovimientosService;
        private readonly ICajasMonedaMservice _cajasMonedaMservice;
        public CajasVM _CajaSeleccionada { get; set; } = null!;

        public Frm_Cajas_Abrir(IServiceProvider serviceProvider,
                               ISucursalesService sucursalesService,
                               ICajasService cajasService,
                               IUsuariosService usuariosService,
                               ICajasTransaccionesService cajasTransaccionesService,
                               ICajasMonedaTservice cajasMonedaTservice,
                               ICajasMovimientosService cajasMovimientosService,
                               ICajasMonedaMservice cajasMonedaMservice)
        {
            InitializeComponent();
            _serviceProvider = serviceProvider;
            _sucursalesService = sucursalesService;
            _cajasService = cajasService;
            _usuariosService = usuariosService;
            _cajasTransaccionesService = cajasTransaccionesService;
            _cajasMonedaTservice = cajasMonedaTservice;
            _cajasMovimientosService = cajasMovimientosService;
            _cajasMonedaMservice = cajasMonedaMservice;
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

            #region CARGO LOS DATOS EN LA VARIABLE DE CAJA Y LLENO LOS CUADROS DE TEXTOS DEL FORMULARIO
            _CajaSeleccionada = new CajasVM
            {
                ID = 0,
                Nombre = VariablesGlobales.UsuarioNombre + DateTime.Now.ToString(" yyyy-MM-dd HH:mm"),
                Condicion = "Abierta",
                Apertura = DateTime.Now,
                SaldoInicial = 0,
                SaldoFinal = 0,
                UsuarioID = VariablesGlobales.UsuarioID,
                Usuario = VariablesGlobales.UsuarioNombre,
                SucursalID = VariablesGlobales.SucursalID,
            };

            //Asignar valores a los controles
            txtID.Text = _CajaSeleccionada.ID.ToString();
            txtNombre.Text = _CajaSeleccionada.Nombre.ToString();
            cmbCondicion.SelectedIndex = 0; //VariablesGlobales.CajaCondicion == "Abierta" ? 0 : 1;
            txtFechaApertura.Text = _CajaSeleccionada.Apertura.ToString();
            txtSaldoInicial.Text = "0";
            //txtID.Enabled = false;
            //txtNombre.Enabled = false;
            //cmbCondicion.Enabled = false;
            //cmbSucursales.Enabled = false;
            //txtFechaApertura.Enabled = false;
            txtSaldoInicial.Focus();

            #endregion
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void btnAbrirCaja_Click(object sender, EventArgs e)
        {
            var respuesta = "";

            //Cargo los datos en el objeto Caja para guardarlo después
            _CajaSeleccionada.SaldoInicial = Convert.ToInt32(txtSaldoInicial.Text);

            var oBjeto = new Cajas
            {
                SucursalID = _CajaSeleccionada.SucursalID,
                Nombre = _CajaSeleccionada.Nombre,
                FechaApertura = _CajaSeleccionada.Apertura,
                SaldoInicial = _CajaSeleccionada.SaldoInicial,
                Condicion = _CajaSeleccionada.Condicion,
                UsuarioID = _CajaSeleccionada.UsuarioID
            };

            #region GENERACION XML DE CAJA NUEVA
            XElement Caja = new XElement("Caja",
                    new XElement("Nombre", _CajaSeleccionada.Nombre),
                    new XElement("FechaApertura", _CajaSeleccionada.Apertura),
                    new XElement("SaldoInicial", Convert.ToInt32(_CajaSeleccionada.SaldoInicial)),
                    new XElement("SaldoFinal", Convert.ToInt32(0)),
                    new XElement("Condicion", _CajaSeleccionada.Condicion),
                    new XElement("SucursalID", Convert.ToInt32(_CajaSeleccionada.SucursalID)),

                    //VALORES PARA CAJA USUARIOS
                    new XElement("CajaID", Convert.ToInt32(0)),
                    new XElement("UsuarioID", Convert.ToInt32(_CajaSeleccionada.UsuarioID)),
                    new XElement("FechaAsignacion", _CajaSeleccionada.Apertura),
                    new XElement("Estado", _CajaSeleccionada.Condicion),

                    // VALORES PARA CAJA TRANSACCIONES Y CAJA MOVIMIENTOS
                    new XElement("ID", 0),
                    new XElement("CajaID", Convert.ToInt32(0)),
                    new XElement("TipoID", Convert.ToInt32(9)),
                    new XElement("Caracter", "suma"),
                    new XElement("Monto", Convert.ToInt32(_CajaSeleccionada.SaldoInicial)),
                    new XElement("Fecha", _CajaSeleccionada.Apertura),
                    new XElement("Descripcion", "*** Apertura de Caja ***"),

                    //VALORES PARA CAJA MONEDA TRANSACCIONES Y CAJA MONEDA MOVIMIENTOS
                    new XElement("Efectivo", Convert.ToInt32(_CajaSeleccionada.SaldoInicial)),
                    new XElement("Tarjeta", Convert.ToInt32(0)),
                    new XElement("Debito", Convert.ToInt32(0)),
                    new XElement("CtaCte", Convert.ToInt32(0))
             );

            #region Guardar XML
            string folderPath = @"D:\Base de Datos\"; // Ruta de la carpeta
            string fileName = "CajaNueva.xml"; // Nombre del archivo
            string fullPath = Path.Combine(folderPath, fileName); // Ruta completa del archivo

            File.WriteAllText(fullPath, Caja.ToString());

            #endregion
            #endregion

            respuesta = await _cajasService.crear(Caja.ToString());

            if (respuesta != "")
            {
                VariablesGlobales.CajaID = await _usuariosService.BuscaCajaUsuario(_CajaSeleccionada.UsuarioID);

                MessageBox.Show("Caja Generada con éxito", "Caja Generada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(respuesta);
                this.Close();
            }
        }

        private void txtSaldoInicial_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Bloquea la tecla si no es un número
            }
        }
    }
}
