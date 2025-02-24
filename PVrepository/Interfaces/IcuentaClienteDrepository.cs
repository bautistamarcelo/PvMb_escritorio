using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface IcuentaClienteDrepository
    {
        Task<List<Cuenta_Cliente_D>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
        Task<string> crear(Cuenta_Cliente_D obJeto);
        Task<string> editar(Cuenta_Cliente_D obJeto);
    }
}
