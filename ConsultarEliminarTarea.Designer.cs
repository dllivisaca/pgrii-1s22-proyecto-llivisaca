namespace ProyectoFinal
{
    partial class ConsultarEliminarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarEliminarTarea));
            this.btn_eliminarestado = new System.Windows.Forms.Button();
            this.btn_eliminarfecha = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.Button();
            this.lbl_tareas = new System.Windows.Forms.Label();
            this.dgv_tareas = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDescripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechacreacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFechalimite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_comprobar_fecha = new System.Windows.Forms.Button();
            this.btn_comprobar_estado = new System.Windows.Forms.Button();
            this.btn_buscarfecha = new System.Windows.Forms.Button();
            this.btn_buscarestado = new System.Windows.Forms.Button();
            this.dtp_fechacreacion = new System.Windows.Forms.DateTimePicker();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_fechacreacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tareas)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_eliminarestado
            // 
            this.btn_eliminarestado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_eliminarestado.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarestado.Location = new System.Drawing.Point(759, 149);
            this.btn_eliminarestado.Name = "btn_eliminarestado";
            this.btn_eliminarestado.Size = new System.Drawing.Size(256, 53);
            this.btn_eliminarestado.TabIndex = 58;
            this.btn_eliminarestado.Text = "Eliminar tarea(s)";
            this.btn_eliminarestado.UseVisualStyleBackColor = false;
            this.btn_eliminarestado.Click += new System.EventHandler(this.btn_eliminarestado_Click);
            // 
            // btn_eliminarfecha
            // 
            this.btn_eliminarfecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_eliminarfecha.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_eliminarfecha.Location = new System.Drawing.Point(759, 103);
            this.btn_eliminarfecha.Name = "btn_eliminarfecha";
            this.btn_eliminarfecha.Size = new System.Drawing.Size(256, 53);
            this.btn_eliminarfecha.TabIndex = 57;
            this.btn_eliminarfecha.Text = "Eliminar tarea(s)";
            this.btn_eliminarfecha.UseVisualStyleBackColor = false;
            this.btn_eliminarfecha.Click += new System.EventHandler(this.btn_eliminarfecha_Click);
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_volver.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(1131, 583);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(122, 53);
            this.btn_volver.TabIndex = 56;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // lbl_tareas
            // 
            this.lbl_tareas.AutoSize = true;
            this.lbl_tareas.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tareas.Location = new System.Drawing.Point(408, 293);
            this.lbl_tareas.Name = "lbl_tareas";
            this.lbl_tareas.Size = new System.Drawing.Size(90, 19);
            this.lbl_tareas.TabIndex = 55;
            this.lbl_tareas.Text = "TAREA(S): ";
            // 
            // dgv_tareas
            // 
            this.dgv_tareas.AllowUserToAddRows = false;
            this.dgv_tareas.ColumnHeadersHeight = 30;
            this.dgv_tareas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNombre,
            this.ColumnDescripcion,
            this.ColumnFechacreacion,
            this.ColumnFechalimite,
            this.ColumnEstado});
            this.dgv_tareas.Enabled = false;
            this.dgv_tareas.GridColor = System.Drawing.Color.PaleTurquoise;
            this.dgv_tareas.Location = new System.Drawing.Point(-41, 331);
            this.dgv_tareas.Name = "dgv_tareas";
            this.dgv_tareas.ReadOnly = true;
            this.dgv_tareas.RowHeadersWidth = 62;
            this.dgv_tareas.RowTemplate.Height = 28;
            this.dgv_tareas.Size = new System.Drawing.Size(1386, 225);
            this.dgv_tareas.TabIndex = 54;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.MinimumWidth = 8;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Width = 150;
            // 
            // ColumnNombre
            // 
            this.ColumnNombre.HeaderText = "Nombre";
            this.ColumnNombre.MinimumWidth = 8;
            this.ColumnNombre.Name = "ColumnNombre";
            this.ColumnNombre.ReadOnly = true;
            this.ColumnNombre.Width = 150;
            // 
            // ColumnDescripcion
            // 
            this.ColumnDescripcion.HeaderText = "Descripcion";
            this.ColumnDescripcion.MinimumWidth = 8;
            this.ColumnDescripcion.Name = "ColumnDescripcion";
            this.ColumnDescripcion.ReadOnly = true;
            this.ColumnDescripcion.Width = 150;
            // 
            // ColumnFechacreacion
            // 
            this.ColumnFechacreacion.HeaderText = "Fecha creacion";
            this.ColumnFechacreacion.MinimumWidth = 8;
            this.ColumnFechacreacion.Name = "ColumnFechacreacion";
            this.ColumnFechacreacion.ReadOnly = true;
            this.ColumnFechacreacion.Width = 150;
            // 
            // ColumnFechalimite
            // 
            this.ColumnFechalimite.HeaderText = "Fecha limite";
            this.ColumnFechalimite.MinimumWidth = 8;
            this.ColumnFechalimite.Name = "ColumnFechalimite";
            this.ColumnFechalimite.ReadOnly = true;
            this.ColumnFechalimite.Width = 150;
            // 
            // ColumnEstado
            // 
            this.ColumnEstado.HeaderText = "Estado";
            this.ColumnEstado.MinimumWidth = 8;
            this.ColumnEstado.Name = "ColumnEstado";
            this.ColumnEstado.ReadOnly = true;
            this.ColumnEstado.Width = 150;
            // 
            // btn_comprobar_fecha
            // 
            this.btn_comprobar_fecha.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_comprobar_fecha.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprobar_fecha.Location = new System.Drawing.Point(532, 103);
            this.btn_comprobar_fecha.Name = "btn_comprobar_fecha";
            this.btn_comprobar_fecha.Size = new System.Drawing.Size(122, 53);
            this.btn_comprobar_fecha.TabIndex = 53;
            this.btn_comprobar_fecha.Text = "Comprobar";
            this.btn_comprobar_fecha.UseVisualStyleBackColor = false;
            this.btn_comprobar_fecha.Click += new System.EventHandler(this.btn_comprobar_fecha_Click);
            // 
            // btn_comprobar_estado
            // 
            this.btn_comprobar_estado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_comprobar_estado.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprobar_estado.Location = new System.Drawing.Point(532, 144);
            this.btn_comprobar_estado.Name = "btn_comprobar_estado";
            this.btn_comprobar_estado.Size = new System.Drawing.Size(122, 53);
            this.btn_comprobar_estado.TabIndex = 52;
            this.btn_comprobar_estado.Text = "Comprobar";
            this.btn_comprobar_estado.UseVisualStyleBackColor = false;
            this.btn_comprobar_estado.Click += new System.EventHandler(this.btn_comprobar_estado_Click);
            // 
            // btn_buscarfecha
            // 
            this.btn_buscarfecha.BackColor = System.Drawing.Color.Gray;
            this.btn_buscarfecha.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarfecha.ForeColor = System.Drawing.Color.White;
            this.btn_buscarfecha.Location = new System.Drawing.Point(39, 40);
            this.btn_buscarfecha.Name = "btn_buscarfecha";
            this.btn_buscarfecha.Size = new System.Drawing.Size(142, 52);
            this.btn_buscarfecha.TabIndex = 51;
            this.btn_buscarfecha.Text = "Buscar por fecha";
            this.btn_buscarfecha.UseVisualStyleBackColor = false;
            this.btn_buscarfecha.Click += new System.EventHandler(this.btn_buscarfecha_Click);
            // 
            // btn_buscarestado
            // 
            this.btn_buscarestado.BackColor = System.Drawing.Color.Gray;
            this.btn_buscarestado.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_buscarestado.ForeColor = System.Drawing.Color.White;
            this.btn_buscarestado.Location = new System.Drawing.Point(260, 40);
            this.btn_buscarestado.Name = "btn_buscarestado";
            this.btn_buscarestado.Size = new System.Drawing.Size(167, 52);
            this.btn_buscarestado.TabIndex = 50;
            this.btn_buscarestado.Text = "Buscar por estado";
            this.btn_buscarestado.UseVisualStyleBackColor = false;
            this.btn_buscarestado.Click += new System.EventHandler(this.btn_buscarestado_Click);
            // 
            // dtp_fechacreacion
            // 
            this.dtp_fechacreacion.CustomFormat = " ";
            this.dtp_fechacreacion.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fechacreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fechacreacion.Location = new System.Drawing.Point(218, 120);
            this.dtp_fechacreacion.Name = "dtp_fechacreacion";
            this.dtp_fechacreacion.Size = new System.Drawing.Size(209, 26);
            this.dtp_fechacreacion.TabIndex = 49;
            this.dtp_fechacreacion.Value = new System.DateTime(2022, 8, 12, 10, 32, 6, 0);
            this.dtp_fechacreacion.ValueChanged += new System.EventHandler(this.dtp_fechacreacion_ValueChanged);
            // 
            // cbx_estado
            // 
            this.cbx_estado.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "creada",
            "en ejecucion",
            "completada"});
            this.cbx_estado.Location = new System.Drawing.Point(218, 158);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(209, 27);
            this.cbx_estado.TabIndex = 48;
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_estado.Location = new System.Drawing.Point(45, 166);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(64, 19);
            this.lbl_estado.TabIndex = 47;
            this.lbl_estado.Text = "Estado:";
            // 
            // lbl_fechacreacion
            // 
            this.lbl_fechacreacion.AutoSize = true;
            this.lbl_fechacreacion.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fechacreacion.Location = new System.Drawing.Point(45, 120);
            this.lbl_fechacreacion.Name = "lbl_fechacreacion";
            this.lbl_fechacreacion.Size = new System.Drawing.Size(148, 19);
            this.lbl_fechacreacion.TabIndex = 46;
            this.lbl_fechacreacion.Text = "Fecha de creacion:";
            // 
            // ConsultarEliminarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1304, 664);
            this.Controls.Add(this.btn_eliminarestado);
            this.Controls.Add(this.btn_eliminarfecha);
            this.Controls.Add(this.btn_volver);
            this.Controls.Add(this.lbl_tareas);
            this.Controls.Add(this.dgv_tareas);
            this.Controls.Add(this.btn_comprobar_fecha);
            this.Controls.Add(this.btn_comprobar_estado);
            this.Controls.Add(this.btn_buscarfecha);
            this.Controls.Add(this.btn_buscarestado);
            this.Controls.Add(this.dtp_fechacreacion);
            this.Controls.Add(this.cbx_estado);
            this.Controls.Add(this.lbl_estado);
            this.Controls.Add(this.lbl_fechacreacion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ConsultarEliminarTarea";
            this.Text = "ConsultarEliminarTarea";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_tareas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminarestado;
        private System.Windows.Forms.Button btn_eliminarfecha;
        private System.Windows.Forms.Button btn_volver;
        private System.Windows.Forms.Label lbl_tareas;
        private System.Windows.Forms.DataGridView dgv_tareas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDescripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechacreacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFechalimite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnEstado;
        private System.Windows.Forms.Button btn_comprobar_fecha;
        private System.Windows.Forms.Button btn_comprobar_estado;
        private System.Windows.Forms.Button btn_buscarfecha;
        private System.Windows.Forms.Button btn_buscarestado;
        private System.Windows.Forms.DateTimePicker dtp_fechacreacion;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_fechacreacion;
    }
}