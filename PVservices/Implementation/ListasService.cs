using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;

namespace PVservices.Implementation
{
    public class ListasService : IListasService
    {
        private readonly IListasRepository _ListasRepository;
        public ListasService(IListasRepository ListasRepository)
        {
            _ListasRepository = ListasRepository;
        }

        public async Task<List<Listas>> Lista(string Buscar = "")
        {
            return await _ListasRepository.Lista(Buscar);
        }
    }
}
