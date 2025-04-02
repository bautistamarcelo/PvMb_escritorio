using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IUsuariosService
    {
        Task<List<Usuarios>> Lista(string Buscar = "");
        Task<string> crear(Usuarios objeto);
        Task<string> editar(Usuarios objeto);
        Task<string> eliminar(int UsuarioID);
        Task<Usuarios> Login(string nombre, string clave);
        Task<Usuarios> Buscar(string vNombre);
        Task<int> VerificarCorreo(string correo);
        Task<int> VerificarUsuario(string nombre);
        Task<int> BuscaCajaUsuario(int UsuarioID);
        Task ActualizarClave(int UsuarioID, string clave);
    }
}
