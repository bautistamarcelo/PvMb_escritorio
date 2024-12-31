
namespace PVrepository.Entities
{
    public class Ventas_E
    {
        public int ID {get; set;}
        public DateTime Fecha {get; set;}
        public int Tipo {get; set;}
        public string Numero {get; set;}
        public Clientes ClienteID {get; set;}
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
        public Usuarios VendedorID {get; set;}
        public Sucursales SucursalID {get; set;}
        public Listas ListaID {get; set;} 

    }
}
