

namespace PVrepository.Entities
{
    public class Empresa
    {
        public int ID {get; set;}
        public string Nombre {get; set;}
        public string Direccion {get; set;}
        public string Cuit {get; set;}
        public string Telefono {get; set;}
        public string LogoUrl {get; set;}
        public string LogoNombre {get;set;}
        public Caracter CaracterID {get; set;}
        public string SimboloMoneda {get; set;}
    }
}
