using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb; 


namespace ProyectoBebe
{
    public partial class formhijoiniciar : Form
    {
        string sql;
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        OleDbDataReader reader;


        public formhijoiniciar()
        {
            
            InitializeComponent();
            cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./proyecto111.accdb;";
            string idProgramString = Program.id;
            int idUsuario = Convert.ToInt32(idProgramString);
            string sql = "SELECT nombre, avataRuta  FROM bebe WHERE idUsuario  =  "+idUsuario+" " ;

            OleDbCommand cmd = new OleDbCommand(sql, cn);
            da = new OleDbDataAdapter(cmd);
            da.Fill(ds, "hijos");

            for (int i = 0; i < ds.Tables["hijos"].Rows.Count ; i++)
            {
                string avatar = ds.Tables["hijos"].Rows[i].Field<String>("avataRuta");
                string nombre = ds.Tables["hijos"].Rows[i].Field<String>("nombre");
                Program.nombre.Add(nombre);
                Program.foto.Add(avatar); 
            }
                for (Program.indice = 0; Program.indice < Program.nombre.Count; Program.indice++)
                {
                    ucuser user = new ucuser();
                    user.Parent = flowLayoutPanel1;
                    user.Click += user_Click;
                }

            }

        

        private void user_Click(object sender, EventArgs e)
        {
            acercadelbebe acerca = new acercadelbebe();
            acerca.Show(); 
            this.Hide();
            Cursor = Cursors.Hand;

        }

        private void user_MouseEnter(object sender, EventArgs e)
        {
            // Cambiar el cursor al pasar sobre el botón
            Cursor = Cursors.Hand;
        }

        private void user_MouseLeave(object sender, EventArgs e)
        {
            // Cambiar el cursor al pasar sobre el botón
            Cursor = Cursors.Default;
        }



        private void button2_Click(object sender, EventArgs e)
        {
// NADA DE ESRO FUNCIONA ASI QUE IGNORAR!!!!!!!!!!!!!!!!!!!!!!!!

            /*   DataSet ds = new DataSet();
              int cantidad = ds.Tables[""].Rows.Count; */

            List<string> listadestringnombre = new List<string>();
            List<string> listadestringfoto = new List<string>();
            listadestringnombre.Add("Juan");
            string bebejuan = "C://Users/belus//Downloads/ropa-bebe.jpg";
            listadestringfoto.Add(bebejuan);

            for (int i = 0; i < listadestringnombre.Count; i++)
            {
                ucuser uc = new ucuser();
                // uc 

                // .Show(listadestringfoto[0]);  
            }

            /* for (int i = 0; i < listadestringnombre.Count; i++)
             {
                 ucuser user = new ucuser();
                 user.Show(); 
             } */
        }

        private void formhijoiniciar_Load(object sender, EventArgs e)
        {
     


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {


        }

        private void button21_Click(object sender, EventArgs e)
        {
            nombrebebe nombre = new nombrebebe();
            nombre.Show();
            this.Hide(); 







            /* DataSet ds = new DataSet();
            for (int i = 0; i < ds.Tables[""].Rows.Count; i++)
             {
                 ucuser user = new ucuser();
                user.ImagenAv = "";
                user.Nombre = "";

                 flowLayoutPanel1.Controls.Add(user);
             }
             */


            /*  string rutaImagen = "C://Users/48796306//Downloads/descarga.jpeg";

            
            using (Image imagen = Image.FromFile(rutaImagen))
            {
                
                using (MemoryStream ms = new MemoryStream())
                {
                    imagen.Save(ms, imagen.RawFormat);
                    byte[] byteImagen = ms.ToArray();
                    string base64Imagen = Convert.ToBase64String(byteImagen);
                    MessageBox.Show(base64Imagen.ToString());
                }
            } */

            /*string nombre_bebe = "Juan";
            listadestringnombre.Add(nombre_bebe);
            listadestringfoto.Add(bebejuan);
            ucuser u_c = new ucuser(); 
            panel1.Controls.Add(u_c);
            panel1.BackgroundImage = listadestringfoto[0]; 
            panel1.Visible = true;  */
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            acercadelbebe acercadel = new acercadelbebe();
            acercadel.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Click(object sender, PaintEventArgs e)
        {
            acercadelbebe acercadel = new acercadelbebe();
            acercadel.Show();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            acercadelbebe acerca = new acercadelbebe();
            acerca.Show(); 
        }

        private void button1_Click_4(object sender, EventArgs e)
        {
            forminsesion inicio = new forminsesion();
            inicio.Show();
            this.Hide(); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }
    }
}