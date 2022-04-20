namespace Gestion.Forms
{
    partial class frmIncidenciasAsignadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIncidenciasAsignadas));
            this.cmbIncidencia = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.Detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstatusCamb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Calificación = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Empleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txtServicio = new System.Windows.Forms.TextBox();
            this.btnServicio = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEquipo = new System.Windows.Forms.TextBox();
            this.datetimeFecha = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbPieza = new System.Windows.Forms.ComboBox();
            this.labelPieza = new System.Windows.Forms.Label();
            this.txtPieza = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencia)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbIncidencia
            // 
            this.cmbIncidencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbIncidencia.FormattingEnabled = true;
            this.cmbIncidencia.Location = new System.Drawing.Point(-1, 127);
            this.cmbIncidencia.Name = "cmbIncidencia";
            this.cmbIncidencia.Size = new System.Drawing.Size(134, 28);
            this.cmbIncidencia.TabIndex = 0;
            this.cmbIncidencia.Text = "-Seleccionar-";
            this.cmbIncidencia.SelectedIndexChanged += new System.EventHandler(this.cmbIncidencia_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-4, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id de Incidencia";
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
            this.Detalle,
            this.EstatusCamb,
            this.Estatus,
            this.Calificación,
            this.ID_Empleado,
            this.ID_Equipo,
            this.IdDescripcion});
            this.dgvIncidencia.Location = new System.Drawing.Point(139, 104);
            this.dgvIncidencia.Name = "dgvIncidencia";
            this.dgvIncidencia.Size = new System.Drawing.Size(608, 154);
            this.dgvIncidencia.TabIndex = 9;
            this.dgvIncidencia.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvIncidencia_CellFormatting);
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
            // Detalle
            // 
            this.Detalle.HeaderText = "Detalles del Cambio";
            this.Detalle.Name = "Detalle";
            // 
            // EstatusCamb
            // 
            this.EstatusCamb.HeaderText = "Estatus del cambio";
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
            this.IdDescripcion.HeaderText = "Id Departamento";
            this.IdDescripcion.Name = "IdDescripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 339);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Detalles de Solución";
            // 
            // txtServicio
            // 
            this.txtServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServicio.Location = new System.Drawing.Point(71, 374);
            this.txtServicio.Multiline = true;
            this.txtServicio.Name = "txtServicio";
            this.txtServicio.Size = new System.Drawing.Size(272, 92);
            this.txtServicio.TabIndex = 11;
            // 
            // btnServicio
            // 
            this.btnServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicio.Location = new System.Drawing.Point(315, 481);
            this.btnServicio.Name = "btnServicio";
            this.btnServicio.Size = new System.Drawing.Size(103, 31);
            this.btnServicio.TabIndex = 12;
            this.btnServicio.Text = "ACEPTAR";
            this.btnServicio.UseVisualStyleBackColor = true;
            this.btnServicio.Click += new System.EventHandler(this.btnServicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 339);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(163, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Detalles del equipo";
            // 
            // txtEquipo
            // 
            this.txtEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEquipo.Location = new System.Drawing.Point(404, 374);
            this.txtEquipo.Multiline = true;
            this.txtEquipo.Name = "txtEquipo";
            this.txtEquipo.Size = new System.Drawing.Size(272, 94);
            this.txtEquipo.TabIndex = 14;
            this.txtEquipo.TextChanged += new System.EventHandler(this.txtEquipo_TextChanged);
            // 
            // datetimeFecha
            // 
            this.datetimeFecha.Enabled = false;
            this.datetimeFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datetimeFecha.Location = new System.Drawing.Point(435, 56);
            this.datetimeFecha.MaxDate = new System.DateTime(2020, 12, 15, 0, 0, 0, 0);
            this.datetimeFecha.MinDate = new System.DateTime(2020, 12, 14, 0, 0, 0, 0);
            this.datetimeFecha.Name = "datetimeFecha";
            this.datetimeFecha.Size = new System.Drawing.Size(282, 26);
            this.datetimeFecha.TabIndex = 16;
            this.datetimeFecha.Value = new System.DateTime(2020, 12, 14, 12, 43, 52, 0);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(39, 18);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(342, 37);
            this.label10.TabIndex = 32;
            this.label10.Text = "Solucionar Incidencia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-4, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 20);
            this.label4.TabIndex = 33;
            this.label4.Text = "Cambio de pieza";
            // 
            // cmbPieza
            // 
            this.cmbPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPieza.FormattingEnabled = true;
            this.cmbPieza.Items.AddRange(new object[] {
            "-Seleccionar-",
            "Si",
            "No"});
            this.cmbPieza.Location = new System.Drawing.Point(-1, 230);
            this.cmbPieza.Name = "cmbPieza";
            this.cmbPieza.Size = new System.Drawing.Size(134, 28);
            this.cmbPieza.TabIndex = 34;
            this.cmbPieza.SelectedIndexChanged += new System.EventHandler(this.cmbPieza_SelectedIndexChanged);
            // 
            // labelPieza
            // 
            this.labelPieza.AutoSize = true;
            this.labelPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPieza.Location = new System.Drawing.Point(-4, 270);
            this.labelPieza.Name = "labelPieza";
            this.labelPieza.Size = new System.Drawing.Size(167, 20);
            this.labelPieza.TabIndex = 35;
            this.labelPieza.Text = "Detalles de la pieza";
            // 
            // txtPieza
            // 
            this.txtPieza.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPieza.Location = new System.Drawing.Point(-1, 293);
            this.txtPieza.Multiline = true;
            this.txtPieza.Name = "txtPieza";
            this.txtPieza.Size = new System.Drawing.Size(474, 25);
            this.txtPieza.TabIndex = 36;
            // 
            // frmIncidenciasAsignadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 524);
            this.Controls.Add(this.txtPieza);
            this.Controls.Add(this.labelPieza);
            this.Controls.Add(this.cmbPieza);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.datetimeFecha);
            this.Controls.Add(this.txtEquipo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnServicio);
            this.Controls.Add(this.txtServicio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvIncidencia);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIncidencia);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmIncidenciasAsignadas";
            this.Text = "Incidencias Asignadas";
            this.Load += new System.EventHandler(this.frmIncidenciasAsignadas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIncidencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbIncidencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvIncidencia;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtServicio;
        private System.Windows.Forms.Button btnServicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEquipo;
        private System.Windows.Forms.DateTimePicker datetimeFecha;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbPieza;
        private System.Windows.Forms.Label labelPieza;
        private System.Windows.Forms.TextBox txtPieza;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdIncidencia;
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