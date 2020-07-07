using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_mrp.controlador;
using sistema_mrp.vistas.Administracion;
using sistema_mrp.vistas.Gestion_de_inventario;


namespace sistema_mrp
{
    public partial class btn_GesInventario : Form
    {
        string nombreEmpresa;
        public btn_GesInventario()
        {
            InitializeComponent();
            this.CenterToScreen();
            nombreEmpresa = Empresa.GetEmpresa().Nombre;
            lbl_inicio.Text = "Gestión de " + nombreEmpresa + ":";
        }


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

        private void btn_GesInventario_GiveFeedback(object sender, GiveFeedbackEventArgs e)
        {

        }

        private void btn_GesInventario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
