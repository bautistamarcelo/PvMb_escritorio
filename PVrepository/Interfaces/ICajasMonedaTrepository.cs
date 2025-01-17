using PVrepository.Entities;


namespace PVrepository.Interfaces
{
    public interface ICajasMonedaTrepository
    {
        Task<List<Cajas_Moneda_T>> Lista(int Buscar);
        Task<string> crear(Cajas_Moneda_T objeto);
        Task<string> editar(Cajas_Moneda_T objeto);
    }
}
