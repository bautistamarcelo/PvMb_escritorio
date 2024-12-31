
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace PVrepository.DB
{
    public class Conexion
    {
        private readonly IConfiguration _configuracion;
        private readonly string _cadenaSqL;

        public Conexion(IConfiguration configuracion)
        {
            _configuracion = configuracion;
            _cadenaSqL = _configuracion.GetConnectionString("CadenaSqL")!;
        }

        public SqlConnection ObtenerSqLconexion()
        {
            return new SqlConnection(_cadenaSqL);
        }
    }    

 }