using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVpresentation.ViewModels
{
    public class CajasVM
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public DateTime FechaApertura { get; set; }
        public int SaldoInicial { get; set; }
        public DateTime FechaCierre { get; set; }
        public int SaldoFinal { get; set; }
        public string Condicion { get; set; } // Values: 'Abierta' - 'Cerrada'
        public int UsuarioID { get; set; }
        public string UsuarioNombre { get; set; }
        public int SucursalID { get; set; }
        public string SucursalNombre { get; set; }
        
    }
}
