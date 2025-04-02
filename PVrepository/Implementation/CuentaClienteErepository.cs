using Microsoft.Data.SqlClient;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Entities.ViewModels;
using PVrepository.Interfaces;
using System.Data;

namespace PVrepository.Implementation
{
    public class CuentaClienteErepository : IcuentaClienteErepository
    {
        private readonly Conexion _conexion;
        public CuentaClienteErepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Cuenta_Cliente_E>> Lista(DateTime FechaIni, DateTime FechaFin, int Buscar = 0)
        {
            List<Cuenta_Cliente_E> list = new List<Cuenta_Cliente_E>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cuenta_Cliente_Listado", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@FechaIni", FechaIni));
                cmd.Parameters.Add(new SqlParameter("@FechaFin", FechaFin));
                cmd.Parameters.Add(new SqlParameter("@Buscar", Buscar));

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Cuenta_Cliente_E
                        {
                            ID = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : 0, // Si es DBNull, asigna 0
                            ComprobanteID = dr["ComprobanteID"] != DBNull.Value ? Convert.ToInt32(dr["ComprobanteID"]) : 0, // Si es DBNull, asigna 0
                            TipoID = dr["TipoID"] != DBNull.Value ? Convert.ToInt32(dr["TipoID"]) : 0, // Si es DBNull, asigna 0
                            Fecha = Convert.ToDateTime(dr["Fecha"]),
                            Descripcion = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString() : string.Empty, // Si es DBNull, asigna cadena vacía
                            Credito = dr["Credito"] != DBNull.Value ? Convert.ToInt32(dr["Credito"]) : 0, // Si es DBNull, asigna 0
                            Pagos = dr["Pagos"] != DBNull.Value ? Convert.ToInt32(dr["Pagos"]) : 0, // Si es DBNull, asigna 0
                            Estado = dr["Estado"] != DBNull.Value ? Convert.ToInt32(dr["Estado"]) : 0, // Si es DBNull, asigna 0
                            ClienteID = new Clientes
                            { 
                                ID = Convert.ToInt32(dr["ClienteID"]),
                            },
                        });
                    }
                }
            }
            return list;
        }

        public async Task<List<Cuenta_Cliente_VM>> ListaDetalle(int Buscar = 0)
        {
            List<Cuenta_Cliente_VM> list = new List<Cuenta_Cliente_VM>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("[SP_Cuenta_Cliente_Listado_Detalle]", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@ClienteID", Buscar));

                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Cuenta_Cliente_VM
                        {
                            ID = dr["ID"] != DBNull.Value ? Convert.ToInt32(dr["ID"]) : 0, // Si es DBNull, asigna 0
                            CuentaID = dr["CuentaID"] != DBNull.Value ? Convert.ToInt32(dr["CuentaID"]) : 0, // Si es DBNull, asigna 0
                            FechaD = Convert.ToDateTime(dr["Fecha"]),
                            ComprobanteNumero = dr["ComprobanteNumero"] != DBNull.Value ? Convert.ToInt32(dr["ComprobanteNumero"]) : 0, // Si es DBNull, asigna 0
                            DescripcionD = dr["Descripcion"] != DBNull.Value ? dr["Descripcion"].ToString() : string.Empty, // Si es DBNull, asigna cadena vacía
                            TipoD = dr["Tipo"] != DBNull.Value ? Convert.ToInt32(dr["Tipo"]) : 0, // Si es DBNull, asigna 0
                            Ingreso = dr["Ingreso"] != DBNull.Value ? Convert.ToInt32(dr["Ingreso"]) : 0, // Si es DBNull, asigna 0
                            Salida = dr["Salida"] != DBNull.Value ? Convert.ToInt32(dr["Salida"]) : 0, // Si es DBNull, asigna 0
                            
                        });
                    }
                }
            }
            return list;
        }

        public async Task<Cuenta_Cliente_VM> ObtenerDetalle(int ClienteID)
        {
            Cuenta_Cliente_VM obJeto = new Cuenta_Cliente_VM();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cuenta_Cliente_Obtener", con);
                cmd.Parameters.AddWithValue("@Cliente", ClienteID);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        obJeto = new Cuenta_Cliente_VM()
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            ComprobanteID = Convert.ToInt32(dr["ComprobanteID"]),
                            TipoE = Convert.ToInt32(dr["TipoE"]),
                            ClienteID = Convert.ToInt32(dr["ClienteID"]),
                            ClienteNombre = dr["ClienteNombre"].ToString()!,
                            FechaE = Convert.ToDateTime(dr["FechaE"]),
                            DescripcionE = dr["DescripcionE"].ToString()!,
                            Credito = Convert.ToInt32(dr["Credito"]),
                            Pagos = Convert.ToInt32(dr["Pagos"]),
                            Estado = Convert.ToInt32(dr["Estado"]),
                            CuentaID = Convert.ToInt32(dr["CuentaID"]),
                            DescripcionD = dr["DescripcionD"].ToString()!,
                            TipoD = Convert.ToInt32(dr["TipoD"]),
                            ComprobanteNumero = Convert.ToInt32(dr["ComprobanteNumero"]),
                            FechaD = Convert.ToDateTime(dr["FechaD"]),
                            Ingreso = Convert.ToInt32(dr["Ingreso"]),
                            Salida = Convert.ToInt32(dr["Salida"]),
                        };
                    }
                }
            }
            return obJeto;
        }

        public async Task<Cuenta_Cliente_E> ObtenerSaldo(int ClienteID)
        {
            Cuenta_Cliente_E obJeto = new Cuenta_Cliente_E();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Cuenta_Cliente_Saldo", con);
                cmd.Parameters.AddWithValue("@ClienteID", ClienteID);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    if (await dr.ReadAsync())
                    {
                        obJeto = new Cuenta_Cliente_E()
                        {
                            ClienteID = new Clientes
                            {
                                ID = Convert.ToInt32(dr["ClienteID"])
                            },
                            Credito = Convert.ToInt32(dr["Debitado"]),
                            Pagos = Convert.ToInt32(dr["Pagos"]),
                            Saldo = Convert.ToInt32(dr["Saldo"]),
                        };
                    }
                }
                return obJeto;
            }
        }

        public Task<string> crear(Cuenta_Cliente_E obJeto)
        {
            throw new NotImplementedException();
        }

        public Task<string> editar(Cuenta_Cliente_E obJeto)
        {
            throw new NotImplementedException();
        }
        
    }
}
