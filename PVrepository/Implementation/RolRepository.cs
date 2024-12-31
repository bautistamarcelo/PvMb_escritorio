using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class RolRepository : IRolRepository
    {
        private readonly Conexion _conexion;
        public RolRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Rol>> Lista(string Buscar = "")
        {
            List<Rol> list = new List<Rol>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Rol_Listado", con);
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Rol
                        {
                            IDRol = Convert.ToInt32(dr["IDrol"]),
                            descripcion = dr["descripcion"].ToString()!,
                            esActivo = Convert.ToInt32(dr["esActivo"]),
                            fechaRegistro = Convert.ToDateTime(dr["fechaRegistro"])
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Rol objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Rol_Crear", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.descripcion);
                cmd.Parameters.AddWithValue("@esActivo", objeto.esActivo);
                cmd.Parameters.AddWithValue("@fechaRegistro", objeto.fechaRegistro);
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

        public async Task<string> editar(Rol objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Rol_Editar", con);
                cmd.Parameters.AddWithValue("@ID", objeto.IDRol);
                cmd.Parameters.AddWithValue("@Nombre", objeto.descripcion);
                cmd.Parameters.AddWithValue("@esActivo", objeto.esActivo);
                cmd.Parameters.AddWithValue("@fechaRegistro", objeto.fechaRegistro);
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
