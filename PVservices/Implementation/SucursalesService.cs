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
    public class SucursalesService : ISucursalesService
    {
        private readonly ISucursalesRepository _sucursalesRepository;
        public SucursalesService(ISucursalesRepository sucursalesRepository)
        {
            _sucursalesRepository = sucursalesRepository;
        }

        public async Task<int> obtenerId(Sucursales objeto, int id)
        {
            return await _sucursalesRepository.obtenerId(objeto, id);
        }

        public async Task<List<Sucursales>> Lista(string Buscar = "", int EmpresaID=4)
        {
            return await _sucursalesRepository.Lista(Buscar,EmpresaID);
        }

        public async Task<string> crear(Sucursales objeto)
        {
            return await _sucursalesRepository.crear(objeto);
        }

        public async Task<string> editar(Sucursales objeto)
        {
            return await _sucursalesRepository.editar(objeto);
        }

        

        
    }
}
