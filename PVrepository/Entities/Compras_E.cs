
namespace PVrepository.Entities
{
    public class Compras_E
    {
        public int ID {get; set;}
        public DateTime Fecha {get; set;}
        public int Tipo {get; set;} // Values: 1;"Contado";2;"Cuenta Corriente"
        public string Numero {get; set;}
        public int Costo {get; set;}
        public Impuestos ImpuestoID {get; set;}
        public int ImpuestoMonto {get; set;}
        public int pCompra {get; set;}
        public int Situacion {get; set;} // Values: 1 "Grabada"; 2 "Anulada"; 3 "Pendiente"
        public int Comprobante {get; set;}
        public int Estado {get; set;}
        public Proveedores ProveedorID {get; set;}
        public Sucursales SucursalID {get; set;}
        public List<Compras_D>CompraDetalle {get; set;}

    }
}
