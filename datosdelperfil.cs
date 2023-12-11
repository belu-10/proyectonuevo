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
    public partial class datosdelperfil : Form
    {
        public datosdelperfil()
        {
            InitializeComponent();

            pictureBox2.ImageLocation = (Program.foto[Program.indice-1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true; 

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false; 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            perfilhijo perfil = new perfilhijo();
            perfil.Show();
            this.Hide(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            formhijoiniciar iniciar = new formhijoiniciar();
            iniciar.Show();
            this.Hide(); 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            calendario cal = new calendario();
            cal.Show();
            this.Hide(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formrecuerdo rec = new formrecuerdo();
            rec.Show();
            this.Hide(); 
        }
    }
}
