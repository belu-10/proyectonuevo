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
    public partial class nuevanotdiar : Form
    {
        public nuevanotdiar()
        {
            InitializeComponent();

            pictureBox2.ImageLocation = (Program.foto[Program.indice-1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nota = textBox1.Text;
            Program.nota.Add(nota);

            string fechadiaro = dateTimePicker1.Text;
            Program.fechadiario.Add(fechadiaro);

            formdiario diario = new formdiario();
            diario.Show();
            this.Hide(); 
        }

        private void nuevanotdiar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formperfil perfil = new formperfil();
            perfil.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formdiario diar = new formdiario();
            diar.Show();
            this.Hide(); 
        }
    }
}
