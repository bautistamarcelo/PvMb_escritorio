using PVrepository.Entities.ViewModels;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVrepository.Interfaces
{
    public interface ICajas_VMrepository
    {
        Task<List<Cajas_VM>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "");
    }
}
