using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface IImpuestosRepository
    {
        Task<int> obtenerId(Impuestos objeto, int id);
        Task<List<Impuestos>> Lista(string Buscar = "");
        Task<string> crear(Impuestos objeto);
        Task<string> editar(Impuestos objeto);
    }
}
