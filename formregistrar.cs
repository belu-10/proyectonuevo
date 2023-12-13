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
        public string usuario; 
        public string correo; 

        string sql;
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        OleDbDataReader reader;
        public formregistrar()
        {
            InitializeComponent();
        }

        private void formregistrar_Load(object sender, EventArgs e)
        {
                    cn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =./proyecto111.accdb;";       

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            
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
            usuario = textBox1.Text;
            correo = textBox2.Text;
            Contra = textBox3.Text;
            try
            {
                cn.Open();

                sql = "INSERT INTO registro ([contraseña], nombre, mail) VALUES ('" + Contra + "', '" + usuario + "', '" + correo + "')";
                OleDbCommand cmdInsert = new OleDbCommand(sql, cn);
                cmdInsert.ExecuteNonQuery();

                sql = "SELECT [idUser] FROM registro WHERE nombre = '" + usuario + "' AND [contraseña] = '" + Contra + "'";
                OleDbCommand cmdSelect = new OleDbCommand(sql, cn);
                da = new OleDbDataAdapter(cmdSelect);
                da.Fill(ds, "idUser");

                if (ds.Tables["idUser"].Rows.Count > 0)
                {
                    Program.id = ds.Tables["idUser"].Rows[0]["idUser"].ToString();
                }
            }
            catch (OleDbException ex)
            {
                Console.WriteLine($"Error de OleDb: {ex.Message}");
            }
            finally
            {
                cn.Close();
                MessageBox.Show("Registro correctamente");
                nombrebebe nombre = new nombrebebe();
                nombre.Show();
                this.Hide();
            }

        }

    }
}

