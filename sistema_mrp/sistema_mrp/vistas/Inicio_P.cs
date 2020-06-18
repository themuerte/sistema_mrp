using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_mrp.vistas.Gestion_de_inventario;
using sistema_mrp.vistas.Historial;

namespace sistema_mrp
{
    public partial class btn_GesInventario : Form
    {
        public btn_GesInventario()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
        }


        private void button1_Click(object sender, EventArgs e)
        {
            principal_GI principal = new principal_GI();
            this.Hide();
            principal.Show();
        }

        private void btn_historia_Click(object sender, EventArgs e)
        {
            principal_historial principal = new principal_historial();
            this.Hide();
            principal.Show();
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
