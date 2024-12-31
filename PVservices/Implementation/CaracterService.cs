
using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;


namespace PVservices.Implementation
{
    public class CaracterService : ICaracterService
    {
        private readonly ICaracterRepository _CaracterRepository;
        public CaracterService(ICaracterRepository CaracterRepository) 
        { 
            _CaracterRepository = CaracterRepository;
        }

        public async Task<List<Caracter>> Lista()
        {
            return await _CaracterRepository.Lista();
        }
    }
}
