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
    public class Compras_Repository: ICompras_repository
    {
        private readonly Conexion _conexion;
        public Compras_Repository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<string> Registrar(string ComprasXml)
        {
            string respuestaCompraID = "0";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Compra_Registrar", con);
                cmd.Parameters.AddWithValue("@ComprasXml", ComprasXml);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuestaCompraID = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch (Exception ex)
                {
                    respuestaCompraID = ex.Message;
                }
            }

            return respuestaCompraID;
        }

        public async Task<Compras_E> Obtener(int ComprasID)
        {
            Compras_E obJeto = new Compras_E();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Venta_E_Obtener", con);
                cmd.Parameters.AddWithValue("@CompraID", ComprasID);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        obJeto = new Compras_E()
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            Tipo = Convert.ToInt32(dr["Tipo"]),
                            Numero = dr["Numero"].ToString()!,
                            pCompra = Convert.ToInt32(dr["pCompra"]),
                            ImpuestoMonto = Convert.ToInt32(dr["ImpuestoMonto"]),
                            Costo = Convert.ToInt32(dr["Costo"]),
                            Situacion = Convert.ToInt32(dr["Situacion"]),
                            Comprobante = Convert.ToInt32(dr["Comprobante"]),
                            Estado = Convert.ToInt32(dr["Estado"]),
                            ImpuestoID = new Impuestos
                            {
                                ID = Convert.ToInt32(dr["ImpuestoID"])
                            },
                            ProveedorID = new Proveedores
                            {
                                ID = Convert.ToInt32(dr["ProveedorID"])
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

        public async Task<List<Compras_D>> ObtenerDetalleCompra(int ComprasID)
        {
            List<Compras_D> list = new List<Compras_D>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Compra_D_Obtener", con);
                cmd.Parameters.AddWithValue("@CompraID", ComprasID);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Compras_D
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            CompraID = Convert.ToInt32(dr["CompraID"]),
                            ProductoID = new Productos
                            {
                                ID = Convert.ToInt32(dr["ProductoID"]),
                                Nombre = dr["Nombre"].ToString()!,
                            },
                            Cantidad = Convert.ToInt32(dr["Cantidad"]),
                            pCompra = Convert.ToInt32(dr["pCompra"]),
                            Impuesto = Convert.ToInt32(dr["Impuesto"]),
                            Costo = Convert.ToInt32(dr["Costo"]),
                            TotalLinea = Convert.ToInt32(dr["TotalLinea"]),
                        });
                    }
                }
            }
            return list;
        }

    }
}
