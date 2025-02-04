using Microsoft.Data.SqlClient;
using PVrepository.DB;
using PVrepository.Entities.ViewModels;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class Cajas_VMrepository : ICajas_VMrepository
    {
        private readonly Conexion _conexion;
        public Cajas_VMrepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Cajas_VM>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "")
        {
            List<Cajas_VM> list = new List<Cajas_VM>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Listado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FechaIni", FechaIni));
                cmd.Parameters.Add(new SqlParameter("@FechaFin", FechaFin));
                cmd.Parameters.Add(new SqlParameter("@Buscar", Buscar));
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        list.Add(new Cajas_VM
                        {
                            Id = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : 0, // Si es DBNull, asigna 0
                            SucursalID = dr["SucursalID"] != DBNull.Value ? Convert.ToInt32(dr["SucursalID"]) : 0, // Si es DBNull, asigna 0
                            CajaNombre = dr["CajaNombre"] != DBNull.Value ? dr["CajaNombre"].ToString() : string.Empty, // Si es DBNull, asigna cadena vacía
                            FechaApertura = dr["FechaApertura"] != DBNull.Value ? Convert.ToDateTime(dr["FechaApertura"]) : DateTime.MinValue, // Si es DBNull, asigna la fecha mínima
                            SaldoInicial = dr["SaldoInicial"] != DBNull.Value ? Convert.ToInt32(dr["SaldoInicial"]) : 0, // Si es DBNull, asigna 0
                            FechaCierre = dr["FechaCierre"] != DBNull.Value ? Convert.ToDateTime(dr["FechaCierre"]) : DateTime.MinValue, // Si es DBNull, asigna la fecha mínima
                            SaldoFinal = dr["SaldoFinal"] != DBNull.Value ? Convert.ToInt32(dr["SaldoFinal"]) : 0, // Si es DBNull, asigna 0
                            Condicion = dr["Condicion"] != DBNull.Value ? dr["Condicion"].ToString() : string.Empty, // Si es DBNull, asigna cadena vacía
                            UsuarioNombre = dr["UsuarioNombre"] != DBNull.Value ? dr["UsuarioNombre"].ToString() : string.Empty, // Si es DBNull, asigna cadena vacía
                            UsuarioID = dr["UsuarioID"] != DBNull.Value ? Convert.ToInt32(dr["UsuarioID"]) : 0, // Si es DBNull, asigna 0
                            SucursalNombre = dr["SucursalNombre"] != DBNull.Value ? dr["SucursalNombre"].ToString() : string.Empty, // Si es DBNull, asigna cadena vacía
                        });

                    }
                }
                return list;
            }
        }
    }
}