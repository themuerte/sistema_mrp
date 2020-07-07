namespace sistema_mrp.vistas.Gestion_De_Inventario
{
    partial class MRP
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
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.rdr_L4L = new System.Windows.Forms.RadioButton();
            this.rdr_EOQ = new System.Windows.Forms.RadioButton();
            this.rdr_LTC = new System.Windows.Forms.RadioButton();
            this.txt_semanas = new System.Windows.Forms.TextBox();
            this.txt_costoUnidad = new System.Windows.Forms.TextBox();
            this.txt_costoPedir = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtg_resultado = new System.Windows.Forms.DataGridView();
            this.txt_tasaMantenimiento = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dtg_semanas = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCalcular2 = new System.Windows.Forms.Button();
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSemanas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_semanas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(17, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Datos (1era parte)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 42;
            this.label3.Text = "Semanas";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 127);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 20);
            this.label5.TabIndex = 44;
            this.label5.Text = "Costo por Unidad:";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 20);
            this.label6.TabIndex = 45;
            this.label6.Text = "Costo de Pedir (S):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(991, 298);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 46;
            this.label7.Text = "Tipo";
            // 
            // rdr_L4L
            // 
            this.rdr_L4L.AutoSize = true;
            this.rdr_L4L.Checked = true;
            this.rdr_L4L.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdr_L4L.Location = new System.Drawing.Point(995, 331);
            this.rdr_L4L.Name = "rdr_L4L";
            this.rdr_L4L.Size = new System.Drawing.Size(44, 18);
            this.rdr_L4L.TabIndex = 47;
            this.rdr_L4L.TabStop = true;
            this.rdr_L4L.Text = "L4L";
            this.rdr_L4L.UseVisualStyleBackColor = true;
            // 
            // rdr_EOQ
            // 
            this.rdr_EOQ.AutoSize = true;
            this.rdr_EOQ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdr_EOQ.Location = new System.Drawing.Point(995, 379);
            this.rdr_EOQ.Name = "rdr_EOQ";
            this.rdr_EOQ.Size = new System.Drawing.Size(49, 18);
            this.rdr_EOQ.TabIndex = 48;
            this.rdr_EOQ.Text = "EOQ";
            this.rdr_EOQ.UseVisualStyleBackColor = true;
            // 
            // rdr_LTC
            // 
            this.rdr_LTC.AutoSize = true;
            this.rdr_LTC.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdr_LTC.Location = new System.Drawing.Point(995, 355);
            this.rdr_LTC.Name = "rdr_LTC";
            this.rdr_LTC.Size = new System.Drawing.Size(44, 18);
            this.rdr_LTC.TabIndex = 49;
            this.rdr_LTC.Text = "LTC";
            this.rdr_LTC.UseVisualStyleBackColor = true;
            // 
            // txt_semanas
            // 
            this.txt_semanas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_semanas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_semanas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_semanas.Location = new System.Drawing.Point(144, 54);
            this.txt_semanas.Name = "txt_semanas";
            this.txt_semanas.Size = new System.Drawing.Size(72, 14);
            this.txt_semanas.TabIndex = 51;
            this.txt_semanas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_semanas_KeyPress);
            // 
            // txt_costoUnidad
            // 
            this.txt_costoUnidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_costoUnidad.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_costoUnidad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoUnidad.Location = new System.Drawing.Point(167, 124);
            this.txt_costoUnidad.Name = "txt_costoUnidad";
            this.txt_costoUnidad.Size = new System.Drawing.Size(72, 14);
            this.txt_costoUnidad.TabIndex = 53;
            this.txt_costoUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoUnidad_KeyPress);
            // 
            // txt_costoPedir
            // 
            this.txt_costoPedir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_costoPedir.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_costoPedir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoPedir.Location = new System.Drawing.Point(167, 153);
            this.txt_costoPedir.Name = "txt_costoPedir";
            this.txt_costoPedir.Size = new System.Drawing.Size(72, 14);
            this.txt_costoPedir.TabIndex = 54;
            this.txt_costoPedir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoPedir_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(67)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(233, 51);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 26);
            this.btnAceptar.TabIndex = 55;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(67)))));
            this.btn_calcular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.White;
            this.btn_calcular.Location = new System.Drawing.Point(273, 124);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 29);
            this.btn_calcular.TabIndex = 56;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(67)))));
            this.btn_limpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(273, 170);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 29);
            this.btn_limpiar.TabIndex = 57;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(394, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(234, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Ingrese la demanda por cada semana:";
            // 
            // dtg_resultado
            // 
            this.dtg_resultado.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtg_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_resultado.Location = new System.Drawing.Point(33, 284);
            this.dtg_resultado.Name = "dtg_resultado";
            this.dtg_resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_resultado.Size = new System.Drawing.Size(927, 204);
            this.dtg_resultado.TabIndex = 60;
            // 
            // txt_tasaMantenimiento
            // 
            this.txt_tasaMantenimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txt_tasaMantenimiento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_tasaMantenimiento.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tasaMantenimiento.Location = new System.Drawing.Point(167, 180);
            this.txt_tasaMantenimiento.Name = "txt_tasaMantenimiento";
            this.txt_tasaMantenimiento.Size = new System.Drawing.Size(72, 14);
            this.txt_tasaMantenimiento.TabIndex = 62;
            this.txt_tasaMantenimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tasaMantenimiento_KeyPress);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Tasa de mantenimiento (i):";
            // 
            // dtg_semanas
            // 
            this.dtg_semanas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dtg_semanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_semanas.Location = new System.Drawing.Point(397, 56);
            this.dtg_semanas.Name = "dtg_semanas";
            this.dtg_semanas.Size = new System.Drawing.Size(587, 139);
            this.dtg_semanas.TabIndex = 59;
            this.dtg_semanas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtg_semanas_EditingControlShowing);
            this.dtg_semanas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtg_semanas_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(33, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1025, 260);
            this.tabControl1.TabIndex = 63;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dtg_semanas);
            this.tabPage1.Controls.Add(this.txt_tasaMantenimiento);
            this.tabPage1.Controls.Add(this.btn_limpiar);
            this.tabPage1.Controls.Add(this.btn_calcular);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.txt_semanas);
            this.tabPage1.Controls.Add(this.txt_costoUnidad);
            this.tabPage1.Controls.Add(this.txt_costoPedir);
            this.tabPage1.Controls.Add(this.btnAceptar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1017, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevos Datos";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.btnCalcular2);
            this.tabPage2.Controls.Add(this.dgvProducto);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbSemanas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1017, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Existentes";
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(166)))), ((int)(((byte)(67)))));
            this.btnCalcular2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.btnCalcular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular2.ForeColor = System.Drawing.Color.White;
            this.btnCalcular2.Location = new System.Drawing.Point(132, 146);
            this.btnCalcular2.Name = "btnCalcular2";
            this.btnCalcular2.Size = new System.Drawing.Size(100, 28);
            this.btnCalcular2.TabIndex = 50;
            this.btnCalcular2.Text = "Calcular";
            this.btnCalcular2.UseVisualStyleBackColor = false;
            this.btnCalcular2.Click += new System.EventHandler(this.btnCalcular2_Click);
            // 
            // dgvProducto
            // 
            this.dgvProducto.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProducto.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.nombre,
            this.descripcion});
            this.dgvProducto.Location = new System.Drawing.Point(363, 18);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(530, 201);
            this.dgvProducto.TabIndex = 49;
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
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(129, 76);
            this.label16.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(117, 14);
            this.label16.TabIndex = 47;
            this.label16.Text = "Número de semanas:";
            this.label16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbSemanas
            // 
            this.tbSemanas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSemanas.Location = new System.Drawing.Point(132, 105);
            this.tbSemanas.Name = "tbSemanas";
            this.tbSemanas.Size = new System.Drawing.Size(100, 21);
            this.tbSemanas.TabIndex = 48;
            this.tbSemanas.TextChanged += new System.EventHandler(this.tbSemanas_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Datos (2da parte)";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Location = new System.Drawing.Point(168, 198);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 2);
            this.label9.TabIndex = 65;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Location = new System.Drawing.Point(166, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 2);
            this.label10.TabIndex = 66;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label11.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label11.Location = new System.Drawing.Point(167, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 2);
            this.label11.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label12.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label12.Location = new System.Drawing.Point(143, 73);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 2);
            this.label12.TabIndex = 68;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(115)))), ((int)(((byte)(18)))), ((int)(((byte)(26)))));
            this.label20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label20.Location = new System.Drawing.Point(132, 124);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(100, 1);
            this.label20.TabIndex = 65;
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // MRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1075, 500);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dtg_resultado);
            this.Controls.Add(this.rdr_LTC);
            this.Controls.Add(this.rdr_EOQ);
            this.Controls.Add(this.rdr_L4L);
            this.Controls.Add(this.label7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MRP";
            this.Text = "MRP";
            this.Load += new System.EventHandler(this.MRP_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_resultado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_semanas)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton rdr_L4L;
        private System.Windows.Forms.RadioButton rdr_EOQ;
        private System.Windows.Forms.RadioButton rdr_LTC;
        private System.Windows.Forms.TextBox txt_semanas;
        private System.Windows.Forms.TextBox txt_costoUnidad;
        private System.Windows.Forms.TextBox txt_costoPedir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtg_resultado;
        private System.Windows.Forms.TextBox txt_tasaMantenimiento;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dtg_semanas;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnCalcular2;
        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox tbSemanas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label20;
    }
}