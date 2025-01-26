using PVrepository.Entities;
namespace PVrepository.Interfaces
{
    public interface IProductosRepository
    {
        Task<int> obtenerId(Productos objeto, int id);
        Task<List<Productos>> Lista(string Buscar = "");
        Task<string> crear(Productos objeto);
        Task<string> editar(Productos objeto);
        Task<Productos>Obtener(int IDproducto);
    }
}
