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
    public partial class formmomento : Form
    {
        public formmomento()
        {
            InitializeComponent();
            //label1.Text = (Program.titulo[Program.i]);

            pictureBox2.ImageLocation = (Program.foto[Program.indice-1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            // EN EL PICTURE BOX LA FOTO QUE YA GUARDO ANTES
            // EN EL LABEL 2 VA LA FECHA
            // EN EL LABEL 1 VA EL TITULO

        }

        private void formmomento_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Formalbum album = new Formalbum();
            album.Show();
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
