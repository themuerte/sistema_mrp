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
    public partial class AddNewComponente : Form
    {
        public AddNewComponente()
        {
            InitializeComponent();
            cargarTablaComponentes();
        }

        private void cargarTablaComponentes()
        {    
            Trucazos.vaciarDataGridView(dgvComponentesEx);
            List<Componente> componentes = Componente.GetComponentesAjenosProducto(idProducto);
            foreach (Componente c in componentes)
            {
                Object[] row = { c.IdComponente, c.Nombre, c.Descripcion, c.PrecioUnit, c.Plazo, c.TipoPlazo };
                dgvComponentesEx.Rows.Add(row);
            }
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarComponenteNew_Click(object sender, EventArgs e)
        {
            Componente c = new Componente();
            c.Nombre = tbNombre.Text;
            c.Descripcion = "";
            c.PrecioUnit = double.Parse(tbPrecio.Text);
            c.Plazo = int.Parse(tbplazoNew.Text);
            switch (cbTipoNew.SelectedIndex)
            {
                case 0:
                    c.TipoPlazo = "horas";
                    break;
                case 1:
                    c.TipoPlazo = "dias";
                    break;
                case 2:
                    c.TipoPlazo = "semanas";
                    break;
                case 3:
                    c.TipoPlazo = "meses";
                    break;
        
                default:
                    c.TipoPlazo = "dias";
                    break;
            }
            int idComponente = Componente.AddComponente(c);
            c.IdComponente = idComponente;
            int margenSeguridad = int.Parse(tbMargenSegNew.Text);
            int unidades = int.Parse(tbMargenSegNew.Text);
            ProductoComponente pc = new ProductoComponente(idProducto, idComponente, margenSeguridad, unidades);
            ProductoComponente.AddProductoComponente(pc);
            this.Dispose();
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void tbPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void tbUnidNew_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAddComponentExist_Click(object sender, EventArgs e)
        {
            try
            {
                int idComponente = int.Parse(lIdComponente.Text);
                int unidades = int.Parse(tbUnidNecExist.Text);
                int margen = int.Parse(tbMargenSegExist.Text);
                ProductoComponente pc = new ProductoComponente(idProducto, idComponente, unidades, margen);
                ProductoComponente.AddProductoComponente(pc);
                vaciarTbExist();
                this.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " +ex.Message);
                
            }
            
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {
           if(dgvComponentesEx.SelectedRows.Count > 0)
            {
                int index = dgvComponentesEx.SelectedRows[0].Index;
                lIdComponente.Text = index + "";
                    
            }
        }

        private void vaciarTbExist()
        {
            tbUnidNecExist.Text = "";
            lIdComponente.Text = "<idComponente>";
            tbMargenSegExist.Text = "";
        }

        private void AddNewComponente_Load(object sender, EventArgs e)
        {
            cargarTablaComponentes();
        }
    }
}
