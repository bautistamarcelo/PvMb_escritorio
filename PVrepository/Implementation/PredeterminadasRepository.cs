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
    public class PredeterminadasRepository: IPredeterminadasRespository
    {
        private readonly Conexion _conexion;
        public PredeterminadasRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<Predeterminadas> Obtener()
        {
            Predeterminadas oBjeto = new Predeterminadas();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Predeterminadas", con);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        oBjeto.ID = Convert.ToInt32(dr["ID"]);
                        oBjeto.EmpresaID = Convert.ToInt32(dr["EmpresaID"]);
                        oBjeto.EmpresaNombre = dr["EmpresaNombre"].ToString()!;
                        oBjeto.SucursalID = Convert.ToInt32(dr["SucursalID"]);
                        oBjeto.SucursalNombre = dr["SucursalNombre"].ToString()!;
                    }
                }
            }
            return oBjeto;
        }
    }
}
