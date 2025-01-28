using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;

namespace PVservices.Implementation
{
    public class Venta_E_Service: IVenta_E_Service
    {
        private readonly IVentas_E_repository _ventas_E_Repository;
        public Venta_E_Service(IVentas_E_repository ventas_E_Repository)
        {
            _ventas_E_Repository = ventas_E_Repository;
        }

        public async Task<string> Registrar(string ventaXml)
        {
            return await _ventas_E_Repository.Registrar(ventaXml);
        }

        public async Task<Ventas_E> Obtener(int VentasID)
        {
            return await _ventas_E_Repository.Obtener(VentasID);
        }

        public async Task<List<Ventas_D>> ObtenerDetalleVenta(int VentasID)
        {
            return await _ventas_E_Repository.ObtenerDetalleVenta(VentasID);
        }

        public async Task<string> Grabar(Ventas_E objeto)
        {
            return await _ventas_E_Repository.Grabar(objeto);
        }
    }
}
