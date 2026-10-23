using System.Configuration; // ConfigurationManager: lee el App.config (requiere la referencia a System.Configuration)
using System.Data;          // ConnectionState: para saber si la conexion esta abierta o cerrada
using System.Data.SqlClient; // SqlConnection: la conexion con SQL Server

namespace Sistema_Gestion_universitaria
{
    // "static": no se crea con new, se usa directo: Conexion.abrirConn()
    // "public": para que Form1 (y cualquier otra clase) pueda usarla
    public static class Conexion
    {
        // Abre una conexion nueva a la base y la devuelve lista para usar.
        // Quien la pide es responsable de cerrarla con cerrarConn().
        public static SqlConnection abrirConn()
        {
            // 1. Leer el connection string del App.config.
            //    El nombre entre comillas debe ser IGUAL al "name" de <add name="..."> en App.config.
            string cadena = ConfigurationManager.ConnectionStrings["GestionUniversitaria"].ConnectionString;

            // 2. Crear la conexion con ese texto (todavia NO esta abierta).
            SqlConnection conn = new SqlConnection(cadena);

            // 3. Abrirla. Si el servidor no responde, aca salta la excepcion;
            //    la atrapa el try/catch de quien llamo a abrirConn().
            conn.Open();

            // 4. Devolverla para que el llamador ejecute sus consultas.
            return conn;
        }

        // Cierra la conexion que recibe. Se llama en el "finally" de cada metodo.
        public static void cerrarConn(SqlConnection conn)
        {
            // Dos controles antes de cerrar:
            //  - conn != null: si abrirConn() fallo, conn quedo en null y cerrarlo daria error.
            //  - conn.State == Open: no se puede cerrar lo que ya esta cerrado.
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
