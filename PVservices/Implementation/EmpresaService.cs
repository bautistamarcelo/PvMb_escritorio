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
    public class EmpresaService : IEmpresaService
    {
        private readonly IEmpresaRepository _EmpresaRepository;
        public EmpresaService(IEmpresaRepository empresaRepository)
        {
            _EmpresaRepository = empresaRepository;
        }

        public async Task<int> obtenerId(Empresa objeto, int id)
        {
            return await _EmpresaRepository.obtenerId(objeto, id);
        }

        public async Task<List<Empresa>> Lista(string Buscar = "")
        {
            return await _EmpresaRepository.Lista(Buscar);
        }

        public async Task<string> crear(Empresa objeto)
        {
            return await _EmpresaRepository.crear(objeto);
        }

        public async Task<string> editar(Empresa objeto)
        {
            return await _EmpresaRepository.editar(objeto);
        }

       

        
    }
}
