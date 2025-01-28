using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    //TODO: Implementar la interfaz
    public interface IVentas_E_repository
    {
        //Task<List<Ventas_E>> ListarFechas(DateTime FechaIni, DateTime FechaFin);
        Task<string> Registrar(string ventaXml);
        Task<string> Grabar(Ventas_E objeto);
        Task<Ventas_E> Obtener(int VentasID);
        Task<List<Ventas_D>>ObtenerDetalleVenta(int VentasID);


    }
}
