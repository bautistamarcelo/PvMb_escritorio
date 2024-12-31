using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IUsuariosService
    {
        Task<List<Usuarios>> Lista(string Buscar = "");
        Task<string> crear(Usuarios objeto);
        Task<string> editar(Usuarios objeto);
    }
}
