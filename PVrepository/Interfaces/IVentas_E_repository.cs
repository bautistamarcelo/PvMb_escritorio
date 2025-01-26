using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    //TODO: Implementar la interfaz
    public interface IVentas_E_repository
    {
        Task<List<Ventas_E>> ListarFechas(DateTime FechaIni, DateTime FechaFin);
        Task<Ventas_E> Buscar(int VentasID);
        Task<string> Crear(Ventas_E oBjeto);
        Task<string> Editar(Ventas_E oBjeto);
    }
}
