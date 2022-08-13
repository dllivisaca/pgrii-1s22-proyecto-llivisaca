namespace ProyectoFinal
{
    partial class ModificarTarea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ModificarTarea));
            this.btn_comprobar = new System.Windows.Forms.Button();
            this.lbl_errorfecha = new System.Windows.Forms.Label();
            this.gbx_datos = new System.Windows.Forms.GroupBox();
            this.lbl_idmodificar = new System.Windows.Forms.Label();
            this.dtp_fechalimite = new System.Windows.Forms.DateTimePicker();
            this.dtp_fechacreacion = new System.Windows.Forms.DateTimePicker();
            this.cbx_estado = new System.Windows.Forms.ComboBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_estado = new System.Windows.Forms.Label();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.lbl_fecha_l = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_fecha_c = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.lbl_seleccioneid = new System.Windows.Forms.Label();
            this.btn_volver = new System.Windows.Forms.Button();
            this.gbx_datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_comprobar
            // 
            this.btn_comprobar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_comprobar.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_comprobar.Location = new System.Drawing.Point(581, 121);
            this.btn_comprobar.Name = "btn_comprobar";
            this.btn_comprobar.Size = new System.Drawing.Size(122, 43);
            this.btn_comprobar.TabIndex = 40;
            this.btn_comprobar.Text = "Comprobar";
            this.btn_comprobar.UseVisualStyleBackColor = false;
            this.btn_comprobar.Click += new System.EventHandler(this.btn_comprobar_Click);
            // 
            // lbl_errorfecha
            // 
            this.lbl_errorfecha.AutoSize = true;
            this.lbl_errorfecha.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_errorfecha.Location = new System.Drawing.Point(423, 475);
            this.lbl_errorfecha.Name = "lbl_errorfecha";
            this.lbl_errorfecha.Size = new System.Drawing.Size(0, 19);
            this.lbl_errorfecha.TabIndex = 39;
            // 
            // gbx_datos
            // 
            this.gbx_datos.Controls.Add(this.lbl_idmodificar);
            this.gbx_datos.Controls.Add(this.dtp_fechalimite);
            this.gbx_datos.Controls.Add(this.dtp_fechacreacion);
            this.gbx_datos.Controls.Add(this.cbx_estado);
            this.gbx_datos.Controls.Add(this.lbl_id);
            this.gbx_datos.Controls.Add(this.lbl_nombre);
            this.gbx_datos.Controls.Add(this.lbl_estado);
            this.gbx_datos.Controls.Add(this.lbl_descripcion);
            this.gbx_datos.Controls.Add(this.lbl_fecha_l);
            this.gbx_datos.Controls.Add(this.txt_descripcion);
            this.gbx_datos.Controls.Add(this.lbl_fecha_c);
            this.gbx_datos.Controls.Add(this.txt_nombre);
            this.gbx_datos.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datos.Location = new System.Drawing.Point(50, 197);
            this.gbx_datos.Name = "gbx_datos";
            this.gbx_datos.Size = new System.Drawing.Size(667, 298);
            this.gbx_datos.TabIndex = 38;
            this.gbx_datos.TabStop = false;
            // 
            // lbl_idmodificar
            // 
            this.lbl_idmodificar.AutoSize = true;
            this.lbl_idmodificar.Location = new System.Drawing.Point(188, 25);
            this.lbl_idmodificar.Name = "lbl_idmodificar";
            this.lbl_idmodificar.Size = new System.Drawing.Size(0, 19);
            this.lbl_idmodificar.TabIndex = 24;
            // 
            // dtp_fechalimite
            // 
            this.dtp_fechalimite.CustomFormat = " ";
            this.dtp_fechalimite.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fechalimite.Location = new System.Drawing.Point(192, 195);
            this.dtp_fechalimite.Name = "dtp_fechalimite";
            this.dtp_fechalimite.Size = new System.Drawing.Size(412, 26);
            this.dtp_fechalimite.TabIndex = 23;
            this.dtp_fechalimite.CloseUp += new System.EventHandler(this.dtp_fechalimite_CloseUp);
            this.dtp_fechalimite.ValueChanged += new System.EventHandler(this.dtp_fechalimite_ValueChanged);
            // 
            // dtp_fechacreacion
            // 
            this.dtp_fechacreacion.CustomFormat = " ";
            this.dtp_fechacreacion.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fechacreacion.Location = new System.Drawing.Point(192, 153);
            this.dtp_fechacreacion.Name = "dtp_fechacreacion";
            this.dtp_fechacreacion.Size = new System.Drawing.Size(412, 26);
            this.dtp_fechacreacion.TabIndex = 22;
            this.dtp_fechacreacion.Value = new System.DateTime(2022, 8, 12, 10, 32, 6, 0);
            this.dtp_fechacreacion.ValueChanged += new System.EventHandler(this.dtp_fechacreacion_ValueChanged);
            // 
            // cbx_estado
            // 
            this.cbx_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_estado.FormattingEnabled = true;
            this.cbx_estado.Items.AddRange(new object[] {
            "creada",
            "en ejecucion",
            "completada"});
            this.cbx_estado.Location = new System.Drawing.Point(192, 240);
            this.cbx_estado.Name = "cbx_estado";
            this.cbx_estado.Size = new System.Drawing.Size(412, 27);
            this.cbx_estado.TabIndex = 20;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(21, 25);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(25, 19);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "lD";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(21, 67);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(70, 19);
            this.lbl_nombre.TabIndex = 2;
            this.lbl_nombre.Text = "Nombre";
            // 
            // lbl_estado
            // 
            this.lbl_estado.AutoSize = true;
            this.lbl_estado.Location = new System.Drawing.Point(21, 243);
            this.lbl_estado.Name = "lbl_estado";
            this.lbl_estado.Size = new System.Drawing.Size(59, 19);
            this.lbl_estado.TabIndex = 10;
            this.lbl_estado.Text = "Estado";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Location = new System.Drawing.Point(21, 113);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(96, 19);
            this.lbl_descripcion.TabIndex = 4;
            this.lbl_descripcion.Text = "Descripcion";
            // 
            // lbl_fecha_l
            // 
            this.lbl_fecha_l.AutoSize = true;
            this.lbl_fecha_l.Location = new System.Drawing.Point(21, 200);
            this.lbl_fecha_l.Name = "lbl_fecha_l";
            this.lbl_fecha_l.Size = new System.Drawing.Size(97, 19);
            this.lbl_fecha_l.TabIndex = 8;
            this.lbl_fecha_l.Text = "Fecha limite";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Location = new System.Drawing.Point(192, 110);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(412, 26);
            this.txt_descripcion.TabIndex = 5;
            // 
            // lbl_fecha_c
            // 
            this.lbl_fecha_c.AutoSize = true;
            this.lbl_fecha_c.Location = new System.Drawing.Point(21, 153);
            this.lbl_fecha_c.Name = "lbl_fecha_c";
            this.lbl_fecha_c.Size = new System.Drawing.Size(120, 19);
            this.lbl_fecha_c.TabIndex = 6;
            this.lbl_fecha_c.Text = "Fecha creacion";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(192, 67);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(412, 26);
            this.txt_nombre.TabIndex = 3;
            // 
            // btn_modificar
            // 
            this.btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_modificar.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar.Location = new System.Drawing.Point(882, 310);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(101, 43);
            this.btn_modificar.TabIndex = 37;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = false;
            this.btn_modificar.Click += new System.EventHandler(this.btn_modificar_Click);
            // 
            // txt_id
            // 
            this.txt_id.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_id.Location = new System.Drawing.Point(350, 129);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(100, 26);
            this.txt_id.TabIndex = 36;
            // 
            // lbl_seleccioneid
            // 
            this.lbl_seleccioneid.AutoSize = true;
            this.lbl_seleccioneid.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_seleccioneid.Location = new System.Drawing.Point(74, 132);
            this.lbl_seleccioneid.Name = "lbl_seleccioneid";
            this.lbl_seleccioneid.Size = new System.Drawing.Size(261, 19);
            this.lbl_seleccioneid.TabIndex = 35;
            this.lbl_seleccioneid.Text = "Ingrese ID de la tarea a modificar:";
            // 
            // btn_volver
            // 
            this.btn_volver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_volver.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_volver.Location = new System.Drawing.Point(882, 375);
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(101, 43);
            this.btn_volver.TabIndex = 34;
            this.btn_volver.Text = "Volver";
            this.btn_volver.UseVisualStyleBackColor = false;
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // ModificarTarea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1025, 617);
            this.Controls.Add(this.btn_comprobar);
            this.Controls.Add(this.lbl_errorfecha);
            this.Controls.Add(this.gbx_datos);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_seleccioneid);
            this.Controls.Add(this.btn_volver);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ModificarTarea";
            this.Text = "ModificarTarea";
            this.gbx_datos.ResumeLayout(false);
            this.gbx_datos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_comprobar;
        private System.Windows.Forms.Label lbl_errorfecha;
        private System.Windows.Forms.GroupBox gbx_datos;
        private System.Windows.Forms.Label lbl_idmodificar;
        private System.Windows.Forms.DateTimePicker dtp_fechalimite;
        private System.Windows.Forms.DateTimePicker dtp_fechacreacion;
        private System.Windows.Forms.ComboBox cbx_estado;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_estado;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.Label lbl_fecha_l;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_fecha_c;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Label lbl_seleccioneid;
        private System.Windows.Forms.Button btn_volver;
    }
}