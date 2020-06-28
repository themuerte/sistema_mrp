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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.bL4L = new System.Windows.Forms.RadioButton();
            this.bEOQ = new System.Windows.Forms.RadioButton();
            this.bLTC = new System.Windows.Forms.RadioButton();
            this.bLUC = new System.Windows.Forms.RadioButton();
            this.txt_semanas = new System.Windows.Forms.TextBox();
            this.txt_tasa = new System.Windows.Forms.TextBox();
            this.txt_costoOportu = new System.Windows.Forms.TextBox();
            this.txt_costoPedir = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.btn_limpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dtg_semanas = new System.Windows.Forms.DataGridView();
            this.dtg_resultado = new System.Windows.Forms.DataGridView();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_semanas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_resultado)).BeginInit();
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
            this.label2.Location = new System.Drawing.Point(61, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 41;
            this.label2.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 14);
            this.label3.TabIndex = 42;
            this.label3.Text = "Semanas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(110, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 14);
            this.label4.TabIndex = 43;
            this.label4.Text = "Tasa (i)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(55, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 14);
            this.label5.TabIndex = 44;
            this.label5.Text = "Costo por Unidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(54, 248);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 14);
            this.label6.TabIndex = 45;
            this.label6.Text = "Costo de Pedir (S)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(61, 309);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 19);
            this.label7.TabIndex = 46;
            this.label7.Text = "Tipo";
            // 
            // bL4L
            // 
            this.bL4L.AutoSize = true;
            this.bL4L.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bL4L.Location = new System.Drawing.Point(65, 340);
            this.bL4L.Name = "bL4L";
            this.bL4L.Size = new System.Drawing.Size(44, 18);
            this.bL4L.TabIndex = 47;
            this.bL4L.TabStop = true;
            this.bL4L.Text = "L4L";
            this.bL4L.UseVisualStyleBackColor = true;
            // 
            // bEOQ
            // 
            this.bEOQ.AutoSize = true;
            this.bEOQ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEOQ.Location = new System.Drawing.Point(65, 364);
            this.bEOQ.Name = "bEOQ";
            this.bEOQ.Size = new System.Drawing.Size(49, 18);
            this.bEOQ.TabIndex = 48;
            this.bEOQ.TabStop = true;
            this.bEOQ.Text = "EOQ";
            this.bEOQ.UseVisualStyleBackColor = true;
            // 
            // bLTC
            // 
            this.bLTC.AutoSize = true;
            this.bLTC.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLTC.Location = new System.Drawing.Point(123, 340);
            this.bLTC.Name = "bLTC";
            this.bLTC.Size = new System.Drawing.Size(44, 18);
            this.bLTC.TabIndex = 49;
            this.bLTC.TabStop = true;
            this.bLTC.Text = "LTC";
            this.bLTC.UseVisualStyleBackColor = true;
            // 
            // bLUC
            // 
            this.bLUC.AutoSize = true;
            this.bLUC.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLUC.Location = new System.Drawing.Point(123, 364);
            this.bLUC.Name = "bLUC";
            this.bLUC.Size = new System.Drawing.Size(46, 18);
            this.bLUC.TabIndex = 50;
            this.bLUC.TabStop = true;
            this.bLUC.Text = "LUC";
            this.bLUC.UseVisualStyleBackColor = true;
            // 
            // txt_semanas
            // 
            this.txt_semanas.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_semanas.Location = new System.Drawing.Point(168, 157);
            this.txt_semanas.Name = "txt_semanas";
            this.txt_semanas.Size = new System.Drawing.Size(72, 21);
            this.txt_semanas.TabIndex = 51;
            // 
            // txt_tasa
            // 
            this.txt_tasa.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tasa.Location = new System.Drawing.Point(168, 187);
            this.txt_tasa.Name = "txt_tasa";
            this.txt_tasa.Size = new System.Drawing.Size(72, 21);
            this.txt_tasa.TabIndex = 52;
            // 
            // txt_costoOportu
            // 
            this.txt_costoOportu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoOportu.Location = new System.Drawing.Point(168, 214);
            this.txt_costoOportu.Name = "txt_costoOportu";
            this.txt_costoOportu.Size = new System.Drawing.Size(72, 21);
            this.txt_costoOportu.TabIndex = 53;
            // 
            // txt_costoPedir
            // 
            this.txt_costoPedir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoPedir.Location = new System.Drawing.Point(168, 241);
            this.txt_costoPedir.Name = "txt_costoPedir";
            this.txt_costoPedir.Size = new System.Drawing.Size(72, 21);
            this.txt_costoPedir.TabIndex = 54;
            // 
            // btnAceptar
            // 
            this.btnAceptar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.ForeColor = System.Drawing.Color.White;
            this.btnAceptar.Location = new System.Drawing.Point(267, 157);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(68, 26);
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
            this.btn_calcular.Location = new System.Drawing.Point(99, 437);
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
            this.btn_limpiar.Location = new System.Drawing.Point(197, 437);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 29);
            this.btn_limpiar.TabIndex = 57;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(349, 124);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(231, 17);
            this.label8.TabIndex = 58;
            this.label8.Text = "Ingrese la demanda por cada semana";
            // 
            // dtg_semanas
            // 
            this.dtg_semanas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_semanas.Location = new System.Drawing.Point(362, 157);
            this.dtg_semanas.Name = "dtg_semanas";
            this.dtg_semanas.Size = new System.Drawing.Size(566, 139);
            this.dtg_semanas.TabIndex = 59;
            // 
            // dtg_resultado
            // 
            this.dtg_resultado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_resultado.Location = new System.Drawing.Point(362, 349);
            this.dtg_resultado.Name = "dtg_resultado";
            this.dtg_resultado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_resultado.Size = new System.Drawing.Size(566, 204);
            this.dtg_resultado.TabIndex = 60;
            // 
            // MRP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 621);
            this.Controls.Add(this.dtg_resultado);
            this.Controls.Add(this.dtg_semanas);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txt_costoPedir);
            this.Controls.Add(this.txt_costoOportu);
            this.Controls.Add(this.txt_tasa);
            this.Controls.Add(this.txt_semanas);
            this.Controls.Add(this.bLUC);
            this.Controls.Add(this.bLTC);
            this.Controls.Add(this.bEOQ);
            this.Controls.Add(this.bL4L);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MRP";
            this.Text = "MRP";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_semanas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_resultado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton bL4L;
        private System.Windows.Forms.RadioButton bEOQ;
        private System.Windows.Forms.RadioButton bLTC;
        private System.Windows.Forms.RadioButton bLUC;
        private System.Windows.Forms.TextBox txt_semanas;
        private System.Windows.Forms.TextBox txt_tasa;
        private System.Windows.Forms.TextBox txt_costoOportu;
        private System.Windows.Forms.TextBox txt_costoPedir;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Button btn_limpiar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dtg_semanas;
        private System.Windows.Forms.DataGridView dtg_resultado;
    }
}