using Microsoft.Data.SqlClient;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class CajasTransaccionesRepository : ICajasTransaccionesRepository
    {
        private readonly Conexion _conexion;
        public CajasTransaccionesRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Cajas_Transacciones>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "")
        {
            List<Cajas_Transacciones> list = new List<Cajas_Transacciones>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Transacciones_Listado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FechaIni", FechaIni));
                cmd.Parameters.Add(new SqlParameter("@FechaFin", FechaFin));
                cmd.Parameters.Add(new SqlParameter("@Buscar", Buscar));
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Cajas_Transacciones
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            CajaID = Convert.ToInt32(dr["CajaID"]),
                            TipoID = Convert.ToInt32(dr["TipoID"]),
                            Caracter = dr["Caracter"].ToString(),
                            Monto = Convert.ToInt32(dr["Monto"]),
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            ComprobanteNum = dr["ComprobanteNum"].ToString(),
                            Descripcion = dr["Descripcion"].ToString()
                        });

                    }
                }

            }
            return list;
        }


        public async Task<string> crear(Cajas_Transacciones objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Transacciones_Crear", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CajaID", objeto.CajaID));
                cmd.Parameters.Add(new SqlParameter("@TipoID", objeto.TipoID));
                cmd.Parameters.Add(new SqlParameter("@Caracter", objeto.Caracter));
                cmd.Parameters.Add(new SqlParameter("@Monto", objeto.Monto));
                cmd.Parameters.Add(new SqlParameter("@Fecha", objeto.Fecha));
                cmd.Parameters.Add(new SqlParameter("@ComprobanteNum", objeto.ComprobanteNum));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", objeto.Descripcion));
                respuesta = await cmd.ExecuteScalarAsync() != null ? "Ok" : "Error";
            }
            return respuesta;
        }

        public async Task<string> editar(Cajas_Transacciones objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Transacciones_Editar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", objeto.ID));
                cmd.Parameters.Add(new SqlParameter("@CajaID", objeto.CajaID));
                cmd.Parameters.Add(new SqlParameter("@TipoID", objeto.TipoID));
                cmd.Parameters.Add(new SqlParameter("@Caracter", objeto.Caracter));
                cmd.Parameters.Add(new SqlParameter("@Monto", objeto.Monto));
                cmd.Parameters.Add(new SqlParameter("@Fecha", objeto.Fecha));
                cmd.Parameters.Add(new SqlParameter("@ComprobanteNum", objeto.ComprobanteNum));
                cmd.Parameters.Add(new SqlParameter("@Descripcion", objeto.Descripcion));
                respuesta = await cmd.ExecuteScalarAsync() != null ? "Ok" : "Error";
            }
            return respuesta;
        }

        
    }
}
