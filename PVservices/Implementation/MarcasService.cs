using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;

namespace PVservices.Implementation
{
    public class MarcasService : IMarcasService
    {
        private readonly IMarcasRepository _marcasRepository;
        public MarcasService(IMarcasRepository marcasRepository)
        {
            _marcasRepository = marcasRepository;
        }

        public async Task<int> obtenerId(Marcas objeto, int id)
        {
            return await _marcasRepository.obtenerId(objeto, id);
        }

        public async Task<List<Marcas>> Lista(string Buscar = "")
        {
            return await  _marcasRepository.Lista(Buscar);
        }

        public async Task<string> crear(Marcas objeto)
        {
            return await _marcasRepository.crear(objeto);
        }

        public async Task<string> editar(Marcas objeto)
        {
            return await _marcasRepository.editar(objeto);
        }

        

        
    }
}
