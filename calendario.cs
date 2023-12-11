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
    public partial class calendario : Form
    {

        public calendario()
        {
            InitializeComponent();
            for (Program.iglu = 0; Program.iglu < Program.fechapanel.Count; Program.iglu++)
            {
                ucpanelcalendar user = new ucpanelcalendar(flowLayoutPanel1);
                user.Parent = flowLayoutPanel1;
                user.Click += user_Click;

            }

        }

        private void user_Click(object sender, EventArgs e)
        {
            

        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelvacunas.Visible = true; 

            panelnota.Visible = false;
            panelmedicamento.Visible = false;
            panelcitamedica.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;

            string fecha3 = dateTimePicker1.Text;
            label3.Text = fecha3;

            //NO FUNCIONA TODAVIA ES DE VACUNAS
        }

        private void calendario_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
           panelcitamedica.Visible = true;

            panelnota.Visible = false;
            panelmedicamento.Visible = false;
            panelvacunas.Visible = false;
            panelrecordatorio.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;

            string fecha = dateTimePicker1.Text;
            label2.Text = fecha;


            //ESTA BIEN ES DE CITA MEDICA
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
           /*  panelnota.Visible = true;
            panelcitamedica.Visible = false;
            panelmedicamento.Visible = false;
            panelvacunas.Visible = false; */
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            panelnota.Visible = true;

            panelmedicamento.Visible = false;
            panelvacunas.Visible = false;
            panelcitamedica.Visible = false;
            panelrecordatorio.Visible = false; 
            groupBox1.Visible = false;
            groupBox2.Visible = false; 

            string fecha45 = dateTimePicker1.Text;
            label45.Text = fecha45;

            
            //esta biem
        }

        private void button15_Click(object sender, EventArgs e)
        {
            panelnota.Visible = false;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            panelmedicamento.Visible = true;

            panelnota.Visible = false;
            panelvacunas.Visible = false;
            panelcitamedica.Visible = false;
            panelrecordatorio.Visible = false;
            groupBox1.Visible = false;
            groupBox2.Visible = false;

            string fechamedicamento = dateTimePicker1.Text;
            label1.Text = fechamedicamento;

            //ESTÁ BIEN
        }

        private void button23_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }
        private void button17_Click(object sender, EventArgs e)
        { 
        }

        private void buttonguardarcita_Click(object sender, EventArgs e)
        {
        }


        private void button10_Click_3(object sender, EventArgs e)
        {
        }


        private void button18_Click_2(object sender, EventArgs e)
        {
            panelmedicamento.Visible = false; 
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
           

            //ACA MEDICAMENTO chequear
        }

        private void button14_Click_3(object sender, EventArgs e)
        {
            panelnota.Visible = false; 
        }

        private void button15_Click_3(object sender, EventArgs e)
        {
            panelrecordatorio.Visible = true;
            panelrecordatorio.BringToFront(); 

            string dia = dateTimePicker1.Text;
            Program.fechapanel.Add(dia);

            string nota = "Nota";
            Program.especialidad.Add(nota);

            string ex = textBox1.Text;
            Program.extra.Add(ex); 
            //aca nota CHEQUEAR
        }

        private void panelnota_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click_2(object sender, EventArgs e)
        {
            panelrecordatorio.Visible = true;
            panelrecordatorio.BringToFront();

            string dia = dateTimePicker1.Text;
            Program.fechapanel.Add(dia);

            string vac = "Vacunas";
            Program.especialidad.Add(vac);

            string extr = textBox3.Text;
            Program.extra.Add(extr);
            //ACA VACUNAS
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            panelvacunas.Visible = false;
        }

        private void buttonguardarcit_Click(object sender, EventArgs e)
        {
            panelrecordatorio.Visible = true;
            panelrecordatorio.BringToFront();

            string dia = dateTimePicker1.Text;
            Program.fechapanel.Add(dia);

            string cita = "Cita medica"; 
            Program.especialidad.Add(cita);

            string ext = textBox2.Text;
            Program.extra.Add(ext);
            //ACA CITA MEDICA
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            panelcitamedica.Visible = false;
            panelrecordatorio.Visible = false;
        }

        private void button27_Click_1(object sender, EventArgs e)
        {
            panelrecordatorio.Visible = false;
        }

        private void button30_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = true;
            textBox9.Visible = true; 
        }

        private void button28_Click_1(object sender, EventArgs e)
        {
            panelrecordatorio.Visible = false;
        }

        private void button29_Click(object sender, EventArgs e)
        {
            panelrecordatorio.Visible = false;

            panelvacunas.Visible = false; 
            panelnota.Visible = false;
            panelmedicamento.Visible = false;
            panelcitamedica.Visible = false;
        }

        private void button16_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button89_Click(object sender, EventArgs e)
        {
            panelrecordatorio.Visible = true;
            panelrecordatorio.BringToFront();

            string dia = dateTimePicker1.Text;
            Program.fechapanel.Add(dia);

            string medicamento = "Medicamento";
            Program.especialidad.Add(medicamento);

            string extraa = textBox6.Text;
            Program.extra.Add(extraa);

            //aca medicamento

          
        }

        private void panelvacunas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button28_Click_2(object sender, EventArgs e)
        {
        }

        private void button29_Click_1(object sender, EventArgs e)
        {
         
        }

        private void button30_Click_1(object sender, EventArgs e)
        {
          
        }

        private void button27_Click_2(object sender, EventArgs e)
        {
            
           
        }

        private void label7_Click(object sender, EventArgs e)
        {


        }

        private void panelcitamedica_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button29_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button30_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button28_Click(object sender, EventArgs e)
        {
           
        }

        private void button27_Click(object sender, EventArgs e)
        {
            
        }

        private void button30_Click_3(object sender, EventArgs e)
        {
            //BOTON SI QUIERO RECIBIR REC
            comboBox2.Visible = true;
            textBox9.Visible = true;
        }
        private void button29_Click_3(object sender, EventArgs e)
        {
            // BOTON NO QUIERO RECIBIR REC
            panelrecordatorio.Visible = false;
        }
        private void button28_Click_3(object sender, EventArgs e)
        {
            // BOTON GUARDAR REC
            panelrecordatorio.Visible = false;
            comboBox2.Visible = false;
            textBox9.Visible = false;

            panelvacunas.Visible = false;
            panelnota.Visible = false;
            panelmedicamento.Visible = false;
            panelcitamedica.Visible = false;

            for (Program.iglu = 0; Program.iglu < Program.fechapanel.Count; Program.iglu++)
            {
                    ucpanelcalendar user = new ucpanelcalendar(flowLayoutPanel1);
                    user.Parent = flowLayoutPanel1;
                    user.Click += user_Click;
             
            }
        }

        private void button27_Click_3(object sender, EventArgs e)
        {
            // BOTON CANCELAR
            panelrecordatorio.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            formrecuerdo rec = new formrecuerdo();
            rec.Show();
            this.Hide(); 
        }

        private void button8_Click(object sender, EventArgs e)
        {
            formhijoiniciar hijo = new formhijoiniciar();
            hijo.Show();
            this.Hide(); 
        }
    }
}

