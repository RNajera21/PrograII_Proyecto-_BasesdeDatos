using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Security.Cryptography;

namespace PrograII_Proyecto_2_BasesdeDatos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String s = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            var conexion = new SqlConnection(s);
            conexion.Open();
            var comando = new SqlCommand (" INSERT INTO *Tabla* VALUES('" + tid.Text + "', '" + tnombre.Text + "', '" + tposicion.Text + "')", conexion);
            comando.ExecuteNonQuery();
            conexion.Close();      
        }
    }
}
