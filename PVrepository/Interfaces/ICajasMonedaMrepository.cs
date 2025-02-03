using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ICajasMonedaMrepository
    {
        Task<List<Cajas_Moneda_M>> Lista(int Buscar);
        Task<string> crear(Cajas_Moneda_M objeto);
        Task<string> editar(Cajas_Moneda_M objeto);
        Task<Cajas_Moneda_M> ObtenerSaldo(int cajaID);
    }
}
