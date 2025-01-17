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
    public class CajasMonedaTservice : ICajasMonedaTservice
    {
        private readonly ICajasMonedaTrepository _ICajasMonedaTrepository;
        public CajasMonedaTservice(ICajasMonedaTrepository ICajasMonedaTrepository)
        {
            _ICajasMonedaTrepository = ICajasMonedaTrepository;
        }

        public async Task<string> crear(Cajas_Moneda_T objeto)
        {
            return await _ICajasMonedaTrepository.crear(objeto);
        }

        public async Task<string> editar(Cajas_Moneda_T objeto)
        {
            return await _ICajasMonedaTrepository.editar(objeto);
        }

        public async Task<List<Cajas_Moneda_T>> Lista(int Buscar)
        {
            return await _ICajasMonedaTrepository.Lista(Buscar);
        }
    }
}
