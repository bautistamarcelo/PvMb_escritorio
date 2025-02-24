using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVrepository.Entities.ViewModels
{
    public class Cuenta_Cliente_Saldo_VM
    {
        public int clienteID { get; set; }
        public int Debitado { get; set; }
        public int Pagos { get; set; }
        public int Saldo { get; set; }
    }
}
