using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;

namespace PVservices.Implementation
{
    public class SituacionService : ISituacionService
    {
        private readonly ISituacionRepository _situacionRepository;
        public SituacionService(ISituacionRepository situacionRepository)
        {
            _situacionRepository = situacionRepository;
        }

        public async Task<string> Editar(Situacion objeto)
        {
            return await _situacionRepository.Editar(objeto);
        }

        public async Task<Situacion> Obtener(int SituacionID)
        {
            return await _situacionRepository.Obtener(SituacionID);
        }
    }
}
