using sistema_mrp.controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_mrp.controlador.plan_agregado;

namespace sistema_mrp.vistas.Gestion_De_Inventario
{
    public partial class plan_agregado : Form
    {
        public plan_agregado()
        {
            InitializeComponent();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int cant = Convert.ToInt32(txt_numeroDatos.Text);

            if (txt_numeroDatos.Text == "" || txt_numeroDatos.Text == "")
            {
                MessageBox.Show("Verifique las semanas", "AVISO!!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                dtg_semanas.Columns.Clear();
                dtg_semanas.Rows.Clear();

                DataGridViewTextBoxColumn columna = new DataGridViewTextBoxColumn();
                columna.HeaderText = "Datos";
                columna.Width = 130;
                columna.ReadOnly = true;
                dtg_semanas.Columns.Add(columna);
                dtg_semanas.Rows.Add("Demanda");
                dtg_semanas.Rows.Add("Dias laborados");

                int num = 1;
                for (int i = 0; i < cant; i++)
                {
                    DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
                    columna1.HeaderText = "periodo" + num;
                    columna1.Width = 100;
                    dtg_semanas.Columns.Add(columna1);
                    num++;
                }
            }
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtg_semanas.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dtg_semanas.Rows[i].Cells.Count; j++)
                {
                    if (i == 0 && j == 0 || i == 1 && j == 0)
                    {
                        //se evita que entre en los campos de Demada y Dias Laborados
                    }
                    else
                    {
                        string valor = dtg_semanas.Rows[i].Cells[j].Value.ToString();
                        MessageBox.Show(valor);
                    }
                }
            }
        }

        private void plan_agregado_Load(object sender, EventArgs e)
        {
            cargarProducto();
        }

        public void cargarProducto()
        {
            Trucazos.vaciarDataGridView(dgvProducto);
            List<Object[]> productos = Producto.GetProductosCorto();
            foreach (Object[] producto in productos)
            {
                dgvProducto.Rows.Add(producto);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int index = dgvProducto.SelectedRows[0].Index;
                int idProducto = int.Parse(dgvProducto.Rows[index].Cells[0].Value.ToString());
                Producto prod = Producto.GetProductoById(idProducto);
                int numMeses = int.Parse(tbMeses.Text);
                if (bPersecución.Checked)
                {
                    EstrategiaPersecucion persecucion = new EstrategiaPersecucion(prod, numMeses);
                    List<Fila> resultado = persecucion.getPlanAgregado();
                    rellenarPlaneacion(resultado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void rellenarPlaneacion(List<Fila> resultado)
        {
            try
            {
                int numMeses = int.Parse(tbMeses.Text);
                Trucazos.vaciarDataGridView(dtgResultado);
                dtgResultado.Columns.Clear();
                DataGridViewTextBoxColumn primeraCol = new DataGridViewTextBoxColumn();
                primeraCol.HeaderText = "";
                primeraCol.ReadOnly = true;
                dtgResultado.Columns.Add(primeraCol);

                for (int i = 0; i < numMeses; i++)
                {
                    DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                    col.HeaderText = "Periodo " + (i + 1);
                    col.ReadOnly = true;
                    dtgResultado.Columns.Add(col);
                }


                foreach (Fila fila in resultado)
                {
                    Object[] row = new object[numMeses + 1];
                    row[0] = fila.NombreFila;
                    for (int i = 0; i < numMeses; i++)
                    {
                        row[i + 1] = fila.Valores[i];
                    }
                    dtgResultado.Rows.Add(row);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
        }

    }
}
