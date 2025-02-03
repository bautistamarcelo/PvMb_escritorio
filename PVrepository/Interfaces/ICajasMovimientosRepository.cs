using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ICajasMovimientosRepository
    {
        Task<List<Cajas_Movimientos>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
        Task<string> crear(Cajas_Movimientos objeto);
        Task<string> editar(Cajas_Movimientos objeto);
        Task<Cajas_Movimientos> ObtenerSaldo(int cajaID);
    }
}
