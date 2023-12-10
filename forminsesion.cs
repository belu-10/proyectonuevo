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
    public partial class forminsesion : Form
    {
        string sql;
        OleDbConnection cn = new OleDbConnection();

        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
     
        public forminsesion()
        {
            InitializeComponent(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttoninsesion_Click(object sender, EventArgs e)
        {
            formhijoiniciar hi = new formhijoiniciar();
            hi.Show(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void forminsesion_Load(object sender, EventArgs e)
        {
           cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./proyecto11.accdb;";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
         
            try {
                cn.Open(); 

            }
            
            catch (Exception exp){

             MessageBox.Show(exp.ToString());
            }

            finally {

                formhijoiniciar hiniciar = new formhijoiniciar();
                hiniciar.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formregistrar registro = new formregistrar();
            registro.Show();
            this.Hide(); 
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            calendario hiniciar = new calendario();
            hiniciar.Show();
            this.Hide();
        }
    }
}
