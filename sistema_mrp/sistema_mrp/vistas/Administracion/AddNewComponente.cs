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
            c.Plazo = 
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
            this.Dispose();
        }
    }
}
