using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVpresentation.ViewModels
{
    public class UsuariosVM
    {
        public int IDUsuario { get; set; }
        public string nombre { get; set; }
        public string correo { get; set; }
        public string telefono { get; set; }
        public int IDRol {get; set;}
        public string nombreRol {get; set;}
        public string urlFoto {get; set;}
        public string nombreFoto {get;set;}
        public string clave {get;set; }
        public int esActivo {get; set;}
        public string Situacion{get; set;}
        public DateTime fechaRegistro {get; set;}
    }
}
