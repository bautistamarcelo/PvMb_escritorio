using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IRolService
    {
        Task<List<Rol>> Lista(string Buscar = "");
        Task<string> crear(Rol objeto);
        Task<string> editar(Rol objeto);
    }
}
