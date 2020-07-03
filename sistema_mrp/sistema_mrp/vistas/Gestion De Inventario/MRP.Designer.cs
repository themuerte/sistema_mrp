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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_resultado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_semanas)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 44);
            this.panel3.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(922, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "M.R.P";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(77, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 42;
            this.label3.Text = "Semanas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 14);
            this.label5.TabIndex = 44;
            this.label5.Text = "Costo por Unidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 122);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 14);
            this.label6.TabIndex = 45;
            this.label6.Text = "Costo de Pedir (S)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(43, 324);
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
            this.rdr_L4L.Location = new System.Drawing.Point(104, 325);
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
            this.rdr_EOQ.Location = new System.Drawing.Point(204, 325);
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
            this.rdr_LTC.Location = new System.Drawing.Point(156, 325);
            this.rdr_LTC.Name = "rdr_LTC";
            this.rdr_LTC.Size = new System.Drawing.Size(44, 18);
            this.rdr_LTC.TabIndex = 49;
            this.rdr_LTC.Text = "LTC";
            this.rdr_LTC.UseVisualStyleBackColor = true;
            // 
            // txt_semanas
            // 
            this.txt_semanas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_semanas.Location = new System.Drawing.Point(144, 56);
            this.txt_semanas.Name = "txt_semanas";
            this.txt_semanas.Size = new System.Drawing.Size(72, 21);
            this.txt_semanas.TabIndex = 51;
            this.txt_semanas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_semanas_KeyPress);
            // 
            // txt_costoUnidad
            // 
            this.txt_costoUnidad.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoUnidad.Location = new System.Drawing.Point(209, 88);
            this.txt_costoUnidad.Name = "txt_costoUnidad";
            this.txt_costoUnidad.Size = new System.Drawing.Size(72, 21);
            this.txt_costoUnidad.TabIndex = 53;
            this.txt_costoUnidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoUnidad_KeyPress);
            // 
            // txt_costoPedir
            // 
            this.txt_costoPedir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoPedir.Location = new System.Drawing.Point(209, 115);
            this.txt_costoPedir.Name = "txt_costoPedir";
            this.txt_costoPedir.Size = new System.Drawing.Size(72, 21);
            this.txt_costoPedir.TabIndex = 54;
            this.txt_costoPedir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoPedir_KeyPress);
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(231, 51);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(59, 26);
            this.btnAceptar.TabIndex = 55;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = false;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btn_calcular
            // 
            this.btn_calcular.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_calcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.ForeColor = System.Drawing.Color.White;
            this.btn_calcular.Location = new System.Drawing.Point(73, 179);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 29);
            this.btn_calcular.TabIndex = 56;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = false;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_limpiar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_limpiar.ForeColor = System.Drawing.Color.White;
            this.btn_limpiar.Location = new System.Drawing.Point(154, 179);
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
            this.label8.Location = new System.Drawing.Point(310, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Ingrese la demanda por cada semana";
            // 
            // dtg_resultado
            // 
            this.dtg_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_resultado.Location = new System.Drawing.Point(17, 349);
            this.dtg_resultado.Name = "dtg_resultado";
            this.dtg_resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_resultado.Size = new System.Drawing.Size(862, 204);
            this.dtg_resultado.TabIndex = 60;
            // 
            // txt_tasaMantenimiento
            // 
            this.txt_tasaMantenimiento.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tasaMantenimiento.Location = new System.Drawing.Point(209, 140);
            this.txt_tasaMantenimiento.Name = "txt_tasaMantenimiento";
            this.txt_tasaMantenimiento.Size = new System.Drawing.Size(72, 21);
            this.txt_tasaMantenimiento.TabIndex = 62;
            this.txt_tasaMantenimiento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tasaMantenimiento_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(51, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 14);
            this.label4.TabIndex = 61;
            this.label4.Text = "Tasa de mantenimiento (i)";
            // 
            // dtg_semanas
            // 
            this.dtg_semanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_semanas.Location = new System.Drawing.Point(313, 56);
            this.dtg_semanas.Name = "dtg_semanas";
            this.dtg_semanas.Size = new System.Drawing.Size(545, 139);
            this.dtg_semanas.TabIndex = 59;
            this.dtg_semanas.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dtg_semanas_EditingControlShowing);
            this.dtg_semanas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.dtg_semanas_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(17, 59);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(914, 260);
            this.tabControl1.TabIndex = 63;
            // 
            // tabPage1
            // 
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
            this.tabPage1.Size = new System.Drawing.Size(906, 234);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Nuevos Datos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCalcular2);
            this.tabPage2.Controls.Add(this.dgvProducto);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.tbSemanas);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(906, 234);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Datos Existentes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCalcular2
            // 
            this.btnCalcular2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btnCalcular2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular2.ForeColor = System.Drawing.Color.White;
            this.btnCalcular2.Location = new System.Drawing.Point(132, 129);
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
            this.tbSemanas.Location = new System.Drawing.Point(132, 102);
            this.tbSemanas.Name = "tbSemanas";
            this.tbSemanas.Size = new System.Drawing.Size(100, 21);
            this.tbSemanas.TabIndex = 48;
            // 
            // MRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 621);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.dtg_resultado);
            this.Controls.Add(this.rdr_LTC);
            this.Controls.Add(this.rdr_EOQ);
            this.Controls.Add(this.rdr_L4L);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MRP";
            this.Text = "MRP";
            this.Load += new System.EventHandler(this.MRP_Load);
            this.panel3.ResumeLayout(false);
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

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
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
    }
}