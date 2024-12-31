
using Microsoft.Data.SqlClient;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class CaracterRepository : ICaracterRepository
    {
        private readonly Conexion _conexion;
        public CaracterRepository(Conexion conexion)
        {
            _conexion = conexion;
        }
            public async Task<List<Caracter>> Lista()
            {
                List<Caracter> list = new List<Caracter>();
                using (var con = _conexion.ObtenerSqLconexion())
                {
                    con.Open();
                    var cmd = new SqlCommand("SP_Caracter_Listado", con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (var dr = await cmd.ExecuteReaderAsync())
                    {
                        while (await dr.ReadAsync())
                        {
                            list.Add(new Caracter
                            {
                                ID = Convert.ToInt32(dr["ID"]),
                                Nombre = dr["Nombre"].ToString()
                            });
                        }
                    }
                }
            return list;
        }
    } 
}
