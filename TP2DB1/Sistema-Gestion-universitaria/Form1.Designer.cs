namespace Sistema_Gestion_universitaria
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvAlumnos = new System.Windows.Forms.DataGridView();
            this.dgvMaterias = new System.Windows.Forms.DataGridView();
            this.dgvAlumnoMateria = new System.Windows.Forms.DataGridView();
            this.txtAlumno = new System.Windows.Forms.TextBox();
            this.txtMateria = new System.Windows.Forms.TextBox();
            this.cboEstado = new System.Windows.Forms.ComboBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.lblAlumnoMateria = new System.Windows.Forms.Label();
            this.lblAlumnos = new System.Windows.Forms.Label();
            this.lblMaterias = new System.Windows.Forms.Label();
            this.lblDiaHoy = new System.Windows.Forms.Label();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMaterias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumnoMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAlumnos
            // 
            this.dgvAlumnos.AllowUserToAddRows = false;
            this.dgvAlumnos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnos.Location = new System.Drawing.Point(45, 27);
            this.dgvAlumnos.Name = "dgvAlumnos";
            this.dgvAlumnos.ReadOnly = true;
            this.dgvAlumnos.Size = new System.Drawing.Size(607, 150);
            this.dgvAlumnos.TabIndex = 0;
            this.dgvAlumnos.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvAlumnos_CellMouseDoubleClick);
            // 
            // dgvMaterias
            // 
            this.dgvMaterias.AllowUserToAddRows = false;
            this.dgvMaterias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMaterias.Location = new System.Drawing.Point(707, 27);
            this.dgvMaterias.Name = "dgvMaterias";
            this.dgvMaterias.ReadOnly = true;
            this.dgvMaterias.Size = new System.Drawing.Size(391, 150);
            this.dgvMaterias.TabIndex = 1;
            this.dgvMaterias.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvMaterias_CellMouseDoubleClick);
            // 
            // dgvAlumnoMateria
            // 
            this.dgvAlumnoMateria.AllowUserToAddRows = false;
            this.dgvAlumnoMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumnoMateria.Location = new System.Drawing.Point(35, 266);
            this.dgvAlumnoMateria.Name = "dgvAlumnoMateria";
            this.dgvAlumnoMateria.ReadOnly = true;
            this.dgvAlumnoMateria.Size = new System.Drawing.Size(505, 150);
            this.dgvAlumnoMateria.TabIndex = 2;
            // 
            // txtAlumno
            // 
            this.txtAlumno.Location = new System.Drawing.Point(87, 219);
            this.txtAlumno.Name = "txtAlumno";
            this.txtAlumno.Size = new System.Drawing.Size(100, 20);
            this.txtAlumno.TabIndex = 4;
            // 
            // txtMateria
            // 
            this.txtMateria.Location = new System.Drawing.Point(297, 221);
            this.txtMateria.Name = "txtMateria";
            this.txtMateria.Size = new System.Drawing.Size(100, 20);
            this.txtMateria.TabIndex = 5;
            // 
            // cboEstado
            // 
            this.cboEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEstado.FormattingEnabled = true;
            this.cboEstado.Items.AddRange(new object[] {
            "Aprobado",
            "Regular",
            "Desaprobado"});
            this.cboEstado.Location = new System.Drawing.Point(531, 221);
            this.cboEstado.Name = "cboEstado";
            this.cboEstado.Size = new System.Drawing.Size(121, 21);
            this.cboEstado.TabIndex = 6;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(687, 221);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(108, 23);
            this.btnRegistrar.TabIndex = 7;
            this.btnRegistrar.Text = "Registrar Alumno";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // lblAlumnoMateria
            // 
            this.lblAlumnoMateria.AutoSize = true;
            this.lblAlumnoMateria.Location = new System.Drawing.Point(84, 250);
            this.lblAlumnoMateria.Name = "lblAlumnoMateria";
            this.lblAlumnoMateria.Size = new System.Drawing.Size(151, 13);
            this.lblAlumnoMateria.TabIndex = 8;
            this.lblAlumnoMateria.Text = "Alumnos Anotados por Materia";
            // 
            // lblAlumnos
            // 
            this.lblAlumnos.AutoSize = true;
            this.lblAlumnos.Location = new System.Drawing.Point(64, 9);
            this.lblAlumnos.Name = "lblAlumnos";
            this.lblAlumnos.Size = new System.Drawing.Size(47, 13);
            this.lblAlumnos.TabIndex = 9;
            this.lblAlumnos.Text = "Alumnos";
            // 
            // lblMaterias
            // 
            this.lblMaterias.AutoSize = true;
            this.lblMaterias.Location = new System.Drawing.Point(957, 11);
            this.lblMaterias.Name = "lblMaterias";
            this.lblMaterias.Size = new System.Drawing.Size(47, 13);
            this.lblMaterias.TabIndex = 10;
            this.lblMaterias.Text = "Materias";
            // 
            // lblDiaHoy
            // 
            this.lblDiaHoy.AutoSize = true;
            this.lblDiaHoy.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaHoy.Location = new System.Drawing.Point(844, 219);
            this.lblDiaHoy.Name = "lblDiaHoy";
            this.lblDiaHoy.Size = new System.Drawing.Size(91, 16);
            this.lblDiaHoy.TabIndex = 11;
            this.lblDiaHoy.Text = "dd/MM/yyyy";
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Location = new System.Drawing.Point(84, 203);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(45, 13);
            this.lblAlumno.TabIndex = 11;
            this.lblAlumno.Text = "Alumno:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Materia:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(528, 205);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(43, 13);
            this.lblEstado.TabIndex = 13;
            this.lblEstado.Text = "Estado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 450);
            this.Controls.Add(this.lblDiaHoy);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblAlumno);
            this.Controls.Add(this.lblMaterias);
            this.Controls.Add(this.lblAlumnos);
            this.Controls.Add(this.lblAlumnoMateria);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.cboEstado);
            this.Controls.Add(this.txtMateria);
            this.Controls.Add(this.txtAlumno);
            this.Controls.Add(this.dgvAlumnoMateria);
            this.Controls.Add(this.dgvMaterias);
            this.Controls.Add(this.dgvAlumnos);
            this.Name = "Form1";
            this.Text = "Sistema de Gestión Universitaria";
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
        private System.Windows.Forms.TextBox txtAlumno;
        private System.Windows.Forms.TextBox txtMateria;
        private System.Windows.Forms.ComboBox cboEstado;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label lblAlumnoMateria;
        private System.Windows.Forms.Label lblAlumnos;
        private System.Windows.Forms.Label lblMaterias;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblDiaHoy;
    }
}

