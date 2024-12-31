using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;

namespace PVservices.Implementation
{
    public class RolService : IRolService
    {
        private readonly IRolRepository _rolRepository;
        public RolService(IRolRepository rolRepository)
        {
            _rolRepository = rolRepository;
        }

        public async Task<List<Rol>> Lista(string Buscar = "")
        {
            return await _rolRepository.Lista(Buscar);
        }

        public async Task<string> crear(Rol objeto)
        {
            return await _rolRepository.crear(objeto);
        }

        public async Task<string> editar(Rol objeto)
        {
            return await _rolRepository.editar(objeto);
        }

       
    }
}
