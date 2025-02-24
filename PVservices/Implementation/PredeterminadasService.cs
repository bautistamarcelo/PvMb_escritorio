using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;

namespace PVservices.Implementation
{

    public class PredeterminadasService : IPredeterminadasService
    {
        private readonly IPredeterminadasRespository _predeterminadasRespository;
        public PredeterminadasService(IPredeterminadasRespository predeterminadasRespository)
        {
            _predeterminadasRespository = predeterminadasRespository;
        }

        public async Task<Predeterminadas> Obtener()
        {
            return await _predeterminadasRespository.Obtener();
        }
    }
}
