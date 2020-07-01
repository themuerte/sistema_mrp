using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using sistema_mrp.controlador;

namespace sistema_mrp.vistas.Gestion_De_Inventario
{
    public partial class modelo_Q : Form
    {
        Producto productoSeleccionado;
        public modelo_Q()
        {
            InitializeComponent();
            cargarProductosTabla();
            tbNumeroPeriodos.Text = "5";
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
            if (txt_demanda.Text == "" || txt_costoPro.Text == "" || txt_costoM.Text == "" || txt_costoPedir.Text == "" || txt_plazoE.Text == "" || txt_diasAño.Text == "" )
            {
                MessageBox.Show("Verifique los datos", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txt_Qoptimo.Enabled = true;
                txt_numPedidos.Enabled = true;
                txt_TiempoEntreP.Enabled = true;
                txt_inventarioSegu.Enabled = true;
                txt_costoTotal.Enabled = true;

                Modelo_Q modelo_q = new Modelo_Q(Convert.ToDouble(txt_demanda.Text), Convert.ToDouble(txt_costoPro.Text), Convert.ToDouble(txt_costoM.Text)
                    , Convert.ToDouble(txt_costoPedir.Text), Convert.ToInt32(txt_plazoE.Text), Convert.ToInt32(txt_diasAño.Text));

                //falta poner los valores de resultados en su capo, problemas con convertir

                txt_Qoptimo.Text = modelo_q.get_Qoptimo();
                txt_numPedidos.Text = modelo_q.get_pedidosA();
                txt_TiempoEntreP.Text = modelo_q.get_tiempoEntreP();
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

        private void txt_costoM_TextChanged(object sender, EventArgs e)
        {

        }

        private void modelo_Q_Load(object sender, EventArgs e)
        {

        }
        private void cargarProductosTabla()
        {
            Trucazos.vaciarDataGridView(dgvProductos);
            List<Object[]> productos = Producto.GetProductosCorto();
            if (productos.Count > 0)
            {
                foreach (Object[] producto in productos)
                {
                    dgvProductos.Rows.Add(producto);
                }
            }

        }
        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProductos.SelectedRows.Count > 0)
            {
                try
                {
                    int index = dgvProductos.SelectedRows[0].Index;
                    int idProducto = int.Parse(dgvProductos.Rows[index].Cells[0].Value.ToString());
                    productoSeleccionado = Producto.GetProductoById(idProducto);
                    if (productoSeleccionado.isValid())
                    {


                        Modelo_Q modelo_q = new Modelo_Q( productoSeleccionado.DemandaDiaria * 360, productoSeleccionado.CostoUnitario, productoSeleccionado.CostoMantenimiento , productoSeleccionado.CostoPedir, (int) productoSeleccionado.PlazoEntregaDias, (int) Empresa.GetEmpresa().DiasTrabajadosPorAnio);

                        //falta poner los valores de resultados en su capo, problemas con convertir

                        txt_Qoptimo.Text = modelo_q.get_Qoptimo();
                        txt_numPedidos.Text = modelo_q.get_pedidosA();
                        txt_TiempoEntreP.Text = modelo_q.get_tiempoEntreP();
                        txt_inventarioSegu.Text = modelo_q.get_inventarionSeguridad();
                        txt_costoTotal.Text = modelo_q.get_costoTotal();

                        int numeroPeriodos = int.Parse(tbNumeroPeriodos.Text);
                        cargarGrafico(numeroPeriodos);
                    }


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void bUpdateChart_Click(object sender, EventArgs e)
        {
            try
            {

                int numeroPeriodos = int.Parse(tbNumeroPeriodos.Text);
                cargarGrafico(numeroPeriodos);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void cargarGrafico(int numeroPeriodos)
        {
            Series sQoptimo = cModeloQ.Series[0];
            Series sInventario = cModeloQ.Series[1];
            Series sSSeguridad = cModeloQ.Series[2];
            sQoptimo.Points.Clear();
            sInventario.Points.Clear();
            sSSeguridad.Points.Clear();
            double stockSeguridad = double.Parse(txt_inventarioSegu.Text);
            double tiempoPedido = double.Parse(txt_TiempoEntreP.Text);
            double qOptimo = double.Parse(txt_Qoptimo.Text);
            if(tiempoPedido <= 30)
            {
                for (int i = 0; i < numeroPeriodos; i++)
                {
                    sQoptimo.Points.AddXY(i, qOptimo);
                    sInventario.Points.AddXY(i - 0.001, 0);
                    sInventario.Points.AddXY(i, qOptimo);
                    sInventario.Points.AddXY(Math.Round(i + tiempoPedido/30,2), stockSeguridad);
                    sSSeguridad.Points.AddXY(i, stockSeguridad);
                }
            }
            
        }
    }
}
