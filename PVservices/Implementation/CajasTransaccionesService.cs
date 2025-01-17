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
    public class CajasTransaccionesService : ICajasTransaccionesService
    {
        private readonly ICajasTransaccionesRepository _CajasTransaccionesRepository;
        public CajasTransaccionesService(ICajasTransaccionesRepository CajasTransaccionesRepository)
        {
            _CajasTransaccionesRepository = CajasTransaccionesRepository;
        }

        public async Task<List<Cajas_Transacciones>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar)
        {
            return await _CajasTransaccionesRepository.Lista(FechaIni, FechaFin, Buscar);
        }
        public async Task<string> crear(Cajas_Transacciones objeto)
        {
            return await _CajasTransaccionesRepository.crear(objeto);
        }
        public async Task<string> editar(Cajas_Transacciones objeto)
        {
            return await _CajasTransaccionesRepository.editar(objeto);
        }
    }
}