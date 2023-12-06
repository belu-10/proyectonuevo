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
    public partial class ucalbum : UserControl
    {
        public ucalbum()
        {
            InitializeComponent();
            label1.Text = (Program.titulo[Program.i]);
            pictureBox1.ImageLocation = (Program.album[Program.i]); 
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;


        }

        private void ucalbum_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
