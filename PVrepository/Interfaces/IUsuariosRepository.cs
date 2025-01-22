using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface IUsuariosRepository
    {
        Task<List<Usuarios>> Lista(string Buscar = "");
        Task<string> crear(Usuarios objeto);
        Task<string> editar(Usuarios objeto);
        Task<Usuarios> Login(string nombre, string clave);
        Task<int>VerificarCorreo(string correo);
        Task<int> VerificarUsuario(string nombre);
        Task<int>BuscaCajaUsuario(int UsuarioID);
        Task ActualizarClave(int UsuarioID, string clave);
    }
}
