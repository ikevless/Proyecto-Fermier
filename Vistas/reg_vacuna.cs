using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using SG.Modelos;
using SG.Controladores;
namespace SG
{
    public partial class reg_vacuna : Form
    {
        public reg_vacuna()
        {
            InitializeComponent();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_parto_Click(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dat_apli.Value.Date;
            string fechapeso = fecha.Date.ToString("MM/dd/yyyy");
            DateTime fechar = dat_reg.Value.Date;
            string fechareg = fechar.Date.ToString("MM/dd/yyyy");

            Reg_vacuna_Controlador rvcontrolador = new Reg_vacuna_Controlador();
            rvcontrolador.regvacuna(idrv_cbx.Text, txb_vac.Text, txb_nom.Text, txb_aplicador.Text, fechapeso, fechareg, txb_obs.Text);
            idrv_cbx.SelectedIndex = -1;
            txb_vac.ResetText();
            txb_nom.ResetText();
            txb_aplicador.ResetText();
            txb_obs.ResetText();
        }

        private void GunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void idrv_tbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
