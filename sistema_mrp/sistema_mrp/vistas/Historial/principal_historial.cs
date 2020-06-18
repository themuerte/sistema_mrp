using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_mrp.vistas.Historial
{
    public partial class principal_historial : Form
    {
        public principal_historial()
        {
            InitializeComponent();
            this.Location = new Point(0,0);
        }

        private void internal_frame(object ob)//metodo para generar los componentes adentro del panel
        {
            if (this.panel_principal.Controls.Count > 0)
            {
                this.panel_principal.Controls.RemoveAt(0);
            }

            Form fh = ob as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_principal.Controls.Add(fh);
            this.panel_principal.Tag = fh;
            fh.Show();

        }

        private void btn_modeloQyP_Click(object sender, EventArgs e)
        {
            internal_frame(new modelo_QyP());
        }

        private void btn_MRP_Click(object sender, EventArgs e)
        {
            internal_frame(new MRP());
        }

        private void btn_planAgre_Click(object sender, EventArgs e)
        {
            internal_frame(new plan_agregado());
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            btn_GesInventario btn_Ges = new btn_GesInventario();// este es la vista inicio pero no se por que se llama asi en vez de inicio_P
            this.Hide();
            btn_Ges.Show();
        }

    }
}
