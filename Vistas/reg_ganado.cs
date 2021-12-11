using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SG.Controladores;
using System.Data.SqlClient;
using SG.Modelos;

namespace SG
{
    public partial class reg_ganado : Form
    {
        public reg_ganado()
        {
            InitializeComponent();
        }

        private void reg_ganado_Load(object sender, EventArgs e)
        {

        }

        private void licensing1_Load(object sender, EventArgs e)
        {

        }

        private void lbl_registro_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void gunaLabel2_Click(object sender, EventArgs e)
        {

        }

        private void gunaLabel3_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
            
        {
            
            
           
            
            Reg_Ganado_Controlador controlador = new Reg_Ganado_Controlador();

            try
            {
                

                controlador.btn_guardar_Click(txb_id.Text, txb_peso.Text, cbx_sexo.Text, preciok, cbx_animal.Text, cbx_color.Text, txb_edad.Text, precioim, dat_ingreso.Value.Date, dat_reg.Value.Date);
                
                txb_peso.ResetText();
                txb_id.ResetText();
                cbx_sexo.SelectedIndex = -1;
                Precio_Txt.ResetText();
                cbx_animal.SelectedIndex=-1;
               cbx_color.SelectedIndex = -1;
                txb_edad.ResetText();
                txb_importe.ResetText();
                dat_ingreso.Value = DateTime.Now;
                dat_reg.Value = DateTime.Now;


            }
            catch (Exception ex)
            {

                MessageBox.Show("Insercion fallida");
                txb_peso.ResetText();
                txb_id.ResetText();
                cbx_sexo.SelectedIndex = -1;
                Precio_Txt.ResetText();
                cbx_animal.SelectedIndex = -1;
                cbx_color.SelectedIndex = -1;
                txb_edad.ResetText();
                txb_importe.ResetText();
                dat_ingreso.Value = DateTime.Now;
                dat_reg.Value = DateTime.Now;
            }

            
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kryptonTextBox1_TextChanged(object sender, EventArgs e)
        {
            this.Text = " ";
        }

        private void kryptonTextBox1_TextChanged_1(object sender, EventArgs e)
        {
            this.Text = " ";
        }

        private void gunaLabel4_Click(object sender, EventArgs e)
        {

        }

        private void GunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaLineTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        public string preciok;
        public string precioim;
        private void gunaLineTextBox1_Leave(object sender, EventArgs e)
        {
            Double value;
            preciok = Precio_Txt.Text;
            if (Double.TryParse(Precio_Txt.Text, out value))
                Precio_Txt.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
            
        }

        private void txb_peso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txb_peso_Leave(object sender, EventArgs e)
        {
            
        }

        private void txb_peso_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            bool FalseInput = !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '.';
            if (!FalseInput)
            {
                e.Handled = false;
                if (System.Text.RegularExpressions.Regex.IsMatch(txb_peso.Text, @"^\d+\.\d*$") && e.KeyChar != 8)
                {
                    bool ContainDot = txb_peso.Text.Contains(".");
                    e.Handled = true;
                    if (ContainDot && e.KeyChar != 8 && e.KeyChar != '.')
                    {
                        e.Handled = System.Text.RegularExpressions.Regex.IsMatch(txb_peso.Text, @"\.\d\d\d");
                    }
                }
            }
        }

        private void Precio_Txt_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txb_edad_Leave(object sender, EventArgs e)
        {
            
            Double value;
            precioim = txb_importe.Text;
            if (Double.TryParse(txb_importe.Text, out value))
                txb_importe.Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
        }

        private void gunaLabel5_Click_1(object sender, EventArgs e)
        {

        }

        private void txb_importe_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verify that the pressed key isn't CTRL or any non-numeric digit
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

          
        }

        private void txb_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txb_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
