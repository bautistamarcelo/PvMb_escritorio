using Microsoft.Data.SqlClient;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Entities.ViewModels;
using PVrepository.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PVrepository.Implementation
{
    public class Cajas_Detalle_VMrepository : ICajas_Detalle_VMrepository
    {
        private readonly Conexion _conexion;
        public Cajas_Detalle_VMrepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Cajas_Detalle_VM>> Lista(int cajaID = 0)
        {
            List<Cajas_Detalle_VM> list = new List<Cajas_Detalle_VM>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Listar_Detalles", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CajaID", cajaID));

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Cajas_Detalle_VM
                        {
                            CajaID = dr["CajaID"] != DBNull.Value ? Convert.ToInt32(dr["CajaID"]) : 0, // Si es DBNull, asigna 0,
                            Descripcion = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString() : string.Empty, // Si es DBNull, asigna cadena vacía
                            Monto = dr["Monto"] != DBNull.Value ? Convert.ToInt32(dr["Monto"]) : 0, // Si es DBNull, asigna 0
                            Efectivo = dr["Efectivo"] != DBNull.Value ? Convert.ToInt32(dr["Efectivo"]) : 0, // Si es DBNull, asigna 0
                            Debito = dr["Debito"] != DBNull.Value ? Convert.ToInt32(dr["Debito"]) : 0, // Si es DBNull, asigna 0
                            Tarjeta = dr["Tarjeta"] != DBNull.Value ? Convert.ToInt32(dr["Tarjeta"]) : 0, // Si es DBNull, asigna 0
                        });
                    }
                }
            }
            return list;
        }
    }
}
