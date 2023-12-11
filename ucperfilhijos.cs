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
    public partial class ucperfilhijos : UserControl
    {
        public ucperfilhijos()
        {
            InitializeComponent();

            textBox1.Text = (Program.nombre[Program.indice]);

            textBox2.Text = (Program.nacimiento[Program.indice]);

            pictureBox1.ImageLocation = (Program.foto[Program.indice]);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucperfilhijos_Load(object sender, EventArgs e)
        {

        }
    }
}
