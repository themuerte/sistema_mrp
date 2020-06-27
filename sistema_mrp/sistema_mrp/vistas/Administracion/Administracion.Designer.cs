namespace sistema_mrp.vistas.Administracion
{
    partial class Administracion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lProd = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.tbComponents = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSubirPrimerNivel = new System.Windows.Forms.Button();
            this.btnAddComponent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lNombreComponente = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idComponenteH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazoCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnAddNewComponent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbBusquedaComponente = new System.Windows.Forms.TextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazoC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.tbComponents.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Cerrar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.descripcion,
            this.precio,
            this.cantidadInventario});
            this.dgvProductos.Location = new System.Drawing.Point(134, 48);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(744, 92);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            this.dgvProductos.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvProductos_KeyDown);
            this.dgvProductos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dgvProductos_KeyPress);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "Código";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.Name = "descripcion";
            // 
            // precio
            // 
            this.precio.HeaderText = "precio";
            this.precio.Name = "precio";
            // 
            // cantidadInventario
            // 
            this.cantidadInventario.HeaderText = "Inventario";
            this.cantidadInventario.Name = "cantidadInventario";
            this.cantidadInventario.ReadOnly = true;
            this.cantidadInventario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // lProd
            // 
            this.lProd.AutoSize = true;
            this.lProd.Location = new System.Drawing.Point(450, 13);
            this.lProd.Name = "lProd";
            this.lProd.Size = new System.Drawing.Size(55, 13);
            this.lProd.TabIndex = 4;
            this.lProd.Text = "Productos";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Volver";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(761, 19);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(117, 23);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Nuevo Producto";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // tbComponents
            // 
            this.tbComponents.Controls.Add(this.tabPage1);
            this.tbComponents.Controls.Add(this.tabPage3);
            this.tbComponents.Location = new System.Drawing.Point(134, 161);
            this.tbComponents.Name = "tbComponents";
            this.tbComponents.SelectedIndex = 0;
            this.tbComponents.Size = new System.Drawing.Size(801, 450);
            this.tbComponents.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSubirPrimerNivel);
            this.tabPage1.Controls.Add(this.btnAddComponent);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.textBox4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.textBox3);
            this.tabPage1.Controls.Add(this.textBox2);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.lNombreComponente);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(793, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manegar Componentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSubirPrimerNivel
            // 
            this.btnSubirPrimerNivel.Location = new System.Drawing.Point(176, 46);
            this.btnSubirPrimerNivel.Name = "btnSubirPrimerNivel";
            this.btnSubirPrimerNivel.Size = new System.Drawing.Size(137, 23);
            this.btnSubirPrimerNivel.TabIndex = 29;
            this.btnSubirPrimerNivel.Text = "Subir al Primer Nivel";
            this.btnSubirPrimerNivel.UseVisualStyleBackColor = true;
            // 
            // btnAddComponent
            // 
            this.btnAddComponent.Location = new System.Drawing.Point(631, 52);
            this.btnAddComponent.Name = "btnAddComponent";
            this.btnAddComponent.Size = new System.Drawing.Size(117, 23);
            this.btnAddComponent.TabIndex = 21;
            this.btnAddComponent.Text = "Nuevo Componente";
            this.btnAddComponent.UseVisualStyleBackColor = true;
            this.btnAddComponent.Click += new System.EventHandler(this.btnAddComponent_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(45, 46);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 23);
            this.button3.TabIndex = 19;
            this.button3.Text = "Subir de nivel";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(480, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Componentes Hijos";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(105, 190);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Precio";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "dias",
            "semanas",
            "meses"});
            this.comboBox1.Location = new System.Drawing.Point(156, 334);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(49, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(105, 335);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(45, 20);
            this.textBox3.TabIndex = 24;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(105, 257);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 23;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(105, 128);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(102, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Plazo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Cantidad";
            // 
            // lNombreComponente
            // 
            this.lNombreComponente.AutoSize = true;
            this.lNombreComponente.Location = new System.Drawing.Point(102, 90);
            this.lNombreComponente.Name = "lNombreComponente";
            this.lNombreComponente.Size = new System.Drawing.Size(50, 13);
            this.lNombreComponente.TabIndex = 17;
            this.lNombreComponente.Text = "Nombre: ";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComponenteH,
            this.nombreCH,
            this.descripcionCH,
            this.precioCH,
            this.plazoCH,
            this.tipoCH});
            this.dataGridView3.Location = new System.Drawing.Point(303, 81);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(445, 298);
            this.dataGridView3.TabIndex = 16;
            // 
            // idComponenteH
            // 
            this.idComponenteH.HeaderText = "id";
            this.idComponenteH.Name = "idComponenteH";
            this.idComponenteH.ReadOnly = true;
            this.idComponenteH.Visible = false;
            // 
            // nombreCH
            // 
            this.nombreCH.HeaderText = "nombre";
            this.nombreCH.Name = "nombreCH";
            this.nombreCH.ReadOnly = true;
            // 
            // descripcionCH
            // 
            this.descripcionCH.HeaderText = "descripcion";
            this.descripcionCH.Name = "descripcionCH";
            this.descripcionCH.Visible = false;
            // 
            // precioCH
            // 
            this.precioCH.HeaderText = "precio";
            this.precioCH.Name = "precioCH";
            this.precioCH.ReadOnly = true;
            // 
            // plazoCH
            // 
            this.plazoCH.HeaderText = "plazo";
            this.plazoCH.Name = "plazoCH";
            this.plazoCH.ReadOnly = true;
            // 
            // tipoCH
            // 
            this.tipoCH.HeaderText = "tipo";
            this.tipoCH.Name = "tipoCH";
            this.tipoCH.ReadOnly = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnAddNewComponent);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.tbBusquedaComponente);
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(793, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Componentes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddNewComponent
            // 
            this.btnAddNewComponent.Location = new System.Drawing.Point(648, 36);
            this.btnAddNewComponent.Name = "btnAddNewComponent";
            this.btnAddNewComponent.Size = new System.Drawing.Size(117, 23);
            this.btnAddNewComponent.TabIndex = 17;
            this.btnAddNewComponent.Text = "Nuevo Componente";
            this.btnAddNewComponent.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Búsqueda: ";
            // 
            // tbBusquedaComponente
            // 
            this.tbBusquedaComponente.Location = new System.Drawing.Point(100, 38);
            this.tbBusquedaComponente.Name = "tbBusquedaComponente";
            this.tbBusquedaComponente.Size = new System.Drawing.Size(132, 20);
            this.tbBusquedaComponente.TabIndex = 18;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn3,
            this.plazoC,
            this.tipo});
            this.dataGridView2.Location = new System.Drawing.Point(21, 73);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(744, 293);
            this.dataGridView2.TabIndex = 17;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "precio";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "descripcion";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // plazoC
            // 
            this.plazoC.HeaderText = "plazo";
            this.plazoC.Name = "plazoC";
            this.plazoC.ReadOnly = true;
            // 
            // tipo
            // 
            this.tipo.HeaderText = "tipo";
            this.tipo.Name = "tipo";
            this.tipo.ReadOnly = true;
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 675);
            this.Controls.Add(this.tbComponents);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lProd);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.button1);
            this.Name = "Administracion";
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.tbComponents.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lProd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TabControl tbComponents;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnAddComponent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lNombreComponente;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComponenteH;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazoCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCH;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnAddNewComponent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbBusquedaComponente;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazoC;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo;
        private System.Windows.Forms.Button btnSubirPrimerNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadInventario;
    }
}