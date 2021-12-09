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
namespace SG.Controladores
{
    public class Login_Controlador
    {
        public bool flag = true;
        public void LogIn(String Usuario, String Password)
        {
            
            Ganado.LogIn log = new Ganado.LogIn();
            SqlCommand codigo;
            codigo = new SqlCommand("SELECT * FROM USUARIO WHERE idusuario = '" + Usuario + "' and contraseña = '" + Password + "'", Conexion.Conectar());
            SqlDataReader leer = codigo.ExecuteReader();
            if (leer.Read())
            {
               
                flag = true;
               
            }
            else
            {
                flag = false;
             
            }
        }
    }
}
