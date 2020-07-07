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
using sistema_mrp.vistas;
using sistema_mrp.vistas.Gestion_De_Inventario;


namespace sistema_mrp.vistas.Gestion_de_inventario
{
    public partial class principal_GI : Form
    {
        public principal_GI()
        {
            InitializeComponent();

            this.Location = new Point(0,0);
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg,
        int wparam, int lparam);

        private void internal_frame(object ob)//metodo para generar los componentes adentro del panel
        {
            if (this.panel_prin.Controls.Count > 0)
            {
                this.panel_prin.Controls.RemoveAt(0);
            }

            Form fh = ob as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel_prin.Controls.Add(fh);
            this.panel_prin.Tag = fh;
            fh.Show();

        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            btn_GesInventario btn_Ges = new btn_GesInventario();// este es la vista inicio pero no se por que se llama asi en vez de inicio_P
            this.Hide();
            btn_Ges.Show();
            
        }

        private void btn_modeloP_Click(object sender, EventArgs e)
        {
            internal_frame(new modelo_P());

        }

        private void btn_modeloQ_Click(object sender, EventArgs e)
        {
            internal_frame(new modelo_Q());
        }

        private void btn_MRP_Click(object sender, EventArgs e)
        {
            internal_frame(new MRP());
        }

        private void btn_planeacioA_Click(object sender, EventArgs e)
        {
            internal_frame(new plan_agregado());
        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel_prin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel_prin_MouseDown(object sender, MouseEventArgs e)
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
    }
}
