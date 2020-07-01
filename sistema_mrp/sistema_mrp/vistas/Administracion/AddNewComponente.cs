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
           
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregarComponenteNew_Click(object sender, EventArgs e)
        {
            
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
                int idComponente = int.Parse(dgvComponentesEx.Rows[index].Cells[0].Value.ToString());
                lIdComponente.Text = idComponente + "";
                    
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
