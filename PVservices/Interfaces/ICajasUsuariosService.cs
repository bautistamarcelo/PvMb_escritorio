using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface ICajasUsuariosService
    {
        Task<List<Cajas_Usuarios>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
        Task<string> crear(Cajas_Usuarios objeto);
        Task<string> editar(Cajas_Usuarios objeto);
    }
}
