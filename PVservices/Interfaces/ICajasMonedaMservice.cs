using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface ICajasMonedaMservice
    {
        Task<List<Cajas_Moneda_M>> Lista(int Buscar);
        Task<string> crear(Cajas_Moneda_M objeto);
        Task<string> editar(Cajas_Moneda_M objeto);
    }
}
