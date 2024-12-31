using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface ITramitesService
    {
        Task<List<Tramites>> Lista(string Buscar = "");
        Task<int> obtenerId(Tramites objeto, int id);
    }
}
