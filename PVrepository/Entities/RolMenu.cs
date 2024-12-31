
namespace PVrepository.Entities
{
    public class RolMenu
    {
        public int IDRolMenu {get; set;}
        public Rol IDRol {get; set;}
        public Menu IDMenu {get; set;}
        public int esActivo {get; set;}
        public DateTime fechaRegistro {get; set;}    
    }
}
