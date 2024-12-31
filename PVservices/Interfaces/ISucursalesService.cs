using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface ISucursalesService
    {
        Task<List<Sucursales>> Lista(string Buscar = "");
        Task<string> crear(Sucursales objeto);
        Task<string> editar(Sucursales objeto);
        Task<int> obtenerId(Sucursales objeto, int id);
    }
}
