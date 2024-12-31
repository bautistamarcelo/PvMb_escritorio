using PVrepository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVrepository.Interfaces
{
    public interface IRolRepository
    {
        Task<List<Rol>> Lista(string Buscar = "");
        Task<string> crear(Rol objeto);
        Task<string> editar(Rol objeto);
    }
}
