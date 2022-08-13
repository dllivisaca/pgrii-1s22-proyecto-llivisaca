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
    public partial class ModificarTarea : Form
    {
        private int c = 0;
        public ModificarTarea()
        {
            InitializeComponent();
            if (!File.Exists("tareas.txt"))
            {
                StreamWriter archivo = new StreamWriter("tareas.txt");
                archivo.Close();
            }


            gbx_datos.Hide();
            btn_modificar.Hide();
        }
        private void ValidarID()
        {
            c = 0;
            StreamReader archivo = new StreamReader("tareas.txt", true);
            while (!archivo.EndOfStream)
            {
                string id = archivo.ReadLine();
                if (id == this.txt_id.Text)
                {
                    c = 1;
                }
            }
            archivo.Close();
        }
        private void GrabarDatosModificados()
        {
            StreamReader lectura;
            StreamWriter escribir;
            try
            {
                lectura = File.OpenText("tareas.txt");
                escribir = File.CreateText("tmp.txt");

                while (!lectura.EndOfStream)
                {
                    string id_ = lectura.ReadLine();
                    string nombre_ = lectura.ReadLine();
                    string descripcion_ = lectura.ReadLine();
                    string fechacreacion_ = lectura.ReadLine();
                    string fechalimite_ = lectura.ReadLine();
                    string estado_ = lectura.ReadLine();
                    if (id_ != this.txt_id.Text)
                    {
                        escribir.WriteLine(id_);
                        escribir.WriteLine(nombre_);
                        escribir.WriteLine(descripcion_);
                        escribir.WriteLine(fechacreacion_);
                        escribir.WriteLine(fechalimite_);
                        escribir.WriteLine(estado_);
                    }
                    else
                    {
                        string id = this.txt_id.Text;
                        string nombre = this.txt_nombre.Text;
                        string descripcion = this.txt_descripcion.Text;
                        string fechacreacion = this.dtp_fechacreacion.Text;
                        string fechalimite = this.dtp_fechalimite.Text;
                        string estado = this.cbx_estado.Text;
                        escribir.WriteLine(id);
                        escribir.WriteLine(nombre);
                        escribir.WriteLine(descripcion);
                        escribir.WriteLine(fechacreacion);
                        escribir.WriteLine(fechalimite);
                        escribir.WriteLine(estado);
                    }
                }
                lectura.Close();
                escribir.Close();
                File.Delete("tareas.txt");
                File.Move("tmp.txt", "tareas.txt");
            }
            catch
            {
                MessageBox.Show("No se ha podido modificar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btn_modificar_Click(object sender, EventArgs e)
        {
            var nombre = this.txt_nombre.Text;
            var descripcion = this.txt_descripcion.Text;
            var fechacreacion = this.dtp_fechacreacion.Text;
            var fechalimite = this.dtp_fechalimite.Text;
            var estado = this.cbx_estado.Text;
            if ((nombre == "") || (descripcion == "") || (fechacreacion == " ") || (fechalimite == " ") || (estado == ""))
            {
                MessageBox.Show("Se han encontrado campos sin llenar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                GrabarDatosModificados();
                MessageBox.Show("Se ha modificado la tarea correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form1 = new ProyectoFinal();
                form1.Show();
                this.Hide();
            }
        }
        private void ValidarEstado()
        {
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
                    if (estado == "creada")
                    {
                        gbx_datos.Show();
                        lbl_idmodificar.Text = id;
                        btn_modificar.Show();

                    }
                    else
                    {
                        MessageBox.Show("La tarea no se puede modificar porque ya esta en ejecucion o esta completada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            archivo.Close();

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
        }

        private void btn_comprobar_Click(object sender, EventArgs e)
        {
            ValidarID();
            if (c == 0)
            {
                MessageBox.Show("ID no existente. Por favor escriba un ID diferente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                ValidarEstado();
            }
        }
    }
}
