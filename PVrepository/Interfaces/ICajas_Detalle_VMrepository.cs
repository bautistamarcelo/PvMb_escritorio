using PVrepository.Entities.ViewModels;

namespace PVrepository.Interfaces
{
    public interface ICajas_Detalle_VMrepository
    {
        Task<List<Cajas_Detalle_VM>> Lista(int cajaID = 0);
    }

}
