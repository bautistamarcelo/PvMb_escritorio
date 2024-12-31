
namespace PVrepository.Entities
{
    public class Sucursales
    {
        public int ID {get; set;}
        public string Nombre {get; set;}
        public string Direccion {get; set;}
        public string Telefono {get; set;}
        public string Email {get; set;} 
        public Empresa EmpresaID {get; set;}
    }
}
