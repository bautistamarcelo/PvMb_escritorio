
namespace PVrepository.Entities
{
    public class Cuenta_Cliente_E
    {
        public int ID {get; set;}
        public int ComprobanteID {get; set;}
        public int TipoID {get; set;} //1;"Factura";2;"Recibo";3;"Nota de Crédito";4;"Nota de Débito"
        public DateTime Fecha {get; set;}
        public string Descripcion { get; set; } = string.Empty;
        public int Credito {get; set;}
        public int Pagos {get; set;}
        public int Saldo {get; set;}
        public int Estado {get; set;}

        public Clientes ClienteID {get; set;}
        public List<Cuenta_Cliente_D>CuentaCliente_D {get; set;}
    }
}
