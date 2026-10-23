using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ListarAgregarAlumnosMaterias
{
    public static class Conexion
    {
        private static readonly string cadena =
            ConfigurationManager.ConnectionStrings["GestionUniversitaria"].ConnectionString;

        public static SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadena);
        }

        // SELECT -> DataTable (la conexion se abre y cierra sola)
        public static DataTable Listar(string query)
        {
            var tabla = new DataTable();
            using (var da = new SqlDataAdapter(query, cadena))
            {
                da.Fill(tabla);
            }
            return tabla;
        }

        // INSERT / UPDATE / DELETE con parametros
        public static int Ejecutar(string sql, params SqlParameter[] parametros)
        {
            using (var cn = ObtenerConexion())
            using (var cmd = new SqlCommand(sql, cn))
            {
                cmd.Parameters.AddRange(parametros);
                cn.Open();
                return cmd.ExecuteNonQuery();
            }
        }
    }
}
