using PVrepository.Entities;
using PVrepository.Interfaces;
using PVservices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVservices.Implementation
{
    public class CajasService : ICajasService
    {
        private readonly ICajasRepository _CajasRepository;
        public CajasService(ICajasRepository CajasRepository)
        {
            _CajasRepository = CajasRepository;
        }

        public async Task<List<Cajas>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "")
        {
            return await _CajasRepository.Lista(FechaIni, FechaFin, Buscar);
        }

        public async Task<string> crear(Cajas objeto)
        {
            return await _CajasRepository.crear(objeto);
        }

        public async Task<string> editar(Cajas objeto)
        {
            return await _CajasRepository.editar(objeto);
        }

       
    }
}
