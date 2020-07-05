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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lProd = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dgvBOM = new System.Windows.Forms.TabControl();
            this.tpProductosDetalles = new System.Windows.Forms.TabPage();
            this.dgvDemanda = new System.Windows.Forms.DataGridView();
            this.idPlanProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.demanda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lIdProductoSel = new System.Windows.Forms.Label();
            this.btnEditarPP = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ModP = new System.Windows.Forms.TabPage();
            this.btnEditarP1 = new System.Windows.Forms.Button();
            this.tbProbabilidadDemanda = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDesviacion = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPeriodoRevision = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPlazodeEntregaP = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbDemandaDiaria = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ModQ = new System.Windows.Forms.TabPage();
            this.tbCostoUnitario = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbCostoFaltante = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.tbStockSeguridad = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.tbInventarioInicial = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.tbCostoMantenimiento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditarP2 = new System.Windows.Forms.Button();
            this.MRP = new System.Windows.Forms.TabPage();
            this.btnEditarP3 = new System.Windows.Forms.Button();
            this.tbCostoHrsExtras = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.tbCostosxHoras = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.tbHorasRequeridas = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.tbCostoPorPedir = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbInventario = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lNombreComponente = new System.Windows.Forms.Label();
            this.tpEmpresa = new System.Windows.Forms.TabPage();
            this.dgvDiasHabiles = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbCostoDespido = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tbFuerzaLaboral = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.tbCostoContratacion = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tbCostoSubContratacion = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbDiaTrabajadoXAnio = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnEditarOD = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.MensajeSalir = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.dgvBOM.SuspendLayout();
            this.tpProductosDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemanda)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.ModP.SuspendLayout();
            this.ModQ.SuspendLayout();
            this.MRP.SuspendLayout();
            this.tpEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasHabiles)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::sistema_mrp.Properties.Resources.shapes_and_symbols;
            this.button1.Location = new System.Drawing.Point(13, 746);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(86, 62);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.descripcion});
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.dgvProductos.Location = new System.Drawing.Point(4, 68);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(872, 154);
            this.dgvProductos.TabIndex = 1;
            this.dgvProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellContentClick);
            this.dgvProductos.SelectionChanged += new System.EventHandler(this.dgvProductos_SelectionChanged);
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.MinimumWidth = 6;
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "descripcion";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            // 
            // lProd
            // 
            this.lProd.AutoSize = true;
            this.lProd.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProd.Location = new System.Drawing.Point(365, 21);
            this.lProd.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lProd.Name = "lProd";
            this.lProd.Size = new System.Drawing.Size(150, 36);
            this.lProd.TabIndex = 4;
            this.lProd.Text = "Productos";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(16, 676);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 41);
            this.button2.TabIndex = 6;
            this.button2.Text = "Atrás";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btnAddProduct.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.Color.White;
            this.btnAddProduct.Location = new System.Drawing.Point(72, 487);
            this.btnAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(151, 39);
            this.btnAddProduct.TabIndex = 8;
            this.btnAddProduct.Text = "Nuevo Producto";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dgvBOM
            // 
            this.dgvBOM.Controls.Add(this.tpProductosDetalles);
            this.dgvBOM.Controls.Add(this.tpEmpresa);
            this.dgvBOM.Location = new System.Drawing.Point(16, 50);
            this.dgvBOM.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBOM.Name = "dgvBOM";
            this.dgvBOM.SelectedIndex = 0;
            this.dgvBOM.Size = new System.Drawing.Size(1247, 618);
            this.dgvBOM.TabIndex = 16;
            // 
            // tpProductosDetalles
            // 
            this.tpProductosDetalles.BackColor = System.Drawing.SystemColors.Control;
            this.tpProductosDetalles.Controls.Add(this.dgvDemanda);
            this.tpProductosDetalles.Controls.Add(this.lIdProductoSel);
            this.tpProductosDetalles.Controls.Add(this.btnEditarPP);
            this.tpProductosDetalles.Controls.Add(this.tabControl1);
            this.tpProductosDetalles.Controls.Add(this.tbDescripcion);
            this.tpProductosDetalles.Controls.Add(this.btnAddProduct);
            this.tpProductosDetalles.Controls.Add(this.label1);
            this.tpProductosDetalles.Controls.Add(this.lProd);
            this.tpProductosDetalles.Controls.Add(this.dgvProductos);
            this.tpProductosDetalles.Controls.Add(this.tbInventario);
            this.tpProductosDetalles.Controls.Add(this.tbNombre);
            this.tpProductosDetalles.Controls.Add(this.label2);
            this.tpProductosDetalles.Controls.Add(this.lNombreComponente);
            this.tpProductosDetalles.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpProductosDetalles.Location = new System.Drawing.Point(4, 25);
            this.tpProductosDetalles.Margin = new System.Windows.Forms.Padding(4);
            this.tpProductosDetalles.Name = "tpProductosDetalles";
            this.tpProductosDetalles.Padding = new System.Windows.Forms.Padding(4);
            this.tpProductosDetalles.Size = new System.Drawing.Size(1239, 589);
            this.tpProductosDetalles.TabIndex = 0;
            this.tpProductosDetalles.Text = "Productos";
            this.tpProductosDetalles.Click += new System.EventHandler(this.tpProductosDetalles_Click);
            // 
            // dgvDemanda
            // 
            this.dgvDemanda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDemanda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDemanda.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dgvDemanda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemanda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPlanProducto,
            this.mes,
            this.demanda});
            this.dgvDemanda.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.dgvDemanda.Location = new System.Drawing.Point(21, 231);
            this.dgvDemanda.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDemanda.Name = "dgvDemanda";
            this.dgvDemanda.RowHeadersWidth = 51;
            this.dgvDemanda.Size = new System.Drawing.Size(771, 136);
            this.dgvDemanda.TabIndex = 30;
            this.dgvDemanda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDemanda_CellDoubleClick);
            // 
            // idPlanProducto
            // 
            this.idPlanProducto.HeaderText = "id";
            this.idPlanProducto.MinimumWidth = 6;
            this.idPlanProducto.Name = "idPlanProducto";
            this.idPlanProducto.Visible = false;
            // 
            // mes
            // 
            this.mes.HeaderText = "mes";
            this.mes.MinimumWidth = 6;
            this.mes.Name = "mes";
            // 
            // demanda
            // 
            this.demanda.HeaderText = "demanda";
            this.demanda.MinimumWidth = 6;
            this.demanda.Name = "demanda";
            // 
            // lIdProductoSel
            // 
            this.lIdProductoSel.AutoSize = true;
            this.lIdProductoSel.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIdProductoSel.Location = new System.Drawing.Point(18, 406);
            this.lIdProductoSel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lIdProductoSel.Name = "lIdProductoSel";
            this.lIdProductoSel.Size = new System.Drawing.Size(21, 18);
            this.lIdProductoSel.TabIndex = 18;
            this.lIdProductoSel.Text = "id";
            // 
            // btnEditarPP
            // 
            this.btnEditarPP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarPP.Image = global::sistema_mrp.Properties.Resources.edit;
            this.btnEditarPP.Location = new System.Drawing.Point(802, 392);
            this.btnEditarPP.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarPP.Name = "btnEditarPP";
            this.btnEditarPP.Size = new System.Drawing.Size(33, 31);
            this.btnEditarPP.TabIndex = 29;
            this.btnEditarPP.Text = "E";
            this.btnEditarPP.UseVisualStyleBackColor = true;
            this.btnEditarPP.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ModP);
            this.tabControl1.Controls.Add(this.ModQ);
            this.tabControl1.Controls.Add(this.MRP);
            this.tabControl1.Location = new System.Drawing.Point(884, 21);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(335, 377);
            this.tabControl1.TabIndex = 28;
            // 
            // ModP
            // 
            this.ModP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.ModP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ModP.Controls.Add(this.btnEditarP1);
            this.ModP.Controls.Add(this.tbProbabilidadDemanda);
            this.ModP.Controls.Add(this.label9);
            this.ModP.Controls.Add(this.tbDesviacion);
            this.ModP.Controls.Add(this.label10);
            this.ModP.Controls.Add(this.tbPeriodoRevision);
            this.ModP.Controls.Add(this.label11);
            this.ModP.Controls.Add(this.tbPlazodeEntregaP);
            this.ModP.Controls.Add(this.label12);
            this.ModP.Controls.Add(this.tbDemandaDiaria);
            this.ModP.Controls.Add(this.label13);
            this.ModP.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModP.Location = new System.Drawing.Point(4, 25);
            this.ModP.Margin = new System.Windows.Forms.Padding(4);
            this.ModP.Name = "ModP";
            this.ModP.Padding = new System.Windows.Forms.Padding(4);
            this.ModP.Size = new System.Drawing.Size(327, 348);
            this.ModP.TabIndex = 0;
            this.ModP.Text = "Primera Parte";
            // 
            // btnEditarP1
            // 
            this.btnEditarP1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarP1.Image = global::sistema_mrp.Properties.Resources.edit;
            this.btnEditarP1.Location = new System.Drawing.Point(230, 268);
            this.btnEditarP1.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarP1.Name = "btnEditarP1";
            this.btnEditarP1.Size = new System.Drawing.Size(33, 31);
            this.btnEditarP1.TabIndex = 30;
            this.btnEditarP1.Text = "E";
            this.btnEditarP1.UseVisualStyleBackColor = true;
            this.btnEditarP1.Click += new System.EventHandler(this.btnEditarP1_Click);
            // 
            // tbProbabilidadDemanda
            // 
            this.tbProbabilidadDemanda.Location = new System.Drawing.Point(29, 266);
            this.tbProbabilidadDemanda.Margin = new System.Windows.Forms.Padding(4);
            this.tbProbabilidadDemanda.Name = "tbProbabilidadDemanda";
            this.tbProbabilidadDemanda.Size = new System.Drawing.Size(177, 27);
            this.tbProbabilidadDemanda.TabIndex = 49;
            this.tbProbabilidadDemanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbProbabilidadDemanda_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 245);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(212, 19);
            this.label9.TabIndex = 48;
            this.label9.Text = "Probabilidad de la Demanda:";
            // 
            // tbDesviacion
            // 
            this.tbDesviacion.Location = new System.Drawing.Point(28, 148);
            this.tbDesviacion.Margin = new System.Windows.Forms.Padding(4);
            this.tbDesviacion.Name = "tbDesviacion";
            this.tbDesviacion.Size = new System.Drawing.Size(177, 27);
            this.tbDesviacion.TabIndex = 47;
            this.tbDesviacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDesviacion_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(25, 127);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 19);
            this.label10.TabIndex = 46;
            this.label10.Text = "Desviación:";
            // 
            // tbPeriodoRevision
            // 
            this.tbPeriodoRevision.Location = new System.Drawing.Point(29, 205);
            this.tbPeriodoRevision.Margin = new System.Windows.Forms.Padding(4);
            this.tbPeriodoRevision.Name = "tbPeriodoRevision";
            this.tbPeriodoRevision.Size = new System.Drawing.Size(177, 27);
            this.tbPeriodoRevision.TabIndex = 45;
            this.tbPeriodoRevision.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPeriodoRevision_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(26, 184);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(149, 19);
            this.label11.TabIndex = 44;
            this.label11.Text = "Periodo de Revisión";
            // 
            // tbPlazodeEntregaP
            // 
            this.tbPlazodeEntregaP.Location = new System.Drawing.Point(25, 90);
            this.tbPlazodeEntregaP.Margin = new System.Windows.Forms.Padding(4);
            this.tbPlazodeEntregaP.Name = "tbPlazodeEntregaP";
            this.tbPlazodeEntregaP.Size = new System.Drawing.Size(177, 27);
            this.tbPlazodeEntregaP.TabIndex = 43;
            this.tbPlazodeEntregaP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbPlazodeEntregaP_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(22, 69);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(126, 19);
            this.label12.TabIndex = 42;
            this.label12.Text = "Plazo de Entrega";
            // 
            // tbDemandaDiaria
            // 
            this.tbDemandaDiaria.Location = new System.Drawing.Point(29, 38);
            this.tbDemandaDiaria.Margin = new System.Windows.Forms.Padding(4);
            this.tbDemandaDiaria.Name = "tbDemandaDiaria";
            this.tbDemandaDiaria.Size = new System.Drawing.Size(177, 27);
            this.tbDemandaDiaria.TabIndex = 41;
            this.tbDemandaDiaria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDemandaDiaria_KeyPress);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(26, 17);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 19);
            this.label13.TabIndex = 40;
            this.label13.Text = "Demanda Diaria";
            // 
            // ModQ
            // 
            this.ModQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.ModQ.Controls.Add(this.tbCostoUnitario);
            this.ModQ.Controls.Add(this.label15);
            this.ModQ.Controls.Add(this.tbCostoFaltante);
            this.ModQ.Controls.Add(this.label23);
            this.ModQ.Controls.Add(this.tbStockSeguridad);
            this.ModQ.Controls.Add(this.label22);
            this.ModQ.Controls.Add(this.tbInventarioInicial);
            this.ModQ.Controls.Add(this.label20);
            this.ModQ.Controls.Add(this.tbCostoMantenimiento);
            this.ModQ.Controls.Add(this.label6);
            this.ModQ.Controls.Add(this.btnEditarP2);
            this.ModQ.Location = new System.Drawing.Point(4, 25);
            this.ModQ.Margin = new System.Windows.Forms.Padding(4);
            this.ModQ.Name = "ModQ";
            this.ModQ.Padding = new System.Windows.Forms.Padding(4);
            this.ModQ.Size = new System.Drawing.Size(300, 348);
            this.ModQ.TabIndex = 1;
            this.ModQ.Text = "Segunda Parte";
            // 
            // tbCostoUnitario
            // 
            this.tbCostoUnitario.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoUnitario.Location = new System.Drawing.Point(24, 100);
            this.tbCostoUnitario.Margin = new System.Windows.Forms.Padding(4);
            this.tbCostoUnitario.Name = "tbCostoUnitario";
            this.tbCostoUnitario.Size = new System.Drawing.Size(177, 24);
            this.tbCostoUnitario.TabIndex = 55;
            this.tbCostoUnitario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCostoUnitario_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(21, 78);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(128, 18);
            this.label15.TabIndex = 54;
            this.label15.Text = "Costo por unidad:";
            // 
            // tbCostoFaltante
            // 
            this.tbCostoFaltante.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoFaltante.Location = new System.Drawing.Point(24, 44);
            this.tbCostoFaltante.Margin = new System.Windows.Forms.Padding(4);
            this.tbCostoFaltante.Name = "tbCostoFaltante";
            this.tbCostoFaltante.Size = new System.Drawing.Size(177, 24);
            this.tbCostoFaltante.TabIndex = 53;
            this.tbCostoFaltante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCostoFaltante_KeyPress);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(21, 22);
            this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(111, 18);
            this.label23.TabIndex = 52;
            this.label23.Text = "Costo Faltante: ";
            // 
            // tbStockSeguridad
            // 
            this.tbStockSeguridad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockSeguridad.Location = new System.Drawing.Point(24, 207);
            this.tbStockSeguridad.Margin = new System.Windows.Forms.Padding(4);
            this.tbStockSeguridad.Name = "tbStockSeguridad";
            this.tbStockSeguridad.Size = new System.Drawing.Size(177, 24);
            this.tbStockSeguridad.TabIndex = 51;
            this.tbStockSeguridad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbStockSeguridad_KeyPress);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(21, 185);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(139, 18);
            this.label22.TabIndex = 50;
            this.label22.Text = "Stock de seguridad:";
            // 
            // tbInventarioInicial
            // 
            this.tbInventarioInicial.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventarioInicial.Location = new System.Drawing.Point(26, 254);
            this.tbInventarioInicial.Margin = new System.Windows.Forms.Padding(4);
            this.tbInventarioInicial.Name = "tbInventarioInicial";
            this.tbInventarioInicial.Size = new System.Drawing.Size(177, 24);
            this.tbInventarioInicial.TabIndex = 49;
            this.tbInventarioInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInventarioInicial_KeyPress);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(21, 235);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(120, 18);
            this.label20.TabIndex = 48;
            this.label20.Text = "Inventario Inicial";
            // 
            // tbCostoMantenimiento
            // 
            this.tbCostoMantenimiento.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoMantenimiento.Location = new System.Drawing.Point(24, 157);
            this.tbCostoMantenimiento.Margin = new System.Windows.Forms.Padding(4);
            this.tbCostoMantenimiento.Name = "tbCostoMantenimiento";
            this.tbCostoMantenimiento.Size = new System.Drawing.Size(177, 24);
            this.tbCostoMantenimiento.TabIndex = 45;
            this.tbCostoMantenimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCostoMantenimiento_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(21, 135);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(182, 18);
            this.label6.TabIndex = 44;
            this.label6.Text = "Costo del mantenimiento:";
            // 
            // btnEditarP2
            // 
            this.btnEditarP2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarP2.Image = global::sistema_mrp.Properties.Resources.edit;
            this.btnEditarP2.Location = new System.Drawing.Point(226, 250);
            this.btnEditarP2.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarP2.Name = "btnEditarP2";
            this.btnEditarP2.Size = new System.Drawing.Size(33, 31);
            this.btnEditarP2.TabIndex = 30;
            this.btnEditarP2.Text = "E";
            this.btnEditarP2.UseVisualStyleBackColor = true;
            this.btnEditarP2.Click += new System.EventHandler(this.btnEditarP2_Click);
            // 
            // MRP
            // 
            this.MRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.MRP.Controls.Add(this.btnEditarP3);
            this.MRP.Controls.Add(this.tbCostoHrsExtras);
            this.MRP.Controls.Add(this.label25);
            this.MRP.Controls.Add(this.tbCostosxHoras);
            this.MRP.Controls.Add(this.label24);
            this.MRP.Controls.Add(this.tbHorasRequeridas);
            this.MRP.Controls.Add(this.label21);
            this.MRP.Controls.Add(this.tbCostoPorPedir);
            this.MRP.Controls.Add(this.label14);
            this.MRP.Location = new System.Drawing.Point(4, 25);
            this.MRP.Margin = new System.Windows.Forms.Padding(4);
            this.MRP.Name = "MRP";
            this.MRP.Size = new System.Drawing.Size(300, 348);
            this.MRP.TabIndex = 2;
            this.MRP.Text = "Tercera Parte";
            // 
            // btnEditarP3
            // 
            this.btnEditarP3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarP3.Image = global::sistema_mrp.Properties.Resources.edit;
            this.btnEditarP3.Location = new System.Drawing.Point(213, 208);
            this.btnEditarP3.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarP3.Name = "btnEditarP3";
            this.btnEditarP3.Size = new System.Drawing.Size(39, 31);
            this.btnEditarP3.TabIndex = 56;
            this.btnEditarP3.Text = "E";
            this.btnEditarP3.UseVisualStyleBackColor = true;
            this.btnEditarP3.Click += new System.EventHandler(this.btnEditarP3_Click);
            // 
            // tbCostoHrsExtras
            // 
            this.tbCostoHrsExtras.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoHrsExtras.Location = new System.Drawing.Point(11, 208);
            this.tbCostoHrsExtras.Margin = new System.Windows.Forms.Padding(4);
            this.tbCostoHrsExtras.Name = "tbCostoHrsExtras";
            this.tbCostoHrsExtras.Size = new System.Drawing.Size(177, 24);
            this.tbCostoHrsExtras.TabIndex = 55;
            this.tbCostoHrsExtras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCostoHrsExtras_KeyPress);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(8, 187);
            this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(160, 18);
            this.label25.TabIndex = 54;
            this.label25.Text = "Costo por horas extras:";
            // 
            // tbCostosxHoras
            // 
            this.tbCostosxHoras.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostosxHoras.Location = new System.Drawing.Point(9, 145);
            this.tbCostosxHoras.Margin = new System.Windows.Forms.Padding(4);
            this.tbCostosxHoras.Name = "tbCostosxHoras";
            this.tbCostosxHoras.Size = new System.Drawing.Size(177, 24);
            this.tbCostosxHoras.TabIndex = 53;
            this.tbCostosxHoras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCostosxHoras_KeyPress);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(6, 124);
            this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(117, 18);
            this.label24.TabIndex = 52;
            this.label24.Text = "Costo por horas:";
            // 
            // tbHorasRequeridas
            // 
            this.tbHorasRequeridas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHorasRequeridas.Location = new System.Drawing.Point(9, 84);
            this.tbHorasRequeridas.Margin = new System.Windows.Forms.Padding(4);
            this.tbHorasRequeridas.Name = "tbHorasRequeridas";
            this.tbHorasRequeridas.Size = new System.Drawing.Size(177, 24);
            this.tbHorasRequeridas.TabIndex = 47;
            this.tbHorasRequeridas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbHorasRequeridas_KeyPress);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(6, 63);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(233, 18);
            this.label21.TabIndex = 46;
            this.label21.Text = "Horas requeridas para producirlo:";
            // 
            // tbCostoPorPedir
            // 
            this.tbCostoPorPedir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoPorPedir.Location = new System.Drawing.Point(9, 31);
            this.tbCostoPorPedir.Margin = new System.Windows.Forms.Padding(4);
            this.tbCostoPorPedir.Name = "tbCostoPorPedir";
            this.tbCostoPorPedir.Size = new System.Drawing.Size(177, 24);
            this.tbCostoPorPedir.TabIndex = 43;
            this.tbCostoPorPedir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCostoPorPedir_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(6, 10);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 18);
            this.label14.TabIndex = 42;
            this.label14.Text = "Costo por Pedir:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDescripcion.Location = new System.Drawing.Point(250, 402);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(376, 24);
            this.tbDescripcion.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(247, 380);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Descripción:";
            // 
            // tbInventario
            // 
            this.tbInventario.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventario.Location = new System.Drawing.Point(662, 399);
            this.tbInventario.Margin = new System.Windows.Forms.Padding(4);
            this.tbInventario.Name = "tbInventario";
            this.tbInventario.Size = new System.Drawing.Size(132, 24);
            this.tbInventario.TabIndex = 23;
            this.tbInventario.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            this.tbInventario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbInventario_KeyPress);
            // 
            // tbNombre
            // 
            this.tbNombre.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombre.Location = new System.Drawing.Point(46, 402);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(177, 24);
            this.tbNombre.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(659, 377);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 18);
            this.label2.TabIndex = 18;
            this.label2.Text = "Inventario:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lNombreComponente
            // 
            this.lNombreComponente.AutoSize = true;
            this.lNombreComponente.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreComponente.Location = new System.Drawing.Point(43, 380);
            this.lNombreComponente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lNombreComponente.Name = "lNombreComponente";
            this.lNombreComponente.Size = new System.Drawing.Size(70, 18);
            this.lNombreComponente.TabIndex = 17;
            this.lNombreComponente.Text = "Nombre: ";
            // 
            // tpEmpresa
            // 
            this.tpEmpresa.BackColor = System.Drawing.SystemColors.Control;
            this.tpEmpresa.Controls.Add(this.dgvDiasHabiles);
            this.tpEmpresa.Controls.Add(this.tbCostoDespido);
            this.tpEmpresa.Controls.Add(this.label19);
            this.tpEmpresa.Controls.Add(this.tbFuerzaLaboral);
            this.tpEmpresa.Controls.Add(this.label18);
            this.tpEmpresa.Controls.Add(this.tbCostoContratacion);
            this.tpEmpresa.Controls.Add(this.label17);
            this.tpEmpresa.Controls.Add(this.tbCostoSubContratacion);
            this.tpEmpresa.Controls.Add(this.label16);
            this.tpEmpresa.Controls.Add(this.tbDiaTrabajadoXAnio);
            this.tpEmpresa.Controls.Add(this.label5);
            this.tpEmpresa.Controls.Add(this.tbNombreEmpresa);
            this.tpEmpresa.Controls.Add(this.label7);
            this.tpEmpresa.Controls.Add(this.btnEditarOD);
            this.tpEmpresa.Location = new System.Drawing.Point(4, 25);
            this.tpEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.tpEmpresa.Name = "tpEmpresa";
            this.tpEmpresa.Size = new System.Drawing.Size(1200, 589);
            this.tpEmpresa.TabIndex = 2;
            this.tpEmpresa.Text = "Otros Datos";
            // 
            // dgvDiasHabiles
            // 
            this.dgvDiasHabiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDiasHabiles.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDiasHabiles.BackgroundColor = System.Drawing.Color.White;
            this.dgvDiasHabiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiasHabiles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dgvDiasHabiles.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.dgvDiasHabiles.Location = new System.Drawing.Point(71, 333);
            this.dgvDiasHabiles.Margin = new System.Windows.Forms.Padding(4);
            this.dgvDiasHabiles.Name = "dgvDiasHabiles";
            this.dgvDiasHabiles.RowHeadersWidth = 51;
            this.dgvDiasHabiles.Size = new System.Drawing.Size(832, 215);
            this.dgvDiasHabiles.TabIndex = 63;
            this.dgvDiasHabiles.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvDiasHabiles_CellMouseDoubleClick);
            this.dgvDiasHabiles.SelectionChanged += new System.EventHandler(this.dgvDiasHabiles_SelectionChanged);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "mes";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "diasHabiles";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // tbCostoDespido
            // 
            this.tbCostoDespido.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoDespido.Location = new System.Drawing.Point(71, 235);
            this.tbCostoDespido.Margin = new System.Windows.Forms.Padding(4);
            this.tbCostoDespido.Name = "tbCostoDespido";
            this.tbCostoDespido.Size = new System.Drawing.Size(177, 24);
            this.tbCostoDespido.TabIndex = 61;
            this.tbCostoDespido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCostoDespido_KeyPress);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(68, 199);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(128, 18);
            this.label19.TabIndex = 60;
            this.label19.Text = "Costo de despido:";
            // 
            // tbFuerzaLaboral
            // 
            this.tbFuerzaLaboral.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFuerzaLaboral.Location = new System.Drawing.Point(353, 237);
            this.tbFuerzaLaboral.Margin = new System.Windows.Forms.Padding(4);
            this.tbFuerzaLaboral.Name = "tbFuerzaLaboral";
            this.tbFuerzaLaboral.Size = new System.Drawing.Size(177, 24);
            this.tbFuerzaLaboral.TabIndex = 59;
            this.tbFuerzaLaboral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbFuerzaLaboral_KeyPress);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(350, 199);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(109, 18);
            this.label18.TabIndex = 58;
            this.label18.Text = "Fuerza Laboral:";
            // 
            // tbCostoContratacion
            // 
            this.tbCostoContratacion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoContratacion.Location = new System.Drawing.Point(353, 142);
            this.tbCostoContratacion.Margin = new System.Windows.Forms.Padding(4);
            this.tbCostoContratacion.Name = "tbCostoContratacion";
            this.tbCostoContratacion.Size = new System.Drawing.Size(177, 24);
            this.tbCostoContratacion.TabIndex = 57;
            this.tbCostoContratacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCostoContratacion_KeyPress);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(350, 107);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(165, 18);
            this.label17.TabIndex = 56;
            this.label17.Text = "Costo de Contratación: ";
            // 
            // tbCostoSubContratacion
            // 
            this.tbCostoSubContratacion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoSubContratacion.Location = new System.Drawing.Point(587, 141);
            this.tbCostoSubContratacion.Margin = new System.Windows.Forms.Padding(4);
            this.tbCostoSubContratacion.Name = "tbCostoSubContratacion";
            this.tbCostoSubContratacion.Size = new System.Drawing.Size(177, 24);
            this.tbCostoSubContratacion.TabIndex = 55;
            this.tbCostoSubContratacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCostoSubContratacion_KeyPress);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(584, 107);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(185, 18);
            this.label16.TabIndex = 54;
            this.label16.Text = "Costo de Subcontratación:";
            // 
            // tbDiaTrabajadoXAnio
            // 
            this.tbDiaTrabajadoXAnio.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDiaTrabajadoXAnio.Location = new System.Drawing.Point(71, 142);
            this.tbDiaTrabajadoXAnio.Margin = new System.Windows.Forms.Padding(4);
            this.tbDiaTrabajadoXAnio.Name = "tbDiaTrabajadoXAnio";
            this.tbDiaTrabajadoXAnio.Size = new System.Drawing.Size(177, 24);
            this.tbDiaTrabajadoXAnio.TabIndex = 53;
            this.tbDiaTrabajadoXAnio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDiaTrabajadoXAnio_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(68, 107);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 18);
            this.label5.TabIndex = 52;
            this.label5.Text = "Días Trabajado  por Año:";
            // 
            // tbNombreEmpresa
            // 
            this.tbNombreEmpresa.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreEmpresa.Location = new System.Drawing.Point(240, 20);
            this.tbNombreEmpresa.Margin = new System.Windows.Forms.Padding(4);
            this.tbNombreEmpresa.Name = "tbNombreEmpresa";
            this.tbNombreEmpresa.Size = new System.Drawing.Size(419, 24);
            this.tbNombreEmpresa.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(68, 26);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(164, 18);
            this.label7.TabIndex = 50;
            this.label7.Text = "Nombre de la Empresa:";
            // 
            // btnEditarOD
            // 
            this.btnEditarOD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarOD.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarOD.Image = global::sistema_mrp.Properties.Resources.edit;
            this.btnEditarOD.Location = new System.Drawing.Point(654, 228);
            this.btnEditarOD.Margin = new System.Windows.Forms.Padding(4);
            this.btnEditarOD.Name = "btnEditarOD";
            this.btnEditarOD.Size = new System.Drawing.Size(33, 31);
            this.btnEditarOD.TabIndex = 62;
            this.btnEditarOD.Text = "E";
            this.btnEditarOD.UseVisualStyleBackColor = true;
            this.btnEditarOD.Click += new System.EventHandler(this.btnEditarOD_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(484, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 36);
            this.label3.TabIndex = 17;
            this.label3.Text = "Administración";
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1314, 831);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvBOM);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Administracion";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administracion";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Administracion_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.dgvBOM.ResumeLayout(false);
            this.tpProductosDetalles.ResumeLayout(false);
            this.tpProductosDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemanda)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ModP.ResumeLayout(false);
            this.ModP.PerformLayout();
            this.ModQ.ResumeLayout(false);
            this.ModQ.PerformLayout();
            this.MRP.ResumeLayout(false);
            this.MRP.PerformLayout();
            this.tpEmpresa.ResumeLayout(false);
            this.tpEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiasHabiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Label lProd;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TabControl dgvBOM;
        private System.Windows.Forms.TabPage tpProductosDetalles;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbInventario;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lNombreComponente;
        private System.Windows.Forms.TabPage tpEmpresa;
        private System.Windows.Forms.Label lIdProductoSel;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button btnEditarPP;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ModP;
        private System.Windows.Forms.TabPage ModQ;
        private System.Windows.Forms.TabPage MRP;
        private System.Windows.Forms.Button btnEditarP1;
        private System.Windows.Forms.TextBox tbProbabilidadDemanda;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDesviacion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPeriodoRevision;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPlazodeEntregaP;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbDemandaDiaria;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnEditarP2;
        private System.Windows.Forms.TextBox tbStockSeguridad;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox tbInventarioInicial;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox tbCostoMantenimiento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditarP3;
        private System.Windows.Forms.TextBox tbCostoHrsExtras;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox tbCostosxHoras;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox tbHorasRequeridas;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox tbCostoPorPedir;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbCostoDespido;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tbFuerzaLaboral;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox tbCostoContratacion;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox tbCostoSubContratacion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbDiaTrabajadoXAnio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNombreEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnEditarOD;
        private System.Windows.Forms.TextBox tbCostoFaltante;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox tbCostoUnitario;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridView dgvDemanda;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPlanProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn mes;
        private System.Windows.Forms.DataGridViewTextBoxColumn demanda;
        private System.Windows.Forms.DataGridView dgvDiasHabiles;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip MensajeSalir;
    }
}