﻿using System;
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
    public partial class forminsesion : Form
    {
        string sql;
        OleDbConnection cn = new OleDbConnection();

        OleDbCommand cmd;
        OleDbDataAdapter da;
        DataSet ds = new DataSet();
        OleDbDataReader reader;
        bool existe;

         public string Contra; 
         public string usuario; 
        public forminsesion()
        {
            InitializeComponent(); 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void buttoninsesion_Click(object sender, EventArgs e)
        {
            formhijoiniciar hi = new formhijoiniciar();
            hi.Show(); 
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
        
        }

        private void forminsesion_Load(object sender, EventArgs e)
        {
           cn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=./proyecto111.accdb;";

        }

        private void button2_Click_1(object sender, EventArgs e)
        {


            usuario = textBox1.Text;
            Contra = textBox2.Text;
            try
            {
                cn.Open();

                sql = "SELECT nombre,[contraseña]  FROM registro WHERE nombre = '" + usuario + "' and [contraseña] = '" + Contra + "' ";
                cmd = new OleDbCommand(sql, cn);
                reader = cmd.ExecuteReader();
                existe = reader.HasRows;

                cn.Close();

                if (existe)
                {
                    cn.Open();

                    sql = "SELECT [idUser] FROM registro WHERE nombre = '" + usuario + "' AND [contraseña] = '" + Contra + "'";
                    OleDbCommand cmdSelect = new OleDbCommand(sql, cn);
                    da = new OleDbDataAdapter(cmdSelect);
                    da.Fill(ds, "idUser");

                    if (ds.Tables["idUser"].Rows.Count > 0)
                    {
                        Program.id = ds.Tables["idUser"].Rows[0]["idUser"].ToString();
                    }

                    cn.Close();

                    MessageBox.Show("bienvenid@ " + textBox1.Text + "!");
                    formhijoiniciar hiniciar = new formhijoiniciar();
                    hiniciar.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("por favor revise su contraseña o usuario, no existe registro congrruente");
                    return;
                }
            


                
            
             
            }
            
            catch (Exception exp){

             MessageBox.Show(exp.ToString());
            }

            finally
            {
                cn.Close(); 
            }

            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formregistrar registro = new formregistrar();
            registro.Show();
            this.Hide(); 
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            acercadelbebe hiniciar = new acercadelbebe();
            hiniciar.Show();
            this.Hide();
        }
    }
}
