using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVpresentation.ViewModels
{
    public class EmpresaVM
    {
         public int ID {get; set;}
        public string Nombre {get; set;}
        public string Direccion {get; set;}
        public string Cuit {get; set;}
        public string Telefono {get; set;}
        public string LogoUrl {get; set;}
        public string LogoNombre {get;set;}
        public int CaracterID {get; set;}
        public string Caracter {get; set;}
        public string SimboloMoneda {get; set;}
    }
}
