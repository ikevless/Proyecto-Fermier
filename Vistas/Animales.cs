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
    public partial class Animales : UserControl
    {
        public Animales()
        {
            InitializeComponent();
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Nombre", typeof(string));
            table.Columns.Add("Animal", typeof(string));
            table.Columns.Add("Raza", typeof(string));
            table.Columns.Add("Edad", typeof(string));
            table.Columns.Add("Color", typeof(string));

            table.Rows.Add(111, "Pili", "Vaca", "Holstein", "2", "negro");
            table.Rows.Add(111, "Pili", "Vaca", "Holstein", "2", "negro");
            table.Rows.Add(111, "Pili", "Vaca", "Holstein", "2", "negro");
            table.Rows.Add(111, "Pili", "Vaca", "Holstein", "2", "negro");

            
            Dtgv_animales.DataSource = table;
            
        }

        private void gunaDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String nombrecol = Dtgv_animales.CurrentCell.OwningColumn.Name;
            if (nombrecol=="Detalles")
            {

            }
        }

        private void Animales_Load(object sender, EventArgs e)
        {
            
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
