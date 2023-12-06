using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBebe
{
    public partial class nombrebebe : Form
    {
        public nombrebebe()
        {
            InitializeComponent();
            string nombre = textBox1.Text;
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            
        }

        private void Nombrebebe_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            cuannaciobb cnbb = new cuannaciobb();
            cnbb.Show();
            this.Hide(); 

            string nombre = textBox1.Text;
            Program.nombre.Add(nombre); 

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
