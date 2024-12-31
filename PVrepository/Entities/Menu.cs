
namespace PVrepository.Entities
{
    public class Menu
    {
        public int IDMenu {get; set;}
        public string descripcion {get; set;}
        public Menu IDMenuPadre {get; set;}
        public string icono {get; set;}
        public string controlador {get; set;}
        public string paginaAccion {get; set;}
        public int esActivo {get; set;}
        public DateTime fechaRegistro {get; set;}
    }
}
