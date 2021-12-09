using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ganado;

namespace SG
{
    public partial class Menuadmin : Form
    {
        Controladores.Menuadmin_Controlador controlador = new Controladores.Menuadmin_Controlador();
        public Menuadmin()
        {
            InitializeComponent();
            
            establo1.btn_e1.Click += Btn_e1_Click;
            animales1.Dtgv_animales.CellContentClick += Dtgv_animales_CellContentClick;
            infoanimal.btn_regresar.Click += Btn_regresar_Click;
            establo1.btn_regresar.Click += Btn_regresar_Click1;


        }

        public void Btn_regresar_Click1(object sender, EventArgs e)
        {
            logo1.BringToFront();
        }

        public void Btn_regresar_Click(object sender, EventArgs e)
        {
            animales1.BringToFront();
        }

        public void Dtgv_animales_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            controlador.Dtgv_animales_CellContentClick();
            String nombrecol = animales1.Dtgv_animales.CurrentCell.OwningColumn.Name;
            if (nombrecol == "Detalles")
            {
                infoanimal.BringToFront();
            }
        }

        public void Btn_e1_Click(object sender, EventArgs e)
        {
            
            animales1.BringToFront();
        }

        private void Btn_regop_Click(object sender, EventArgs e)
        {
            
        }

        
       
        private void Btn_establo_Click(object sender, EventArgs e)
        {
            establo1.BringToFront();
        }

        private void GunaPictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void agregarop1_Load(object sender, EventArgs e)
        {

        }

        private void white1_Load(object sender, EventArgs e)
        {
            
        }

        private void gunaPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public void abrirmenuanimales()
        {
            
                
            
        }

        private void Menuadmin_Load(object sender, EventArgs e)
        {
            logo1.BringToFront();
            controlador.Menuadmin_Load();
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }

        private void establo1_Load(object sender, EventArgs e)
        {

        }

        private void animales1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void infoanimal1_Load(object sender, EventArgs e)
        {

        }

        private void logo1_Load(object sender, EventArgs e)
        {

        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }


        private void Btn_regsal_Click(object sender, EventArgs e)
        {
            controlador.Btn_regsal_Click();
        }

        private void Btn_regan_Click_1(object sender, EventArgs e)
        {
            controlador.Btn_regan_Click_1();
        }
    }
}
