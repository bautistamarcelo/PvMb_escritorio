

namespace PVrepository.Entities
{
    public class Cuenta_Cliente_D
    {
        public int ID {get; set;}
        public Cuenta_Cliente_E CuentaID {get; set;}
        public int TipoID {get; set;} //1;"Factura";2;"Recibo";3;"Nota de Crédito";4;"Nota de Débito"
        public int ComprobanteNumero {get; set;}
        public DateOnly Fecha {get; set;}
        public int Ingreso {get; set;}
        public int Salida {get; set;}
        public string Descripcion { get; set; } = string.Empty;
    }
}
