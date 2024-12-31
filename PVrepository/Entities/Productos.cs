
namespace PVrepository.Entities
{
    public class Productos
    {
        public int ID {get; set;}
        public string Nombre {get; set;}
        public int Situacion {get; set;}
        public string BarCode {get; set;}
        public int Stock {get; set;}
        public int Costo {get; set;}
        public int pOferta {get; set;}
        public int pVenta {get; set;}
        public DateTime fechaRegistro {get; set;}
        public Impuestos Impuesto {get; set;}
        public Categorias Categoria {get; set;}
        public Marcas Marca {get; set;}
        public Proveedores Proveedor {get; set;}
        public string Talle {get; set;}
        public string Color {get; set;}
    }
}
