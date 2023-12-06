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
    public partial class FORMSINUTILIDADSOLOPANEL : Form
    {
        /* const string Usuario = "belusaire07@gmail.com";
        const string Contra = "111"; 

        const string connectionString = "YOUR_CONNECTION_STRING_HERE";
        const string invariant = "YOUR_INVARIANT";
        var silo = new HostBuilder()
            .UseOrleans(builder =>
            {
                builder.UseAdoNetReminderService(options =>
                {
                    options.ConnectionString = connectionString; // Redacted
            options.Invariant = invariant;
                });
            })
            .Build(); */

        public FORMSINUTILIDADSOLOPANEL()
        {
            InitializeComponent();
        }

        private void panelCITMED_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttoninsesion_Click(object sender, EventArgs e)
        {
            //panel1.Visible = true; 


        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void FORMSINUTILIDADSOLOPANEL_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
          //  label2.Text = ("Fecha seleccionada:  " + dateTimePicker1.Text);
        }

        private void button9_Click(object sender, EventArgs e)
        {
           // panel2.Visible = true;
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = true; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = false; 
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            formhijoiniciar hijo = new formhijoiniciar();
            hijo.Show();
            this.Hide(); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            formrecuerdo recuerdo = new formrecuerdo();
            recuerdo.Show();
            this.Hide();

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = true; 
        }

        private void button10_Click(object sender, EventArgs e)
        {
            panelnota.Visible = false; 
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panelrec.Visible = true; 
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            textBox3.Visible = true; 
        }

        private void button13_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            textBox3.Visible = false;
            panelrec.Visible = false; 
        }

        private void button15_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            textBox3.Visible = false;
            panelrec.Visible = false;

        }

        private void button14_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            textBox3.Visible = false;
            panelrec.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panelnota.Visible = true;
            panelmedicamento.Visible = false;
            panelcitamedica.Visible = false;
            panelvacunas.Visible = false;

            groupBox1.Visible = false; 

            string fecha = dateTimePicker1.Text;
            label45.Text = fecha;
        }

        private void panelnota_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            panelcitamedica.Visible = true;
            panelvacunas.Visible = false;
            panelnota.Visible = false;
            panelmedicamento.Visible = false;

            groupBox1.Visible = false; 
            
            string fechamed = dateTimePicker1.Text;
            label2.Text = fechamed; 
        }

        private void button20_Click(object sender, EventArgs e)
        {
            panelcitamedica.Visible = false; 
        }

        private void button11_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true; 
        }

        private void buttonguardarcit_Click(object sender, EventArgs e)
        {
            panelrec.Visible = true; 
        }

        private void button17_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true; 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            panelvacunas.Visible = true;
            panelmedicamento.Visible = false;
            panelcitamedica.Visible = false;
            panelnota.Visible = false;

            groupBox1.Visible = false; 

            string fechavac= dateTimePicker1.Text;
            label2.Text = fechavac;


        }

        private void button19_Click(object sender, EventArgs e)
        {
            panelvacunas.Visible = false; 

        }

        private void button21_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true; 
        }

        private void buttonguardarvac_Click(object sender, EventArgs e)
        {
            panelrec.Visible = true; 
        }

        private void button26_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true; 
        }

        private void buttonguardarmed_Click(object sender, EventArgs e)
        {
            panelrec.Visible = true; 
        }

        private void button25_Click(object sender, EventArgs e)
        {
            panelmedicamento.Visible = false; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panelmedicamento.Visible = true;
            panelnota.Visible = false;
            panelcitamedica.Visible = false;
            panelvacunas.Visible = false;

            groupBox1.Visible = false; 

            string fechamedi = dateTimePicker1.Text;
            label4.Text = fechamedi;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = false;
            groupBox1.Visible = false; 
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = false; 
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            panelvacunas.Visible = false; 
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            panelnota.Visible = false; 
        }

        private void button13_Click_1(object sender, EventArgs e)
        {
            groupBox2.Visible = false; 
        }

        private void button19_Click_1(object sender, EventArgs e)
        {
            REC.Visible = true; 
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void button15_Click_1(object sender, EventArgs e)
        {
            panelrec.Visible = true; 
        }

        private void button14_Click_2(object sender, EventArgs e)
        {
            panelnota.Visible = false; 
        }

        private void panelvacunas_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button12_Click_1(object sender, EventArgs e)
        {
            panelvacunas.Visible = true; 
        }

        private void button18_Click(object sender, EventArgs e)
        {
            panelmedicamento.Visible = false; 
        }

        private void button25_Click_1(object sender, EventArgs e)
        {
            comboBox1.Visible = true;
            textBox7.Visible = true; 
        }

        private void button18_Click_1(object sender, EventArgs e)
        {
            panelmedicamento.Visible = false; 
        }

        private void button19_Click_2(object sender, EventArgs e)
        {
            REC.Visible = true; 
        }

        private void button29_Click(object sender, EventArgs e)
        {
            
        }



        /*  public static void EnviarCorreo(StringBuilder Mensaje, DateTime FechaEnvio, string Para, string Asunto, out string Error)
          {
              Error = "";
              try
              {
                  Mensaje.Append(Environment.NewLine);
                  Mensaje.Append(string.Format("El día {0:dd/MM/yyyy} a las {0:HH:mm} hrs", FechaEnvio));
                  Mensaje.Append(Environment.NewLine);
                  MailMessage mail = new MailMessage();
                  mail.To.Add(Para);
                  mail.Subject = Asunto;
                  mail.Body = Mensaje.ToString;
                  SmtpClient smtp = new SmtpClient("smtp.gmail.com");
                  smtp.Port = 587;
                  smtp.UseDefaultCredentials = false;
                  smtp.Credentials = new System.Net.NetworkCredential(Usuario, Contra);
                  smtp.EnableSsl = true;
                  smtp.Send(mail);
                  Error = "Éxito";
                  MessageBox.Show(Error); 
              }
              catch(Exception ex)
              {
                  Error = ("Error: " + ex.Message); 
                  return;
              }
          } */

    }
}
