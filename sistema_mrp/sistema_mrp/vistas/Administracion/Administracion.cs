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
    public partial class Administracion : Form
    {

        Producto productoSel;
        Empresa empresa;
        public Administracion()
        {
            InitializeComponent();
            empresa = Empresa.GetEmpresa();
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
            AddProducto producto = new AddProducto(this);
            producto.Visible = true;
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            recargarTablaProductos();
            cargarEmpresaDatos();
        }

        private void cargarEmpresaDatos()
        {
            tbNombreEmpresa.Text = empresa.Nombre;
            tbDiaTrabajadoXAnio.Text = empresa.DiasTrabajadosPorAnio + "";
            tbCostoContratacion.Text = empresa.CostoContratacion + "";
            tbCostoSubContratacion.Text = empresa.CostoSubContratacion + "";
            tbCostoDespido.Text = empresa.CostoDespido + "";
            tbFuerzaLaboral.Text = empresa.FuerzaLaboral + "";


        }

        public void recargarTablaProductos()
        {
            Trucazos.vaciarDataGridView(dgvProductos);
            List<Object[]> productos = Producto.GetProductosCorto();
            if (productos.Count > 0)
            {
                foreach (Object[] producto in productos)
                {
                    dgvProductos.Rows.Add(producto);
                }
            }
            
        }

        

      

        private void dgvProductos_SelectionChanged(object sender, EventArgs e)
        {
            if(dgvProductos.SelectedRows.Count > 0)
            {
                try
                {
                    int index = dgvProductos.SelectedRows[0].Index;
                    int idProducto = int.Parse(dgvProductos.Rows[index].Cells[0].Value.ToString());
                    lIdProductoSel.Text = idProducto + "";
                    
                    llenarParametros();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }
        }

        private void llenarParametros()
        {
            try
            {
                int idProducto = int.Parse(lIdProductoSel.Text);
                productoSel = Producto.GetProductoById(idProducto);
                tbNombre.Text = productoSel.Nombre;
                tbDescripcion.Text = productoSel.Descripcion;
                tbInventario.Text =            Math.Round(productoSel.Inventario, 2) + "";
                tbCostoUnitario.Text =         Math.Round(productoSel.CostoUnitario, 2) + "";
                tbCostoPorPedir.Text =         Math.Round(productoSel.CostoPedir, 2) + "";
                tbCostoMantenimiento.Text =    Math.Round(productoSel.CostoMantenimiento, 2) + "";
                tbDesviacion.Text =            Math.Round(productoSel.DesviacionDemanda, 2) + "";
                tbDemandaDiaria.Text =         Math.Round(productoSel.DemandaDiaria, 2) + "";
                tbPeriodoRevision.Text =       Math.Round(productoSel.PeriodoRevision, 2) + "";
                tbProbabilidadDemanda.Text =   Math.Round(productoSel.ProbabilidadDemanda, 2) + "";
                tbPlazodeEntregaP.Text =       Math.Round(productoSel.PlazoEntregaDias, 2) + "";
                tbInventarioInicial.Text =     Math.Round(productoSel.InventarioInicial, 2) + "";
                tbHorasRequeridas.Text =       Math.Round(productoSel.HorasRequeridas, 2) + "";
                tbStockSeguridad.Text =        Math.Round(productoSel.StockSeguridad, 2) + "";
                tbCostoFaltante.Text =         Math.Round(productoSel.CostoFaltante, 2) + "";
                tbCostosxHoras.Text =          Math.Round(productoSel.CostoHrs, 2) + "";
                tbCostoHrsExtras.Text =        Math.Round(productoSel.CostoHrsExtras,2) + "";
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
             
            }
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(tbNombre.Text == "" || tbDescripcion.Text == "" || tbInventario.Text == "")
            {
                MessageBox.Show("Rellene los campos vacíos!");
            }
            else
            {
                try
                {
                    string nombre = tbNombre.Text;
                    string descripcion = tbDescripcion.Text;
                    double inventario = double.Parse(tbInventario.Text);
                    if (lIdProductoSel.Text == "id")
                    {
                        MessageBox.Show("Seleccione un producto primero!");
                    }
                    else
                    {
                        productoSel.UpdateNombre(nombre);
                        productoSel.UpdateDescripcion(descripcion);
                        productoSel.UpdateInventario(inventario);
                        MessageBox.Show("Datos Actualizados!!");
                        llenarParametros();
                    }

                }
                catch (Exception ex )
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnEditarP2_Click(object sender, EventArgs e)
        {
            if(tbCostoFaltante.Text == "" || tbCostoUnitario.Text =="" || tbCostoMantenimiento.Text =="" || tbStockSeguridad.Text == "" || tbInventarioInicial.Text == "")
            {
                MessageBox.Show("Rellene los campos vacíos!");
            }
            else
            {
                try
                {
                    double costoFaltante, costoProducto, costoMantenimiento, stockSeguridad, inventarioInicial;
                    costoFaltante = double.Parse(tbCostoFaltante.Text);
                    costoProducto = double.Parse(tbCostoUnitario.Text);
                    costoMantenimiento = double.Parse(tbCostoMantenimiento.Text);
                    stockSeguridad = double.Parse(tbStockSeguridad.Text);
                    inventarioInicial = double.Parse(tbInventarioInicial.Text);

                    productoSel.UpdateCostoFaltante(costoFaltante);
                    productoSel.UpdateCostoUnitario(costoProducto);
                    productoSel.UpdateCostoMantenimiento(costoMantenimiento);
                    productoSel.UpdateStockSeguridad(stockSeguridad);
                    productoSel.UpdateInventarioInicial(inventarioInicial);
                    MessageBox.Show("Datos Parte 2 Actualizados!!");
                    llenarParametros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }
            }
        }

        private void btnEditarP1_Click(object sender, EventArgs e)
        {
            if (tbDemandaDiaria.Text == "" || tbPlazodeEntregaP.Text == "" || tbPeriodoRevision.Text == "" || tbDesviacion.Text == "" || tbProbabilidadDemanda.Text == "")
            {
                MessageBox.Show("Rellene los campos vacíos!");
            }
            else
            {
                try
                {
                    double demandaDiaria, plazoEntrega, periodoRevision, desviacion, probabilidadDemanda;
                    demandaDiaria = double.Parse(tbDemandaDiaria.Text);
                    plazoEntrega = double.Parse(tbPlazodeEntregaP.Text);
                    periodoRevision = double.Parse(tbPeriodoRevision.Text);
                    desviacion = double.Parse(tbDesviacion.Text);
                    probabilidadDemanda = double.Parse(tbProbabilidadDemanda.Text);

                    productoSel.UpdateDemandaDiaria(demandaDiaria);
                    productoSel.UpdatePlazoEntregaDias(plazoEntrega);
                    productoSel.UpdatePeriodoRevision(periodoRevision);
                    productoSel.UpdateDesviacionDemanda(desviacion);
                    productoSel.UpdateProbabilidadDemanda(probabilidadDemanda);
                    MessageBox.Show("Datos Parte 1 Actualizados!!");
                    llenarParametros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void btnEditarP3_Click(object sender, EventArgs e)
        {
            if (tbCostoPorPedir.Text == "" || tbHorasRequeridas.Text == "" || tbCostosxHoras.Text == "" || tbCostoHrsExtras.Text == "")
            {
                MessageBox.Show("Rellene los campos vacíos!");
            }
            else
            {
                try
                {
                    double costoPedir, horasRequeridas, costoHora, costoHoraExtra;
                    costoPedir = double.Parse(tbCostoPorPedir.Text);
                    horasRequeridas = double.Parse(tbHorasRequeridas.Text);
                    costoHora = double.Parse(tbCostosxHoras.Text);
                    costoHoraExtra = double.Parse(tbCostoHrsExtras.Text);


                    productoSel.UpdateCostoPedir(costoPedir);
                    productoSel.UpdateHorasRequeridas(horasRequeridas);
                    productoSel.UpdateCostoHrs(costoHora);
                    productoSel.UpdateCostoHrsEx(costoHoraExtra);
                    MessageBox.Show("Datos Parte 3 Actualizados!!");
                    llenarParametros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
        }

        private void btnEditarOD_Click(object sender, EventArgs e)
        {
            if (tbNombreEmpresa.Text == "" || tbDiaTrabajadoXAnio.Text == "" || tbCostoContratacion.Text == "" || tbCostoSubContratacion.Text == "" || tbCostoDespido.Text == "" || tbFuerzaLaboral.Text == "")
            {
                MessageBox.Show("Rellene los campos vacíos!");
            }
            else
            {
                try
                {
                    empresa.Nombre= tbNombreEmpresa.Text; 
                    
                    empresa.DiasTrabajadosPorAnio = double.Parse(tbDiaTrabajadoXAnio.Text);
                    empresa.CostoContratacion = double.Parse(tbCostoContratacion.Text);
                    empresa.CostoSubContratacion = double.Parse(tbCostoSubContratacion.Text);
                    empresa.CostoDespido = double.Parse(tbCostoDespido.Text);
                    empresa.FuerzaLaboral = double.Parse(tbFuerzaLaboral.Text);

                    Empresa.UpdateEmpresa(empresa);
                    cargarEmpresaDatos();
                    MessageBox.Show("Datos Actualizados!!");
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            btn_GesInventario btn_Ges = new btn_GesInventario();// este es la vista inicio pero no se por que se llama asi en vez de inicio_P
            this.Hide();
            btn_Ges.Show();
        }
    }
}
