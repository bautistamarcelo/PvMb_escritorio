using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVpresentation.ViewModels
{
    public class SucursalesVM
    {
        public int ID {get; set;}
        public string Nombre {get; set;}
        public string Direccion {get; set;}
        public string Telefono {get; set;}
        public string Email {get; set;} 
        public int EmpresaID {get; set;}
        public string EmpresaNombre {get; set;}
    }
}
