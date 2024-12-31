using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IMarcasService
    {
        Task<int> obtenerId(Marcas objeto, int id);
        Task<List<Marcas>> Lista(string Buscar = "");
        Task<string> crear(Marcas objeto);
        Task<string> editar(Marcas objeto);
        
    }
}
