using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IProductosService
    {
        Task<List<Productos>> Lista(string Buscar = "");
        Task<string> crear(Productos objeto);
        Task<string> editar(Productos objeto);
        Task<int> obtenerId(Productos objeto, int id);
    }
}
