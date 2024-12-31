using PVrepository.Entities;


namespace PVservices.Interfaces
{
    public interface ICaracterService
    {
        Task<List<Caracter>> Lista();
    }
}
