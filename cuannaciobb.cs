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
    public partial class cuannaciobb : Form
    {
        public static string fecha;

        public cuannaciobb()
        { 
        InitializeComponent();

        }
            


        

            /*string hexColor = "#FF5733"; // Tu color hexadecimal
            Color customColor = ColorTranslator.FromHtml(hexColor); // Convierte el valor hexadecimal en un objeto Color

            dateTimePicker1.CalendarForeColor = customColor; // Cambia el color del texto del calendario
            */
        
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

           string fecha = dateTimePicker1.Text;
           

            
            formelegirbebe elegir = new formelegirbebe();
            elegir.Show();
            this.Hide(); 
        }

        private void cuannaciobb_Load(object sender, EventArgs e)
        {
          //  cn.ConnectionString = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source =./proyecto11.accdb;";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formperfil perfil = new formperfil();
            perfil.Show();
            this.Hide(); 
        }
    }
}
