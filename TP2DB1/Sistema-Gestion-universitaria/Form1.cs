using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gestion_universitaria
{
    public partial class Form1 : Form
    {
        // Variables para guardar el id del alumno y de la materia seleccionados en las grillas.
        public int idAlumnoSeleccionado = 0;
        public int idMateriaSeleccionada = 0;
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            listarEstudiantes();
            listarMaterias();
            listarAlumnosPorMateria();

            // Fecha del dia en que se abre el programa (formato dia/mes/año). Se calcula en cada ejecucion.
            lblDiaHoy.Text = DateTime.Now.ToString("dd/MM/yyyy");

            // Estado que aparece elegido al abrir el formulario.
            cboEstado.Text = "Regular";
        }

        // MODELO para listarMaterias(): mismo esquema, cambian 3 cosas
        // (nombre del metodo, la consulta SQL y la grilla donde se muestra).
        private void listarEstudiantes()
        {

            SqlConnection conn = null;

            try
            {

                // 1. Abrir la conexion (devuelve un SqlConnection ya abierto).
                conn = Conexion.abrirConn();
                //MessageBox.Show("Conexion a la db exitosa");

                // 2. Preparar la consulta: el texto SQL + la conexion por donde viaja.
                //    OJO: la tabla se llama "alumno" (singular) y * trae todas las columnas.
                SqlCommand cmd = new SqlCommand("SELECT * FROM alumno", conn);

                // 3. Ejecutarla. El reader va leyendo las filas que devuelve la base.
                SqlDataReader reader = cmd.ExecuteReader();

                // 4. Pasar las filas a un DataTable (una tabla en memoria).
                DataTable dt = new DataTable();
                dt.Load(reader);

                // 5. Mostrar el DataTable en la grilla de alumnos.
                dgvAlumnos.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar alumnos: " + ex.Message);
            }
            finally
            {
                // Siempre se ejecuta, haya error o no: cierra la conexion.
                // cerrarConn ya controla si conn es null o esta cerrada.
                Conexion.cerrarConn(conn);
            }
        }
        private void listarMaterias()
        {
            SqlConnection conn = null;
            try
            {
                conn = Conexion.abrirConn();
                SqlCommand cmd = new SqlCommand("SELECT * FROM materia", conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvMaterias.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar materias: " + ex.Message);
            }
            finally
            {
                Conexion.cerrarConn(conn);
            }
        }
        private void listarAlumnosPorMateria()
        {
            SqlConnection conn = null;
            try
            {
                conn = Conexion.abrirConn();

                string query = @"
                    SELECT
                        am.fecha_inscripcion as FECHA,
                        concat(a.apellido,' - ' ,a.nombre) as Alumno,   -- junta apellido y nombre
                        m.nombre_materia,
                        CASE am.id_estado                               -- numero de estado -> texto
                            WHEN 1 THEN 'APR'
                            WHEN 2 THEN 'REG'
                            WHEN 3 THEN 'DES'
                        END as Estado,
                        CASE m.id_carrera                               -- numero de carrera -> sigla
                            WHEN 1 THEN 'PROG'
                            WHEN 2 THEN 'MANTIND'
                            WHEN 3 THEN 'LOGIST'
                            WHEN 4 THEN 'ELECT'
                        END AS Tecnicatura
                    FROM alumno_materia AS am
                    INNER JOIN alumno AS a ON a.id_alumno = am.id_alumno      -- trae el alumno de cada inscripcion
                    INNER JOIN materia AS m ON m.id_materia = am.id_materia   -- trae la materia de cada inscripcion
                    INNER JOIN carrera AS c ON c.id_carrera = m.id_carrera    -- trae la carrera de la materia
                    order by am.fecha_inscripcion desc";                      // las mas nuevas primero
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvAlumnoMateria.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar alumnos por materia: " + ex.Message);
            }
            finally
            {
                Conexion.cerrarConn(conn);
            }
        }

        // Boton "Registrar Alumno": valida, inserta la inscripcion y refresca la grilla.
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            // Si falta elegir alumno o materia (doble click en las grillas), se avisa y se sale.
            // "||" significa "o": basta que uno de los dos este vacio.
            if (txtAlumno.Text == "" || txtMateria.Text == "")
            {
                MessageBox.Show("No pueden estar cajas vacias, doble click en las grillas para traer datos");
                return; // corta el metodo: no se inserta nada
            }

            //Confirmacion antes de registrar
            DialogResult respuesta = MessageBox.Show( "¿Querés registrar a " + txtAlumno.Text + " en " + txtMateria.Text + "?",   // el mensaje
            "Confirmar inscripción",                                                      // el título de la ventana
            MessageBoxButtons.YesNo,                                                      // botones Sí / No
            MessageBoxIcon.Question);                                                     // ícono de pregunta

            if (respuesta == DialogResult.No)
            {
                return;   // salió "No": se corta y no se inserta nada
            }
            registrarAlumnoMateria();   // 1. guarda la inscripcion en la base
            listarAlumnosPorMateria();  // 2. vuelve a leer la grilla para mostrar la fila nueva
        }

        // Inserta una fila en alumno_materia con el alumno y la materia elegidos.
        private void registrarAlumnoMateria()
        {
            // Convierte el texto del combo en el id que guarda la base (tabla estado_academico).
            int estado = 0;
            if (cboEstado.Text == "Aprobado")
            {
                estado = 1;
            }
            else
            {
                if (cboEstado.Text == "Regular")
                {
                    estado = 2;
                }
                else
                {
                    if (cboEstado.Text == "Desaprobado")
                        estado = 3;
                }
            }

            // Fecha de hoy en formato yyyyMMdd (ej: 20261023), que SQL Server interpreta siempre igual.
            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToString("yyyyMMdd");

            SqlConnection conn = null;

            // Los {valores} se reemplazan por las variables. Los ids vienen de las variables
            // globales cargadas con el doble click, no de los textbox. La fecha va entre comillas simples.
            string query = $"INSERT INTO alumno_materia" +
                $" (id_alumno, id_materia, fecha_inscripcion, id_estado) " +
                $"VALUES" +
                $" ({idAlumnoSeleccionado}, {idMateriaSeleccionada},'{fecha}' ,{estado})";

            try
            {
                conn = Conexion.abrirConn();
                SqlCommand cmd = new SqlCommand(query, conn);

                // ExecuteNonQuery se usa cuando la consulta NO devuelve filas (INSERT, UPDATE, DELETE).
                cmd.ExecuteNonQuery();

                MessageBox.Show("Registro generado correctamente.");
            }
            catch (SqlException ex)
            {
                // SqlException es el error que devuelve SQL Server; ex.Number es su codigo.
                // Asi se muestra un mensaje en español en vez del texto tecnico en ingles.
                if (ex.Number == 2627 || ex.Number == 2601)
                {
                    // 2627 / 2601: clave repetida. La clave de alumno_materia es (id_alumno, id_materia).
                    MessageBox.Show("Ese alumno ya está inscripto en esa materia.");
                }
                else if (ex.Number == 547)
                {
                    // 547: el alumno, la materia o el estado no existen en sus tablas (clave foranea).
                    MessageBox.Show("El alumno, la materia o el estado elegido no existe en la base de datos.");
                }
                else
                {
                    // Cualquier otro error de la base: se muestra el numero para poder buscarlo.
                    MessageBox.Show("No se pudo registrar la inscripción (error " + ex.Number + "): " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                // Errores que no son de la base (por ejemplo, no se pudo abrir la conexion).
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
            finally
            {
                Conexion.cerrarConn(conn);
            }
        }

        private void dgvMaterias_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0) // Evita que se haga click en el encabezado de la grilla.
            {
                DataGridViewRow fila = dgvMaterias.Rows[e.RowIndex];
                txtMateria.Text = fila.Cells["id_materia"].Value.ToString() + " - " + fila.Cells["nombre_materia"].Value.ToString();
                idMateriaSeleccionada = Convert.ToInt32(fila.Cells["id_materia"].Value);
            }
        }

        private void dgvAlumnos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvAlumnos.Rows[e.RowIndex];
                txtAlumno.Text = fila.Cells["id_alumno"].Value.ToString() + " - " + fila.Cells["apellido"].Value.ToString() + ", " + fila.Cells["nombre"].Value.ToString();
                idAlumnoSeleccionado = Convert.ToInt32(fila.Cells["id_alumno"].Value);

            }
        }

        private void lblDiaHoy_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void lblAlumnos_Click(object sender, EventArgs e)
        {

        }

        private void dgvMaterias_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblMaterias_Click(object sender, EventArgs e)
        {

        }
    }
}
