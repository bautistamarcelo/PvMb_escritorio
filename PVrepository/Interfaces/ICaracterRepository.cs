
using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ICaracterRepository
    {
        Task<List<Caracter>> Lista();
    }
}
