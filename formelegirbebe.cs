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
    public partial class formelegirbebe : Form
    {
        string sql;
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd;
        public formelegirbebe()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        { 

            formhijoiniciar iniciar = new formhijoiniciar();
            iniciar.Show();
            this.Hide(); 
            



        }

        private void button7_Click(object sender, EventArgs e)
        {
            string foto5 = "C:/Users/48796306//Downloads//Group (6).png";
           //  Program.foto.Add(foto5);

          
            try {
                cn.Open();
                sql = "UPDATE bebe SET (avatarRuta) = '" + foto5 + "' WHERE id = '"+Program.idBBregistro+"'  ";
                MessageBox.Show("Has seleccionado un avatar!");
            } 
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally {
                cn.Close();
                
            }
            // guardar como vos haces en las listas, en la base de datos la url 
        }

        private void formelegirbebe_Load(object sender, EventArgs e)
        {
            cn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =./proyecto111.accdb;";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string foto1 = "C:/Users/48796306//Downloads//Clip path group.png";
            //Program.foto.Add(foto1);
            try
            {
                cn.Open();
                sql = "UPDATE bebe SET (avatarRuta) = '" + foto1 + "' WHERE id = '" + Program.idBBregistro + "'  ";
                MessageBox.Show("Has seleccionado un avatar!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally
            {
                cn.Close();

            }
        }

        private void buttonft2_Click(object sender, EventArgs e)
        {
            string foto2 = "C:/Users/48796306//Downloads//Group (7).png";
            // Program.foto.Add(foto2);
            try
            {
                cn.Open();
                sql = "UPDATE bebe SET (avatarRuta) = '" + foto2 + "' WHERE id = '" + Program.idBBregistro + "'  ";
                MessageBox.Show("Has seleccionado un avatar!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally
            {
                cn.Close();

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string foto3 = "C:/Users/48796306//Downloads//Group (4).png";
           // Program.foto.Add(foto3);
            try
            {
                cn.Open();
                sql = "UPDATE bebe SET (avatarRuta) = '" + foto3 + "' WHERE id = '" + Program.idBBregistro + "'  ";
                MessageBox.Show("Has seleccionado un avatar!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally
            {
                cn.Close();

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string foto4 = "C:/Users/48796306//Downloads//Group (5).png";
            try
            {
                cn.Open();
                sql = "UPDATE bebe SET (avatarRuta) = '" + foto4 + "' WHERE id = '" + Program.idBBregistro + "'  ";
                MessageBox.Show("Has seleccionado un avatar!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally
            {
                cn.Close();

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            cuannaciobb nacio = new cuannaciobb();
            nacio.Show();
            this.Hide(); 

        }

        private void button9_Click(object sender, EventArgs e)
        {
            string foto6 = "C:/Users/48796306//Downloads//Group (8).png";
            // Program.foto.Add(foto6);
            try
            {
                cn.Open();
                sql = "UPDATE bebe SET (avatarRuta) = '" + foto6 + "' WHERE id = '" + Program.idBBregistro + "'  ";
                MessageBox.Show("Has seleccionado un avatar!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally
            {
                cn.Close();

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string foto7 = "C:/Users/48796306//Downloads//Group (9).png";
            //  Program.foto.Add(foto7);
            try
            {
                cn.Open();
                sql = "UPDATE bebe SET (avatarRuta) = '" + foto7 + "' WHERE id = '" + Program.idBBregistro + "'  ";
                MessageBox.Show("Has seleccionado un avatar!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally
            {
                cn.Close();

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            string foto8 = "C:/Users/48796306//Downloads//Group (10).png";
            // Program.foto.Add(foto8);
            try
            {
                cn.Open();
                sql = "UPDATE bebe SET (avatarRuta) = '" + foto8 + "' WHERE id = '" + Program.idBBregistro + "'  ";
                MessageBox.Show("Has seleccionado un avatar!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally
            {
                cn.Close();

            }
        }
    }
}
