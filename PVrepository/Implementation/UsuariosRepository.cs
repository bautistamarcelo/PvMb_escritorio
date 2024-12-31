using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;


namespace PVrepository.Implementation
{
    public class UsuariosRepository : IUsuariosRepository
    {
        private readonly Conexion _conexion;
        public UsuariosRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Usuarios>> Lista(string Buscar = "")
        {
            List<Usuarios> list = new List<Usuarios>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Usuarios_Listado", con);
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Usuarios
                        {
                            IDUsuario = Convert.ToInt32(dr["IDUsuario"]),
                            nombre = dr["nombre"].ToString()!,
                            correo = dr["correo"].ToString()!,
                            telefono = dr["telefono"].ToString()!,
                            IDRol = new Rol
                            {
                                IDRol = Convert.ToInt32(dr["IDRol"]),
                                descripcion = dr["Rol"].ToString()!
                            },
                            urlFoto = dr["urlFoto"].ToString()!,
                            nombreFoto = dr["nombreFoto"].ToString()!,
                            clave = dr["clave"].ToString()!,
                            esActivo = Convert.ToInt32(dr["esActivo"]),
                            fechaRegistro = Convert.ToDateTime(dr["fechaRegistro"])
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Usuarios objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Usuarios_Crear", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.nombre);
                cmd.Parameters.AddWithValue("@Correo", objeto.correo);
                cmd.Parameters.AddWithValue("@Telefono", objeto.telefono);
                cmd.Parameters.AddWithValue("@IDRol", objeto.IDRol.IDRol);
                cmd.Parameters.AddWithValue("@UrlFoto", objeto.urlFoto);
                cmd.Parameters.AddWithValue("@NombreFoto", objeto.nombreFoto);
                cmd.Parameters.AddWithValue("@Clave", objeto.clave);
                cmd.Parameters.AddWithValue("@esActivo", objeto.esActivo);
                cmd.Parameters.AddWithValue("@FechaRegistro", objeto.fechaRegistro);
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

        public async Task<string> editar(Usuarios objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Usuarios_Editar", con);
                cmd.Parameters.AddWithValue("@ID", objeto.IDUsuario);
                cmd.Parameters.AddWithValue("@Nombre", objeto.nombre);
                cmd.Parameters.AddWithValue("@Correo", objeto.correo);
                cmd.Parameters.AddWithValue("@Telefono", objeto.telefono);
                cmd.Parameters.AddWithValue("@IDRol", objeto.IDRol.IDRol);
                cmd.Parameters.AddWithValue("@UrlFoto", objeto.urlFoto);
                cmd.Parameters.AddWithValue("@NombreFoto", objeto.nombreFoto);
                cmd.Parameters.AddWithValue("@Clave", objeto.clave);
                cmd.Parameters.AddWithValue("@esActivo", objeto.esActivo);
                //cmd.Parameters.AddWithValue("@FechaRegistro", objeto.fechaRegistro);
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
