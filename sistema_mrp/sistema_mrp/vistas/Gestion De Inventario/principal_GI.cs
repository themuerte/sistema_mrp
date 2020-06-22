using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_mrp.vistas;
using sistema_mrp.vistas.Gestion_De_Inventario;


namespace sistema_mrp.vistas.Gestion_de_inventario
{
    public partial class principal_GI : Form
    {
        public principal_GI()
        {
            InitializeComponent();

            this.Location = new Point(0,0);
        }

        private void internal_frame(object ob)//metodo para generar los componentes adentro del panel
        {
            if (this.panel_prin.Controls.Count > 0)
            {
                this.panel_prin.Controls.RemoveAt(0);
            }

            Form fh = ob as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_prin.Controls.Add(fh);
            this.panel_prin.Tag = fh;
            fh.Show();

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            btn_GesInventario btn_Ges = new btn_GesInventario();// este es la vista inicio pero no se por que se llama asi en vez de inicio_P
            this.Hide();
            btn_Ges.Show();
            
        }

        private void btn_modeloP_Click(object sender, EventArgs e)
        {
            internal_frame(new modelo_P());

        }

        private void btn_modeloQ_Click(object sender, EventArgs e)
        {
            internal_frame(new modelo_Q());
        }

        private void btn_MRP_Click(object sender, EventArgs e)
        {
            internal_frame(new MRP());
        }

        private void btn_planeacioA_Click(object sender, EventArgs e)
        {
            internal_frame(new plan_agregado());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_prin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
