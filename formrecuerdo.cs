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
    public partial class formrecuerdo : Form
    {
        public formrecuerdo()
        {
            InitializeComponent();

            pictureBox2.ImageLocation = (Program.foto[Program.indice-1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void formrecuerdo_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formalbum album = new Formalbum();
            album.Show(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
          

        }

        private void buttoninsesion_Click(object sender, EventArgs e)
        {
            formdiario diario = new formdiario();
            diario.Show();
            this.Hide(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            BackgroundImage = Image.FromFile
              ("C://Users/48796306//Downloads//Rectangulo.PNG"); 
       

        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            Formalbum album = new Formalbum();
            album.Show();
        }

        private void buttonrec2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true; 
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            Formalbum album = new Formalbum();
            album.Show();
            this.Hide(); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formdiario diario = new formdiario();
            diario.Show();
            this.Hide();
        }

        private void button3_Click_3(object sender, EventArgs e)
        {
            veralbum ver = new veralbum();
            ver.Show();
            this.Hide(); 
        }

        private void buttoninsesion_Click_1(object sender, EventArgs e)
        {
            verdiario vver = new verdiario();
            vver.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            perfilhijo perfil = new perfilhijo();
            perfil.Show();
            this.Hide();
        }
    }
}
