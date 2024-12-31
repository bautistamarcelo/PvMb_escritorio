using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class MarcasRepository : IMarcasRepository
    {
        private readonly Conexion _conexion;
        public MarcasRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<int> obtenerId(Marcas objeto, int id)
        {
            string respuesta = "";
            int resultado = 0;

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Marcas_ObtenerID", con);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    resultado = Convert.ToInt32(cmd.Parameters["@ID"].Value)!;
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }

            return resultado;
        }

        public async Task<List<Marcas>> Lista(string Buscar = "")
        {
            List<Marcas> list = new List<Marcas>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Marcas_Listado", con);
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Marcas
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString()!
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Marcas objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Marcas_Crear", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }
            return respuesta;
        }

        public async Task<string> editar(Marcas objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Marcas_Editar", con);
                cmd.Parameters.AddWithValue("@ID", objeto.ID);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }


            }

            return respuesta;
        }
        
    }
}
