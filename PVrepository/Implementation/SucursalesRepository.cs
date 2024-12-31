using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class SucursalesRepository : ISucursalesRepository
    {
        private readonly Conexion _conexion;
        public SucursalesRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<int> obtenerId(Sucursales objeto, int id)
        {
            string respuesta = "";
            int resultado = 0;

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Sucursales_ObtenerID", con);
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

        public async Task<List<Sucursales>> Lista(string Buscar = "")
        {
            List<Sucursales> list = new List<Sucursales>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Sucursales_Listado", con);
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Sucursales
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString()!,
                            Direccion = dr["Direccion"].ToString()!,
                            Telefono = dr["Telefono"].ToString()!,
                            Email = dr["Email"].ToString()!,               
                            EmpresaID = new Empresa
                            {
                                ID = Convert.ToInt32(dr["EmpresaID"]),
                                Nombre = dr["Empresa"].ToString()!
                            },
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Sucursales objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Sucursales_Crear", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);
                cmd.Parameters.AddWithValue("@Email", objeto.Email);
                cmd.Parameters.AddWithValue("@EmpresaID", objeto.EmpresaID.ID);
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

        public async Task<string> editar(Sucursales objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Sucursales_Editar", con);
                cmd.Parameters.AddWithValue("@ID", objeto.ID);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);
                cmd.Parameters.AddWithValue("@Email", objeto.Email);
                cmd.Parameters.AddWithValue("@EmpresaID", objeto.EmpresaID.ID);
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
