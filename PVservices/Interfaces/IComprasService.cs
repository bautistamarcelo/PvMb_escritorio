using PVrepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVservices.Interfaces
{
    public interface IComprasService
    {
        Task<string> Registrar(string ComprasXml);
        Task<Compras_E> Obtener(int ComprasID);
        Task<List<Compras_D>> ObtenerDetalleCompra(int ComprasID);
    }
}
