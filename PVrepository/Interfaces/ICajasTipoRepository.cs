using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ICajasTipoRepository
    {
        Task<List<Cajas_Tipo>> Lista(string Buscar = "");
        Task<string> crear(Cajas_Tipo objeto);
        Task<string> editar(Cajas_Tipo objeto);
    }
}
