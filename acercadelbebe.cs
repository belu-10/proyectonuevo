﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb; 

namespace ProyectoBebe
{
    public partial class acercadelbebe : Form
    {

        string sql;
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        OleDbDataReader reader;

       

        public acercadelbebe()
        {
            InitializeComponent();
            //  label1.Text = (Program.nombre[Program.indice]);

       //ESTO ES TEMA FOTO
          pictureBox3.ImageLocation = (Program.foto[Program.indice-1]);
          pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;

          pictureBox2.ImageLocation = (Program.foto[Program.indice - 1]);
          pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

          pictureBox5.ImageLocation = (Program.foto[Program.indice - 1]);
          pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;


            // ESTO ES PARA ACTUALIZAR ALGUNOS DATOS


            // label4.Text = Program.nombre[Program.indice-1];
            //label5.Text = Program.nacimiento[Program.indice - 1];

            cn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =./proyecto111.accdb;";

            sql = "SELECT (nombre) FROM bebe WHERE id = " + Convert.ToInt32(Program.idBBregistro) + ";";
            cmd = new OleDbCommand(sql, cn);
            da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "nombre");
            if (ds.Tables["nombre"].Rows.Count > 0)
            {
                label4.Text = ds.Tables["nombre"].Rows[0]["nombre"].ToString();
            }

            sql = "SELECT (nacimiento) FROM bebe WHERE id = " + Convert.ToInt32(Program.idBBregistro) + ";"; 
            cmd = new OleDbCommand(sql, cn);
            da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "nacimiento");
            if (ds.Tables["nacimiento"].Rows.Count > 0)
            {
                label5.Text = ds.Tables["nacimiento"].Rows[0]["nacimiento"].ToString();
            }




            



        // desde aca viene e
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

          //ACA SE DEBERIA ACTUALIZAR EL NOMBRE EN LA BASE DE DATOS Y QUE SE GUARDE AHÍ EN EL LABEL4. LO MISMO CON LA FECHA DE NACIMIENTO 
          //  Y QUE SE GUARDE EN EL LABEL5
            textBox1.Visible = false;
            label4.Visible = true;

            

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

        private void label4_Click(object sender, EventArgs e)
        {

            textBox1.Visible = true;
            textBox1.Text = Program.nombre[Program.indice-1];
            label4.Visible = false; 
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            formperfil perfil = new formperfil();
            perfil.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            formperfil perfil = new formperfil();
            perfil.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
