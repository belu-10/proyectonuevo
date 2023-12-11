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
        public ucpanelcalendar()
        {
            InitializeComponent();
            label1.Text = (Program.fecha[Program.iglu]);
            label2.Text = (Program.especialidad[Program.iglu]);
            label3.Text = (Program.extra[Program.iglu]);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ucpanelcalendar_Load(object sender, EventArgs e)
        {

        }
    }
}
