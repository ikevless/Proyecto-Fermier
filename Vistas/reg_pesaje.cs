using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SG.Modelos;
using System.Data.SqlClient;

namespace SG
{
    public partial class reg_pesaje : Form
    {
        public reg_pesaje()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reg_pesaje_Load(object sender, EventArgs e)
        {

        }
    }
}
