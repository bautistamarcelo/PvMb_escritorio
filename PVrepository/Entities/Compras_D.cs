
namespace PVrepository.Entities
{
    public class Compras_D
    {
        public int ID {get; set;}
        public Compras_E CompraID {get; set;}
        public Productos ProductoID {get; set;}
        public int Cantidad {get; set;}
        public int Costo {get; set;}
        public int TotalLinea {get; set;}

    }
}
