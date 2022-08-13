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
    public partial class ConsultarEliminarTarea : Form
    {
        private int a = 0;
        private int b = 0;
        public ConsultarEliminarTarea()
        {            
            InitializeComponent();
            if (!File.Exists("tareas.txt"))
            {
                StreamWriter archivo = new StreamWriter("tareas.txt");
                archivo.Close();
            }
            btn_comprobar_fecha.Hide();
            btn_comprobar_estado.Hide();
            lbl_fechacreacion.Hide();
            lbl_estado.Hide();
            dtp_fechacreacion.Hide();
            cbx_estado.Hide();
            lbl_tareas.Hide();
            dgv_tareas.Hide();
            btn_eliminarfecha.Hide();
            btn_eliminarestado.Hide();
        }
        private void dtp_fechacreacion_ValueChanged(object sender, EventArgs e)
        {
            dtp_fechacreacion.CustomFormat = "dd/MM/yyyy";
        }
        private void ValidarEstado()
        {
            b = 0;
            StreamReader archivo = new StreamReader("tareas.txt", true);
            while (!archivo.EndOfStream)
            {
                string id = archivo.ReadLine();
                string nombre = archivo.ReadLine();
                string descripcion = archivo.ReadLine();
                string fechacreacion = archivo.ReadLine();
                string fechalimite = archivo.ReadLine();
                string estado = archivo.ReadLine();
                if (estado == this.cbx_estado.Text)
                {
                    b = 1;
                }
            }
            archivo.Close();
        }
        private void ValidarFechacreacion()
        {
            a = 0;
            StreamReader archivo = new StreamReader("tareas.txt", true);
            while (!archivo.EndOfStream)
            {
                string id = archivo.ReadLine();
                string nombre = archivo.ReadLine();
                string descripcion = archivo.ReadLine();
                string fechacreacion = archivo.ReadLine();
                string fechalimite = archivo.ReadLine();
                string estado = archivo.ReadLine();
                if (fechacreacion == this.dtp_fechacreacion.Text)
                {
                    a = 1;
                }
            }
            archivo.Close();
        }
        private void btn_buscarfecha_Click(object sender, EventArgs e)
        {
            btn_buscarfecha.Hide();
            lbl_fechacreacion.Show();
            dtp_fechacreacion.Show();
            btn_comprobar_fecha.Show();
            btn_buscarestado.Hide();
        }

        private void btn_buscarestado_Click(object sender, EventArgs e)
        {
            btn_buscarestado.Hide();
            lbl_estado.Show();
            cbx_estado.Show();
            btn_comprobar_estado.Show();
            btn_buscarfecha.Hide();
        }

        private void btn_comprobar_fecha_Click(object sender, EventArgs e)
        {
            ValidarFechacreacion();
            if (a == 0)
            {
                MessageBox.Show("Fecha no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgv_tareas.Show();
                lbl_tareas.Show();
                StreamReader archivo = new StreamReader("tareas.txt", true);
                while (!archivo.EndOfStream)
                {
                    string id = archivo.ReadLine();
                    string nombre = archivo.ReadLine();
                    string descripcion = archivo.ReadLine();
                    string fechacreacion = archivo.ReadLine();
                    string fechalimite = archivo.ReadLine();
                    string estado = archivo.ReadLine();
                    if (fechacreacion == this.dtp_fechacreacion.Text)
                    {
                        dgv_tareas.Rows.Add(id, nombre, descripcion, fechacreacion, fechalimite, estado);
                        btn_eliminarfecha.Show();
                    }                   
                }
                archivo.Close();
            }
        }

        private void btn_comprobar_estado_Click(object sender, EventArgs e)
        {
            ValidarEstado();
            if (b == 0)
            {
                MessageBox.Show("Estado no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dgv_tareas.Show();
                lbl_tareas.Show();
                StreamReader archivo = new StreamReader("tareas.txt", true);
                while (!archivo.EndOfStream)
                {
                    string id = archivo.ReadLine();
                    string nombre = archivo.ReadLine();
                    string descripcion = archivo.ReadLine();
                    string fechacreacion = archivo.ReadLine();
                    string fechalimite = archivo.ReadLine();
                    string estado = archivo.ReadLine();
                    if (estado == this.cbx_estado.Text)
                    {
                        dgv_tareas.Rows.Add(id, nombre, descripcion, fechacreacion, fechalimite, estado);
                        btn_eliminarestado.Show();
                    }                    
                }
                archivo.Close();

            }
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            var form1 = new ProyectoFinal();
            form1.Show();
            this.Hide();
        }
        private void Eliminardatosfecha()
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
                    if (fechacreacion_ == this.dtp_fechacreacion.Text)
                    {
                        id_ = "";
                        nombre_ = "";
                        descripcion_ = "";
                        fechacreacion_ = "";
                        fechalimite_ = "";
                        estado_ = "";
                        escribir.WriteLine(id_);
                        escribir.WriteLine(nombre_);
                        escribir.WriteLine(descripcion_);
                        escribir.WriteLine(fechacreacion_);
                        escribir.WriteLine(fechalimite_);
                        escribir.WriteLine(estado_);
                    }
                    else
                    {
                        string id = id_;
                        string nombre = nombre_;
                        string descripcion = descripcion_;
                        string fechacreacion = fechacreacion_;
                        string fechalimite = fechalimite_;
                        string estado = estado_;                        
                    }
                }
                lectura.Close();
                escribir.Close();
                File.Delete("tareas.txt");
                File.Move("tmp.txt", "tareas.txt");
                MessageBox.Show("Tarea eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form1 = new ProyectoFinal();
                form1.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("No se ha podido eliminar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Eliminardatosestado()
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
                    if (estado_ == this.cbx_estado.Text)
                    {
                        id_ = "";
                        nombre_ = "";
                        descripcion_ = "";
                        fechacreacion_ = "";
                        fechalimite_ = "";
                        estado_ = "";                        
                    }
                    else
                    {
                        string id = id_;
                        string nombre = nombre_;
                        string descripcion = descripcion_;
                        string fechacreacion = fechacreacion_;
                        string fechalimite = fechalimite_;
                        string estado = estado_;
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
                MessageBox.Show("Tarea eliminada correctamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var form1 = new ProyectoFinal();
                form1.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("No se ha podido eliminar la tarea", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_eliminarestado_Click(object sender, EventArgs e)
        {
            Eliminardatosestado();
        }

        private void btn_eliminarfecha_Click(object sender, EventArgs e)
        {
            Eliminardatosfecha();
        }
    }
}
