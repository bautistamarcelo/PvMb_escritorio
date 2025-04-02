using PVrepository.Entities;
namespace PVrepository.Interfaces
{
    public interface IProductosRepository
    {
        Task<int> obtenerId(Productos objeto, int id);
        Task<List<Productos>> Lista(string Buscar = "");
        Task<List<Productos>> ListaSF();
        Task<string> crear(Productos objeto);
        Task<string> editar(Productos objeto);
        Task<string> eliminar(int IDproducto, int Situacion);
        Task<Productos>Obtener(int IDproducto);
        Task<Productos>ObtenerXnombre(string productoNombre);

    }
}
