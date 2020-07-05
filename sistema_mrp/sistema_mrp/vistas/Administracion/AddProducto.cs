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
using System.Runtime.InteropServices;

namespace sistema_mrp.vistas.Administracion
{
    public partial class AddProducto : Form
    {

        Producto productoSel;
        Administracion papa;
        public AddProducto(Administracion papa)
        {
            InitializeComponent();
            this.papa = papa;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
         int wparam, int lparam);

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
            if (tbNombre.Text == "" || tbDescripcion.Text == "")
            {
                MessageBox.Show("Rellene los campos vacíos!");
            }
            else
            {
                try
                {
                    string nombre = tbNombre.Text;
                    string descripcion = tbDescripcion.Text;

                    Producto.AddProductoCorto(nombre, descripcion);
                    
                    papa.recargarTablaProductos();
                    this.Dispose(true);

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tbDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

<<<<<<< HEAD
        private void btnAddProduct_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void AddProducto_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
=======
        private void label3_Click(object sender, EventArgs e)
        {

>>>>>>> 19cbc7ac8de050fe960cefb021aa07c2bf6c3775
        }
    }
}
