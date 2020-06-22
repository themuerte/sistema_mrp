using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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


    }
}
