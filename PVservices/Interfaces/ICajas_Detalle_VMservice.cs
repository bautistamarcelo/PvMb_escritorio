using PVrepository.Entities.ViewModels;

namespace PVservices.Interfaces
{
    public interface ICajas_Detalle_VMservice
    {
        Task<List<Cajas_Detalle_VM>> Lista(int cajaID = 0);
    }
}
