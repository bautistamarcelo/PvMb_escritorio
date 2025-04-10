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
    public class ProductosService : IProductosService
    {
        private readonly IProductosRepository _productosRepository;
        public ProductosService(IProductosRepository productosRepository)
        {
            _productosRepository = productosRepository;
        }


        public async Task<string> crear(Productos objeto)
        {
            return await _productosRepository.crear(objeto);
        }

        public async Task<string> editar(Productos objeto)
        {
            return await _productosRepository.editar(objeto);
        }

        public async Task<string> eliminar(int IDproducto, int Situacion)
        {
            return await _productosRepository.eliminar(IDproducto, Situacion);
        }

        public async Task<List<Productos>> Lista(string Buscar = "")
        {
            return await _productosRepository.Lista(Buscar);
        }

        public async Task<List<Productos>> ListaSF()
        {
            return await _productosRepository.ListaSF();
        }

        public async Task<Productos> Obtener(string IDproducto)
        {
            return await _productosRepository.Obtener(IDproducto);
        }

        public async Task<int> obtenerId(Productos objeto, int id)
        {
            return await _productosRepository.obtenerId(objeto, id);
        }

        public async Task<Productos> ObtenerXnombre(string productoNombre)
        {
            return await _productosRepository.ObtenerXnombre(productoNombre);
        }
    }
}
