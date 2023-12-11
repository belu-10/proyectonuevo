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
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {  /*
            string nombre = textBox1.Text;
            string contra = textBox2.Text; 
            OleDbConnection cn = new OleDbConnection(connstring);
            try
            {
                cn.Open();
                sql = "INSERT INTO [usuario] (nombre, contraseña) VALUES ('" + nombre + "', '" + contra + "')";
                OleDbCommand com = new OleDbCommand(sql, cn);
                com.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(Convert.ToString(ex));
            }
            finally
            {
                cn.Close();
                MessageBox.Show("Registro correctamente");
            }
         */
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            calendario inicio = new calendario();
            inicio.Show();
            this.Hide();
        }
    }
}
