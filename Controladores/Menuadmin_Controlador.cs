using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SG;
using Ganado;

namespace SG.Controladores
{
    class Menuadmin_Controlador
    {
        
        public void inicializar()
        {
            Menuadmin admin = new Menuadmin();

           
        }

        public void Menuadmin_Load()
        {
           
            Menuadmin admin = new Menuadmin();
            admin.establo1.btn_e1.Click += admin.Btn_e1_Click;
            admin.animales1.Dtgv_animales.CellContentClick += admin.Dtgv_animales_CellContentClick;
            admin.infoanimal.btn_regresar.Click += admin.Btn_regresar_Click;
            admin.establo1.btn_regresar.Click += admin.Btn_regresar_Click1;
           /* LogIn log = new LogIn();
            log.ShowDialog();*/
            admin.logo1.BringToFront();
            

        }

        public void Dtgv_animales_CellContentClick()
        {
            Menuadmin admin = new Menuadmin();
            String nombrecol = admin.animales1.Dtgv_animales.CurrentCell.OwningColumn.Name;
            if (nombrecol == "Detalles")
            {
                admin.infoanimal.BringToFront();
            }
        }

        public void Btn_regsal_Click()
        {
            reg_salida salida = new reg_salida();
            salida.ShowDialog();
        }

        public void Btn_regan_Click_1()
        {
            reg_ganado ganado = new reg_ganado();
            ganado.ShowDialog();
        }

        public void Btn_e1_Click()
        {
            Menuadmin admin = new Menuadmin();
            admin.animales1.BringToFront();
        }


    }
}
