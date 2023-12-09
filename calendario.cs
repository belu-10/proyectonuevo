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
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelvacunas.Visible = true; 

            panelnota.Visible = false;
            panelmedicamento.Visible = false;
            panelcitamedica.Visible = false; 

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

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            string fecha = dateTimePicker1.Text;
            label1.Text = (fecha);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button13_Click(object sender, EventArgs e)
        {
            
        }

        private void button14_Click(object sender, EventArgs e)
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

            string fecha45 = dateTimePicker1.Text;
            label45.Text = fecha45;

            
            //esta biem
        }

        private void button16_Click(object sender, EventArgs e)
        {
            
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

            string fechamedicamento = dateTimePicker1.Text;
            label1.Text = fechamedicamento;

            //ESTÁ BIEN
        }

        private void button19_Click(object sender, EventArgs e)
        {

        }

        private void button22_Click(object sender, EventArgs e)
        {
           
        }

        private void button23_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panelmedicamento_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelvacunas_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void panelcitamedica_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelnota_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            panelmedicamento.Hide(); 
        }

        private void buttonguardarmed_Click(object sender, EventArgs e)
        {
           
        }

        private void button12_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
             
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonguardarnot_Click(object sender, EventArgs e)
        {
                    }

        private void buttonguardarvac_Click(object sender, EventArgs e)
        {
            ; 
        }

        private void buttonguardarcita_Click(object sender, EventArgs e)
        {
            ////panelrec.Visible = true; 
        }

        private void button13_Click_2(object sender, EventArgs e)
        {
; 
        }

        private void button10_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button15_Click_2(object sender, EventArgs e)
        {
           
        }

        private void button20_Click_1(object sender, EventArgs e)
        {
           
        }

        private void buttonguardarvac_Click_1(object sender, EventArgs e)
        {
            ; 
        }

        private void buttonguardarnot_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_3(object sender, EventArgs e)
        {
            panelnota.Hide(); 
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button18_Click_2(object sender, EventArgs e)
        {
            panelmedicamento.Visible = false; 
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            panelrecordatorio.Visible = true;

            //ACA MEDICAMENTO chequear
        }

        private void button28_Click(object sender, EventArgs e)
        {
           
        }

        private void button27_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_3(object sender, EventArgs e)
        {
            panelnota.Visible = false; 
        }

        private void button15_Click_3(object sender, EventArgs e)
        {
            panelrecordatorio.Visible = true;

            //aca nota CHEQUEAR
        }

        private void panelnota_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button20_Click_2(object sender, EventArgs e)
        {
            panelvacunas.Visible = false; 

            //ACA VACUNAS
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
            panelvacunas.Visible = false;
        }

        private void buttonguardarcit_Click(object sender, EventArgs e)
        {
            panelrecordatorio.Visible = true; 

         /*   if (panelrecordatorio.Visible = true)
            {
                panelmedicamento.Visible = false;
                panelnota.Visible = false;
                panelvacunas.Visible = false; 
                

            }; */



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
        }
    }
}

