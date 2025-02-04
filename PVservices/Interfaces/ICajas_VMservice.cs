using PVrepository.Entities.ViewModels;

namespace PVservices.Interfaces
{
    public interface ICajas_VMservice
    {
        Task<List<Cajas_VM>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
    }
}
