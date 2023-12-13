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
    public partial class nombrebebe : Form
    {
        string nombre;
        int idInt; 
        string sql;
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd;

        public nombrebebe()
        {
            InitializeComponent();
             nombre = textBox1.Text;

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Nombrebebe_Load(object sender, EventArgs e)
        {
        

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =./proyecto111.accdb;";

            nombre = textBox1.Text;
            Program.nombre.Add(nombre);
            try
            {
                cn.Open();
                idInt = Convert.ToInt32(Program.id); 
                sql = "INSERT INTO bebe (nombre, idUsuario) VALUES ('" + nombre + "', '"+idInt+"') ";
                OleDbCommand cmd = new OleDbCommand(sql, cn);
                cmd.ExecuteNonQuery();
                cn.Close(); 
            }
            finally
            {
                cuannaciobb cnbb = new cuannaciobb();
                cnbb.Show();
                this.Hide();
            }
           

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            formhijoiniciar hijo = new formhijoiniciar();
            hijo.Show();
            this.Hide(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
