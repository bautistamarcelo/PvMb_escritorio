
namespace PVrepository.Entities
{
    public class Compras_E
    {
        public int ID {get; set;}
        public DateTime Fecha {get; set;}
        public int Tipo {get; set;}
        public string Numero {get; set;}
        public int Costo {get; set;}
        public Impuestos ImpuestoID {get; set;}
        public int pCompra {get; set;}
        public int Situacion {get; set;}
        public Proveedores ProveedorID {get; set;}
        public Sucursales SucursalID {get; set;}
        public int Comprobante {get; set;}

    }
}
