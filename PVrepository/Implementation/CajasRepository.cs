using Microsoft.Data.SqlClient;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class CajasRepository : ICajasRepository
    {
        private readonly Conexion _conexion;
        public CajasRepository(Conexion conexion)
        {
            _conexion = conexion;
        }


        public async Task<List<Cajas>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "")
        {
            List<Cajas> list = new List<Cajas>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Listado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FechaIni", FechaIni));
                cmd.Parameters.Add(new SqlParameter("@FechaFin", FechaFin));
                cmd.Parameters.Add(new SqlParameter("@Buscar", Buscar));

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Cajas
                        {
                            ID = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : 0, // Si es DBNull, asigna 0
                            SucursalID = dr["SucursalID"] != DBNull.Value ? Convert.ToInt32(dr["SucursalID"]) : 0, // Si es DBNull, asigna 0
                            Nombre = dr["CajaNombre"] != DBNull.Value ? dr["CajaNombre"].ToString() : string.Empty, // Si es DBNull, asigna cadena vacía
                            FechaApertura = dr["FechaApertura"] != DBNull.Value ? Convert.ToDateTime(dr["FechaApertura"]) : DateTime.MinValue, // Si es DBNull, asigna la fecha mínima
                            SaldoInicial = dr["SaldoInicial"] != DBNull.Value ? Convert.ToInt32(dr["SaldoInicial"]) : 0, // Si es DBNull, asigna 0
                            FechaCierre = dr["FechaCierre"] != DBNull.Value ? Convert.ToDateTime(dr["FechaCierre"]) : DateTime.MinValue, // Si es DBNull, asigna la fecha mínima
                            SaldoFinal = dr["SaldoFinal"] != DBNull.Value ? Convert.ToInt32(dr["SaldoFinal"]) : 0, // Si es DBNull, asigna 0
                            Condicion = dr["Condicion"] != DBNull.Value ? dr["Condicion"].ToString() : string.Empty, // Si es DBNull, asigna cadena vacía
                            
                        });
                    }
                }
            }
            return list;
        }


        public async Task<string> crear(string cajaXml)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_CrearNueva", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@cajaXml", cajaXml);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                try
                {
                    //await cmd.ExecuteNonQueryAsync();
                    //respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                    respuesta = await cmd.ExecuteNonQueryAsync() == 1 ? "Caja creada" : "Error al crear caja";
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }
            return respuesta;
        }

        public async Task<string> editar(Cajas objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Editar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", objeto.ID));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
                cmd.Parameters.Add(new SqlParameter("@FechaApertura", objeto.FechaApertura));
                cmd.Parameters.Add(new SqlParameter("@SaldoInicial", objeto.SaldoInicial));
                cmd.Parameters.Add(new SqlParameter("@FechaCierre", objeto.FechaCierre));
                cmd.Parameters.Add(new SqlParameter("@SaldoFinal", objeto.SaldoFinal));
                cmd.Parameters.Add(new SqlParameter("@Condicion", objeto.Condicion));
                cmd.Parameters.Add(new SqlParameter("@Resultado", objeto.Resultado));
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                try
                {
                    //await cmd.ExecuteNonQueryAsync();
                    //respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                    respuesta = await cmd.ExecuteNonQueryAsync() == 1 ? "Caja editada" : "Error al editar caja";
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
