
namespace PVrepository.Entities
{
    public class Proveedores
    {
        public int ID {get; set;}
        public string Nombre {get; set;}
        public string Direccion {get; set;}
        public int Renta {get; set;}
        public string Cuit {get; set;}
        public string Telefono{get; set;}
        public string Email {get; set;} 
        public Caracter CaracterID {get; set;}
     }
}
