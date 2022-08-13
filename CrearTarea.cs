using System;
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

        private void CrearTarea_Load(object sender, EventArgs e)
        {
            if (!File.Exists("tareas.txt"))
            {
                StreamWriter archivo = new StreamWriter("tareas.txt");
                archivo.Close();
            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            var form1 = new ProyectoFinal();
            form1.Show();
            this.Hide();
        }

        private void dtp_fechacreacion_ValueChanged(object sender, EventArgs e)
        {
            dtp_fechacreacion.CustomFormat = "dd/MM/yyyy";
        }

        private void dtp_fechalimite_ValueChanged(object sender, EventArgs e)
        {
            dtp_fechalimite.CustomFormat = "dd/MM/yyyy";
        }

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

        private void btn_listo_Click(object sender, EventArgs e)
        {
            ValidarDatos();
            if (c == 1)
            {
                GrabarDatos();
            }            
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
            if (c == 0)
            {
                MessageBox.Show("ID ya existe. Por favor escriba un ID diferente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (a == 1 && b == 1 && c == 1)
            {
                //dataGridView1.Rows.Add(txt_id.Text, txt_nombre.Text, txt_descripcion.Text, dtp_fechacreacion.Text, dtp_fechalimite.Text, cbx_estado.Text);
                MessageBox.Show("Tarea creada exitosamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form1 = new ProyectoFinal();
                form1.Show();
                this.Hide();
            }
        }
        private void ValidarDatos()
        {
            c = 1;
            StreamReader archivo = new StreamReader("tareas.txt", true);
            while (!archivo.EndOfStream)
            {
                string id = archivo.ReadLine();
                if (id == this.txt_id.Text)
                {
                    c = 0;
                }
            }
            archivo.Close();
        }
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
