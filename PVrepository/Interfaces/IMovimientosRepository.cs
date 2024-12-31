using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface IMovimientosRepository
    {
        Task<int> obtenerId(Movimientos objeto, int id);
        Task<List<Movimientos>> Lista(string Buscar = "");
        Task<string> crear(Movimientos objeto);
        Task<string> editar(Movimientos objeto);
        Task<string> StockInicial(Movimientos objeto);

    }
}
