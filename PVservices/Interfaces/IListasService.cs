using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IListasService
    {
        Task<List<Listas>> Lista(string Buscar = "");
    }
}
