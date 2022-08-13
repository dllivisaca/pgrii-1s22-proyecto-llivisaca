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
    }
}
