
namespace PVrepository.Entities
{
    public class Ventas_D
    {
        public int ID {get; set;}
        public int VentaID {get; set;}
        public Productos ProductoID {get; set;}
        public int Cantidad {get; set;}
        public int pOferta {get; set;}
        public int pVenta {get; set;}
        public int pTotalOferta {get; set;}
        public int pTotalVenta {get; set; }
        public string Observaciones {get; set;}
    }
}
