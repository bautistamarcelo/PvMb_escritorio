using PVrepository.Entities;
using PVrepository.Entities.ViewModels;

namespace PVrepository.Interfaces
{
    public interface IcuentaClienteErepository
    {
        Task<List<Cuenta_Cliente_E>> Lista(DateTime FechaIni, DateTime FechaFin, int Buscar = 0);
        Task<Cuenta_Cliente_VM> ObtenerDetalle(int ClienteID);
        Task<Cuenta_Cliente_E> ObtenerSaldo(int ClienteID);
        Task<string> crear(Cuenta_Cliente_E obJeto);
        Task<string> editar(Cuenta_Cliente_E obJeto);
    }
}
