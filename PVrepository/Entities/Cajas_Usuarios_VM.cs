using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PVrepository.Entities;

namespace PVrepository.Entities
{
    public class Cajas_Usuarios_VM
    {
        public int ID { get; set; }
        public int CajaID { get; set; }
        public string CajaNombre{ get; set; }
        public int UsuarioID { get; set; }
        public string UsuarioNombre { get; set; }
        public DateTime FechaAsignacion { get; set; }
        public string Estado { get; set; } = string.Empty; //Values: 'Abierta' / 'Cerrada'
        
        

    }
}
