using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVpresentation.ViewModels
{
    public class Venta_D_VM
    {
        public int ProductoID { get; set; }
        public string ProductoBarCode { get; set; }
        public string ProductoNombre { get; set; }
        public int Cantidad { get; set; }
        public int pOferta { get; set; }
        public int pVenta { get; set; }
        public int pTotalOferta { get; set; }
        public int pTotalVenta { get; set; }
    }
}
