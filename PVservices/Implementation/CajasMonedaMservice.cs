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
    public class CajasMonedaMservice : ICajasMonedaMservice
    {
        private readonly ICajasMonedaMrepository _ICajasMonedaMrepository;
        public CajasMonedaMservice(ICajasMonedaMrepository ICajasMonedaMrepository)
        {
            _ICajasMonedaMrepository = ICajasMonedaMrepository;
        }

        public async Task<string> crear(Cajas_Moneda_M objeto)
        {
            return await _ICajasMonedaMrepository.crear(objeto);
        }

        public async Task<string> editar(Cajas_Moneda_M objeto)
        {
            return await _ICajasMonedaMrepository.editar(objeto);
        }

        public async Task<List<Cajas_Moneda_M>> Lista(int Buscar)
        {
            return await _ICajasMonedaMrepository.Lista(Buscar);
        }
    }
}
