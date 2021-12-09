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
    public class Reg_pesaje_Controlador
    {

        public bool flag = true;
        public void regpesaje(String arete, String operador, String peso, String fechapeso, String fecharegistro)
        {

            SG.reg_pesaje regpeso = new SG.reg_pesaje();
            SqlCommand comando;
            comando = new SqlCommand("INSERT INTO PESAJE (id_ganado,operador,peso_act,registro,fparto) VALUES (" + arete + ",'" + operador + "'," + peso + ",'" + fechapeso + "'," + "'" + fecharegistro + "'" + ")", Conexion.Conectar());
            SqlDataReader leer = comando.ExecuteReader();
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
