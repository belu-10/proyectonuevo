using System;
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
    public partial class Formalbum : Form
    {
        public Formalbum()
        {
            InitializeComponent();
            pictureBox2.ImageLocation = (Program.foto[Program.indice - 1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

            for (Program.i = 0; Program.i < Program.titulo.Count; Program.i++)
            {
                ucalbum user = new ucalbum();
                user.Parent = flowLayoutPanel1;
                user.Click += user_Click;
            }
        }

        private void user_Click(object sender, EventArgs e)
        {
            formmomento momento = new formmomento();
            momento.Show();
            this.Hide(); 
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Formalbum_Load(object sender, EventArgs e)
        {
           // DataSet ds = new DataSet();

          //  int cantidad = ds.Tables["..."].Rows.Count;


         //   for (int i = 0; i < cantidad; i++)
            {

              /*  ucalbum uc = new ucalbum();
                uc.Imagen = ds.Tables["...}"].Rows[i]["ImagenBase"].ToString();
                uc.Imagen = "imagen";
                uc.Fecha = "fecha";
                uc.Titulo = "titulo";
                panel1.Controls.Add(uc); */

            }
        }

        private void ucalbum1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            formnuevorecuerdo nuevo = new formnuevorecuerdo();
            nuevo.Show();
            this.Hide(); 


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formperfil perfil = new formperfil();
            perfil.Show();
            this.Hide();
        }
    }

       
    }

