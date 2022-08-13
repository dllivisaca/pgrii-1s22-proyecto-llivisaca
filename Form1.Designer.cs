namespace ProyectoFinal
{
    partial class ProyectoFinal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectoFinal));
            this.lbl_menuprincipal = new System.Windows.Forms.Label();
            this.btn_modificar_tarea = new System.Windows.Forms.Button();
            this.btn_crear_tarea = new System.Windows.Forms.Button();
            this.btn_consultareliminartarea = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_menuprincipal
            // 
            this.lbl_menuprincipal.AutoSize = true;
            this.lbl_menuprincipal.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_menuprincipal.Location = new System.Drawing.Point(287, 71);
            this.lbl_menuprincipal.Name = "lbl_menuprincipal";
            this.lbl_menuprincipal.Size = new System.Drawing.Size(141, 19);
            this.lbl_menuprincipal.TabIndex = 8;
            this.lbl_menuprincipal.Text = "MENU PRINCIPAL";
            // 
            // btn_modificar_tarea
            // 
            this.btn_modificar_tarea.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_modificar_tarea.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modificar_tarea.ForeColor = System.Drawing.Color.White;
            this.btn_modificar_tarea.Location = new System.Drawing.Point(283, 188);
            this.btn_modificar_tarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_modificar_tarea.Name = "btn_modificar_tarea";
            this.btn_modificar_tarea.Size = new System.Drawing.Size(148, 35);
            this.btn_modificar_tarea.TabIndex = 6;
            this.btn_modificar_tarea.Text = "Modificar tarea";
            this.btn_modificar_tarea.UseVisualStyleBackColor = false;
            this.btn_modificar_tarea.Click += new System.EventHandler(this.btn_modificar_tarea_Click);
            // 
            // btn_crear_tarea
            // 
            this.btn_crear_tarea.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_crear_tarea.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_crear_tarea.ForeColor = System.Drawing.Color.White;
            this.btn_crear_tarea.Location = new System.Drawing.Point(283, 111);
            this.btn_crear_tarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_crear_tarea.Name = "btn_crear_tarea";
            this.btn_crear_tarea.Size = new System.Drawing.Size(148, 35);
            this.btn_crear_tarea.TabIndex = 5;
            this.btn_crear_tarea.Text = "Crear tarea";
            this.btn_crear_tarea.UseVisualStyleBackColor = false;
            this.btn_crear_tarea.Click += new System.EventHandler(this.btn_crear_tarea_Click);
            // 
            // btn_consultareliminartarea
            // 
            this.btn_consultareliminartarea.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_consultareliminartarea.Font = new System.Drawing.Font("Rockwell", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_consultareliminartarea.ForeColor = System.Drawing.Color.White;
            this.btn_consultareliminartarea.Location = new System.Drawing.Point(262, 264);
            this.btn_consultareliminartarea.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_consultareliminartarea.Name = "btn_consultareliminartarea";
            this.btn_consultareliminartarea.Size = new System.Drawing.Size(199, 64);
            this.btn_consultareliminartarea.TabIndex = 9;
            this.btn_consultareliminartarea.Text = "Consultar/Eliminar tarea";
            this.btn_consultareliminartarea.UseVisualStyleBackColor = false;
            this.btn_consultareliminartarea.Click += new System.EventHandler(this.btn_consultareliminartarea_Click);
            // 
            // ProyectoFinal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(740, 450);
            this.Controls.Add(this.btn_consultareliminartarea);
            this.Controls.Add(this.lbl_menuprincipal);
            this.Controls.Add(this.btn_modificar_tarea);
            this.Controls.Add(this.btn_crear_tarea);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ProyectoFinal";
            this.Text = "Pantalla principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_menuprincipal;
        private System.Windows.Forms.Button btn_modificar_tarea;
        private System.Windows.Forms.Button btn_crear_tarea;
        private System.Windows.Forms.Button btn_consultareliminartarea;
    }
}

