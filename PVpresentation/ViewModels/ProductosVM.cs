using PVrepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVpresentation.ViewModels
{
    public  class ProductosVM
    {
        public int ID {get; set;}
        public string Nombre {get; set;}
        public int Situacion {get; set;}
        public string BarCode {get; set;}
        public int Stock {get; set;}
        public int Costo {get; set;}
        public int pOferta {get; set;}
        public int pVenta {get; set;}
        public int ImpuestoID {get; set;}
        public int CategoriaID {get; set;}
        public string CategoriaN {get; set;}
        public int MarcaID {get; set;}
        public string MarcaN {get; set;}
        public int ProveedorID {get; set;}
        public string ProveedorN {get; set;}
        public string Talle  {get; set;}
        public string Color {get; set;}
    }
}
