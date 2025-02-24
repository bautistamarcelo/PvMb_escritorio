using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IPredeterminadasService
    {
        Task<Predeterminadas> Obtener();
    }
}
