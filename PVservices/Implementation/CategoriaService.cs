
using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;

namespace PVservices.Implementation
{
    public class CategoriaService : ICategoriaService
    {
        private readonly ICategoriaRepository _CategoriaRepository;
        public CategoriaService(ICategoriaRepository CategoriaRepository) 
        {
            _CategoriaRepository = CategoriaRepository;
        }

        public async Task<List<Categorias>> Lista(string Buscar = "")
        {
            return await _CategoriaRepository.Lista(Buscar);
        }

        public async Task<string> crear(Categorias objeto)
        {
            return await _CategoriaRepository.crear(objeto);
        }

        public async Task<string> editar(Categorias objeto)
        {
            return await _CategoriaRepository.editar(objeto);
        }

        public async Task<int> Buscar(Categorias MiID)
        {
            return await _CategoriaRepository.Buscar(MiID);
        }
    }
}
