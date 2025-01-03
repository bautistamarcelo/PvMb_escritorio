using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using PVrepository.DB;
using PVrepository.Entities;
using PVrepository.Interfaces;
using System.Data;


namespace PVrepository.Implementation
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly Conexion _conexion;
        public CategoriaRepository(Conexion conexion)
        {
            _conexion = conexion;
        }

        public async Task<List<Categorias>> Lista(string Buscar = "")
        {
            List<Categorias> list = new List<Categorias>();
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Categoria_Listado", con);
                cmd.Parameters.AddWithValue("@Buscar", Buscar);
                cmd.CommandType = CommandType.StoredProcedure;
                using (var dr = await cmd.ExecuteReaderAsync())
                {
                    while (await dr.ReadAsync())
                    {
                        list.Add(new Categorias
                        {
                            ID = Convert.ToInt32(dr["ID"]),
                            Nombre = dr["Nombre"].ToString()!
                        });
                    }
                }
            }
            return list;
        }

        public async Task<string> crear(Categorias objeTo)
        {
            string respuesta="";
            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Categoria_Crear", con);
                cmd.Parameters.AddWithValue("@NombreCategoria", objeTo.Nombre);
                cmd.Parameters.Add("@MsjError", SqlDbType.VarChar, 100).Direction=ParameterDirection.Output ;
                
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    await cmd.ExecuteNonQueryAsync();
                    respuesta= Convert.ToString(cmd.Parameters["@MsjError"].Value)!;
                }
                catch (Exception ex)
                {
                    respuesta= ex.Message;
                }


            }

            return respuesta;
            
        }

        public async Task<string> editar(Categorias objeTo)
        {
            string respuesta = "";

            using (var con = _conexion.ObtenerSqLconexion())
            {
                con.Open();
                var cmd = new SqlCommand("SP_Categoria_Editar", con);
                cmd.Parameters.AddWithValue("@IDcategoria", objeTo.ID);
                cmd.Parameters.AddWithValue("@NombreCategoria", objeTo.Nombre);
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
        
    }
}
