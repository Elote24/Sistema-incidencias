namespace Gestion.Forms
{
    partial class frmAsignaIncidencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAsignaIncidencias));
            this.label1 = new System.Windows.Forms.Label();
            this.Tecnico = new System.Windows.Forms.Label();
            this.dgvTecnico = new System.Windows.Forms.DataGridView();
            this.Id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especializacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Certificaciones = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Numeros = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbPrioridad = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cmbIncidencia = new System.Windows.Forms.ComboBox();
            this.cmbTecnico = new System.Windows.Forms.ComboBox();
            this.cbTIPO = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_De_Levantamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_De_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_De_Finalización = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstatusCamb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Incidencias";
            // 
            // Tecnico
            // 
            this.Tecnico.AutoSize = true;
            this.Tecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tecnico.Location = new System.Drawing.Point(48, 321);
            this.Tecnico.Name = "Tecnico";
            this.Tecnico.Size = new System.Drawing.Size(71, 20);
            this.Tecnico.TabIndex = 3;
            this.Tecnico.Text = "Tecnico";
            // 
            // dgvTecnico
            // 
            this.dgvTecnico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTecnico.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id1,
            this.Nombre1,
            this.Especializacion,
            this.Certificaciones,
            this.Numeros});
            this.dgvTecnico.Location = new System.Drawing.Point(181, 252);
            this.dgvTecnico.Name = "dgvTecnico";
            this.dgvTecnico.Size = new System.Drawing.Size(565, 139);
            this.dgvTecnico.TabIndex = 5;
            // 
            // Id1
            // 
            this.Id1.HeaderText = "ID";
            this.Id1.Name = "Id1";
            // 
            // Nombre1
            // 
            this.Nombre1.HeaderText = "Nombre";
            this.Nombre1.Name = "Nombre1";
            // 
            // Especializacion
            // 
            this.Especializacion.HeaderText = "Especializacion";
            this.Especializacion.Name = "Especializacion";
            // 
            // Certificaciones
            // 
            this.Certificaciones.HeaderText = "Certificaciones";
            this.Certificaciones.Name = "Certificaciones";
            // 
            // Numeros
            // 
            this.Numeros.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Numeros.HeaderText = "Numero de Incidencias asignadas";
            this.Numeros.Name = "Numeros";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(315, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 39);
            this.button1.TabIndex = 6;
            this.button1.Text = "ASIGNAR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Prioridad";
            // 
            // cmbPrioridad
            // 
            this.cmbPrioridad.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "3",
            "4"});
            this.cmbPrioridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPrioridad.FormattingEnabled = true;
            this.cmbPrioridad.Items.AddRange(new object[] {
            "-Seleccione-",
            "ALTA",
            "MEDIA",
            "BAJA"});
            this.cmbPrioridad.Location = new System.Drawing.Point(40, 278);
            this.cmbPrioridad.Name = "cmbPrioridad";
            this.cmbPrioridad.Size = new System.Drawing.Size(133, 28);
            this.cmbPrioridad.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Descripcion,
            this.Tipo,
            this.Prioridad,
            this.Fecha_De_Levantamiento,
            this.Fecha_De_Inicio,
            this.Fecha_De_Finalización,
            this.Servicio,
            this.Cambio,
            this.Detalle,
            this.EstatusCamb,
            this.Estatus,
            this.Calificación,
            this.ID_Empleado,
            this.ID_Equipo,
            this.IdDescripcion});
            this.dataGridView1.Location = new System.Drawing.Point(181, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(565, 152);
            this.dataGridView1.TabIndex = 11;
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "3",
            "4"});
            this.cmbIncidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIncidencia.FormattingEnabled = true;
            this.cmbIncidencia.Location = new System.Drawing.Point(42, 136);
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(133, 28);
            this.cmbIncidencia.TabIndex = 12;
            this.cmbIncidencia.Text = "-Seleccionar-";
            this.cmbIncidencia.SelectedIndexChanged += new System.EventHandler(this.cmbIncidencia_SelectedIndexChanged);
            // 
            // cmbTecnico
            // 
            this.cmbTecnico.AutoCompleteCustomSource.AddRange(new string[] {
            "1",
            "3",
            "4"});
            this.cmbTecnico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTecnico.FormattingEnabled = true;
            this.cmbTecnico.Location = new System.Drawing.Point(42, 344);
            this.cmbTecnico.Name = "cmbTecnico";
            this.cmbTecnico.Size = new System.Drawing.Size(133, 28);
            this.cmbTecnico.TabIndex = 13;
            this.cmbTecnico.Text = "-Seleccionar-";
            // 
            // cbTIPO
            // 
            this.cbTIPO.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTIPO.FormattingEnabled = true;
            this.cbTIPO.Items.AddRange(new object[] {
            "-Seleccionar-",
            "HARDWARE",
            "SOFTWARE"});
            this.cbTIPO.Location = new System.Drawing.Point(40, 190);
            this.cbTIPO.Name = "cbTIPO";
            this.cbTIPO.Size = new System.Drawing.Size(135, 28);
            this.cbTIPO.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Tipo";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Enabled = false;
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(454, 32);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(292, 26);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(33, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(302, 37);
            this.label10.TabIndex = 33;
            this.label10.Text = "Asigna Incidencias";
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // Descripcion
            // 
            this.Descripcion.HeaderText = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // Prioridad
            // 
            this.Prioridad.HeaderText = "Prioridad";
            this.Prioridad.Name = "Prioridad";
            // 
            // Fecha_De_Levantamiento
            // 
            this.Fecha_De_Levantamiento.HeaderText = "Fecha De Levantamiento";
            this.Fecha_De_Levantamiento.Name = "Fecha_De_Levantamiento";
            // 
            // Fecha_De_Inicio
            // 
            this.Fecha_De_Inicio.HeaderText = "Fecha De Inicio";
            this.Fecha_De_Inicio.Name = "Fecha_De_Inicio";
            // 
            // Fecha_De_Finalización
            // 
            this.Fecha_De_Finalización.HeaderText = "Fecha De Finalización";
            this.Fecha_De_Finalización.Name = "Fecha_De_Finalización";
            // 
            // Servicio
            // 
            this.Servicio.HeaderText = "Servicio";
            this.Servicio.Name = "Servicio";
            // 
            // Cambio
            // 
            this.Cambio.HeaderText = "Cambio";
            this.Cambio.Name = "Cambio";
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalles del cambio";
            this.Detalle.Name = "Detalle";
            // 
            // EstatusCamb
            // 
            this.EstatusCamb.HeaderText = "Estatus del Cambio";
            this.EstatusCamb.Name = "EstatusCamb";
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus";
            this.Estatus.Name = "Estatus";
            // 
            // Calificación
            // 
            this.Calificación.HeaderText = "Calificacion";
            this.Calificación.Name = "Calificación";
            // 
            // ID_Empleado
            // 
            this.ID_Empleado.HeaderText = "ID Empleado";
            this.ID_Empleado.Name = "ID_Empleado";
            // 
            // ID_Equipo
            // 
            this.ID_Equipo.HeaderText = "ID Equipo";
            this.ID_Equipo.Name = "ID_Equipo";
            // 
            // IdDescripcion
            // 
            this.IdDescripcion.HeaderText = "Id Descipcion";
            this.IdDescripcion.Name = "IdDescripcion";
            // 
            // frmAsignaIncidencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 456);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbTIPO);
            this.Controls.Add(this.cmbTecnico);
            this.Controls.Add(this.cmbIncidencia);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbPrioridad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvTecnico);
            this.Controls.Add(this.Tecnico);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmAsignaIncidencias";
            this.Text = "Asigna Incidenicas";
            this.Load += new System.EventHandler(this.frmAsignaIncidencias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTecnico)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Tecnico;
        private System.Windows.Forms.DataGridView dgvTecnico;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbPrioridad;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cmbIncidencia;
        private System.Windows.Forms.ComboBox cmbTecnico;
        private System.Windows.Forms.ComboBox cbTIPO;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especializacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Certificaciones;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numeros;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_De_Levantamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_De_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_De_Finalización;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstatusCamb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDescripcion;
    }
}