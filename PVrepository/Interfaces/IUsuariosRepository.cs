using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface IUsuariosRepository
    {
        Task<List<Usuarios>> Lista(string Buscar = "");
        Task<string> crear(Usuarios objeto);
        Task<string> editar(Usuarios objeto);
        
    }
}
