using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ICajasRepository
    {
        Task<List<Cajas>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
        Task<string> crear(Cajas objeto);
        Task<string> editar(Cajas objeto);
    }
}
