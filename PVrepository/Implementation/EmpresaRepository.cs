using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PVrepository.Implementation
{
    public class EmpresaRepository: IEmpresaRepository
    {
        private readonly Conexion _conexion;
        public EmpresaRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<int> obtenerId(Empresa objeto, int id)
        {
            string respuesta = "";
            int resultado = 0;

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Empresa_ObtenerID", con);
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

        public async Task<List<Empresa>> Lista(string Buscar = "")
        {
            
            List<Empresa> list = new List<Empresa>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Empresa_Listado", con);
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Empresa
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString()!,
                            Direccion = dr["Direccion"].ToString()!,
                            Telefono = dr["Telefono"].ToString()!,
                            Cuit = dr["Cuit"].ToString()!,
                            LogoUrl = dr["LogoUrl"].ToString()!,
                            LogoNombre = dr["LogoNombre"].ToString()!,
                            CaracterID = new Caracter
                            {
                                ID = Convert.ToInt32(dr["CaracterID"]),
                                Nombre = dr["Caracter"].ToString()!
                            },
                           SimboloMoneda= dr["SimboloMoneda"].ToString()!,
                           Predeterminada= Convert.ToInt32(dr["Predeterminada"])
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Empresa objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Empresa_Crear", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                cmd.Parameters.AddWithValue("@Cuit", objeto.Cuit);
                cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);
                cmd.Parameters.AddWithValue("@LogoUrl", objeto.LogoUrl);
                cmd.Parameters.AddWithValue("@LogoNombre", objeto.LogoNombre);
                cmd.Parameters.AddWithValue("@Caracter", objeto.CaracterID.ID);
                cmd.Parameters.AddWithValue("@Moneda", objeto.SimboloMoneda);
                cmd.Parameters.AddWithValue("@Predeterminada", objeto.SimboloMoneda);
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

        public async Task<string> editar(Empresa objeto)
        {

            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Empresa_Editar", con);
                cmd.Parameters.AddWithValue("@ID", objeto.ID);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Direccion", objeto.Direccion);
                cmd.Parameters.AddWithValue("@Cuit", objeto.Cuit);
                cmd.Parameters.AddWithValue("@Telefono", objeto.Telefono);
                cmd.Parameters.AddWithValue("@LogoUrl", objeto.LogoUrl);
                cmd.Parameters.AddWithValue("@LogoNombre", objeto.LogoNombre);
                cmd.Parameters.AddWithValue("@Caracter", objeto.CaracterID.ID);
                cmd.Parameters.AddWithValue("@Moneda", objeto.SimboloMoneda);
                cmd.Parameters.AddWithValue("@Predeterminada", objeto.Predeterminada);
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

        public async Task<Empresa> Obtener(int EmpresaID)
        {
            Empresa oBjeto = new Empresa();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Empresa_Obtener", con);
                cmd.Parameters.AddWithValue("@EmpresaID", EmpresaID);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        oBjeto.ID = Convert.ToInt32(dr["ID"]);
                        oBjeto.Nombre = dr["Nombre"].ToString()!;
                        oBjeto.Cuit = dr["Cuit"].ToString()!;
                        oBjeto.Direccion = dr["Direccion"].ToString()!;
                        oBjeto.LogoUrl = dr["LogoUrl"].ToString()!;
                        oBjeto.Telefono = dr["Telefono"].ToString()!;
                        oBjeto.CaracterID = new Caracter
                        {
                            ID = Convert.ToInt32(dr["CaracterID"]),
                        };
                        oBjeto.Predeterminada = Convert.ToInt32(dr["Predeterminada"]);
                    }
                }
            }
            return oBjeto;
        }

        public async Task<string> RespaldarDB()
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Backup_CleanUp_DB", con);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = "Exito"!;
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
