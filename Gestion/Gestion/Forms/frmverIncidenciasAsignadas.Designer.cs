namespace Gestion.Forms
{
    partial class frmverIncidenciasAsignadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmverIncidenciasAsignadas));
            this.dgvIncidencia = new System.Windows.Forms.DataGridView();
            this.IdIncidencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prioridad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_De_Levantamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_De_Inicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha_De_Finalización = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalles = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstatusCam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreDepa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edificio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cubiculo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencia)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvIncidencia
            // 
            this.dgvIncidencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIncidencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdIncidencia,
            this.Descripcion,
            this.Tipo,
            this.Prioridad,
            this.Fecha_De_Levantamiento,
            this.Fecha_De_Inicio,
            this.Fecha_De_Finalización,
            this.Servicio,
            this.Cambio,
            this.Detalles,
            this.EstatusCam,
            this.Estatus,
            this.Calificación,
            this.ID_Empleado,
            this.NombreEmpleado,
            this.ID_Equipo,
            this.IdDescripcion,
            this.NombreDepa,
            this.Edificio,
            this.Cubiculo});
            this.dgvIncidencia.Location = new System.Drawing.Point(2, 1);
            this.dgvIncidencia.Name = "dgvIncidencia";
            this.dgvIncidencia.Size = new System.Drawing.Size(773, 567);
            this.dgvIncidencia.TabIndex = 9;
            this.dgvIncidencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dgvIncidencia.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvIncidencia_CellFormatting);
            this.dgvIncidencia.RowValidated += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvIncidencia_RowValidated);
            // 
            // IdIncidencia
            // 
            this.IdIncidencia.HeaderText = "Id";
            this.IdIncidencia.Name = "IdIncidencia";
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
            // Detalles
            // 
            this.Detalles.HeaderText = "Detalles del cambio";
            this.Detalles.Name = "Detalles";
            // 
            // EstatusCam
            // 
            this.EstatusCam.HeaderText = "Estatus del cambio";
            this.EstatusCam.Name = "EstatusCam";
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
            // NombreEmpleado
            // 
            this.NombreEmpleado.HeaderText = "NombreEmpleado";
            this.NombreEmpleado.Name = "NombreEmpleado";
            // 
            // ID_Equipo
            // 
            this.ID_Equipo.HeaderText = "ID Equipo";
            this.ID_Equipo.Name = "ID_Equipo";
            // 
            // IdDescripcion
            // 
            this.IdDescripcion.HeaderText = "Id Departamento";
            this.IdDescripcion.Name = "IdDescripcion";
            // 
            // NombreDepa
            // 
            this.NombreDepa.HeaderText = "NombreDepartamento";
            this.NombreDepa.Name = "NombreDepa";
            // 
            // Edificio
            // 
            this.Edificio.HeaderText = "Edificio";
            this.Edificio.Name = "Edificio";
            // 
            // Cubiculo
            // 
            this.Cubiculo.HeaderText = "Cubiculo";
            this.Cubiculo.Name = "Cubiculo";
            // 
            // frmverIncidenciasAsignadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 524);
            this.Controls.Add(this.dgvIncidencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmverIncidenciasAsignadas";
            this.Text = "Incidencias Asignadas";
            this.Load += new System.EventHandler(this.frmverIncidenciasAsignadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvIncidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIncidencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prioridad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_De_Levantamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_De_Inicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha_De_Finalización;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Detalles;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstatusCam;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Calificación;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Empleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDepa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edificio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cubiculo;
    }
}