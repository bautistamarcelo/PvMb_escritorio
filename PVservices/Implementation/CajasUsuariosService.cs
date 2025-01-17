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
    public class CajasUsuariosService : ICajasUsuariosService
    {
        private readonly ICajasUsuariosRepository _CajasUsuariosRepository;
        public CajasUsuariosService(ICajasUsuariosRepository CajasUsuariosRepository)
        {
            _CajasUsuariosRepository = CajasUsuariosRepository;
        }
        public async Task<List<Cajas_Usuarios>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar)
        {
            return await _CajasUsuariosRepository.Lista(FechaIni, FechaFin, Buscar);
        }
        public async Task<string> crear(Cajas_Usuarios objeto)
        {
            return await _CajasUsuariosRepository.crear(objeto);
        }
        public async Task<string> editar(Cajas_Usuarios objeto)
        {
            return await _CajasUsuariosRepository.editar(objeto);
        }
    }
    {
    }
}
