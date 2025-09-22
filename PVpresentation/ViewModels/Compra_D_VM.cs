using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVpresentation.ViewModels
{
    public class Compra_D_VM
    {
        public int ID {get; set;}
        public int CompraID {get; set;}
        public int ProductoID {get; set;}
        public string ProductoBarCode { get; set; } = string.Empty;
        public string ProductoNombre { get; set; }=string.Empty;
        public int Cantidad {get; set;}
        public int pCompra {get; set;}
        public int Impuesto {get; set;}
        public int Costo {get; set;}
        public int pOferta {get; set;}
        public int pVenta {get; set;}
        public int TotalCosto {get; set;}
        public int TotalCompra {get; set;}

    }
}
