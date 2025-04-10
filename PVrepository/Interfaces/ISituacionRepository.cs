using PVrepository.Entities;

namespace PVrepository.Interfaces
{
    public interface ISituacionRepository
    {
        Task<Situacion>Obtener(int SituacionID);
        Task<string> Editar(Situacion objeto);
    }
}
