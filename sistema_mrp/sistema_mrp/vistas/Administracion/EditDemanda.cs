﻿using sistema_mrp.controlador;
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
    public partial class EditDemanda : Form
    {

        PlanProducto pp;
        Administracion papa;
        public EditDemanda(Administracion papa, PlanProducto pp)
        {
            InitializeComponent();
            this.papa = papa;
            this.pp = pp;
            lMes.Text = "Mes NO. " + pp.IdPlanAgregado;
        }


        private void Administracion_Load(object sender, EventArgs e)
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
                    double demanda = double.Parse(tbDescripcion.Text);
                    pp.UpdateDemanda(demanda);
                    papa.llenarDatosDemanda();
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

        private void tbDescripcion_TextChanged(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
