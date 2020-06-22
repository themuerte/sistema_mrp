using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_mrp.controlador;

namespace sistema_mrp.vistas.Gestion_De_Inventario
{
    public partial class modelo_P : Form
    {
        public modelo_P()
        {
            InitializeComponent();
        }

        void getSelectedRB_Click(object sender, EventArgs e)
        {
            if (rdr_dias.Checked == true)
            {
                lbl_demanda.Text = "Demanda Diaria:";
            }
            else if (rdr_mensual.Checked == true)
            {
                lbl_demanda.Text = "Demanda Mensual:";
            }
            else if (rdr_semanal.Checked == true)
            {
                lbl_demanda.Text = "Demanda Semanal:";
            }
            else if (rdr_anual.Checked == true)
            {
                lbl_demanda.Text = "Demanda Anual:";
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            txt_z.Enabled = true;
            txt_cantidadOptima.Enabled = true;
            txt_desvEstandarDem.Enabled = true;

            Modelo_P modelo = new Modelo_P(Convert.ToInt32(txt_demandaP.Text),Convert.ToDouble(txt_plazoEntrega.Text),Convert.ToDouble(txt_periodoRevi.Text),
                Convert.ToDouble(txt_desviacion.Text),Convert.ToDouble(txt_probabilidadDemanda.Text));

            txt_z.Text = modelo.get_z();
        }
    }
}
