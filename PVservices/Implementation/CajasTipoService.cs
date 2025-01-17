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
    public class CajasTipoService : ICajasTipoService
    {
        private readonly ICajasTipoRepository _CajasTipoRepository;
        public CajasTipoService(ICajasTipoRepository CajasTipoRepository)
        {
            _CajasTipoRepository = CajasTipoRepository;
        }

        public async Task<List<Cajas_Tipo>> Lista(string Buscar = "")
        {
            return await _CajasTipoRepository.Lista(Buscar);
        }

        public async Task<string> crear(Cajas_Tipo objeto)
        {
            return await _CajasTipoRepository.crear(objeto);
        }

        public async Task<string> editar(Cajas_Tipo objeto)
        {
            return await _CajasTipoRepository.editar(objeto);
        }

        
    }
}
