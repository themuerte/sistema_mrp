namespace sistema_mrp.vistas.Gestion_De_Inventario
{
    partial class plan_agregado
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_numeroDatos = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.txtplanes = new System.Windows.Forms.Label();
            this.bPersecución = new System.Windows.Forms.RadioButton();
            this.bFuerzasNiveladas = new System.Windows.Forms.RadioButton();
            this.bOutsourcing = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbCostoDeProducción = new System.Windows.Forms.TextBox();
            this.tbMantenimiento = new System.Windows.Forms.TextBox();
            this.tbCostoContratación = new System.Windows.Forms.TextBox();
            this.tbInventarioInicial = new System.Windows.Forms.TextBox();
            this.tbCostoDeSubContratación = new System.Windows.Forms.TextBox();
            this.tbCostoDeDespido = new System.Windows.Forms.TextBox();
            this.tbHorasRequeridas = new System.Windows.Forms.TextBox();
            this.tbStockSeguridad = new System.Windows.Forms.TextBox();
            this.tbFuerzaLaboral = new System.Windows.Forms.TextBox();
            this.tbCostoHorasExtras = new System.Windows.Forms.TextBox();
            this.tbCostoHorasNormal = new System.Windows.Forms.TextBox();
            this.tbCostoFaltante = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dtg_semanas = new System.Windows.Forms.DataGridView();
            this.dtgResultado = new System.Windows.Forms.DataGridView();
            this.tcModo1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tModo2 = new System.Windows.Forms.TabPage();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.label16 = new System.Windows.Forms.Label();
            this.tbMeses = new System.Windows.Forms.TextBox();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_semanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).BeginInit();
            this.tcModo1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tModo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Número de datos";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_numeroDatos
            // 
            this.txt_numeroDatos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numeroDatos.Location = new System.Drawing.Point(118, 38);
            this.txt_numeroDatos.Name = "txt_numeroDatos";
            this.txt_numeroDatos.Size = new System.Drawing.Size(100, 21);
            this.txt_numeroDatos.TabIndex = 2;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btnAceptar.FlatAppearance.BorderSize = 0;
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(236, 35);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 24);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // txtplanes
            // 
            this.txtplanes.AutoSize = true;
            this.txtplanes.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtplanes.Location = new System.Drawing.Point(792, 145);
            this.txtplanes.Name = "txtplanes";
            this.txtplanes.Size = new System.Drawing.Size(55, 19);
            this.txtplanes.TabIndex = 7;
            this.txtplanes.Text = "Planes";
            // 
            // bPersecución
            // 
            this.bPersecución.AutoSize = true;
            this.bPersecución.Checked = true;
            this.bPersecución.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPersecución.Location = new System.Drawing.Point(795, 171);
            this.bPersecución.Name = "bPersecución";
            this.bPersecución.Size = new System.Drawing.Size(87, 18);
            this.bPersecución.TabIndex = 8;
            this.bPersecución.TabStop = true;
            this.bPersecución.Text = "Persecución";
            this.bPersecución.UseVisualStyleBackColor = true;
            // 
            // bFuerzasNiveladas
            // 
            this.bFuerzasNiveladas.AutoSize = true;
            this.bFuerzasNiveladas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bFuerzasNiveladas.Location = new System.Drawing.Point(795, 195);
            this.bFuerzasNiveladas.Name = "bFuerzasNiveladas";
            this.bFuerzasNiveladas.Size = new System.Drawing.Size(108, 18);
            this.bFuerzasNiveladas.TabIndex = 9;
            this.bFuerzasNiveladas.Text = "Fuerza Nivelada";
            this.bFuerzasNiveladas.UseVisualStyleBackColor = true;
            // 
            // bOutsourcing
            // 
            this.bOutsourcing.AutoSize = true;
            this.bOutsourcing.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOutsourcing.Location = new System.Drawing.Point(795, 219);
            this.bOutsourcing.Name = "bOutsourcing";
            this.bOutsourcing.Size = new System.Drawing.Size(90, 18);
            this.bOutsourcing.TabIndex = 10;
            this.bOutsourcing.Text = "Outsourcing";
            this.bOutsourcing.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 19);
            this.label3.TabIndex = 11;
            this.label3.Text = "Datos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 14);
            this.label4.TabIndex = 12;
            this.label4.Text = "Costo de Producción";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 243);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 14);
            this.label5.TabIndex = 13;
            this.label5.Text = "Mantenimiento";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 14);
            this.label6.TabIndex = 14;
            this.label6.Text = "Costo Contratación";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 290);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "Inventario Inicial";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(260, 291);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 14);
            this.label8.TabIndex = 20;
            this.label8.Text = "Stock de reguridad";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(265, 267);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 14);
            this.label9.TabIndex = 19;
            this.label9.Text = "Horas Requeridas";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 244);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 14);
            this.label10.TabIndex = 18;
            this.label10.Text = "Costo de Despido";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(223, 222);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(148, 14);
            this.label11.TabIndex = 17;
            this.label11.Text = "Costo de Sub-Contratación";
            // 
            // tbCostoDeProducción
            // 
            this.tbCostoDeProducción.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoDeProducción.Location = new System.Drawing.Point(137, 219);
            this.tbCostoDeProducción.Name = "tbCostoDeProducción";
            this.tbCostoDeProducción.Size = new System.Drawing.Size(80, 21);
            this.tbCostoDeProducción.TabIndex = 21;
            // 
            // tbMantenimiento
            // 
            this.tbMantenimiento.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMantenimiento.Location = new System.Drawing.Point(137, 241);
            this.tbMantenimiento.Name = "tbMantenimiento";
            this.tbMantenimiento.Size = new System.Drawing.Size(81, 21);
            this.tbMantenimiento.TabIndex = 22;
            // 
            // tbCostoContratación
            // 
            this.tbCostoContratación.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoContratación.Location = new System.Drawing.Point(137, 264);
            this.tbCostoContratación.Name = "tbCostoContratación";
            this.tbCostoContratación.Size = new System.Drawing.Size(81, 21);
            this.tbCostoContratación.TabIndex = 23;
            // 
            // tbInventarioInicial
            // 
            this.tbInventarioInicial.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbInventarioInicial.Location = new System.Drawing.Point(137, 288);
            this.tbInventarioInicial.Name = "tbInventarioInicial";
            this.tbInventarioInicial.Size = new System.Drawing.Size(81, 21);
            this.tbInventarioInicial.TabIndex = 24;
            // 
            // tbCostoDeSubContratación
            // 
            this.tbCostoDeSubContratación.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoDeSubContratación.Location = new System.Drawing.Point(371, 219);
            this.tbCostoDeSubContratación.Name = "tbCostoDeSubContratación";
            this.tbCostoDeSubContratación.Size = new System.Drawing.Size(67, 21);
            this.tbCostoDeSubContratación.TabIndex = 25;
            // 
            // tbCostoDeDespido
            // 
            this.tbCostoDeDespido.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoDeDespido.Location = new System.Drawing.Point(372, 241);
            this.tbCostoDeDespido.Name = "tbCostoDeDespido";
            this.tbCostoDeDespido.Size = new System.Drawing.Size(66, 21);
            this.tbCostoDeDespido.TabIndex = 26;
            // 
            // tbHorasRequeridas
            // 
            this.tbHorasRequeridas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbHorasRequeridas.Location = new System.Drawing.Point(371, 264);
            this.tbHorasRequeridas.Name = "tbHorasRequeridas";
            this.tbHorasRequeridas.Size = new System.Drawing.Size(67, 21);
            this.tbHorasRequeridas.TabIndex = 27;
            // 
            // tbStockSeguridad
            // 
            this.tbStockSeguridad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbStockSeguridad.Location = new System.Drawing.Point(371, 288);
            this.tbStockSeguridad.Name = "tbStockSeguridad";
            this.tbStockSeguridad.Size = new System.Drawing.Size(67, 21);
            this.tbStockSeguridad.TabIndex = 28;
            // 
            // tbFuerzaLaboral
            // 
            this.tbFuerzaLaboral.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbFuerzaLaboral.Location = new System.Drawing.Point(562, 288);
            this.tbFuerzaLaboral.Name = "tbFuerzaLaboral";
            this.tbFuerzaLaboral.Size = new System.Drawing.Size(67, 21);
            this.tbFuerzaLaboral.TabIndex = 36;
            // 
            // tbCostoHorasExtras
            // 
            this.tbCostoHorasExtras.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoHorasExtras.Location = new System.Drawing.Point(562, 264);
            this.tbCostoHorasExtras.Name = "tbCostoHorasExtras";
            this.tbCostoHorasExtras.Size = new System.Drawing.Size(67, 21);
            this.tbCostoHorasExtras.TabIndex = 35;
            // 
            // tbCostoHorasNormal
            // 
            this.tbCostoHorasNormal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoHorasNormal.Location = new System.Drawing.Point(562, 241);
            this.tbCostoHorasNormal.Name = "tbCostoHorasNormal";
            this.tbCostoHorasNormal.Size = new System.Drawing.Size(67, 21);
            this.tbCostoHorasNormal.TabIndex = 34;
            // 
            // tbCostoFaltante
            // 
            this.tbCostoFaltante.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCostoFaltante.Location = new System.Drawing.Point(562, 219);
            this.tbCostoFaltante.Name = "tbCostoFaltante";
            this.tbCostoFaltante.Size = new System.Drawing.Size(67, 21);
            this.tbCostoFaltante.TabIndex = 33;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(472, 291);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 14);
            this.label12.TabIndex = 32;
            this.label12.Text = "Fuerza Laboral";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(453, 266);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 14);
            this.label13.TabIndex = 31;
            this.label13.Text = "Costo Horas Extras";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(448, 244);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(112, 14);
            this.label14.TabIndex = 30;
            this.label14.Text = "Costo Horas Normal";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(474, 222);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(82, 14);
            this.label15.TabIndex = 29;
            this.label15.Text = "Costo Faltante";
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.White;
            this.btnCalcular.Location = new System.Drawing.Point(421, 31);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 28);
            this.btnCalcular.TabIndex = 37;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.Location = new System.Drawing.Point(502, 31);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 28);
            this.btnLimpiar.TabIndex = 38;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 44);
            this.panel3.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(333, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Planeación Agregada";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtg_semanas
            // 
            this.dtg_semanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_semanas.Location = new System.Drawing.Point(24, 76);
            this.dtg_semanas.Name = "dtg_semanas";
            this.dtg_semanas.Size = new System.Drawing.Size(643, 116);
            this.dtg_semanas.TabIndex = 41;
            // 
            // dtgResultado
            // 
            this.dtgResultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgResultado.Location = new System.Drawing.Point(49, 425);
            this.dtgResultado.Name = "dtgResultado";
            this.dtgResultado.Size = new System.Drawing.Size(711, 187);
            this.dtgResultado.TabIndex = 42;
            // 
            // tcModo1
            // 
            this.tcModo1.Controls.Add(this.tabPage1);
            this.tcModo1.Controls.Add(this.tModo2);
            this.tcModo1.Location = new System.Drawing.Point(49, 50);
            this.tcModo1.Name = "tcModo1";
            this.tcModo1.SelectedIndex = 0;
            this.tcModo1.Size = new System.Drawing.Size(715, 357);
            this.tcModo1.TabIndex = 43;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dtg_semanas);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.txt_numeroDatos);
            this.tabPage1.Controls.Add(this.btnCalcular);
            this.tabPage1.Controls.Add(this.btnLimpiar);
            this.tabPage1.Controls.Add(this.btnAceptar);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.tbFuerzaLaboral);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.tbCostoHorasExtras);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.tbCostoHorasNormal);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.tbCostoFaltante);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label14);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label15);
            this.tabPage1.Controls.Add(this.tbCostoDeProducción);
            this.tabPage1.Controls.Add(this.tbStockSeguridad);
            this.tabPage1.Controls.Add(this.tbMantenimiento);
            this.tabPage1.Controls.Add(this.tbHorasRequeridas);
            this.tabPage1.Controls.Add(this.tbCostoContratación);
            this.tabPage1.Controls.Add(this.tbCostoDeDespido);
            this.tabPage1.Controls.Add(this.tbInventarioInicial);
            this.tabPage1.Controls.Add(this.tbCostoDeSubContratación);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(707, 331);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Datos Nuevos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tModo2
            // 
            this.tModo2.Controls.Add(this.btnCalcular2);
            this.tModo2.Controls.Add(this.dgvProducto);
            this.tModo2.Controls.Add(this.label16);
            this.tModo2.Controls.Add(this.tbMeses);
            this.tModo2.Location = new System.Drawing.Point(4, 22);
            this.tModo2.Name = "tModo2";
            this.tModo2.Padding = new System.Windows.Forms.Padding(3);
            this.tModo2.Size = new System.Drawing.Size(707, 331);
            this.tModo2.TabIndex = 1;
            this.tModo2.Text = "Productos Existentes";
            this.tModo2.UseVisualStyleBackColor = true;
            // 
            // dgvProducto
            // 
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.descripcion});
            this.dgvProducto.Location = new System.Drawing.Point(32, 73);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(643, 201);
            this.dgvProducto.TabIndex = 45;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(29, 36);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(101, 14);
            this.label16.TabIndex = 42;
            this.label16.Text = "Número de meses";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbMeses
            // 
            this.tbMeses.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbMeses.Location = new System.Drawing.Point(136, 33);
            this.tbMeses.Name = "tbMeses";
            this.tbMeses.Size = new System.Drawing.Size(100, 21);
            this.tbMeses.TabIndex = 43;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "id";
            this.idProducto.Name = "idProducto";
            this.idProducto.Visible = false;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre del producto";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción del producto";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btnCalcular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular2.ForeColor = System.Drawing.Color.White;
            this.btnCalcular2.Location = new System.Drawing.Point(265, 28);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(75, 28);
            this.btnCalcular2.TabIndex = 46;
            this.btnCalcular2.Text = "Calcular";
            this.btnCalcular2.UseVisualStyleBackColor = false;
            this.btnCalcular2.Click += new System.EventHandler(this.button1_Click);
            // 
            // plan_agregado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 621);
            this.Controls.Add(this.tcModo1);
            this.Controls.Add(this.dtgResultado);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.bOutsourcing);
            this.Controls.Add(this.bFuerzasNiveladas);
            this.Controls.Add(this.bPersecución);
            this.Controls.Add(this.txtplanes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "plan_agregado";
            this.Text = "plan_agregado";
            this.Load += new System.EventHandler(this.plan_agregado_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_semanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgResultado)).EndInit();
            this.tcModo1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tModo2.ResumeLayout(false);
            this.tModo2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_numeroDatos;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label txtplanes;
        private System.Windows.Forms.RadioButton bPersecución;
        private System.Windows.Forms.RadioButton bFuerzasNiveladas;
        private System.Windows.Forms.RadioButton bOutsourcing;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbCostoDeProducción;
        private System.Windows.Forms.TextBox tbMantenimiento;
        private System.Windows.Forms.TextBox tbCostoContratación;
        private System.Windows.Forms.TextBox tbInventarioInicial;
        private System.Windows.Forms.TextBox tbCostoDeSubContratación;
        private System.Windows.Forms.TextBox tbCostoDeDespido;
        private System.Windows.Forms.TextBox tbHorasRequeridas;
        private System.Windows.Forms.TextBox tbStockSeguridad;
        private System.Windows.Forms.TextBox tbFuerzaLaboral;
        private System.Windows.Forms.TextBox tbCostoHorasExtras;
        private System.Windows.Forms.TextBox tbCostoHorasNormal;
        private System.Windows.Forms.TextBox tbCostoFaltante;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtg_semanas;
        private System.Windows.Forms.DataGridView dtgResultado;
        private System.Windows.Forms.TabControl tcModo1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tModo2;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbMeses;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Button btnCalcular2;
    }
}