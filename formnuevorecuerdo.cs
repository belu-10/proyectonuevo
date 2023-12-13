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
    public partial class formnuevorecuerdo : Form

    {
        string sql;
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        OleDbDataReader reader;
        public formnuevorecuerdo()

        {
            InitializeComponent();

            pictureBox2.ImageLocation = (Program.foto[Program.indice-1]);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de imagen|.jpg;.jpeg;.png;.gif;.bmp|Todos los arcivos|.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string rutaImagen = openFileDialog.FileName;
                    pictureBox1.Image = Image.FromFile(rutaImagen);
                    Program.rutaFoto = rutaImagen; 
                }
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            string titulo = textBox1.Text;
          //  Program.titulo.Add(titulo);

            string fecha = dateTimePicker1.Text;
           // Program.fecha.Add(fecha);

            string album = pictureBox1.ImageLocation;
          //  Program.album.Add(album);

            try
            {
                cn.Open();
                sql = "INSERT INTO foto (pie de imagen, imagenURL, fecha) VALUES ('" + titulo + "', '"+Program.rutaFoto+"', '"+fecha+"')";
                cmd = new OleDbCommand(sql, cn);
                cmd.ExecuteNonQuery(); 

            }
            finally
            {
                cn.Close(); 
                Formalbum albumm = new Formalbum();
                albumm.Show();
                this.Hide();
            }
            string titulo = textBox1.Text;
            Program.titulo.Add(titulo);

            string fecha = dateTimePicker1.Text;
            Program.fecha.Add(fecha);

            string album = pictureBox1.ImageLocation;
            Program.album.Add(album);

        

        }

        private void formnuevorecuerdo_Load(object sender, EventArgs e)
        {
         cn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =./proyecto111.accdb;";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Formalbum albumm = new Formalbum();
            albumm.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            perfilhijo perfil = new perfilhijo();
            perfil.Show();
            this.Hide();
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Formalbum album = new Formalbum();
            album.Show();
            this.Hide(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
