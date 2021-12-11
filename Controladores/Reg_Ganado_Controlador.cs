using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SG.Modelos;
using SG.Vistas;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace SG.Controladores
{
    class Reg_Ganado_Controlador
    {
        public void btn_guardar_Click(String arete, String peso, String sexo, String preciokilo, String animal, String color, String edad, String importe, DateTime Fechai, DateTime Fechar)
        {
            
            string Fechaingreso = Fechai.Date.ToString("MM/dd/yyyy");
            string Fecharegistro = Fechar.Date.ToString("MM/dd/yyyy");
            if (arete == "" || peso== "" || sexo== "" || preciokilo== null || animal=="" || color== "" || edad=="" || importe== null)
            {
                MessageBox.Show("Debe llenar los campos necesarios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else { 
            try
            {

                SqlCommand codigo;
                codigo = new SqlCommand("Insert Into GANADO (arete,animal,fecha_ingreso,color,precio_kilo,fecha_registro,edad,importe,Sexo,peso_inicial) Values ('" + arete + "','" + animal + "','" + Fechaingreso + "','" + color + "','" + preciokilo + "','" + Fecharegistro + "','" + edad + "','" + importe + "','" + sexo + "','" + peso + "')", Conexion.Conectar());
                codigo.ExecuteNonQuery();
                codigo.Dispose();
                MessageBox.Show("Registro realizado con exito");



                }
            catch (SqlException ex)
            {

                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            }

        }
    }
}
