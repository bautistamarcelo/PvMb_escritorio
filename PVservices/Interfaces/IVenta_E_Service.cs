using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IVenta_E_Service
    {
        //Task<List<Ventas_E>> ListarFechas(DateTime FechaIni, DateTime FechaFin);
        Task<int> Registrar(string ventaXml);
        Task<Ventas_E> Obtener(int VentasID);
        Task<List<Ventas_D>> ObtenerDetalleVenta(int VentasID);
    }
}
