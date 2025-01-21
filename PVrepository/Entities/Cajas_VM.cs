using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVrepository.Entities
{
    public class Cajas_VM
    {
        public int Id { get; set; }
        public string CajaNombre { get; set; }
        public DateTime FechaApertura { get; set; }
        public int SaldoInicial { get; set; }
        public DateTime FechaCierre { get; set; }
        public int SaldoFinal { get; set; }
        public string Condicion { get; set; }
        public string UsuarioNombre { get; set; }
        public int UsuarioID { get; set; }
        public string SucursalNombre { get; set; }
        public int SucursalID { get; set; }
    }
}
