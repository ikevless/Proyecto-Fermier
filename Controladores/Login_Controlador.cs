using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SG.Modelos;
using SG.Vistas;
using SG;
using Ganado;
using System.Windows.Forms;
namespace SG.Controladores
{
    public class Login_Controlador
    {
        public bool flag = true;
        public void LogIn(String Usuario, String Password)
        {
            
            
            SqlCommand codigo;
            codigo = new SqlCommand("SELECT * FROM USUARIO WHERE idusuario = '" + Usuario + "' and contraseña = '" + Password + "'", Conexion.Conectar());
            SqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
               
                flag = true;
                MessageBox.Show("Inicio de sesion exitoso", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                flag = false;
                MessageBox.Show("La cuenta y/o contraseña son incorrectos.", "Información de cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
