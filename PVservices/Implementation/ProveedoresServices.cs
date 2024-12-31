using PVrepository.Entities;
using PVrepository.Implementation;
using PVrepository.Interfaces;
using PVservices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVservices.Implementation
{
    internal class ProveedoresServices : IProveedoresService
    {
        private readonly IProveedoresRepository _proveedoresRepository;
        public ProveedoresServices(IProveedoresRepository proveedoresRepository)
        {
            _proveedoresRepository = proveedoresRepository;
        }

        public async Task<int> obtenerId(Proveedores objeto, int id)
        {
            return await _proveedoresRepository.obtenerId(objeto, id);
        }

        public async Task<List<Proveedores>> Lista(string Buscar = "")
        {
            return await _proveedoresRepository.Lista(Buscar);
        }

        public async Task<string> crear(Proveedores objeto)
        {
            return await _proveedoresRepository.crear(objeto);
        }

        public async Task<string> editar(Proveedores objeto)
        {
            return await _proveedoresRepository.editar(objeto);
        }

    
       
    }
}
