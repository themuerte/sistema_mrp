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
using sistema_mrp.vistas.Administracion;
using sistema_mrp.vistas.Gestion_de_inventario;




namespace sistema_mrp
{
    public partial class btn_GesInventario : Form
    {
        public btn_GesInventario()
        {
            InitializeComponent();
            this.Location = new Point(0, 0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);

        private void button1_Click(object sender, EventArgs e)
        {
            principal_GI principal = new principal_GI();
            this.Hide();
            principal.Show();
        }


        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Administracion administracion = new Administracion();
            this.Hide();
            administracion.Show();
        }

        private void lbl_inicio_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_GesInventario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_salir_MouseHover(object sender, EventArgs e)
        {
            MensajeSalir.SetToolTip(btn_salir, "Al precionar este Botón estará cerrando la aplicación");
            MensajeSalir.ToolTipTitle = "Cerrar Aplicación";
            MensajeSalir.ToolTipIcon = ToolTipIcon.Info;
        }

        private void btn_GesInventario_Load(object sender, EventArgs e)
        {

        }
    }
}
