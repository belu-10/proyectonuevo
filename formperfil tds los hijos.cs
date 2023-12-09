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
    public partial class formperfil_tds_los_hijos : Form
    {
        public formperfil_tds_los_hijos()
        {
            InitializeComponent();

            pictureBox2.ImageLocation = (Program.foto[Program.indice - 1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            for (Program.indice = 0; Program.indice < Program.nombre.Count; Program.indice++)
            {
                ucperfilhijos user = new ucperfilhijos();
                user.Parent = flowLayoutPanel1;
   
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            formperfil perfil = new formperfil();
            perfil.Show();
            this.Hide(); 
        }

        private void formperfil_tds_los_hijos_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
