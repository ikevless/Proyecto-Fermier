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
        public void regpesaje(String arete, String operador, String peso, String fechapeso, String fecharegistro)
        {

            if ((arete == "") || (operador == "") || (peso == ""))
            {
                MessageBox.Show("Llenas los campos necesarios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SG.reg_pesaje regpeso = new SG.reg_pesaje();
                    SqlCommand comando;
                    comando = new SqlCommand("INSERT INTO PESAJE (id_ganado,operador,peso_act,registro,fparto) VALUES (" + arete + ",'" + operador + "'," + peso + ",'" + fechapeso + "'," + "'" + fecharegistro + "'" + ")", Conexion.Conectar());
                    SqlDataReader leer = comando.ExecuteReader();
                    MessageBox.Show("Pesaje agregado correctamente", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    peso = "";

                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }



        }
    }
}
