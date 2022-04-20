namespace Gestion.Forms
{
    partial class frmAltaCubiculo
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbEdificio = new System.Windows.Forms.ComboBox();
            this.txtNombreEdi = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Blue;
            this.label10.Location = new System.Drawing.Point(53, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(270, 37);
            this.label10.TabIndex = 33;
            this.label10.Text = "Agrega Cubiculo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(107, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "NOMBRE DEL CUBICULO";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(111, 135);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(336, 29);
            this.txtNombre.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(308, 24);
            this.label2.TabIndex = 37;
            this.label2.Text = "EDIFICIO AL QUE PERTENECE";
            // 
            // CmbEdificio
            // 
            this.CmbEdificio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbEdificio.FormattingEnabled = true;
            this.CmbEdificio.Location = new System.Drawing.Point(111, 213);
            this.CmbEdificio.Name = "CmbEdificio";
            this.CmbEdificio.Size = new System.Drawing.Size(185, 32);
            this.CmbEdificio.TabIndex = 38;
            this.CmbEdificio.Text = "-Seleccionar-";
            this.CmbEdificio.SelectedIndexChanged += new System.EventHandler(this.CmbEdificio_SelectedIndexChanged);
            // 
            // txtNombreEdi
            // 
            this.txtNombreEdi.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreEdi.Location = new System.Drawing.Point(320, 213);
            this.txtNombreEdi.Multiline = true;
            this.txtNombreEdi.Name = "txtNombreEdi";
            this.txtNombreEdi.Size = new System.Drawing.Size(198, 32);
            this.txtNombreEdi.TabIndex = 39;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(300, 333);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(130, 46);
            this.btnGuardar.TabIndex = 40;
            this.btnGuardar.Text = "GUARDAR";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmAltaCubiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(744, 524);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtNombreEdi);
            this.Controls.Add(this.CmbEdificio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Name = "frmAltaCubiculo";
            this.Text = "frmAltaCubiculo";
            this.Load += new System.EventHandler(this.frmAltaCubiculo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbEdificio;
        private System.Windows.Forms.TextBox txtNombreEdi;
        private System.Windows.Forms.Button btnGuardar;
    }
}