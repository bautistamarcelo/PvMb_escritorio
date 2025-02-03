using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface ICajasService
    {
        Task<List<Cajas>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
        Task<string> crear(string cajaXml);
        Task<string> editar(Cajas objeto);
    }
}
