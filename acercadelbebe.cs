﻿using System;
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
    public partial class acercadelbebe : Form
    {
        public acercadelbebe()
        {
            InitializeComponent();
            //  label1.Text = (Program.nombre[Program.indice]);

       //ESTOOOOO
          pictureBox3.ImageLocation = (Program.foto[Program.indice-1]);
          pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBox4.ImageLocation = (Program.foto[Program.indice - 1]);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = true;
            groupBox1.Visible = false; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true; 
        }

        private void acercadelbebe_Load(object sender, EventArgs e)
        {
         
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            formhijoiniciar hijoinicio = new formhijoiniciar();
            hijoinicio.Show();
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
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

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            panel1.Visible = false; 
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            panel1.Visible = true; 
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}
