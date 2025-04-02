using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IProductosService
    {
        Task<List<Productos>> Lista(string Buscar = "");
        Task<List<Productos>> ListaSF();
        Task<string> crear(Productos objeto);
        Task<string> editar(Productos objeto);
        Task<string> eliminar(int IDproducto, int Situacion);
        Task<int> obtenerId(Productos objeto, int id);
        Task<Productos> Obtener(int IDproducto);
        Task<Productos> ObtenerXnombre(string productoNombre);
    }
}
