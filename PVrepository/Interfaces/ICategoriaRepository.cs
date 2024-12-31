using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<List<Categorias>> Lista(string Buscar = "");
        Task<string> crear(Categorias objeto);
        Task<string> editar(Categorias objeto);
    }
}
