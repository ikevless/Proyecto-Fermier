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
using SG.Controladores;


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

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            DateTime fecha = dat_peso.Value.Date;
            string fechapeso = fecha.Date.ToString("MM/dd/yyyy");
            DateTime fechar = dat_reg.Value.Date;
            string fechareg = fechar.Date.ToString("MM/dd/yyyy");

            Reg_pesaje_Controlador rpcontrolador = new Reg_pesaje_Controlador();
            rpcontrolador.regpesaje(cbx_id.Text, cbx_op.Text, txb_peso.Text, fechapeso, fechareg);

            cbx_id.SelectedIndex = -1;
            cbx_op.SelectedIndex = -1;
            txb_peso.ResetText();
        }

        private void txb_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
