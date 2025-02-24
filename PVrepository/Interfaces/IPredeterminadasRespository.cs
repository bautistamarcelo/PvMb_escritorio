using PVrepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVrepository.Interfaces
{
    public interface IPredeterminadasRespository
    {
        Task<Predeterminadas> Obtener();

    }
}
