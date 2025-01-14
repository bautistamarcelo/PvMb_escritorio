

namespace PVrepository.Entities
{
    public class Cajas_Tipo
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Relacion { get; set; }  // Values: 'suma' / 'resta'
        public string GMCaja { get; set;}  // Values: 'si' / 'no'
    }
}
