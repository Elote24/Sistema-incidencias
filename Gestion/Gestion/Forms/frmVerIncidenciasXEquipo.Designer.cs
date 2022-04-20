namespace Gestion.Forms
{
    partial class frmVerIncidenciasXEquipo
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
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cmbEquipo = new System.Windows.Forms.ComboBox();
            this.dtIncidencia = new System.Windows.Forms.DataGridView();
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
            this.ID_Equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEdificio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCubiculo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDueño = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtIncidencia)).BeginInit();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(34, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(363, 37);
            this.label10.TabIndex = 34;
            this.label10.Text = "Incidencias por Equipo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(66, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 40;
            this.label5.Text = "Id Equipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(239, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Descripcion";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDescripcion.Enabled = false;
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(243, 98);
            this.txtDescripcion.Multiline = true;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(425, 82);
            this.txtDescripcion.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 131);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(70, 154);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(141, 26);
            this.txtNombre.TabIndex = 36;
            // 
            // cmbEquipo
            // 
            this.cmbEquipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbEquipo.FormattingEnabled = true;
            this.cmbEquipo.Location = new System.Drawing.Point(70, 98);
            this.cmbEquipo.Name = "cmbEquipo";
            this.cmbEquipo.Size = new System.Drawing.Size(141, 24);
            this.cmbEquipo.TabIndex = 35;
            this.cmbEquipo.Text = "-Seleccionar-";
            this.cmbEquipo.SelectedIndexChanged += new System.EventHandler(this.cmbEquipo_SelectedIndexChanged);
            // 
            // dtIncidencia
            // 
            this.dtIncidencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtIncidencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.ID_Equipo,
            this.IdDescripcion});
            this.dtIncidencia.Location = new System.Drawing.Point(-11, 272);
            this.dtIncidencia.Name = "dtIncidencia";
            this.dtIncidencia.Size = new System.Drawing.Size(767, 298);
            this.dtIncidencia.TabIndex = 41;
            this.dtIncidencia.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dtIncidencia_CellFormatting);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(338, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Departamento";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDepartamento.Enabled = false;
            this.txtDepartamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDepartamento.Location = new System.Drawing.Point(342, 221);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(121, 26);
            this.txtDepartamento.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(481, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 45;
            this.label3.Text = "Edificio";
            // 
            // txtEdificio
            // 
            this.txtEdificio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtEdificio.Enabled = false;
            this.txtEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdificio.Location = new System.Drawing.Point(485, 221);
            this.txtEdificio.Name = "txtEdificio";
            this.txtEdificio.Size = new System.Drawing.Size(121, 26);
            this.txtEdificio.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(615, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "Cubiculo";
            // 
            // txtCubiculo
            // 
            this.txtCubiculo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCubiculo.Enabled = false;
            this.txtCubiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCubiculo.Location = new System.Drawing.Point(619, 221);
            this.txtCubiculo.Name = "txtCubiculo";
            this.txtCubiculo.Size = new System.Drawing.Size(121, 26);
            this.txtCubiculo.TabIndex = 46;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(66, 198);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 20);
            this.label7.TabIndex = 49;
            this.label7.Text = "Dueño actual";
            // 
            // txtDueño
            // 
            this.txtDueño.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDueño.Enabled = false;
            this.txtDueño.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDueño.Location = new System.Drawing.Point(70, 221);
            this.txtDueño.Name = "txtDueño";
            this.txtDueño.Size = new System.Drawing.Size(260, 26);
            this.txtDueño.TabIndex = 48;
            // 
            // frmVerIncidenciasXEquipo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 524);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtDueño);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCubiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtEdificio);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDepartamento);
            this.Controls.Add(this.dtIncidencia);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbEquipo);
            this.Controls.Add(this.label10);
            this.Name = "frmVerIncidenciasXEquipo";
            this.Text = "INCIDENCIAS POR EQUIPO";
            this.Load += new System.EventHandler(this.frmVerIncidenciasXEquipo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtIncidencia)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cmbEquipo;
        private System.Windows.Forms.DataGridView dtIncidencia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEdificio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCubiculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDueño;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdDescripcion;
    }
}