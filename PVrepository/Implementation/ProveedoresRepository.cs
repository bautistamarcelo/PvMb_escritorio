using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class ProveedoresRepository : IProveedoresRepository
    {
        private readonly Conexion _conexion;
        public ProveedoresRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<int> obtenerId(Proveedores objeto, int id)
        {
            string respuesta = "";
            int resultado = 0;

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Proveedores_ObtenerID", con);
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

        public async Task<List<Proveedores>> Lista(string Buscar = "")
        {
            List<Proveedores> list = new List<Proveedores>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Proveedor_Listado", con);
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Proveedores
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Renta = Convert.ToInt32(dr["Renta"]),
                            CaracterID = new Caracter
                            {
                                ID = Convert.ToInt32(dr["CaracterID"]),
                                Nombre = dr["Caracter"].ToString()!
                            },
                            Nombre = dr["Nombre"].ToString()!,
                            Direccion = dr["Direccion"].ToString()!,
                            Cuit = dr["Cuit"].ToString()!,
                            Email = dr["Email"].ToString()!,
                            Telefono = dr["Telefono"].ToString()!
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Proveedores objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Proveedor_Crear", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                cmd.Parameters.AddWithValue("@Cuit", objeto.Cuit);
                cmd.Parameters.AddWithValue("@Email", objeto.Email);
                cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);
                cmd.Parameters.AddWithValue("@Renta", objeto.Renta);
                cmd.Parameters.AddWithValue("@Caracter", objeto.CaracterID.ID);
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

        public async Task<string> editar(Proveedores objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Proveedor_Editar", con);
                cmd.Parameters.AddWithValue("@ID", objeto.ID);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                cmd.Parameters.AddWithValue("@Cuit", objeto.Cuit);
                cmd.Parameters.AddWithValue("@Email", objeto.Email);
                cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);
                cmd.Parameters.AddWithValue("@Renta", objeto.Renta);
                cmd.Parameters.AddWithValue("@Caracter", objeto.CaracterID.ID);
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

        public async Task<string> Eliminar(int IDproveedor)
        {
            string Resultado;

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Proveedor_Eliminar", con);
                cmd.Parameters.AddWithValue("@ID", IDproveedor);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;
                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    Resultado = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch (Exception ex)
                {
                    Resultado = ex.Message;
                }
            }

            return Resultado;
        }

        public async Task<Proveedores> Obtener(int IDproveedor)
        {
            Proveedores obJeto = new Proveedores();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Proveedor_Obtener", con);
                cmd.Parameters.AddWithValue("@ID", IDproveedor);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        obJeto = new Proveedores()
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString()!,
                            Renta = Convert.ToInt32(dr["Renta"])
                        };
                    }
                }
            }
            return obJeto;
        }
    }
}
