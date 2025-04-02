
using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface IClientesRepository
    {
        Task<List<Clientes>> Lista(string Buscar = "");
        Task<string> crear(Clientes objeto);
        Task<string> editar(Clientes objeto);
        Task<string> eliminar(int IDcliente, int Estado);
        Task<int> obtenerId(Clientes objeto, int id);
        Task<int> Buscar(string Buscar = "");

    }
}
