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
    public class ProductosRepository : IProductosRepository
    {
        private readonly Conexion _conexion;
        public ProductosRepository(Conexion conexion)
        {
            _conexion = conexion;
        }


        public async Task<int> obtenerId(Productos objeto, int id)
        {
            string respuesta = "";
            int resultado = 0;

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Productos_ObtenerID", con);
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

        public async Task<List<Productos>> Lista(string Buscar = "")
        {
            List<Productos> list = new List<Productos>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Productos_Listado", con);
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Productos
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString()!,
                            Situacion = Convert.ToInt32(dr["Situacion"]),
                            BarCode = dr["BarCode"].ToString()!,
                            Stock = Convert.ToInt32(dr["Stock"]),
                            Costo= Convert.ToInt32(dr["Costo"]),
                            pOferta= Convert.ToInt32(dr["pOferta"]),
                            pVenta= Convert.ToInt32(dr["pVenta"]),
                            Impuesto = new Impuestos 
                            {
                                ID = Convert.ToInt32(dr["Impuesto"]),
                                Nombre = dr["ImpuestoN"].ToString()!
                            },
                            Categoria = new Categorias
                            {
                                ID = Convert.ToInt32(dr["Categoria"]),
                                Nombre = dr["CategoriaN"].ToString()!
                            },
                            Marca = new Marcas
                            {
                                ID = Convert.ToInt32(dr["Marca"]),
                                Nombre= dr["MarcaN"].ToString()!
                            },
                            Proveedor = new Proveedores
                            {
                                ID = Convert.ToInt32(dr["Proveedor"]),
                                Nombre= dr["ProveedorN"].ToString()!
                            },
                            Talle = dr["Talle"].ToString()!,
                            Color = dr["Color"].ToString()!
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Productos objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Productos_Crear", con);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Situacion", objeto.Situacion);
                cmd.Parameters.AddWithValue("@BarCode", objeto.BarCode);
                cmd.Parameters.AddWithValue("@Stock", objeto.Stock);
                cmd.Parameters.AddWithValue("@Costo", objeto.Costo);
                cmd.Parameters.AddWithValue("@pOferta", objeto.pOferta);
                cmd.Parameters.AddWithValue("@pVenta", objeto.pVenta);
                cmd.Parameters.AddWithValue("@fechaRegistro", objeto.fechaRegistro);
                cmd.Parameters.AddWithValue("@ImpuestoID", objeto.Impuesto.ID);
                cmd.Parameters.AddWithValue("@CategoriaID", objeto.Categoria.ID);
                cmd.Parameters.AddWithValue("@MarcaID", objeto.Marca.ID);
                cmd.Parameters.AddWithValue("@ProveedorID", objeto.Proveedor.ID);
                cmd.Parameters.AddWithValue("@Talle", objeto.Talle);
                cmd.Parameters.AddWithValue("@Color", objeto.Color);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }

            return respuesta;
        }

        public async Task<string> editar(Productos objeto)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Productos_Editar", con);
                cmd.Parameters.AddWithValue("@ID", objeto.ID);
                cmd.Parameters.AddWithValue("@Nombre", objeto.Nombre);
                cmd.Parameters.AddWithValue("@Situacion", objeto.Situacion);
                cmd.Parameters.AddWithValue("@BarCode", objeto.BarCode);
                cmd.Parameters.AddWithValue("@Stock", objeto.Stock);
                cmd.Parameters.AddWithValue("@Costo", objeto.Costo);
                cmd.Parameters.AddWithValue("@pOferta", objeto.pOferta);
                cmd.Parameters.AddWithValue("@pVenta", objeto.pVenta);
                cmd.Parameters.AddWithValue("@fechaRegistro", objeto.fechaRegistro);
                cmd.Parameters.AddWithValue("@ImpuestoID", objeto.Impuesto.ID);
                cmd.Parameters.AddWithValue("@CategoriaID", objeto.Categoria.ID);
                cmd.Parameters.AddWithValue("@MarcaID", objeto.Marca.ID);
                cmd.Parameters.AddWithValue("@ProveedorID", objeto.Proveedor.ID);
                cmd.Parameters.AddWithValue("@Talle", objeto.Talle);
                cmd.Parameters.AddWithValue("@Color", objeto.Color);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction = ParameterDirection.Output;
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta = Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch (Exception ex)
                {
                    respuesta = ex.Message;
                }
            }

            return respuesta;
        }

        public async Task<Productos> Obtener(int IDproducto)
        {
            Productos oBjeto = new Productos();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Productos_Obtener", con);
                cmd.Parameters.AddWithValue("@ProductoID", IDproducto);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        oBjeto = new Productos
                        {
                             ID = Convert.ToInt32(dr["ID"]),
                             BarCode = dr["BarCode"].ToString()!,
                             Nombre = dr["Nombre"].ToString()!,
                             pOferta = Convert.ToInt32(dr["pOferta"]),
                             pVenta = Convert.ToInt32(dr["pVenta"]),
                             Stock = Convert.ToInt32(dr["Stock"]),
                             Situacion = Convert.ToInt32(dr["Situacion"]),
                        };
                    }
                }
            }
            return oBjeto;
        }

        public async Task<Productos> ObtenerXnombre(string productoNombre)
        {
            Productos oBjeto = new Productos();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Productos_ObtenerXnombre", con);
                cmd.Parameters.AddWithValue("@ProductoNombre", productoNombre);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        oBjeto = new Productos
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            BarCode = dr["BarCode"].ToString()!,
                            Nombre = dr["Nombre"].ToString()!,
                            pOferta = Convert.ToInt32(dr["pOferta"]),
                            pVenta = Convert.ToInt32(dr["pVenta"]),
                            Stock = Convert.ToInt32(dr["Stock"]),
                            Situacion = Convert.ToInt32(dr["Situacion"]),
                        };
                    }
                }
            }
            return oBjeto;
        }
    }
}
