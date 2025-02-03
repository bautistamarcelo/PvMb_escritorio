using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ICajasRepository
    {
        Task<List<Cajas>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
        Task<string> crear(string cajaXml);
        Task<string> editar(Cajas objeto);
    }
}
