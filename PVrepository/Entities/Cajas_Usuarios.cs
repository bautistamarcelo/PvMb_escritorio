
namespace PVrepository.Entities
{
    public class Cajas_Usuarios
    {
        public int ID { get; set; }
        public int CajaID { get; set; }
        public int UsuarioID { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string Estado { get; set; } = string.Empty; //Values: 'Abierta' / 'Cerrada'
    }
}
