

namespace PVrepository.Entities.ViewModels
{
    public class Cajas_Detalle_VM
    {
        public int CajaID { get; set; }
        public string Descripcion { get; set; } = string.Empty;
        public int Monto { get; set; }
        public int Efectivo { get; set; }
        public int Tarjeta { get; set; }
        public int Debito { get; set; }
    }
}
