
namespace PVrepository.Entities
{
    public class Movimientos
    {
        public int ID { get; set; }
        public DateTime Fecha { get; set; }
        public DateTime Hora { get; set; }
        public Tramites TramiteID {get; set;}
        public Sucursales SucursalID {get; set;}
        public Productos ProductoID {get; set;}
        public string Comprobante {get; set;}
        public int Cantidad {get; set;}
        public int pCosto {get; set;}
        public int pOferta {get; set;}
        public int pVenta {get; set;}
        public int pTotal {get; set;}
        public string Descripcion {get; set;}
    }
}
