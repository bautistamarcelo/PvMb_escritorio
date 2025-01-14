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
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString(),
                            FechaApertura = Convert.ToDateTime(dr["Fecha"]),
                            SaldoInicial = Convert.ToInt32(dr["SaldoInicial"]),
                            FechaCierre = Convert.ToDateTime(dr["FechaCierre"]),
                            SaldoFinal = Convert.ToInt32(dr["SaldoFinal"]),
                            Condicion = dr["Condicion"].ToString(),
                            Resultado = Convert.ToInt32(dr["Resultado"])
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Cajas objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Crear", con);
                cmd.CommandType = CommandType.StoredProcedure;
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
