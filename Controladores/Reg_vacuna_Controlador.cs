using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using SG.Modelos;
using System.Windows.Forms;
namespace SG.Controladores
{
    class Reg_vacuna_Controlador
    {
        public void regvacuna(String arete, String idvacuna, String nombre, String aplicador, String fechapl, String fechareg, String observacion)
        {


            if ((arete == "") || (idvacuna == "") || (nombre == "") || (aplicador == ""))
            {
                MessageBox.Show("Llenas los campos necesarios", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SG.reg_vacuna regva = new SG.reg_vacuna();
                    SqlCommand comando;
                    comando = new SqlCommand("INSERT INTO VACUNA (id_ganado,id_vacuna,nombre_vacuna,aplicador,aplicacion,registro,observaciones) VALUES (" + arete + ",'" + idvacuna + "'," + "'" + nombre + "'," + "'" + aplicador + "'," + "'" + fechapl + "'," + "'" + fechareg + "'," + "'" + observacion + "'" + ")", Conexion.Conectar());
                    SqlDataReader leer = comando.ExecuteReader();
                    MessageBox.Show("Registro de vacuna agregado", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    idvacuna = " ";
                    nombre = " ";
                    aplicador = " ";
                    observacion = " ";


                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Conexion.Desconectar();
                }
            }
        }
    }
}
