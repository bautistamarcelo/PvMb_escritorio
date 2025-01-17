using Microsoft.Data.SqlClient;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class CajasTipoRepository : ICajasTipoRepository
    {
        private readonly Conexion _conexion;
        public CajasTipoRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Cajas_Tipo>> Lista(string Buscar = "")
        {
            List<Cajas_Tipo> list = new List<Cajas_Tipo>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Tipo_Listado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Buscar", Buscar));
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Cajas_Tipo
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString(),
                            Relacion = dr["Relacion"].ToString(),
                            GMCaja = dr["GMCaja"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Cajas_Tipo objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Tipo_Crear", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Relacion", objeto.Relacion));
                cmd.Parameters.Add(new SqlParameter("@GMCaja", objeto.GMCaja));
                respuesta = await cmd.ExecuteScalarAsync() != null ? "OK" : "No se pudo crear el registro";
            }
            return respuesta;
        }

        public async Task<string> editar(Cajas_Tipo objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Tipo_Editar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", objeto.ID));
                cmd.Parameters.Add(new SqlParameter("@Nombre", objeto.Nombre));
                cmd.Parameters.Add(new SqlParameter("@Relacion", objeto.Relacion));
                cmd.Parameters.Add(new SqlParameter("@GMCaja", objeto.GMCaja));
                respuesta = await cmd.ExecuteScalarAsync() != null ? "OK" : "No se pudo editar el registro";
            }
            return respuesta;
        }

        
    }
}
