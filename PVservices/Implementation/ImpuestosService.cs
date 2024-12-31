using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;

namespace PVservices.Implementation
{
    public class ImpuestosService : IImpuestosService
    {
        private readonly IImpuestosRepository _impuestosRepository;
        public ImpuestosService(IImpuestosRepository impuestosRepository)
        {
            _impuestosRepository = impuestosRepository;
        }

        public async Task<int> obtenerId(Impuestos objeto, int id)
        {
            return await _impuestosRepository.obtenerId(objeto, id);
        }

        public async Task<List<Impuestos>> Lista(string Buscar = "")
        {
            return await _impuestosRepository.Lista(Buscar);
        }

        public async Task<string> crear(Impuestos objeto)
        {
            return await _impuestosRepository.crear(objeto);
        }

        public async Task<string> editar(Impuestos objeto)
        {
            return await _impuestosRepository.editar(objeto);
        }
        
    }
}
