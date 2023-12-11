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
        string sql;
        OleDbConnection cn = new OleDbConnection();
        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        string diasInsercion;
        string mesesInsercion;
        string añosInsercion; 

        public cuannaciobb()
        { 
        InitializeComponent();
        }
           

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            DateTime fechaseleccionada = dateTimePicker1.Value;

            TimeSpan diferencia = DateTime.Now - fechaseleccionada;

            int años = (int)(diferencia.Days / 365.25); //promedio de días en un año
            Convert.ToString(años); //esta variable es la que se tiene que mostrar en el label1 (form acerca del bb)

            int meses = (int)((diferencia.Days % 365.25) / 30.44); // 30.44 es el promedio de dias en un mes
            Convert.ToString(meses);  //esta variable es la que se tiene que mostrar en el label2 (form acerca del bb)

            int dias = diferencia.Days % 30;
            Convert.ToString(dias); //esta variable es la que se tiene que mostrar en el label3 (form acerca del bb)

          //  diasInsercion = dias;
          //  mesesInsercion = meses;
          //  añosInsercion = años; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Text;
            Program.nacimiento.Add(fecha);

            try {
              //  sql = "UPDATE bebe SET nacimiento = '"+fecha+"' dia = '"+dias +"' mes = '"+meses+"' [año] ='"+ años+"' WHERE"; 
            }
            finally {
                formelegirbebe elegir = new formelegirbebe();
                elegir.Show();
                this.Hide();
            }
        
       


            
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
