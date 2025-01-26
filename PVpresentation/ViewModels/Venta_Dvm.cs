using PVrepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVpresentation.ViewModels
{
    public class Venta_Dvm
    {
        public int ID {get; set;}
        public int VentaID {get; set;}
        public int ProductoID {get; set;}
        public string ProductoNombre {get; set;}
        public int Cantidad {get; set;}
        public int pOferta {get; set;}
        public int pVenta {get; set;}
        public int pTotalOferta {get; set;}
        public int pTotalVenta {get; set; }
        public string Observaciones {get; set;}
    }
}
