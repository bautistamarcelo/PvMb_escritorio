
using PVrepository.Entities;

namespace PVservices.Interfaces
{
    public interface ICategoriaService
    {
        Task<List<Categorias>> Lista(string Buscar = "");
        Task<string> crear(Categorias objeto);
        Task<string> editar(Categorias objeto);
    }
}
