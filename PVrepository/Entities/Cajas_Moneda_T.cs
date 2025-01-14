

namespace PVrepository.Entities
{
    public class Cajas_Moneda_T
    {
        public int ID { get; set; }
        public int CajasTransaccionesID { get; set; }
        public int Efectivo { get; set; }
        public int Tarjeta { get; set; }
        public int Debito { get; set; }
        public int CtaCte { get; set; }
    }
}
