using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ITramitesRepository
    {
        Task<List<Tramites>> Lista(string Buscar = "");
        Task<int> obtenerId(Tramites objeto, int id);
    }


}
