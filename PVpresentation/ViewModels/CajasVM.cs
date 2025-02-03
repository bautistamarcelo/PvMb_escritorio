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
        public DateTime Apertura { get; set; }
        public int SaldoInicial { get; set; }
        public DateTime Cierre { get; set; }
        public int SaldoFinal { get; set; }
        public string Condicion { get; set; } // Values: 'Abierta' - 'Cerrada'
        public int UsuarioID { get; set; }
        public string Usuario { get; set; }
        public int SucursalID { get; set; }
        public string Sucursal { get; set; }
        
    }
}
