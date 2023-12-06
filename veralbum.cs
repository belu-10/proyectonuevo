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
    public partial class veralbum : Form
    {
        List<string> listaDE = new List<string>()
        {
          "C:/Users/48796306/Pictures/Saved Pictures/wwe1.jpg",
          "C:/Users/48796306/Pictures/Saved Pictures/wwe2.jpg",
          "C:/Users/48796306/Pictures/Saved Pictures/wwe3.jpg",
          "C:/Users/48796306/Pictures/Saved Pictures/wwe4.jfif",
          "C:/Users/48796306/Pictures/Saved Pictures/wwe4}.jfif"
        };

        int Indice = 0;
        

        public veralbum()
        {
            InitializeComponent();

            pictureBox2.ImageLocation = (Program.foto[Program.indice-1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void LoadNextImage()
        {
            
        }

        private void veralbum_Load(object sender, EventArgs e)
        {
          
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            if (Indice == listaDE.Count())
            {
                Indice = 0; 
            }
            else
            {
                pictureBox1.BackgroundImage = Image.FromFile(listaDE[Indice]);
                Indice++;
            }
            
        }

        private void btnIzq_Click(object sender, EventArgs e)
        { 
            if (Indice == 0)
            {
                Indice = listaDE.Count(); 
            }
            else
            {
                Indice--;
                pictureBox1.BackgroundImage = Image.FromFile(listaDE[Indice]);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
