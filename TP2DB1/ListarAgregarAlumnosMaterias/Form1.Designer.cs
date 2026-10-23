namespace ListarAgregarAlumnosMaterias
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.dgvAlumnoMateria = new System.Windows.Forms.DataGridView();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblMateriaAlumnos = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAlumnos.Location = new System.Drawing.Point(12, 46);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnos.Size = new System.Drawing.Size(730, 120);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlumnos_CellMouseDoubleClick);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.Location = new System.Drawing.Point(12, 193);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMaterias.Size = new System.Drawing.Size(730, 120);
            this.dgvMaterias.TabIndex = 1;
            this.dgvMaterias.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaterias_CellMouseDoubleClick);
            // 
            // dgvAlumnoMateria
            // 
            this.dgvAlumnoMateria.AllowUserToAddRows = false;
            this.dgvAlumnoMateria.Location = new System.Drawing.Point(12, 339);
            this.dgvAlumnoMateria.Name = "dgvAlumnoMateria";
            this.dgvAlumnoMateria.ReadOnly = true;
            this.dgvAlumnoMateria.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAlumnoMateria.Size = new System.Drawing.Size(730, 120);
            this.dgvAlumnoMateria.TabIndex = 6;
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(781, 81);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(45, 13);
            this.lblAlumno.TabIndex = 2;
            this.lblAlumno.Text = "Alumno:";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(781, 199);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(45, 13);
            this.lblMateria.TabIndex = 3;
            this.lblMateria.Text = "Materia:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(781, 323);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado:";
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(784, 97);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.ReadOnly = true;
            this.txtAlumno.Size = new System.Drawing.Size(220, 20);
            this.txtAlumno.TabIndex = 2;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(784, 215);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.ReadOnly = true;
            this.txtMateria.Size = new System.Drawing.Size(220, 20);
            this.txtMateria.TabIndex = 3;
            // 
            // cmbEstado
            // 
            this.cmbEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstado.Location = new System.Drawing.Point(784, 339);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(115, 21);
            this.cmbEstado.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(784, 413);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(115, 21);
            this.btnRegistrar.TabIndex = 5;
            this.btnRegistrar.Text = "Registrar Alumno";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblAlumnos.Location = new System.Drawing.Point(29, 23);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(78, 20);
            this.lblAlumnos.TabIndex = 7;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblMaterias.Location = new System.Drawing.Point(29, 170);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(78, 20);
            this.lblMaterias.TabIndex = 8;
            this.lblMaterias.Text = "Materias";
            // 
            // lblMateriaAlumnos
            // 
            this.lblMateriaAlumnos.AutoSize = true;
            this.lblMateriaAlumnos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.lblMateriaAlumnos.Location = new System.Drawing.Point(29, 316);
            this.lblMateriaAlumnos.Name = "lblMateriaAlumnos";
            this.lblMateriaAlumnos.Size = new System.Drawing.Size(256, 20);
            this.lblMateriaAlumnos.TabIndex = 9;
            this.lblMateriaAlumnos.Text = "Alumnos Anotados por Materia";
            this.lblMateriaAlumnos.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 472);
            this.Controls.Add(this.lblMateriaAlumnos);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.dgvAlumnos);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.dgvAlumnoMateria);
            this.Name = "Form1";
            this.Text = "Alumnos y Materias";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAlumnos;
        private System.Windows.Forms.DataGridView dgvMaterias;
        private System.Windows.Forms.DataGridView dgvAlumnoMateria;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblMateriaAlumnos;
    }
}
