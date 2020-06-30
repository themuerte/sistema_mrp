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

namespace sistema_mrp.vistas.Administracion
{
    public partial class Administracion : Form
    {
        
        public Administracion()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAddComponent_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewComponente fcomponente = new AddNewComponente("", int.Parse(lIdProductoSel.Text));
                fcomponente.Show();

            }
            catch (Exception)
            {
                MessageBox.Show("Seleccione un producto primero.");
            }
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProducto producto = new AddProducto(this);
            producto.Show();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            recargarTablaProductos();
        }

        public void recargarTablaProductos()
        {
            Trucazos.vaciarDataGridView(dgvProductos);
            List<Producto> productos = Producto.GetProductos();
            
            foreach (Producto producto in productos)
            {
                Object[] p = {producto.IdProducto, producto.Nombre, producto.Descripcion,producto.PrecioActual, producto.CantidadInventario };
                dgvProductos.Rows.Add(p);
            }
        }

        

      

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int nFila = e.RowIndex;

            DataGridViewCell cell = dgvProductos.Rows[nFila].Cells[0];
            int idProducto = Convert.ToInt32(cell.Value);
            cell = dgvProductos.Rows[nFila].Cells[1];
            string nombre = Convert.ToString(cell.Value);
            cell = dgvProductos.Rows[nFila].Cells[2];
            string descripcion = Convert.ToString(cell.Value);
            cell = dgvProductos.Rows[nFila].Cells[3];
            double precioActual = Convert.ToDouble(cell.Value);
            cell = dgvProductos.Rows[nFila].Cells[4];
            int cantidadInventario = Convert.ToInt32(cell.Value);

            Producto p = new Producto(idProducto, nombre, descripcion, precioActual, cantidadInventario);
            EditProducto edit = new EditProducto(this, p);
            edit.Show();
        }

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvProductos.SelectedRows.Count > 0)
            {
                try
                {
                    int index = dgvProductos.SelectedRows[0].Index;
                    int idProducto = int.Parse(dgvProductos.Rows[index].Cells[0].Value.ToString());
                    lIdProductoSel.Text = idProducto + "";
                    llenarTabla();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }

        private void llenarTabla()
        {
            int idProducto = int.Parse(lIdProductoSel.Text);
            Trucazos.vaciarDataGridView(dgvBeanOfMat);
            List<Componente> componentes = Componente.GetComponentesPorProducto(idProducto);
            foreach (Componente c in componentes)
            {
                Object[] row = { c.IdComponente, c.Nombre, c.Descripcion, c.PrecioUnit, c.Plazo, c.TipoPlazo };
                dgvBeanOfMat.Rows.Add(row);
            }
        }
    }
}
