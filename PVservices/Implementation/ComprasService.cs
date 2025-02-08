using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVservices.Implementation
{
    public class ComprasService: IComprasService
    {
        private readonly ICompras_repository _compras_Repository;
        public ComprasService(ICompras_repository compras_Repository)
        {
            _compras_Repository = compras_Repository;
        }

        public async Task<Compras_E> Obtener(int ComprasID)
        {
            return await _compras_Repository.Obtener(ComprasID);
        }

        public async Task<List<Compras_D>> ObtenerDetalleCompra(int ComprasID)
        {
            return await _compras_Repository.ObtenerDetalleCompra(ComprasID);
        }

        public async Task<string> Registrar(string ComprasXml)
        {
            return await _compras_Repository.Registrar(ComprasXml);
        }
    }
}
