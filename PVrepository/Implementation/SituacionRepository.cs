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
    public class SituacionRepository : ISituacionRepository
    {
        private readonly Conexion _conexion;
        public SituacionRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<string> Editar(Situacion objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Situacion_Editar", con);
                cmd.Parameters.AddWithValue("@ID", objeto.ID);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@EstadoID", objeto.EstadoID);
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

        public async Task<Situacion> Obtener(int SituacionID)
        {
            Situacion obJeto = new Situacion();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Situacion_Obtener", con);
                cmd.Parameters.AddWithValue("@ID", SituacionID);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        obJeto = new Situacion()
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString()!,
                            EstadoID = Convert.ToInt32(dr["EstadoID"]),
                            Dias = Convert.ToInt32(dr["Dias"])
                        };
                    }
                }
            }
            return obJeto;
        }
    }
}
