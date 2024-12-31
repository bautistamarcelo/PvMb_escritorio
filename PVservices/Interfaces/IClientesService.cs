
using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IClientesService
    {
        Task<List<Clientes>> Lista(string Buscar = "");
        Task<string> crear(Clientes objeto);
        Task<string> editar(Clientes objeto);
        Task<int> obtenerId(Clientes objeto, int id);
    }
}
