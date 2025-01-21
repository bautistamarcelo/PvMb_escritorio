using PVrepository.Entities;
using PVrepository.Interfaces;

namespace PVservices.Implementation
{

    public class Cajas_VMservice : Interfaces.ICajas_VMservice
    {
        private readonly ICajas_VMrepository _Cajas_VMrepository;
        public Cajas_VMservice(ICajas_VMrepository Cajas_VMrepository)
        {
            _Cajas_VMrepository = Cajas_VMrepository;
        }

        public async Task<List<Cajas_VM>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "")
        {
            return await _Cajas_VMrepository.Lista(FechaIni, FechaFin, Buscar);
        }
    }
}
