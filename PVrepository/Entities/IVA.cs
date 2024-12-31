
namespace PVrepository.Entities
{
    public class IVA
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int Tipo {get; set; }
        public double Compra { get; set; }
        public double Venta { get; set; }
        public int Comprobante {get; set; }
    }
}
