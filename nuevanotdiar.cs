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
    public partial class nuevanotdiar : Form
    {
        string sql;
        OleDbConnection cn = new OleDbConnection();

        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        OleDbDataReader reader;

        public nuevanotdiar()
        {
            InitializeComponent();

            pictureBox2.ImageLocation = (Program.foto[Program.indice-1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string nota = textBox1.Text;
            Program.nota.Add(nota);

            string fechadiaro = dateTimePicker1.Text;
            Program.fechadiario.Add(fechadiaro);
            try {
                sql = "INSERT INTO diario(nota, fecha,[id bebe (fk)] VALUES ('"+nota+"', '"+fechadiaro+"', '"+Program.idBebeIniciado+"') ";
                cmd = new OleDbCommand(sql, cn);
                cmd.ExecuteNonQuery(); 
            }
            finally
            {
                cn.Close(); 

                formdiario diario = new formdiario();
                diario.Show();
                this.Hide();

            }
        


            formdiario diario = new formdiario();
            diario.Show();
            this.Hide(); 
        }

        private void nuevanotdiar_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            formperfil perfil = new formperfil();
            perfil.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formdiario diar = new formdiario();
            diar.Show();
            this.Hide(); 
        }
    }
}
