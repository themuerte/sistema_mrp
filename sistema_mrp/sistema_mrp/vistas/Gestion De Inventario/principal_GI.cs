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
        List<Button> botonesgg = new List<Button>(4);
        public principal_GI()
        {
            InitializeComponent();
            botonesgg.Add(btn_modeloP);
            botonesgg.Add(btn_modeloQ);
            botonesgg.Add(btn_MRP);
            botonesgg.Add(btn_planeacioA); 
            CenterToScreen();
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
            focusBotones(0);
            internal_frame(new modelo_P());

        }

        private void focusBotones(int v)
        {
            for (int i = 0; i < botonesgg.Count; i++)
            {
                if(i == v)
                {
                    botonesgg[i].BackColor = Color.FromArgb(115, 19, 26);
                }
                else
                {
                    botonesgg[i].BackColor = Color.FromArgb(60,166,67);
                }
            }
        }

        private void btn_modeloQ_Click(object sender, EventArgs e)
        {
            focusBotones(1);
            internal_frame(new modelo_Q());
        }

        private void btn_MRP_Click(object sender, EventArgs e)
        {
            focusBotones(2);
            internal_frame(new MRP());
        }

        private void btn_planeacioA_Click(object sender, EventArgs e)
        {
            focusBotones(3);
            internal_frame(new plan_agregado());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_prin_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Salir()
        {
            Application.Exit();
            
        }

        private void principal_GI_FormClosing(object sender, FormClosingEventArgs e)
        {
            Salir();
        }
    }
}
