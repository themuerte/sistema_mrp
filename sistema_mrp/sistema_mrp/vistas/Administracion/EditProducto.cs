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
using Npgsql;

namespace sistema_mrp.vistas.Administracion
{
    public partial class EditProducto : Form
    {
        Administracion padre;
        Producto p;
        public EditProducto(Administracion padre, Producto p)
        {
            InitializeComponent();
            this.padre = padre;
            this.p = p;
            llenarContenido();
            
        }

        private void llenarContenido()
        {
           
        }

        private void AddProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (mtbPrecio.Text == "" || mtbUnidades.Text == "" || tbNombre.Text == "")
            {
                MessageBox.Show(this, "Campos Vacíos");
            }
            else
            {
                try
                {
                    double precio = double.Parse(mtbPrecio.Text);
                    int unidades = int.Parse(mtbUnidades.Text);
                    string nombre = tbNombre.Text;
                    string descripcion = tbDescripcion.Text;
                    p.UpdateNombre(nombre);
                    p.UpdateDescripcion(descripcion);
                    //p.UpdatePrecio(precio);
                    p.UpdateInventario(unidades);
                    padre.recargarTablaProductos();
                    this.Dispose();
                }
                catch (Exception except)
                {
                    MessageBox.Show(this, "" + except.Message);

                }



            }
        }
    }
}
