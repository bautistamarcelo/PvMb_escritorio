using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface ICajasTipoService
    {
        Task<List<Cajas_Tipo>> Lista(string Buscar = "");
        Task<string> crear(Cajas_Tipo objeto);
        Task<string> editar(Cajas_Tipo objeto);
    }
}
