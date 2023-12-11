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
    public partial class formperfil : Form
    {
        public formperfil()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel1.Visible = false; 
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false; 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            formhijoiniciar hijoinicio = new formhijoiniciar();
            hijoinicio.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button12_Click(object sender, EventArgs e)
        {
            perfilhijo perfil = new perfilhijo();
            perfil.Show();
            this.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel1.BringToFront(); 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panel2.Visible = false; 
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panel3.Visible = false; 
        }

        private void button22_Click(object sender, EventArgs e)
        {
            formperfil_tds_los_hijos hijos = new formperfil_tds_los_hijos();
            hijos.Show();
            this.Hide(); 
        }

        private void formperfil_Load(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
           //ACA CERRAR SESÍÓN
            forminsesion inicio = new forminsesion();
            inicio.Show();
            this.Hide(); 
        }

        private void button19_Click(object sender, EventArgs e)
        {
            //ACA ELIMINAR CUENTA
            forminsesion inicio = new forminsesion();
            inicio.Show();
            this.Hide();
        }

        private void button23_Click(object sender, EventArgs e)
        {
            panel1.Visible = false; 
        }

        private void button24_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true; 
        }

        private void button25_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true; 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.BringToFront(); 
        }

        private void button26_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel3.BringToFront(); 
        }
    }
}
