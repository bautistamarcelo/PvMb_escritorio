using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface IEmpresaRepository
    {
        Task<List<Empresa>> Lista(string Buscar = "");
        Task<string> crear(Empresa objeto);
        Task<string> editar(Empresa objeto);
        Task<int> obtenerId(Empresa objeto, int id);
    }
}
