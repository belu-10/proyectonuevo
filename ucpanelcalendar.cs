using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBebe
{
    public partial class ucpanelcalendar : UserControl
    {
        private FlowLayoutPanel contenedor;
        public ucpanelcalendar(FlowLayoutPanel contenedor)
        {
            InitializeComponent();
            this.contenedor = contenedor;

            label1.Text = (Program.fechapanel[Program.iglu]);
            label2.Text = (Program.especialidad[Program.iglu]);
            label3.Text = (Program.extra[Program.iglu]); 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucpanelcalendar_Load(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            contenedor.Controls.Remove(this); // borrar de la bdd 
            this.Dispose(); // 

        }
    }
}
