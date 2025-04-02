using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface IEmpresaService
    {
        Task<List<Empresa>> Lista(string Buscar = "");
        Task<string> crear(Empresa objeto);
        Task<string> editar(Empresa objeto);
        Task<int> obtenerId(Empresa objeto, int id);
        Task<Empresa> Obtener(int EmpresaID);
        Task<string> RespaldarDB();
    }
}
