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
    public partial class perfilhijo : Form
    {
        public perfilhijo()
        {
            InitializeComponent();
            pictureBox2.ImageLocation = (Program.foto[Program.indice-1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void perfilhijo_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
