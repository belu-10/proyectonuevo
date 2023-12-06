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
    public partial class formelegir : Form
    {
        public formelegir()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            nombrebebe nb = new nombrebebe();
            nb.Show();
        }

        private void formelegir_Load(object sender, EventArgs e)
        {

        }
    }
}
