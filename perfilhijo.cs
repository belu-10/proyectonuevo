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
            formperfil perfil = new formperfil();
            perfil.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            formperfil perfil = new formperfil();
            perfil.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formhijoiniciar hijoinicio = new formhijoiniciar();
            hijoinicio.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            calendario cl = new calendario();
            cl.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formrecuerdo recuero = new formrecuerdo();
            recuero.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false; 
        }
    }
}
