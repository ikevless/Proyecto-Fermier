using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace SG.Modelos
{
    class Conexion
    {
        public static SqlConnection Conectar()
        {
            SqlConnection cn = new SqlConnection("server = MSI; database = SG; Integrated Security = true");
            cn.Open();
            return cn;
        }

        public static SqlConnection Desconectar()
        {
            SqlConnection cn = new SqlConnection("server = MSI; database = SG; Integrated Security = true");
            cn.Close();
            return cn;
        }
    }
}
