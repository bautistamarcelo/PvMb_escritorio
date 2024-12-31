using PVrepository.Entities;
using PVrepository.Implementation;
using PVrepository.Interfaces;
using PVservices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVservices.Implementation
{
    public class TramitesService : ITramitesService
    {
        private readonly ITramitesRepository _tramitesRepository;
        public TramitesService(ITramitesRepository tramitesRepository)
        {
            _tramitesRepository = tramitesRepository;
        }

        public async Task<List<Tramites>> Lista(string Buscar = "")
        {
            return await _tramitesRepository.Lista(Buscar);
        }

        public async Task<int> obtenerId(Tramites objeto, int id)
        {
            return await _tramitesRepository.obtenerId(objeto, id);
        }
    }
}
