using PVrepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVservices.Interfaces
{
    public interface ISituacionService
    {
        Task<string> Editar(Situacion objeto);
        Task<Situacion> Obtener(int SituacionID);
    }
}
