using PVrepository.Entities;

namespace PVrepository.Entities.ViewModels
{
    public class Cuenta_Cliente_VM
    {
        public int ID {get; set;}
        public int ComprobanteID {get; set;}
        public int TipoE {get; set;} //1;"Factura";2;"Recibo";3;"Nota de Crédito";4;"Nota de Débito"
        public int ClienteID {get; set;}
        public string ClienteNombre {get; set;}
        public DateTime FechaE {get; set;}
        public string DescripcionE { get; set; } = string.Empty;
        public int Credito {get; set;}
        public int Pagos {get; set;}
        public int Saldo {get;}
        public int Estado {get; set;}
        public int CuentaID {get;set;}
        public int TipoD {get;set;} //1;"Factura";2;"Recibo";3;"Nota de Crédito";4;"Nota de Débito"
        public string DescripcionD { get; set; } = string.Empty;
        public int ComprobanteNumero {get;set;}
        public DateTime FechaD {get;set;}
        public int Ingreso {get;set;}
        public int Salida {get;set;}
        public int Detalle {get;set;}
    }
}
