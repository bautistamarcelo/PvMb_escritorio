using PVrepository.Entities;


namespace PVservices.Interfaces
{
    public interface ICajasMovimientosService
    {
        Task<List<Cajas_Movimientos>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
        Task<string> crear(Cajas_Movimientos objeto);
        Task<string> editar(Cajas_Movimientos objeto);
    }
}
