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
    public partial class EditDiasHabiles : Form
    {

        PlanAgregado pa;
        Administracion papa;
        public EditDiasHabiles(Administracion papa, PlanAgregado pa)
        {
            InitializeComponent();
            this.papa = papa;
            this.pa = pa;
            lNombreMes.Text = "Mes de " + pa.Mes;
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
           
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            
        }
    

        private void llenarParametros()
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
    

        private void lNombreComponente_Click(object sender, EventArgs e)
        {

        }

        private void btnAddProduct_Click_1(object sender, EventArgs e)
        {
            if (tbDescripcion.Text == "")
            {
                MessageBox.Show("Rellene los campos vacíos!");
            }
            else
            {
                try
                {
                    double diasHabiles = double.Parse(tbDescripcion.Text);
                    pa.UpdateDiasHabiles(diasHabiles);
                    papa.cargarDiasHabiles();
                    this.Dispose(true);
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tbDescripcion_KeyPress(object sender, KeyPressEventArgs e)
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
