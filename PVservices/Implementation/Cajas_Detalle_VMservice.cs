using PVrepository.Entities;
using PVrepository.Entities.ViewModels;
using PVrepository.Interfaces;
using PVservices.Interfaces;

namespace PVservices.Implementation
{
    public class Cajas_Detalle_VMservice : ICajas_Detalle_VMservice
    {
        private readonly ICajas_Detalle_VMrepository _cajas_Detalle_VMrepository;
        public Cajas_Detalle_VMservice(ICajas_Detalle_VMrepository cajas_Detalle_VMrepository)
        {
            _cajas_Detalle_VMrepository = cajas_Detalle_VMrepository;
        }

        public async Task<List<Cajas_Detalle_VM>> Lista(int cajaID = 0)
        {
            return await _cajas_Detalle_VMrepository.Lista(cajaID);
        }
    }
}
