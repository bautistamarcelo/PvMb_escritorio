using Microsoft.Data.SqlClient;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    internal class CajasUsuariosRepository : ICajasUsuariosRepository
    {
        private readonly Conexion _conexion;
        public CajasUsuariosRepository(Conexion conexion)
        {
            _conexion = conexion;
        }
        public async Task<List<Cajas_Usuarios>> Lista(DateTime FechaIni, DateTime FechaFin, string Buscar = "")
        {
            List<Cajas_Usuarios> list = new List<Cajas_Usuarios>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Usuarios_Listado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FechaIni", FechaIni));
                cmd.Parameters.Add(new SqlParameter("@FechaFin", FechaFin));
                cmd.Parameters.Add(new SqlParameter("@Buscar", Buscar));
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Cajas_Usuarios
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            CajaID = Convert.ToInt32(dr["ID_Caja"]),
                            UsuarioID = Convert.ToInt32(dr["ID_Usuario"]),
                            FechaAsignacion = Convert.ToDateTime(dr["Fecha"]),
                            Estado = dr["Estado"].ToString()
                        });
                    }
                }
            }
            return list;
        }

        public async Task<Cajas_Usuarios> SeleccionarCaja(int CajaID)
        {
            Cajas_Usuarios cajaUsuario = new Cajas_Usuarios();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Usuarios_SeleccionarCaja", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", CajaID));
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        cajaUsuario.ID = Convert.ToInt32(dr["ID"]);
                        cajaUsuario.CajaID = Convert.ToInt32(dr["CajaID"]);
                        cajaUsuario.UsuarioID = Convert.ToInt32(dr["UsuarioID"]);
                        cajaUsuario.FechaAsignacion =Convert.ToDateTime(dr["FechaAsignacion"]);
                        cajaUsuario.Estado = dr["Estado"].ToString();
                    }
                }
            }
            return cajaUsuario;
        }

        public async Task<string> crear(Cajas_Usuarios objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Usuarios_Crear", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@CajaID", objeto.CajaID));
                cmd.Parameters.Add(new SqlParameter("@UsuarioID", objeto.UsuarioID));
                cmd.Parameters.Add(new SqlParameter("@FechaAsignacion", objeto.FechaAsignacion));
                cmd.Parameters.Add(new SqlParameter("@Estado", objeto.Estado));
                
                respuesta = await cmd.ExecuteNonQueryAsync() == 1 ? "Caja Usuario Creado" : "Error al crear Caja Usuario";
            }
            return respuesta;
        }

        public async Task<string> editar(Cajas_Usuarios objeto)
        {
            string respuesta = "";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cajas_Usuarios_Editar", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ID", objeto.ID));
                cmd.Parameters.Add(new SqlParameter("@CajaID", objeto.CajaID));
                cmd.Parameters.Add(new SqlParameter("@UsuarioID", objeto.UsuarioID));
                cmd.Parameters.Add(new SqlParameter("@FechaAsignacion", objeto.FechaAsignacion));
                cmd.Parameters.Add(new SqlParameter("@Estado", objeto.Estado));
                respuesta = await cmd.ExecuteNonQueryAsync() == 1 ? "Caja Usuario Editado" : "Error al editar Caja Usuario";
            }
            return respuesta;
        }
    }
}
