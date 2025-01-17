using Microsoft.Data.SqlClient;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class CajasMonedaTrepository : ICajasMonedaTrepository
    {
        private readonly Conexion _conexion;
        public CajasMonedaTrepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Cajas_Moneda_T>> Lista(int Buscar)
        {
            List<Cajas_Moneda_T> list = new List<Cajas_Moneda_T>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Moneda_T_Listado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Buscar", Buscar));
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Cajas_Moneda_T
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            CajasTransaccionesID = Convert.ToInt32(dr["CajasTransaccionesID"]),
                            Efectivo = Convert.ToInt32(dr["Efectivo"]),
                            Tarjeta = Convert.ToInt32(dr["Tarjeta"]),
                            Debito = Convert.ToInt32(dr["Debito"])
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Cajas_Moneda_T objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Moneda_T_Crear", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CajasTransaccionesID", objeto.CajasTransaccionesID));
                cmd.Parameters.Add(new SqlParameter("@Efectivo", objeto.Efectivo));
                cmd.Parameters.Add(new SqlParameter("@Tarjeta", objeto.Tarjeta));
                cmd.Parameters.Add(new SqlParameter("@Debito", objeto.Debito));
                respuesta = await cmd.ExecuteScalarAsync() != null ? "Ok, Detalle obtenido" : "Error obteniendo el detalle";
            }
            return respuesta;
        }

        public async Task<string> editar(Cajas_Moneda_T objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Moneda_T_Editar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", objeto.ID));
                cmd.Parameters.Add(new SqlParameter("@CajasTransaccionesID", objeto.CajasTransaccionesID));
                cmd.Parameters.Add(new SqlParameter("@Efectivo", objeto.Efectivo));
                cmd.Parameters.Add(new SqlParameter("@Tarjeta", objeto.Tarjeta));
                cmd.Parameters.Add(new SqlParameter("@Debito", objeto.Debito));
                respuesta = await cmd.ExecuteScalarAsync() != null ? "Ok, Detalle obtenido" : "Error obteniendo el detalle";
            }
            return respuesta;
        }

        
    }
}
