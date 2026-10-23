using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ListarAgregarAlumnosMaterias
{
    public partial class Form1 : Form
    {
        private const int ErrorClaveDuplicada = 2627;

        private const string SqlAlumnos =
            "SELECT id_alumno, nombre, apellido, dni, legajo, email, edad FROM alumno";

        private const string SqlMaterias =
            "SELECT id_materia, nombre_materia, creditos, id_carrera, id_profesor FROM materia";

        private const string SqlEstados =
            "SELECT id_estado, descripcion FROM estado_academico ORDER BY id_estado";

        private const string SqlAlumnoMateria =
            @"SELECT am.id_alumno, a.nombre + ' ' + a.apellido AS alumno,
                     am.id_materia, m.nombre_materia AS materia,
                     am.fecha_inscripcion, e.descripcion AS estado
              FROM alumno_materia am
              JOIN alumno a ON a.id_alumno = am.id_alumno
              JOIN materia m ON m.id_materia = am.id_materia
              JOIN estado_academico e ON e.id_estado = am.id_estado";

        private const string SqlInsertar =
            @"INSERT INTO alumno_materia (id_alumno, id_materia, fecha_inscripcion, id_estado)
              VALUES (@alumno, @materia, @fecha, @estado)";

        // ids elegidos con doble click en las grillas (0 = ninguno)
        private int idAlumno;
        private int idMateria;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarGrillas();

            try
            {
                dgvAlumnos.DataSource = Conexion.Listar(SqlAlumnos);
                dgvMaterias.DataSource = Conexion.Listar(SqlMaterias);
                CargarEstados();
                CargarAlumnoMateria();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar/listar: " + ex.Message);
            }
        }

        private void ConfigurarGrillas()
        {
            foreach (var dgv in new[] { dgvAlumnos, dgvMaterias, dgvAlumnoMateria })
            {
                dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                dgv.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }
        }

        private void CargarEstados()
        {
            cmbEstado.DisplayMember = "descripcion";
            cmbEstado.ValueMember = "id_estado";
            cmbEstado.DataSource = Conexion.Listar(SqlEstados);
            cmbEstado.SelectedIndex = -1;
        }

        private void CargarAlumnoMateria()
        {
            dgvAlumnoMateria.DataSource = Conexion.Listar(SqlAlumnoMateria);
        }

        private void dgvAlumnos_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvAlumnos.Rows[e.RowIndex];
            idAlumno = Convert.ToInt32(fila.Cells["id_alumno"].Value);
            txtAlumno.Text = $"{fila.Cells["nombre"].Value} {fila.Cells["apellido"].Value}";
        }

        private void dgvMaterias_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var fila = dgvMaterias.Rows[e.RowIndex];
            idMateria = Convert.ToInt32(fila.Cells["id_materia"].Value);
            txtMateria.Text = Convert.ToString(fila.Cells["nombre_materia"].Value);
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (idAlumno == 0 || idMateria == 0)
            {
                MessageBox.Show("Seleccione un alumno y una materia (doble click en las grillas).");
                return;
            }

            if (cmbEstado.SelectedValue == null)
            {
                MessageBox.Show("Seleccione un estado académico.");
                return;
            }

            registrarAlumnoMateria();
        }

        private void registrarAlumnoMateria()
        {
            try
            {
                Conexion.Ejecutar(SqlInsertar,
                    new SqlParameter("@alumno", SqlDbType.Int) { Value = idAlumno },
                    new SqlParameter("@materia", SqlDbType.Int) { Value = idMateria },
                    new SqlParameter("@fecha", SqlDbType.Date) { Value = DateTime.Today },
                    new SqlParameter("@estado", SqlDbType.Int) { Value = cmbEstado.SelectedValue });
            }
            catch (SqlException ex) when (ex.Number == ErrorClaveDuplicada)
            {
                MessageBox.Show("Ese alumno ya está inscripto en esa materia.");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
                return;
            }

            try
            {
                CargarAlumnoMateria();
                MessageBox.Show("Alumno registrado en la materia.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Alumno registrado, pero no se pudo actualizar la lista de inscripciones: " + ex.Message);
            }
        }

        // Lo referencia Form1.Designer.cs (lblMateriaAlumnos.Click); no borrar
        private void label1_Click_1(object sender, EventArgs e)
        {
        }
    }
}
