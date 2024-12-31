using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class ClientesRepository : IClientesRepository
    {
        private readonly Conexion _conexion;
        public ClientesRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Clientes>> Lista(string Buscar = "")
        {
            List<Clientes> list = new List<Clientes>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Clientes_Listado", con);
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Clientes
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Estado = Convert.ToInt32(dr["Estado"]),
                            HabilitadoCtaCte = Convert.ToInt32(dr["HabilitadoCtaCte"]),
                            CaracterID = new Caracter 
                            {
                                ID = Convert.ToInt32(dr["CaracterID"]),
                                Nombre = dr["Caracter"].ToString()!
                            } ,
                            Nombre = dr["Nombre"].ToString()!,
                            Domicilio = dr["Domicilio"].ToString()!,
                            Cuit = dr["Cuit"].ToString()!,
                            Email = dr["Email"].ToString()!,
                            Telefono = dr["Telefono"].ToString()!
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Clientes objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cliente_Crear", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Domicilio", objeto.Domicilio);
                cmd.Parameters.AddWithValue("@Cuit", objeto.Cuit);
                cmd.Parameters.AddWithValue("@Email", objeto.Email);
                cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);
                cmd.Parameters.AddWithValue("@Estado", objeto.Estado);
                cmd.Parameters.AddWithValue("@Caracter", objeto.CaracterID.ID);
                cmd.Parameters.AddWithValue("@Habilitado", objeto.HabilitadoCtaCte);
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

        public async Task<string> editar(Clientes objeto)
        {

            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cliente_Editar", con);
                cmd.Parameters.AddWithValue("@IDcliente",objeto.ID);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Domicilio", objeto.Domicilio);
                cmd.Parameters.AddWithValue("@Cuit", objeto.Cuit);
                cmd.Parameters.AddWithValue("@Email", objeto.Email);
                cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);
                cmd.Parameters.AddWithValue("@Estado", objeto.Estado);
                cmd.Parameters.AddWithValue("@Caracter", objeto.CaracterID.ID);
                cmd.Parameters.AddWithValue("@Habilitado", objeto.HabilitadoCtaCte);
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

        public async Task<int> obtenerId(Clientes objeto, int id)
        {
            string respuesta = "";
            int resultado = 0;

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cliente_ObtenerID", con);
                cmd.Parameters.Add("@ID_cliente", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    resultado = Convert.ToInt32(cmd.Parameters["@ID_cliente"].Value)!;
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }

            return resultado;
        }
    }
}
