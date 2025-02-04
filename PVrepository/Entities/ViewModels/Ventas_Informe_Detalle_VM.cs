using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVrepository.Entities.ViewModels
{
    public class Ventas_Informe_VM
    {
        public int VentaID {get; set;}
        public DateTime Fecha {get; set;}
        public int Tipo {get; set;} //Values: 1;"Contado";2;"Cuenta Corriente"
        public string Numero {get; set;}
        public int SubTotal {get; set;}
        public int DtoEfectivo {get; set;}
        public int Bruto {get; set;}
        public int DtoGeneral {get; set;}
        public int Monto {get; set;}
        public int Neto {get; set;}
        public int iva {get; set;}
        public int Tefectivo {get; set;}
        public int Tdebito {get; set;}
        public int Ttarjeta {get; set;}
        public int Tcredito {get; set;}
        public int Situacion {get; set;}

        public int ClienteID {get; set;}
        public string ClienteNombre {get; set;}

        public List<Ventas_D>VentaDetalle {get; set;}
    }
}

//public int VendedorID {get; set;}
//        public int SucursalID {get; set;}
//        public string SucursalNombre {get; set;}
//        public int ListaID {get; set;}
//        public List<Ventas_D>VentaDetalle {get; set;}

//         public int ID {get; set;}
//        public int VentaID {get; set;}
//        public Productos ProductoID {get; set;}
//        public int Cantidad {get; set;}
//        public int pOferta {get; set;}
//        public int pVenta {get; set;}
//        public int pTotalOferta {get; set;}
//        public int pTotalVenta {get; set; }
//        public string Observaciones {get; set;}