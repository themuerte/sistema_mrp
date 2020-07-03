namespace sistema_mrp.vistas.Gestion_De_Inventario
{
    partial class modelo_Q
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_demanda = new System.Windows.Forms.TextBox();
            this.txt_costoPro = new System.Windows.Forms.TextBox();
            this.txt_costoPedir = new System.Windows.Forms.TextBox();
            this.txt_costoM = new System.Windows.Forms.TextBox();
            this.txt_diasAño = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_plazoE = new System.Windows.Forms.Label();
            this.txt_plazoE = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_costoTotal = new System.Windows.Forms.TextBox();
            this.txt_numPedidos = new System.Windows.Forms.TextBox();
            this.txt_Qoptimo = new System.Windows.Forms.TextBox();
            this.txt_TiempoEntreP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_inventarioSegu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bUpdateChart = new System.Windows.Forms.Button();
            this.tbNumeroPeriodos = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cModeloQ = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cModeloQ)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(123, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Demanda anual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(105, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo del producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 168);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Costo de mantenimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(123, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Costo de pedir";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(81, 282);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Días trabajados por año";
            // 
            // txt_demanda
            // 
            this.txt_demanda.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_demanda.Location = new System.Drawing.Point(221, 78);
            this.txt_demanda.Name = "txt_demanda";
            this.txt_demanda.Size = new System.Drawing.Size(100, 21);
            this.txt_demanda.TabIndex = 6;
            this.txt_demanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_demanda_KeyPress);
            // 
            // txt_costoPro
            // 
            this.txt_costoPro.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoPro.Location = new System.Drawing.Point(221, 119);
            this.txt_costoPro.Name = "txt_costoPro";
            this.txt_costoPro.Size = new System.Drawing.Size(100, 21);
            this.txt_costoPro.TabIndex = 7;
            this.txt_costoPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoPro_KeyPress);
            // 
            // txt_costoPedir
            // 
            this.txt_costoPedir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoPedir.Location = new System.Drawing.Point(221, 198);
            this.txt_costoPedir.Name = "txt_costoPedir";
            this.txt_costoPedir.Size = new System.Drawing.Size(100, 21);
            this.txt_costoPedir.TabIndex = 9;
            this.txt_costoPedir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoPedir_KeyPress);
            // 
            // txt_costoM
            // 
            this.txt_costoM.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoM.Location = new System.Drawing.Point(221, 161);
            this.txt_costoM.Name = "txt_costoM";
            this.txt_costoM.Size = new System.Drawing.Size(100, 21);
            this.txt_costoM.TabIndex = 8;
            this.txt_costoM.TextChanged += new System.EventHandler(this.txt_costoM_TextChanged);
            this.txt_costoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoM_KeyPress);
            // 
            // txt_diasAño
            // 
            this.txt_diasAño.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diasAño.Location = new System.Drawing.Point(221, 275);
            this.txt_diasAño.Name = "txt_diasAño";
            this.txt_diasAño.Size = new System.Drawing.Size(100, 21);
            this.txt_diasAño.TabIndex = 10;
            this.txt_diasAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_diasAño_KeyPress);
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_calcular.FlatAppearance.BorderSize = 0;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.White;
            this.btn_calcular.Location = new System.Drawing.Point(120, 340);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 31);
            this.btn_calcular.TabIndex = 11;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(236, 340);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 31);
            this.btn_limpiar.TabIndex = 12;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(525, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Q óptimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(714, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Números de pedidos al año";
            // 
            // lbl_plazoE
            // 
            this.lbl_plazoE.AutoSize = true;
            this.lbl_plazoE.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plazoE.Location = new System.Drawing.Point(112, 242);
            this.lbl_plazoE.Name = "lbl_plazoE";
            this.lbl_plazoE.Size = new System.Drawing.Size(94, 14);
            this.lbl_plazoE.TabIndex = 15;
            this.lbl_plazoE.Text = "Plazo de entrega";
            // 
            // txt_plazoE
            // 
            this.txt_plazoE.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plazoE.Location = new System.Drawing.Point(221, 235);
            this.txt_plazoE.Name = "txt_plazoE";
            this.txt_plazoE.Size = new System.Drawing.Size(100, 21);
            this.txt_plazoE.TabIndex = 16;
            this.txt_plazoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_plazoE_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(518, 171);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Costo total";
            // 
            // txt_costoTotal
            // 
            this.txt_costoTotal.Enabled = false;
            this.txt_costoTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoTotal.Location = new System.Drawing.Point(588, 168);
            this.txt_costoTotal.Name = "txt_costoTotal";
            this.txt_costoTotal.Size = new System.Drawing.Size(100, 21);
            this.txt_costoTotal.TabIndex = 23;
            // 
            // txt_numPedidos
            // 
            this.txt_numPedidos.Enabled = false;
            this.txt_numPedidos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numPedidos.Location = new System.Drawing.Point(874, 100);
            this.txt_numPedidos.Name = "txt_numPedidos";
            this.txt_numPedidos.Size = new System.Drawing.Size(100, 21);
            this.txt_numPedidos.TabIndex = 21;
            this.txt_numPedidos.TextChanged += new System.EventHandler(this.txt_numPedidos_TextChanged);
            // 
            // txt_Qoptimo
            // 
            this.txt_Qoptimo.Enabled = false;
            this.txt_Qoptimo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qoptimo.Location = new System.Drawing.Point(588, 97);
            this.txt_Qoptimo.Name = "txt_Qoptimo";
            this.txt_Qoptimo.Size = new System.Drawing.Size(100, 21);
            this.txt_Qoptimo.TabIndex = 20;
            // 
            // txt_TiempoEntreP
            // 
            this.txt_TiempoEntreP.Enabled = false;
            this.txt_TiempoEntreP.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TiempoEntreP.Location = new System.Drawing.Point(590, 134);
            this.txt_TiempoEntreP.Name = "txt_TiempoEntreP";
            this.txt_TiempoEntreP.Size = new System.Drawing.Size(98, 21);
            this.txt_TiempoEntreP.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(461, 137);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 14);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tiempo entre pedidos";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(25, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Datos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(666, 58);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Resultado";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // txt_inventarioSegu
            // 
            this.txt_inventarioSegu.Enabled = false;
            this.txt_inventarioSegu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inventarioSegu.Location = new System.Drawing.Point(874, 134);
            this.txt_inventarioSegu.Name = "txt_inventarioSegu";
            this.txt_inventarioSegu.Size = new System.Drawing.Size(100, 21);
            this.txt_inventarioSegu.TabIndex = 30;
            this.txt_inventarioSegu.TextChanged += new System.EventHandler(this.txt_inventarioSegu_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(734, 141);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 14);
            this.label13.TabIndex = 29;
            this.label13.Text = "Inventario de seguridad";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(986, 44);
            this.panel3.TabIndex = 41;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(0, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(953, 39);
            this.label15.TabIndex = 0;
            this.label15.Text = "Modelo Q";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(29, 69);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(417, 477);
            this.tabControl1.TabIndex = 42;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txt_diasAño);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.txt_demanda);
            this.tabPage1.Controls.Add(this.txt_costoPro);
            this.tabPage1.Controls.Add(this.txt_costoM);
            this.tabPage1.Controls.Add(this.txt_costoPedir);
            this.tabPage1.Controls.Add(this.btn_calcular);
            this.tabPage1.Controls.Add(this.btn_limpiar);
            this.tabPage1.Controls.Add(this.lbl_plazoE);
            this.tabPage1.Controls.Add(this.txt_plazoE);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(409, 451);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Nuevos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dgvProductos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(409, 451);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Producto Registrado";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.descripcion});
            this.dgvProductos.Location = new System.Drawing.Point(16, 41);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.Size = new System.Drawing.Size(366, 363);
            this.dgvProductos.TabIndex = 3;
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // bUpdateChart
            // 
            this.bUpdateChart.Location = new System.Drawing.Point(751, 527);
            this.bUpdateChart.Name = "bUpdateChart";
            this.bUpdateChart.Size = new System.Drawing.Size(116, 23);
            this.bUpdateChart.TabIndex = 46;
            this.bUpdateChart.Text = "Actualizar Gráfico";
            this.bUpdateChart.UseVisualStyleBackColor = true;
            this.bUpdateChart.Click += new System.EventHandler(this.bUpdateChart_Click);
            // 
            // tbNumeroPeriodos
            // 
            this.tbNumeroPeriodos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroPeriodos.Location = new System.Drawing.Point(645, 529);
            this.tbNumeroPeriodos.Name = "tbNumeroPeriodos";
            this.tbNumeroPeriodos.Size = new System.Drawing.Size(100, 21);
            this.tbNumeroPeriodos.TabIndex = 45;
            this.tbNumeroPeriodos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeroPeriodos_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(517, 532);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 14);
            this.label9.TabIndex = 44;
            this.label9.Text = "Número de Períodos";
            // 
            // cModeloQ
            // 
            chartArea3.Name = "ChartArea1";
            this.cModeloQ.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.cModeloQ.Legends.Add(legend3);
            this.cModeloQ.Location = new System.Drawing.Point(482, 210);
            this.cModeloQ.Name = "cModeloQ";
            this.cModeloQ.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "QOptimo";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Legend = "Legend1";
            series8.Name = "Inventario";
            series9.ChartArea = "ChartArea1";
            series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series9.Legend = "Legend1";
            series9.Name = "SSeguridad";
            this.cModeloQ.Series.Add(series7);
            this.cModeloQ.Series.Add(series8);
            this.cModeloQ.Series.Add(series9);
            this.cModeloQ.Size = new System.Drawing.Size(427, 300);
            this.cModeloQ.TabIndex = 43;
            this.cModeloQ.Text = "Modelo Q";
            title3.Name = "tModeloQ";
            title3.Text = "Modelo Q";
            this.cModeloQ.Titles.Add(title3);
            // 
            // modelo_Q
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(986, 621);
            this.Controls.Add(this.bUpdateChart);
            this.Controls.Add(this.tbNumeroPeriodos);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_inventarioSegu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txt_TiempoEntreP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_costoTotal);
            this.Controls.Add(this.txt_numPedidos);
            this.Controls.Add(this.txt_Qoptimo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cModeloQ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modelo_Q";
            this.Text = "modelo_Q";
            this.Load += new System.EventHandler(this.modelo_Q_Load);
            this.panel3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cModeloQ)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_demanda;
        private System.Windows.Forms.TextBox txt_costoPro;
        private System.Windows.Forms.TextBox txt_costoPedir;
        private System.Windows.Forms.TextBox txt_costoM;
        private System.Windows.Forms.TextBox txt_diasAño;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_plazoE;
        private System.Windows.Forms.TextBox txt_plazoE;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_costoTotal;
        private System.Windows.Forms.TextBox txt_numPedidos;
        private System.Windows.Forms.TextBox txt_Qoptimo;
        private System.Windows.Forms.TextBox txt_TiempoEntreP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_inventarioSegu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button bUpdateChart;
        private System.Windows.Forms.TextBox tbNumeroPeriodos;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataVisualization.Charting.Chart cModeloQ;
    }
}