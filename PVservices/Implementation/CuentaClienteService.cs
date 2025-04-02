using PVrepository.Entities;
using PVrepository.Entities.ViewModels;
using PVrepository.Interfaces;
using PVservices.Interfaces;

namespace PVservices.Implementation
{
    public class CuentaClienteService : ICuentaClienteService
    {
        private readonly IcuentaClienteErepository _cuentaClienteErepository;
        public CuentaClienteService(IcuentaClienteErepository cuentaClienteErepository)
        {
            _cuentaClienteErepository = cuentaClienteErepository;
        }

        public async Task<List<Cuenta_Cliente_E>> Lista(DateTime FechaIni, DateTime FechaFin, int Buscar = 0)
        {
            return await _cuentaClienteErepository.Lista(FechaIni, FechaFin, Buscar);
        }

        public async Task<List<Cuenta_Cliente_VM>> ListaDetalle(int Buscar = 0)
        {
            return await _cuentaClienteErepository.ListaDetalle(Buscar);
        }

        public async Task<Cuenta_Cliente_VM> ObtenerDetalle(int ClienteID)
        {
            return await _cuentaClienteErepository.ObtenerDetalle(ClienteID);
        }

        public async Task<Cuenta_Cliente_E> ObtenerSaldo(int ClienteID)
        {
            return await _cuentaClienteErepository.ObtenerSaldo(ClienteID);
        }

        public async Task<string> crear(Cuenta_Cliente_E obJeto)
        {
            return await _cuentaClienteErepository.crear(obJeto);
        }

        public async Task<string> editar(Cuenta_Cliente_E obJeto)
        {
            return await _cuentaClienteErepository.editar(obJeto);
        }
    }
}
