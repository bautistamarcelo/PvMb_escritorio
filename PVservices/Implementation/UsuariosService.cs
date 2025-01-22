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

        public async Task<Usuarios> Login(string nombre, string clave)
        {
            return await _usuariosRepository.Login(nombre, clave);
        }

        public async Task<int> VerificarCorreo(string correo)
        {
            return await _usuariosRepository.VerificarCorreo(correo);
        }

        public async Task<int> VerificarUsuario(string nombre)
        {
            return await _usuariosRepository.VerificarUsuario(nombre);
        }

        public async Task<int> BuscaCajaUsuario(int UsuarioID)
        {
            return await _usuariosRepository.BuscaCajaUsuario(UsuarioID);
        }

        public async Task ActualizarClave(int UsuarioID, string clave)
        {
            await _usuariosRepository.ActualizarClave(UsuarioID, clave);
        }

        
    }
}
