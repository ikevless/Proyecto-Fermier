using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG
{
    public partial class MenuOp : Form
    {
        public MenuOp()
        {
            InitializeComponent();
        }

        private void establos1_Load(object sender, EventArgs e)
        {

        }


        private void Btn_regsalop_Click(object sender, EventArgs e)
        {
            reg_salida salida = new reg_salida();
            salida.ShowDialog();
        }

        private void Btn_reganop_Click_1(object sender, EventArgs e)
        {
            reg_ganado ganado = new reg_ganado();
            ganado.ShowDialog();
        }
    }
}
