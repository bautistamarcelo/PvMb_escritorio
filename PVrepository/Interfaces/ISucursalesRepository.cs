using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ISucursalesRepository
    {
        Task<List<Sucursales>> Lista(string Buscar = "");
        Task<string> crear(Sucursales objeto);
        Task<string> editar(Sucursales objeto);
        Task<int> obtenerId(Sucursales objeto, int id);
    }
}
