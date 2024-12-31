using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;

namespace PVrepository.Implementation
{
    public class MovimientosRepository: IMovimientosRepository
    {
        private readonly Conexion _conexion;
        public MovimientosRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<int> obtenerId(Movimientos objeto, int id)
        {
            string respuesta = "";
            int resultado = 0;

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Movimientos_ObtenerID", con);
                cmd.Parameters.Add("@ID", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    resultado = Convert.ToInt32(cmd.Parameters["@ID"].Value)!;
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }

            return resultado;
        }

        public async Task<List<Movimientos>> Lista(string Buscar = "")
        {
            List<Movimientos> list = new List<Movimientos>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Movimientos_Listado", con);
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Movimientos
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Fecha = Convert.ToDateTime(dr["Fecha"].GetType()),
                            Hora= Convert.ToDateTime(dr["Hora"].GetType()),
                            TramiteID = new Tramites
                            {
                                ID = Convert.ToInt32(dr["TramiteIID"]),
                                Nombre = dr["TramiteN"].ToString()!
                            },
                            SucursalID = new Sucursales
                            {
                                ID= Convert.ToInt32(dr["SucursalID"]),
                                Nombre = dr["SucursalN"].ToString()!
                            },
                            ProductoID = new Productos
                            {
                                ID= Convert.ToInt32(dr["ProductoID"]),
                                Nombre = dr["ProductoN"].ToString()!
                            },
                            Comprobante = dr["Comprobante"].ToString()!,
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            pCosto = Convert.ToInt32(dr["pCosto"]),
                            pOferta = Convert.ToInt32(dr["pOferta"]),
                            pVenta = Convert.ToInt32(dr["pVenta"]),
                            pTotal = Convert.ToInt32(dr["pTotal"]),
                            Descripcion = dr["Descripcion"].ToString()!
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Movimientos objeto)
        {
            throw new NotImplementedException();
        }

        public async Task<string> editar(Movimientos objeto)
        {
            throw new NotImplementedException();
        }

        public async Task<string> StockInicial(Movimientos objeto)
        {
            throw new NotImplementedException();
        }
    }
}
