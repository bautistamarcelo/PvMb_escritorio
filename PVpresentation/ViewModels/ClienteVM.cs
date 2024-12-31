using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVpresentation.ViewModels
{
    public class ClienteVM
    {
        public int ID {get; set;}
        public string Nombre {get; set;}
        public string Domicilio{get; set;}
        public string Cuit {get; set;}
        public string Email {get; set;} 
        public string Telefono {get; set;}
        public int EstadoID {get; set;}
        public string Estado {get; set;}
        public int CaracterID {get; set;}
        public string Caracter {get; set;}
        public int CtaCte {get; set;}
        public string Habilitado {get; set;}
    }
}
