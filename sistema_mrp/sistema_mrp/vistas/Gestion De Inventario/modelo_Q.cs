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
    public partial class modelo_Q : Form
    {
        public modelo_Q()
        {
            InitializeComponent();
        }

        private void btn_limpiar_Click(object sender, EventArgs e)
        {
            txt_costoM.Text = "";
            txt_costoPedir.Text = "";
            txt_costoPro.Text = "";
            txt_demanda.Text = "";
            txt_plazoE.Text = "";
            txt_diasAño.Text = "";
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            if (txt_demanda.Text == "" || txt_costoPro.Text == "" || txt_costoM.Text == "" || txt_costoPedir.Text == "" || txt_plazoE.Text == "" || txt_diasAño.Text == "" || txt_tiempoEspera.Text == "")
            {
                MessageBox.Show("Verifique los datos", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txt_Qoptimo.Enabled = true;
                txt_numPedidos.Enabled = true;
                txt_TiempoEntreP.Enabled = true;
                txt_puntoReo.Enabled = true;
                txt_inventarioSegu.Enabled = true;
                txt_costoTotal.Enabled = true;

                Modelo_Q modelo_q = new Modelo_Q(Convert.ToDouble(txt_demanda.Text), Convert.ToDouble(txt_costoPro.Text), Convert.ToDouble(txt_costoM.Text)
                    , Convert.ToDouble(txt_costoPedir.Text), Convert.ToInt32(txt_plazoE.Text), Convert.ToInt32(txt_diasAño.Text), Convert.ToInt32(txt_tiempoEspera.Text));

                //falta poner los valores de resultados en su capo, problemas con convertir

                txt_Qoptimo.Text = modelo_q.get_Qoptimo();
                txt_numPedidos.Text = modelo_q.get_pedidosA();
                txt_TiempoEntreP.Text = modelo_q.get_tiempoEntreP();
                txt_puntoReo.Text = modelo_q.get_puntoReorden();
                txt_inventarioSegu.Text = modelo_q.get_inventarionSeguridad();
                txt_costoTotal.Text = modelo_q.get_costoTotal();


            }
        }

        //validacion que no puedan ingresar 
        private void txt_demanda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_costoPro_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_costoM_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_costoPedir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_diasAño_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_plazoE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txt_tiempoEspera_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 punto decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

       
    }
}
