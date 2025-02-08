
namespace PVrepository.Entities
{
    public class Compras_D
    {
        public int ID {get; set;}
        public int CompraID {get; set;}
        public Productos ProductoID {get; set;}
        public int Cantidad {get; set;}
        public int pCompra {get; set;}
        public int Impuesto {get; set;}
        public int Costo {get; set;}
        public int TotalLinea {get; set;}

    }
}
