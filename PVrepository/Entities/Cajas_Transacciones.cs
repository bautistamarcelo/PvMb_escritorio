

namespace PVrepository.Entities
{
    public class Cajas_Transacciones
    {
        public int ID { get; set; }
        public int CajaID { get; set; }
        public int TipoID { get; set; }
        public string Caracter { get; set; } = string.Empty; // Values: 'suma' / 'resta'
        public int Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string ComprobanteNum { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
    }
}
