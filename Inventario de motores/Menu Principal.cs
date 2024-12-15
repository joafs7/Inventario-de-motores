using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario_de_motores
{
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void btn_MotoresLinea_Click(object sender, EventArgs e)
        {
            this.Hide();
            Motores_de_linea motores_De_Linea = new Motores_de_linea();
            motores_De_Linea.Show();
        }
    }
}
