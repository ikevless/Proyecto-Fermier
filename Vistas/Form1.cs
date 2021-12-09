using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using SG.Modelos;
using Ganado;

namespace Ganado
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void LogIn_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbl_pass_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_iniciar_Click(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        private void gunaButton1_Click_1(object sender, EventArgs e)
        {

            SqlCommand codigo;
            codigo = new SqlCommand("SELECT * FROM USUARIO WHERE idusuario = '" + textBox2.Text + "' and contraseña = '" + textBox1.Text + "'", Conexion.Conectar());
            SqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
                this.Hide();
                MessageBox.Show("Inicio de sesion exitoso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La cuenta y/o contraseña son incorrectos.", "Información de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            

            


        }
    }
}
