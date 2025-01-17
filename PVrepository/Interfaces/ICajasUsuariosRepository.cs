using PVrepository.Entities;    

namespace PVrepository.Interfaces
{
    public interface ICajasUsuariosRepository
    {
        Task<List<Cajas_Usuarios>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
        Task<string> crear(Cajas_Usuarios objeto);
        Task<string> editar(Cajas_Usuarios objeto);
    }
}
