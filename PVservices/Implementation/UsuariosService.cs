using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;

namespace PVservices.Implementation
{
    public class UsuariosService : IUsuariosService
    {
        private readonly IUsuariosRepository _usuariosRepository;
        public UsuariosService(IUsuariosRepository usuariosRepository)
        {
            _usuariosRepository = usuariosRepository;
        }

        public async Task<List<Usuarios>> Lista(string Buscar = "")
        {
            return await _usuariosRepository.Lista(Buscar);
        }

        public async Task<string> crear(Usuarios objeto)
        {
            return await _usuariosRepository.crear(objeto);
        }

        public async Task<string> editar(Usuarios objeto)
        {
            return await _usuariosRepository.editar(objeto);
        }

        
    }
}
