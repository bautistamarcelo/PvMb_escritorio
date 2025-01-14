
namespace PVrepository.Entities
{
    public class Cajas_Movimientos
    {
        public int ID { get; set; }
        public int CajaID { get; set; }
        public string Caracter { get; set; } = string.Empty;  // Values: 'suma' / 'resta'
        public int Monto { get; set; }
        public DateTime Fecha { get; set; }
        public string Descripcion { get; set; } = string.Empty;

    }
}
