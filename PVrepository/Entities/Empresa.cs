

namespace PVrepository.Entities
{
    public class Empresa
    {
        public int ID {get; set;}
        public string Nombre {get; set;}=string.Empty;
        public string Direccion {get; set;} = string.Empty;
        public string Cuit {get; set;} = string.Empty;
        public string Telefono {get; set;} = string.Empty;
        public string LogoUrl {get; set;} = string.Empty;
        public string LogoNombre {get;set;} = string.Empty;
        public Caracter CaracterID {get; set;}
        public string SimboloMoneda {get; set;} = string.Empty;
        public int Predeterminada{get;set;} //Values: 0 Predeterminada | 1 No Predeterminada
    }
}
