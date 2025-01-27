using Microsoft.Data.SqlClient;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVrepository.Implementation
{
    public class ListasRepository : IListasRepository
    {
        private readonly Conexion _conexion;
        public ListasRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Listas>> Lista(string Buscar = "")
        {
            List<Listas> list = new List<Listas>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Listas_Listado", con);
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Listas
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString()!
                        });
                    }
                }
            }
            return list;
        }
    }
}
