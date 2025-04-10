using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface IProveedoresRepository
    {
        Task<List<Proveedores>> Lista(string Buscar = "");
        Task<string> crear(Proveedores objeto);
        Task<string> editar(Proveedores objeto);
        Task<string> Eliminar(int IDproveedor);
        Task<int> obtenerId(Proveedores objeto, int id);
        Task<Proveedores> Obtener(int IDproveedor);
    }
}
