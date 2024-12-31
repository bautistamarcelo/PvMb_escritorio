using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IImpuestosService
    {
        Task<int> obtenerId(Impuestos objeto, int id);
        Task<List<Impuestos>> Lista(string Buscar = "");
        Task<string> crear(Impuestos objeto);
        Task<string> editar(Impuestos objeto);
    }
}
