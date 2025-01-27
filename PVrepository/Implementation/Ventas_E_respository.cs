using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing;
using System;
//TODO: Implementar la lógica de acceso a datos de la entidad Ventas_E

namespace PVrepository.Implementation
{
    public class Ventas_E_respository: IVentas_E_repository
    {
        private readonly Conexion _conexion;
        public Ventas_E_respository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<int> Registrar(string ventaXml)
        {
            int respuestaVentaID = 0;

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Venta_Registrar", con);
                cmd.Parameters.AddWithValue("@VentaXml", ventaXml);
                cmd.Parameters.Add("@VentaID", SqlDbType.Int).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuestaVentaID = Convert.ToInt32(cmd.Parameters["@VentaID"].Value)!;
                }
                catch (Exception)
                {
                    respuestaVentaID =0;
                }
            }

            return respuestaVentaID;
        }

        public async Task<Ventas_E> Obtener(int VentasID)
        {
            Ventas_E obJeto = new Ventas_E();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Venta_E_Obtener", con);
                cmd.Parameters.AddWithValue("@VentaID", VentasID);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        obJeto = new Ventas_E()
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            SubTotal = Convert.ToInt32(dr["SubTotal"]),
                            DtoEfectivo = Convert.ToInt32(dr["DtoEfectivo"]),
                            Bruto = Convert.ToInt32(dr["Bruto"]),
                            DtoGeneral = Convert.ToInt32(dr["DtoGeneral"]),
                            Monto = Convert.ToInt32(dr["Monto"]),
                            Tipo = Convert.ToInt32(dr["Tipo"]),
                            Tefectivo = Convert.ToInt32(dr["Tefectivo"]),
                            Tdebito = Convert.ToInt32(dr["Tdebito"]),
                            Ttarjeta = Convert.ToInt32(dr["Ttarjeta"]),
                            Tcredito = Convert.ToInt32(dr["Tcredito"]),
                            VendedorID = new Usuarios
                            {
                                IDUsuario = Convert.ToInt32(dr["VendedorID"])
                            },
                            ClienteID = new Clientes
                            {
                                ID = Convert.ToInt32(dr["ClienteID"])
                            },
                            SucursalID = new Sucursales
                            {
                                ID = Convert.ToInt32(dr["SucursalID"])
                            },

                        };
                    }
                }
            }
            return obJeto;
        }

        public async Task<List<Ventas_D>> ObtenerDetalleVenta(int VentasID)
        {
            List<Ventas_D> list = new List<Ventas_D>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Venta_D_Obtener", con);
                cmd.Parameters.AddWithValue("@VentaID", VentasID);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Ventas_D
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            VentaID = Convert.ToInt32(dr["VentaID"]),
                            ProductoID = new Productos
                            {
                                ID = Convert.ToInt32(dr["ProductoID"]),
                                Nombre = dr["Nombre"].ToString(),
                            },
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            pOferta = Convert.ToInt32(dr["pOferta"]),
                            pVenta = Convert.ToInt32(dr["pVenta"]),
                            pTotalOferta = Convert.ToInt32(dr["pTotalOferta"]),
                            pTotalVenta = Convert.ToInt32(dr["pTotalVenta"]),
                        });
                    }
                }
            }
            return list;
        }
        
    }
}
