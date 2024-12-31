

namespace PVrepository.Entities
{
    public class Clientes
    {
        public int ID {get; set;}
        public string Nombre {get; set;}
        public string Domicilio{get; set;}
        public string Cuit {get; set;}
        public string Email {get; set;} 
        public string Telefono {get; set;}
        public int Estado {get; set;}
        public Caracter CaracterID {get; set;}
        public int HabilitadoCtaCte {get; set;}
    }
}
