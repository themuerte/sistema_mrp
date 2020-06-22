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
            AddNewComponente fcomponente = new AddNewComponente("", -1);
            fcomponente.Show();
            
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProducto producto = new AddProducto();
            producto.Show();
        }
    }
}
