using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ICompras_repository
    {
        Task<string> Registrar(string ComprasXml);
        Task<Compras_E> Obtener(int ComprasID);
        Task<List<Compras_D>> ObtenerDetalleCompra(int ComprasID);
    }
}
