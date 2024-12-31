using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVpresentation.ViewModels
{
    internal class TramitesVM
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Tipo {get; set; }
        public string TipoNombre{get; set; }
        public int Automatico {get; set; }
        public string Modo{get; set; }
    }
}
