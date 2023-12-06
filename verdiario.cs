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
    public partial class verdiario : Form
    {
        public verdiario()
        {
            InitializeComponent();

          //  pictureBox2.ImageLocation = (Program.foto[Program.indice]);
          //  pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // textBox1.Text = Program.nota[Program.iman]; 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formrecuerdo recuerdo = new formrecuerdo();
            recuerdo.Show(); 
        }

        private void verdiario_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDer_Click(object sender, EventArgs e)
        {
            if (Program.iman == Program.nota.Count())
            {
                Program.iman = 0;
            }
            else
            {
                label1.Text = Program.nota[Program.iman];
                Program.iman++;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Program.iman == Program.nota.Count())
            {
                Program.iman = 0;
            }
            else
            {
                label1.Text = Program.nota[Program.iman];
                Program.iman--;
            }
        }
    }
}
