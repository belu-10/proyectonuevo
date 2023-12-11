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
    public partial class formdiario : Form
    {
        public formdiario()
        {
            InitializeComponent();
            for (Program.iman = 0; Program.iman < Program.fechadiario.Count; Program.iman++)
            {
                UserControl1 user = new UserControl1();
                user.Parent = flowLayoutPanel1;
                user.Click += user_Click;

                
            }

            pictureBox2.ImageLocation = (Program.foto[Program.indice-1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void user_Click(object sender, EventArgs e)
        {
            nuevanotdiar nuevanota = new nuevanotdiar();
            nuevanota.Show();
            this.Hide(); 

            // ACA SE DEBERIA MOSTRAR LA FECHA ELEGIDA Y LA NOTA ESCRITA

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            nuevanotdiar nuevanota = new nuevanotdiar();
            nuevanota.Show();
            this.Hide(); 

           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            nuevanotdiar nueva = new nuevanotdiar();
            nueva.Show();
            this.Hide(); 


          /*  if (textBox1.Text != string.Empty)
            {
                BackgroundImage = Image.FromFile("C://Users/belus//Downloads//Frame 33.PNG");  
              // ("C:\\Users\belus\\Downloads\\Rectangle414.PNG");
            } */

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            formrecuerdo recuerdos = new formrecuerdo();
            recuerdos.Show();
            this.Hide();
        }

        private void formdiario_Load(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            perfilhijo perfil = new perfilhijo();
            perfil.Show();
            this.Hide();
        }
    }
}
