﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinal
{
    public partial class CrearTarea : Form
    {
        //inicializar variables de validacion
        private int a = 0;
        private int b = 0;
        private int c = 1;
        public CrearTarea()
        {
            InitializeComponent();
        }

        private void lbl_nombre_Click(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
        //crea el archivo tareas.txt en caso de que no exista
        private void CrearTarea_Load(object sender, EventArgs e)
        {
            if (!File.Exists("tareas.txt"))
            {
                StreamWriter archivo = new StreamWriter("tareas.txt");
                archivo.Close();
            }
        }
        //permite volver al menu principal
        private void btn_volver_Click(object sender, EventArgs e)
        {
            var form1 = new ProyectoFinal();
            form1.Show();
            this.Hide();
        }
        //establece el formato de fecha dd/MM/yyyy
        private void dtp_fechacreacion_ValueChanged(object sender, EventArgs e)
        {
            dtp_fechacreacion.CustomFormat = "dd/MM/yyyy";
        }
        private void dtp_fechalimite_ValueChanged(object sender, EventArgs e)
        {
            dtp_fechalimite.CustomFormat = "dd/MM/yyyy";
        }
        //valida que la fecha de creacion no sea mayor a la fecha limite y muestra un mensaje de error 
        private void dtp_fechalimite_CloseUp(object sender, EventArgs e)
        {
            DateTime fromdate = Convert.ToDateTime(dtp_fechacreacion.Text);
            DateTime todate = Convert.ToDateTime(dtp_fechalimite.Text);
            if (fromdate >= todate)
            {
                MessageBox.Show("La Fecha de Creacion debe ser menor a la Fecha limite", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                
            }
            else
            {                
                b = 1;
            }
        }
        //valida que todos los campos esten llenos, que el ID no exista y muestra un mensaje de error o un mensaje informativo
        private void btn_listo_Click(object sender, EventArgs e)
        {
            ValidarDatos();
                  
            var id = this.txt_id.Text;
            var nombre = this.txt_nombre.Text;
            var descripcion = this.txt_descripcion.Text;
            var fechacreacion = this.dtp_fechacreacion.Text;
            var fechalimite = this.dtp_fechalimite.Text;
            var estado = this.cbx_estado.Text;
            if ((id == "") || (nombre == "") || (descripcion == "") || (fechacreacion == " ") || (fechalimite == " ") || (estado == ""))
            {
                MessageBox.Show("Se han encontrado campos sin llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                a = 1;
            }
            if (c == 1)
            {
                MessageBox.Show("ID ya existe. Por favor escriba un ID diferente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (a == 1 && b == 1 && c == 0)
            {
                GrabarDatos();
                MessageBox.Show("Tarea creada exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form1 = new ProyectoFinal();
                form1.Show();
                this.Hide();
            }            
        }
        //valida que el ID no exista
        private void ValidarDatos()
        {
            c = 0;
            StreamReader archivo = new StreamReader("tareas.txt", true);
            while (!archivo.EndOfStream)
            {                
                string id = archivo.ReadLine();
                string nombre = archivo.ReadLine();
                string descripcion = archivo.ReadLine();
                string fechacreacion = archivo.ReadLine();
                string fechalimite = archivo.ReadLine();
                string estado = archivo.ReadLine();
                if (id == this.txt_id.Text)
                {
                    c = 1;
                }
            }
            archivo.Close();
        }
        //escribe los datos en el archivo tareas.txt
        private void GrabarDatos()
        {
            StreamWriter archivo = new StreamWriter("tareas.txt", true);
            archivo.WriteLine(txt_id.Text);
            archivo.WriteLine(txt_nombre.Text);
            archivo.WriteLine(txt_descripcion.Text);
            archivo.WriteLine(dtp_fechacreacion.Text);
            archivo.WriteLine(dtp_fechalimite.Text);
            archivo.WriteLine(cbx_estado.Text);
            archivo.Close();
        }
    }
}
