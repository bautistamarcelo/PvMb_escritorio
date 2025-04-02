using PVrepository.Entities;
using PVrepository.Entities.ViewModels;

namespace PVservices.Interfaces
{
    public interface ICuentaClienteService
    {
        Task<List<Cuenta_Cliente_E>> Lista(DateTime FechaIni, DateTime FechaFin, int Buscar = 0);
        Task<List<Cuenta_Cliente_VM>> ListaDetalle(int Buscar = 0);
        Task<Cuenta_Cliente_VM> ObtenerDetalle(int ClienteID);
        Task<Cuenta_Cliente_E> ObtenerSaldo(int ClienteID);
        Task<string> crear(Cuenta_Cliente_E obJeto);
        Task<string> editar(Cuenta_Cliente_E obJeto);
    }
}
