using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface ICajasMonedaTservice
    {
        Task<List<Cajas_Moneda_T>> Lista(int Buscar);
        Task<string> crear(Cajas_Moneda_T objeto);
        Task<string> editar(Cajas_Moneda_T objeto);
    }
}
