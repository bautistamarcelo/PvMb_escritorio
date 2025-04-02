using Microsoft.Data.SqlClient;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class CajasMonedaMrepository : ICajasMonedaMrepository
    {
        private readonly Conexion _conexion;
        public CajasMonedaMrepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Cajas_Moneda_M>> Lista(int Buscar)
        {
            List<Cajas_Moneda_M> list = new List<Cajas_Moneda_M>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Moneda_M_Listado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Buscar", Buscar));
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Cajas_Moneda_M
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            CajasMovimientoID = Convert.ToInt32(dr["CajasMovimientoID"]),
                            Efectivo = Convert.ToInt32(dr["Efectivo"]),
                            Tarjeta = Convert.ToInt32(dr["Tarjeta"]),
                            Debito = Convert.ToInt32(dr["Debito"])
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Cajas_Moneda_M objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Moneda_M_Crear", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CajasMovimientoID", objeto.CajasMovimientoID));
                cmd.Parameters.Add(new SqlParameter("@Efectivo", objeto.Efectivo));
                cmd.Parameters.Add(new SqlParameter("@Tarjeta", objeto.Tarjeta));
                cmd.Parameters.Add(new SqlParameter("@Debito", objeto.Debito));
                respuesta = await cmd.ExecuteScalarAsync() != null ? "Ok, Detalle obtenido" : "Error obteniendo el detalle";
            }
            return respuesta;
        }

        public async Task<string> editar(Cajas_Moneda_M objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Moneda_M_Editar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", objeto.ID));
                cmd.Parameters.Add(new SqlParameter("@CajasMovimientoID", objeto.CajasMovimientoID));
                cmd.Parameters.Add(new SqlParameter("@Efectivo", objeto.Efectivo));
                cmd.Parameters.Add(new SqlParameter("@Tarjeta", objeto.Tarjeta));
                cmd.Parameters.Add(new SqlParameter("@Debito", objeto.Debito));
                respuesta = await cmd.ExecuteScalarAsync() != null ? "Ok, Detalle actualizado" : "Error actualizando el detalle";
            }
            return respuesta;
        }

        public async Task<Cajas_Moneda_M> ObtenerSaldo(int cajaID)
        {
            Cajas_Moneda_M oBjeto = new Cajas_Moneda_M();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Calcular_Saldos", con);
                cmd.Parameters.AddWithValue("@CajaID", cajaID);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        oBjeto = new Cajas_Moneda_M
                        {
                            Efectivo = dr["Efectivo"] != DBNull.Value ? Convert.ToInt32(dr["Efectivo"]) : 0, // Si es DBNull, asigna 0
                            Debito = dr["Debito"] != DBNull.Value ? Convert.ToInt32(dr["Debito"]) : 0, // Si es DBNull, asigna  0
                            Tarjeta = dr["Tarjeta"] != DBNull.Value ? Convert.ToInt32(dr["Tarjeta"]) : 0, // Si es DBNull, asigna  0
                        };
                    }
                }
            }
            return oBjeto;
        }
    }
}
