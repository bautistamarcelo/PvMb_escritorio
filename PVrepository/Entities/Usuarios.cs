
namespace PVrepository.Entities
{
    public class Usuarios
    {
        public int IDUsuario { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public Rol IDRol {get; set;}
        public string urlFoto {get; set;}
        public string nombreFoto {get;set;}
        public string nombreUsuario {get;set;}
        public string clave {get;set; }
        public int esActivo {get; set;}
        public DateTime fechaRegistro {get; set;}
    }
}
