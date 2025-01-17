using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ICajasTransaccionesRepository
    {
        Task<List<Cajas_Transacciones>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
        Task<string> crear(Cajas_Transacciones objeto);
        Task<string> editar(Cajas_Transacciones objeto);
    }
}
