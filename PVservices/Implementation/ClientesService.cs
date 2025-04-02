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
    public class ClientesService : IClientesService
    {
        private readonly IClientesRepository _ClientesRepository;
        public ClientesService(IClientesRepository ClientesRepository)
        {
            _ClientesRepository = ClientesRepository;
        }

        public async Task<List<Clientes>> Lista(string Buscar = "")
        {
            return await _ClientesRepository.Lista(Buscar);
        }

        public async Task<string> crear(Clientes objeto)
        {
            return await _ClientesRepository.crear(objeto);
        }

        public async Task<string> editar(Clientes objeto)
        {
            return await _ClientesRepository.editar(objeto);
        }

        public async Task<string> Eliminar(int IDcliente, int Estado)
        {
            return await _ClientesRepository.eliminar(IDcliente, Estado);
        }

        public async Task<int> obtenerId(Clientes objeto, int id)
        {
            return await _ClientesRepository.obtenerId(objeto, id);
        }

        public async Task<int> Buscar(string Buscar = "")
        {
            return await _ClientesRepository.Buscar(Buscar);
        }

        
    }
}
