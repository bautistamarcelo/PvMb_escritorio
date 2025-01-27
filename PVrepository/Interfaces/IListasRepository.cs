using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface IListasRepository
    {
        Task<List<Listas>> Lista(string Buscar = "");
    }
}
