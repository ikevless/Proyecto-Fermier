using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SG
{
    public partial class infoanimal : UserControl
    {
        public infoanimal()
        {
            InitializeComponent();
        }

        private void btn_regresar_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_regvacuna_Click(object sender, EventArgs e)
        {
            reg_vacuna vacuna = new reg_vacuna();
            vacuna.ShowDialog();
        }

        private void btn_regparto_Click(object sender, EventArgs e)
        {
            reg_parto parto = new reg_parto();
            parto.ShowDialog();
        }

        private void btn_regtrat_Click(object sender, EventArgs e)
        {
            reg_tratamiento tratamiento = new reg_tratamiento();
            tratamiento.ShowDialog();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            reg_pesaje pesaje = new reg_pesaje();
            pesaje.ShowDialog();
        }

        private void infoanimal_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }
    }
}
