namespace sistema_mrp.vistas.Gestion_De_Inventario
{
    partial class modelo_P
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_demanda = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_demandaP = new System.Windows.Forms.TextBox();
            this.txt_plazoEntrega = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_cantidadOptima = new System.Windows.Forms.TextBox();
            this.txt_desvEstandarDem = new System.Windows.Forms.TextBox();
            this.txt_z = new System.Windows.Forms.TextBox();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_periodoRevi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rdr_dias = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.rdr_semanal = new System.Windows.Forms.RadioButton();
            this.rdr_mensual = new System.Windows.Forms.RadioButton();
            this.rdr_anual = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_desviacion = new System.Windows.Forms.TextBox();
            this.txt_probabilidadDemanda = new System.Windows.Forms.TextBox();
            this.txt_inventarioAct = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbModeloP = new System.Windows.Forms.TabControl();
            this.tpDatosNuevos = new System.Windows.Forms.TabPage();
            this.tpProducto = new System.Windows.Forms.TabPage();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cModeloP = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tbNumeroPeriodos = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.bUpdateChart = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.tbModeloP.SuspendLayout();
            this.tpDatosNuevos.SuspendLayout();
            this.tpProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cModeloP)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(856, 96);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // lbl_demanda
            // 
            this.lbl_demanda.AutoSize = true;
            this.lbl_demanda.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_demanda.Location = new System.Drawing.Point(216, 144);
            this.lbl_demanda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_demanda.Name = "lbl_demanda";
            this.lbl_demanda.Size = new System.Drawing.Size(74, 18);
            this.lbl_demanda.TabIndex = 3;
            this.lbl_demanda.Text = "Demanda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(167, 186);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plazo de entrega";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(192, 290);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Desvias";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 327);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(254, 18);
            this.label8.TabIndex = 7;
            this.label8.Text = "Probabilidad de cumplir la demanda";
            // 
            // txt_demandaP
            // 
            this.txt_demandaP.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_demandaP.Location = new System.Drawing.Point(305, 135);
            this.txt_demandaP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_demandaP.Name = "txt_demandaP";
            this.txt_demandaP.Size = new System.Drawing.Size(132, 24);
            this.txt_demandaP.TabIndex = 8;
            // 
            // txt_plazoEntrega
            // 
            this.txt_plazoEntrega.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plazoEntrega.Location = new System.Drawing.Point(305, 177);
            this.txt_plazoEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.txt_plazoEntrega.Name = "txt_plazoEntrega";
            this.txt_plazoEntrega.Size = new System.Drawing.Size(132, 24);
            this.txt_plazoEntrega.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(821, 142);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(181, 18);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cantidad óptima de pedir";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(907, 175);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 18);
            this.label10.TabIndex = 14;
            this.label10.Text = "Desv Estand Q";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(642, 139);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 18);
            this.label11.TabIndex = 13;
            this.label11.Text = "z";
            // 
            // txt_cantidadOptima
            // 
            this.txt_cantidadOptima.Enabled = false;
            this.txt_cantidadOptima.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidadOptima.Location = new System.Drawing.Point(1024, 138);
            this.txt_cantidadOptima.Margin = new System.Windows.Forms.Padding(4);
            this.txt_cantidadOptima.Name = "txt_cantidadOptima";
            this.txt_cantidadOptima.Size = new System.Drawing.Size(132, 25);
            this.txt_cantidadOptima.TabIndex = 18;
            // 
            // txt_desvEstandarDem
            // 
            this.txt_desvEstandarDem.Enabled = false;
            this.txt_desvEstandarDem.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desvEstandarDem.Location = new System.Drawing.Point(1024, 171);
            this.txt_desvEstandarDem.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desvEstandarDem.Name = "txt_desvEstandarDem";
            this.txt_desvEstandarDem.Size = new System.Drawing.Size(132, 25);
            this.txt_desvEstandarDem.TabIndex = 17;
            // 
            // txt_z
            // 
            this.txt_z.Enabled = false;
            this.txt_z.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_z.Location = new System.Drawing.Point(665, 134);
            this.txt_z.Margin = new System.Windows.Forms.Padding(4);
            this.txt_z.Name = "txt_z";
            this.txt_z.Size = new System.Drawing.Size(132, 25);
            this.txt_z.TabIndex = 16;
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_calcular.FlatAppearance.BorderSize = 0;
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.White;
            this.btn_calcular.Location = new System.Drawing.Point(165, 390);
            this.btn_calcular.Margin = new System.Windows.Forms.Padding(4);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(100, 31);
            this.btn_calcular.TabIndex = 19;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_limpiar.FlatAppearance.BorderSize = 0;
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(304, 390);
            this.btn_limpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_limpiar.Size = new System.Drawing.Size(100, 31);
            this.btn_limpiar.TabIndex = 20;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 226);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "Periodo de revisión";
            // 
            // txt_periodoRevi
            // 
            this.txt_periodoRevi.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_periodoRevi.Location = new System.Drawing.Point(305, 218);
            this.txt_periodoRevi.Margin = new System.Windows.Forms.Padding(4);
            this.txt_periodoRevi.Name = "txt_periodoRevi";
            this.txt_periodoRevi.Size = new System.Drawing.Size(132, 24);
            this.txt_periodoRevi.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1247, 54);
            this.label1.TabIndex = 23;
            this.label1.Text = "Modelo P";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rdr_dias
            // 
            this.rdr_dias.AutoSize = true;
            this.rdr_dias.Location = new System.Drawing.Point(24, 23);
            this.rdr_dias.Margin = new System.Windows.Forms.Padding(4);
            this.rdr_dias.Name = "rdr_dias";
            this.rdr_dias.Size = new System.Drawing.Size(69, 22);
            this.rdr_dias.TabIndex = 24;
            this.rdr_dias.TabStop = true;
            this.rdr_dias.Text = "Diaria";
            this.rdr_dias.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdr_dias.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(-20, -18);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(110, 21);
            this.radioButton2.TabIndex = 25;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "radioButton2";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // rdr_semanal
            // 
            this.rdr_semanal.AutoSize = true;
            this.rdr_semanal.Location = new System.Drawing.Point(101, 23);
            this.rdr_semanal.Margin = new System.Windows.Forms.Padding(4);
            this.rdr_semanal.Name = "rdr_semanal";
            this.rdr_semanal.Size = new System.Drawing.Size(87, 22);
            this.rdr_semanal.TabIndex = 26;
            this.rdr_semanal.TabStop = true;
            this.rdr_semanal.Text = "Semanal";
            this.rdr_semanal.UseVisualStyleBackColor = true;
            // 
            // rdr_mensual
            // 
            this.rdr_mensual.AutoSize = true;
            this.rdr_mensual.Location = new System.Drawing.Point(209, 26);
            this.rdr_mensual.Margin = new System.Windows.Forms.Padding(4);
            this.rdr_mensual.Name = "rdr_mensual";
            this.rdr_mensual.Size = new System.Drawing.Size(87, 22);
            this.rdr_mensual.TabIndex = 27;
            this.rdr_mensual.TabStop = true;
            this.rdr_mensual.Text = "Mensual";
            this.rdr_mensual.UseVisualStyleBackColor = true;
            // 
            // rdr_anual
            // 
            this.rdr_anual.AutoSize = true;
            this.rdr_anual.Location = new System.Drawing.Point(311, 25);
            this.rdr_anual.Margin = new System.Windows.Forms.Padding(4);
            this.rdr_anual.Name = "rdr_anual";
            this.rdr_anual.Size = new System.Drawing.Size(69, 22);
            this.rdr_anual.TabIndex = 28;
            this.rdr_anual.TabStop = true;
            this.rdr_anual.Text = "Anual";
            this.rdr_anual.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdr_dias);
            this.groupBox1.Controls.Add(this.rdr_anual);
            this.groupBox1.Controls.Add(this.rdr_semanal);
            this.groupBox1.Controls.Add(this.rdr_mensual);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(35, 41);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(393, 62);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tipo de demanda";
            // 
            // txt_desviacion
            // 
            this.txt_desviacion.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_desviacion.Location = new System.Drawing.Point(305, 283);
            this.txt_desviacion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_desviacion.Name = "txt_desviacion";
            this.txt_desviacion.Size = new System.Drawing.Size(132, 24);
            this.txt_desviacion.TabIndex = 30;
            // 
            // txt_probabilidadDemanda
            // 
            this.txt_probabilidadDemanda.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_probabilidadDemanda.Location = new System.Drawing.Point(305, 320);
            this.txt_probabilidadDemanda.Margin = new System.Windows.Forms.Padding(4);
            this.txt_probabilidadDemanda.Name = "txt_probabilidadDemanda";
            this.txt_probabilidadDemanda.Size = new System.Drawing.Size(132, 24);
            this.txt_probabilidadDemanda.TabIndex = 31;
            // 
            // txt_inventarioAct
            // 
            this.txt_inventarioAct.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inventarioAct.Location = new System.Drawing.Point(305, 251);
            this.txt_inventarioAct.Margin = new System.Windows.Forms.Padding(4);
            this.txt_inventarioAct.Name = "txt_inventarioAct";
            this.txt_inventarioAct.Size = new System.Drawing.Size(132, 24);
            this.txt_inventarioAct.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(167, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Inventario actual";
            // 
            // tbModeloP
            // 
            this.tbModeloP.Controls.Add(this.tpDatosNuevos);
            this.tbModeloP.Controls.Add(this.tpProducto);
            this.tbModeloP.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbModeloP.Location = new System.Drawing.Point(37, 107);
            this.tbModeloP.Margin = new System.Windows.Forms.Padding(4);
            this.tbModeloP.Name = "tbModeloP";
            this.tbModeloP.SelectedIndex = 0;
            this.tbModeloP.Size = new System.Drawing.Size(541, 484);
            this.tbModeloP.TabIndex = 34;
            // 
            // tpDatosNuevos
            // 
            this.tpDatosNuevos.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatosNuevos.Controls.Add(this.txt_demandaP);
            this.tpDatosNuevos.Controls.Add(this.txt_inventarioAct);
            this.tpDatosNuevos.Controls.Add(this.label2);
            this.tpDatosNuevos.Controls.Add(this.label4);
            this.tpDatosNuevos.Controls.Add(this.lbl_demanda);
            this.tpDatosNuevos.Controls.Add(this.txt_probabilidadDemanda);
            this.tpDatosNuevos.Controls.Add(this.label5);
            this.tpDatosNuevos.Controls.Add(this.txt_desviacion);
            this.tpDatosNuevos.Controls.Add(this.label6);
            this.tpDatosNuevos.Controls.Add(this.groupBox1);
            this.tpDatosNuevos.Controls.Add(this.label7);
            this.tpDatosNuevos.Controls.Add(this.label8);
            this.tpDatosNuevos.Controls.Add(this.txt_plazoEntrega);
            this.tpDatosNuevos.Controls.Add(this.btn_limpiar);
            this.tpDatosNuevos.Controls.Add(this.txt_periodoRevi);
            this.tpDatosNuevos.Controls.Add(this.btn_calcular);
            this.tpDatosNuevos.Location = new System.Drawing.Point(4, 26);
            this.tpDatosNuevos.Margin = new System.Windows.Forms.Padding(4);
            this.tpDatosNuevos.Name = "tpDatosNuevos";
            this.tpDatosNuevos.Padding = new System.Windows.Forms.Padding(4);
            this.tpDatosNuevos.Size = new System.Drawing.Size(533, 454);
            this.tpDatosNuevos.TabIndex = 0;
            this.tpDatosNuevos.Text = "Datos Nuevos";
            // 
            // tpProducto
            // 
            this.tpProducto.BackColor = System.Drawing.SystemColors.Control;
            this.tpProducto.Controls.Add(this.dgvProductos);
            this.tpProducto.Location = new System.Drawing.Point(4, 26);
            this.tpProducto.Margin = new System.Windows.Forms.Padding(4);
            this.tpProducto.Name = "tpProducto";
            this.tpProducto.Padding = new System.Windows.Forms.Padding(4);
            this.tpProducto.Size = new System.Drawing.Size(533, 454);
            this.tpProducto.TabIndex = 1;
            this.tpProducto.Text = "Producto Existente";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.descripcion});
            this.dgvProductos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.dgvProductos.Location = new System.Drawing.Point(8, 48);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.RowHeadersWidth = 51;
            this.dgvProductos.Size = new System.Drawing.Size(515, 325);
            this.dgvProductos.TabIndex = 2;
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
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            // 
            // cModeloP
            // 
            this.cModeloP.BackColor = System.Drawing.SystemColors.Control;
            chartArea2.Name = "ChartArea1";
            this.cModeloP.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.cModeloP.Legends.Add(legend2);
            this.cModeloP.Location = new System.Drawing.Point(637, 217);
            this.cModeloP.Margin = new System.Windows.Forms.Padding(4);
            this.cModeloP.Name = "cModeloP";
            this.cModeloP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Inventario";
            series5.ChartArea = "ChartArea1";
            series5.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series5.Legend = "Legend1";
            series5.Name = "QOptimo";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series6.Legend = "Legend1";
            series6.Name = "Inv, Prom.";
            this.cModeloP.Series.Add(series4);
            this.cModeloP.Series.Add(series5);
            this.cModeloP.Series.Add(series6);
            this.cModeloP.Size = new System.Drawing.Size(569, 369);
            this.cModeloP.TabIndex = 35;
            this.cModeloP.Text = "Modelo P";
            title2.Name = "Title1";
            title2.Text = "Modelo P";
            this.cModeloP.Titles.Add(title2);
            // 
            // tbNumeroPeriodos
            // 
            this.tbNumeroPeriodos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNumeroPeriodos.Location = new System.Drawing.Point(861, 604);
            this.tbNumeroPeriodos.Margin = new System.Windows.Forms.Padding(4);
            this.tbNumeroPeriodos.Name = "tbNumeroPeriodos";
            this.tbNumeroPeriodos.Size = new System.Drawing.Size(132, 24);
            this.tbNumeroPeriodos.TabIndex = 37;
            this.tbNumeroPeriodos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNumeroPeriodos_KeyPress);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(691, 608);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 18);
            this.label12.TabIndex = 36;
            this.label12.Text = "Número de Períodos";
            // 
            // bUpdateChart
            // 
            this.bUpdateChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.bUpdateChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bUpdateChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bUpdateChart.ForeColor = System.Drawing.Color.White;
            this.bUpdateChart.Location = new System.Drawing.Point(1001, 595);
            this.bUpdateChart.Margin = new System.Windows.Forms.Padding(4);
            this.bUpdateChart.Name = "bUpdateChart";
            this.bUpdateChart.Size = new System.Drawing.Size(180, 40);
            this.bUpdateChart.TabIndex = 38;
            this.bUpdateChart.Text = "Actualizar Gráfico";
            this.bUpdateChart.UseVisualStyleBackColor = false;
            this.bUpdateChart.Click += new System.EventHandler(this.bUpdateChart_Click);
            // 
            // modelo_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 764);
            this.Controls.Add(this.bUpdateChart);
            this.Controls.Add(this.tbNumeroPeriodos);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cModeloP);
            this.Controls.Add(this.tbModeloP);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_cantidadOptima);
            this.Controls.Add(this.txt_desvEstandarDem);
            this.Controls.Add(this.txt_z);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "modelo_P";
            this.Load += new System.EventHandler(this.modelo_P_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.modelo_P_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tbModeloP.ResumeLayout(false);
            this.tpDatosNuevos.ResumeLayout(false);
            this.tpDatosNuevos.PerformLayout();
            this.tpProducto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cModeloP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_demanda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_demandaP;
        private System.Windows.Forms.TextBox txt_plazoEntrega;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_cantidadOptima;
        private System.Windows.Forms.TextBox txt_desvEstandarDem;
        private System.Windows.Forms.TextBox txt_z;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_periodoRevi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdr_dias;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton rdr_semanal;
        private System.Windows.Forms.RadioButton rdr_mensual;
        private System.Windows.Forms.RadioButton rdr_anual;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_desviacion;
        private System.Windows.Forms.TextBox txt_probabilidadDemanda;
        private System.Windows.Forms.TextBox txt_inventarioAct;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tbModeloP;
        private System.Windows.Forms.TabPage tpDatosNuevos;
        private System.Windows.Forms.TabPage tpProducto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataVisualization.Charting.Chart cModeloP;
        private System.Windows.Forms.TextBox tbNumeroPeriodos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button bUpdateChart;
    }
}