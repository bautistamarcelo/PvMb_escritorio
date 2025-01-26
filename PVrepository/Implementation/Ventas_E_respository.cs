using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
//TODO: Implementar la lógica de acceso a datos de la entidad Ventas_E

namespace PVrepository.Implementation
{
    public class Ventas_E_respository: IVentas_E_repository
    {
        private readonly Conexion _conexion;
        public Ventas_E_respository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public Task<List<Ventas_E>> ListarFechas(DateTime FechaIni, DateTime FechaFin)
        {
            throw new NotImplementedException();
        }

        public Task<Ventas_E> Buscar(int VentasID)
        {
            throw new NotImplementedException();
        }

        public Task<string> Crear(Ventas_E oBjeto)
        {
            throw new NotImplementedException();
        }

        public Task<string> Editar(Ventas_E oBjeto)
        {
            throw new NotImplementedException();
        }

       
    }
}
