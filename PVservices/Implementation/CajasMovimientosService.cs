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
    public class CajasMovimientosService : ICajasMovimientosService
    {
        private readonly ICajasMovimientosRepository _CajasMovimientosRepository;
        public CajasMovimientosService(ICajasMovimientosRepository CajasMovimientosRepository)
        {
            _CajasMovimientosRepository = CajasMovimientosRepository;
        }
       
        public async Task<List<Cajas_Movimientos>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar)
        {
            return await _CajasMovimientosRepository.Lista(FechaIni, FechaFin, Buscar);
        }

        public async Task<string> crear(Cajas_Movimientos objeto)
        {
            return await _CajasMovimientosRepository.crear(objeto);
        }

        public async Task<string> editar(Cajas_Movimientos objeto)
        {
            return await _CajasMovimientosRepository.editar(objeto);
        }

        public async Task<Cajas_Movimientos> ObtenerSaldo(int cajaID)
        {
            return await _CajasMovimientosRepository.ObtenerSaldo(cajaID);
        }
    } 
}
