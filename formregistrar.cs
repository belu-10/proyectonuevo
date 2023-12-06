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
    public partial class formregistrar : Form
    {
        public string Contra;
        public string ConfirmarContra;
        public string usuario = "";
        public string mail = "";
        public string nacio = "";
        public string bebe = "";
        public int paleta = 0;
        string sql;

        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd;
        public formregistrar()
        {
            InitializeComponent();
        }

        private void formregistrar_Load(object sender, EventArgs e)
        {
                    cn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =./proyecto11.accdb;";       

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string nombre = textBox1.Text;
            string correo = textBox2.Text; 
            string contra = textBox3.Text;
            try
            {
                cn.Open();
            sql = "INSERT INTO registro ([contraseña], nombre, mail, [nacio el hijo?], bebe, [paleta (fk)]) VALUES ('" + Contra + "', '" + usuario + "', '" + mail + "' , '" + nacio + "' , '" + bebe + "' , " + paleta + ")"; sql = "INSERT INTO registro ([contraseña], nombre, mail, [nacio el hijo?], bebe, [paleta (fk)]) VALUES ('" + Contra + "', '" + usuario + "', '" + mail + "' , '" + nacio + "' , '" + bebe + "' , " + paleta + ")";               
                OleDbCommand com = new OleDbCommand(sql, cn);
                cmd.ExecuteNonQuery();
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
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            forminsesion iniciar = new forminsesion(); 
            iniciar.Show();
            this.Hide(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            acercadelbebe acerca = new acercadelbebe();
            acerca.Show(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            nombrebebe nombre = new nombrebebe();
            nombre.Show();

        }
    }
}
