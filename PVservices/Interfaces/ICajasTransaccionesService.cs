using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface ICajasTransaccionesService
    {
        Task<List<Cajas_Transacciones>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
        Task<string> crear(Cajas_Transacciones objeto);
        Task<string> editar(Cajas_Transacciones objeto);
    }
}
