using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class ProyectoFinal : Form
    {
        public ProyectoFinal()
        {
            InitializeComponent();
            
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_crear_tarea_Click(object sender, EventArgs e)
        {
            var form2 = new CrearTarea();
            form2.Show();
            this.Hide();
        }

        private void btn_modificar_tarea_Click(object sender, EventArgs e)
        {
            var form3 = new ModificarTarea();
            form3.Show();
            this.Hide();
        }

        private void btn_consultareliminartarea_Click(object sender, EventArgs e)
        {
            var form4 = new ConsultarEliminarTarea();
            form4.Show();
            this.Hide();
        }
    }
}
