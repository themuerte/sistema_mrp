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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_costoTotal = new System.Windows.Forms.TextBox();
            this.txt_puntoReo = new System.Windows.Forms.TextBox();
            this.txt_numPedidos = new System.Windows.Forms.TextBox();
            this.txt_Qoptimo = new System.Windows.Forms.TextBox();
            this.txt_TiempoEntreP = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_inventarioSegu = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_tiempoEspera = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(129, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Demanda anual";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(114, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo del producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 14);
            this.label1.TabIndex = 3;
            this.label1.Text = "Costo de mantenimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 4;
            this.label4.Text = "Costo de pedir";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(87, 329);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 14);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dias trabajados por año";
            // 
            // txt_demanda
            // 
            this.txt_demanda.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_demanda.Location = new System.Drawing.Point(227, 118);
            this.txt_demanda.Name = "txt_demanda";
            this.txt_demanda.Size = new System.Drawing.Size(100, 21);
            this.txt_demanda.TabIndex = 6;
            this.txt_demanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_demanda_KeyPress);
            // 
            // txt_costoPro
            // 
            this.txt_costoPro.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoPro.Location = new System.Drawing.Point(227, 153);
            this.txt_costoPro.Name = "txt_costoPro";
            this.txt_costoPro.Size = new System.Drawing.Size(100, 21);
            this.txt_costoPro.TabIndex = 7;
            this.txt_costoPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoPro_KeyPress);
            // 
            // txt_costoPedir
            // 
            this.txt_costoPedir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoPedir.Location = new System.Drawing.Point(227, 223);
            this.txt_costoPedir.Name = "txt_costoPedir";
            this.txt_costoPedir.Size = new System.Drawing.Size(100, 21);
            this.txt_costoPedir.TabIndex = 9;
            this.txt_costoPedir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoPedir_KeyPress);
            // 
            // txt_costoM
            // 
            this.txt_costoM.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoM.Location = new System.Drawing.Point(227, 191);
            this.txt_costoM.Name = "txt_costoM";
            this.txt_costoM.Size = new System.Drawing.Size(100, 21);
            this.txt_costoM.TabIndex = 8;
            this.txt_costoM.TextChanged += new System.EventHandler(this.txt_costoM_TextChanged);
            this.txt_costoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoM_KeyPress);
            // 
            // txt_diasAño
            // 
            this.txt_diasAño.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_diasAño.Location = new System.Drawing.Point(227, 329);
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
            this.btn_calcular.Location = new System.Drawing.Point(125, 365);
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
            this.btn_limpiar.Location = new System.Drawing.Point(241, 365);
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
            this.label6.Location = new System.Drawing.Point(519, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 14);
            this.label6.TabIndex = 13;
            this.label6.Text = "Q optimo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(425, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 14);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numeros de pedidos al año";
            // 
            // lbl_plazoE
            // 
            this.lbl_plazoE.AutoSize = true;
            this.lbl_plazoE.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_plazoE.Location = new System.Drawing.Point(121, 254);
            this.lbl_plazoE.Name = "lbl_plazoE";
            this.lbl_plazoE.Size = new System.Drawing.Size(94, 14);
            this.lbl_plazoE.TabIndex = 15;
            this.lbl_plazoE.Text = "Plazo de entrega";
            // 
            // txt_plazoE
            // 
            this.txt_plazoE.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_plazoE.Location = new System.Drawing.Point(227, 254);
            this.txt_plazoE.Name = "txt_plazoE";
            this.txt_plazoE.Size = new System.Drawing.Size(100, 21);
            this.txt_plazoE.TabIndex = 16;
            this.txt_plazoE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_plazoE_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(477, 212);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 14);
            this.label9.TabIndex = 18;
            this.label9.Text = "Punto de reorden";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(512, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 14);
            this.label8.TabIndex = 19;
            this.label8.Text = "Costo total";
            // 
            // txt_costoTotal
            // 
            this.txt_costoTotal.Enabled = false;
            this.txt_costoTotal.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_costoTotal.Location = new System.Drawing.Point(582, 268);
            this.txt_costoTotal.Name = "txt_costoTotal";
            this.txt_costoTotal.Size = new System.Drawing.Size(100, 21);
            this.txt_costoTotal.TabIndex = 23;
            // 
            // txt_puntoReo
            // 
            this.txt_puntoReo.Enabled = false;
            this.txt_puntoReo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_puntoReo.Location = new System.Drawing.Point(582, 212);
            this.txt_puntoReo.Name = "txt_puntoReo";
            this.txt_puntoReo.Size = new System.Drawing.Size(100, 21);
            this.txt_puntoReo.TabIndex = 22;
            // 
            // txt_numPedidos
            // 
            this.txt_numPedidos.Enabled = false;
            this.txt_numPedidos.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_numPedidos.Location = new System.Drawing.Point(582, 156);
            this.txt_numPedidos.Name = "txt_numPedidos";
            this.txt_numPedidos.Size = new System.Drawing.Size(100, 21);
            this.txt_numPedidos.TabIndex = 21;
            // 
            // txt_Qoptimo
            // 
            this.txt_Qoptimo.Enabled = false;
            this.txt_Qoptimo.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Qoptimo.Location = new System.Drawing.Point(582, 121);
            this.txt_Qoptimo.Name = "txt_Qoptimo";
            this.txt_Qoptimo.Size = new System.Drawing.Size(100, 21);
            this.txt_Qoptimo.TabIndex = 20;
            // 
            // txt_TiempoEntreP
            // 
            this.txt_TiempoEntreP.Enabled = false;
            this.txt_TiempoEntreP.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TiempoEntreP.Location = new System.Drawing.Point(582, 186);
            this.txt_TiempoEntreP.Name = "txt_TiempoEntreP";
            this.txt_TiempoEntreP.Size = new System.Drawing.Size(100, 21);
            this.txt_TiempoEntreP.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(455, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 14);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tiempo entre pedidos";
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_guardar.FlatAppearance.BorderSize = 0;
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.ForeColor = System.Drawing.Color.White;
            this.btn_guardar.Location = new System.Drawing.Point(582, 365);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 31);
            this.btn_guardar.TabIndex = 26;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(109, 88);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 20);
            this.label11.TabIndex = 27;
            this.label11.Text = "Datos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(433, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(86, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Resultado";
            // 
            // txt_inventarioSegu
            // 
            this.txt_inventarioSegu.Enabled = false;
            this.txt_inventarioSegu.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_inventarioSegu.Location = new System.Drawing.Point(582, 238);
            this.txt_inventarioSegu.Name = "txt_inventarioSegu";
            this.txt_inventarioSegu.Size = new System.Drawing.Size(100, 21);
            this.txt_inventarioSegu.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(445, 241);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 14);
            this.label13.TabIndex = 29;
            this.label13.Text = "Inventario de seguridad";
            // 
            // txt_tiempoEspera
            // 
            this.txt_tiempoEspera.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tiempoEspera.Location = new System.Drawing.Point(227, 291);
            this.txt_tiempoEspera.Name = "txt_tiempoEspera";
            this.txt_tiempoEspera.Size = new System.Drawing.Size(100, 21);
            this.txt_tiempoEspera.TabIndex = 32;
            this.txt_tiempoEspera.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_tiempoEspera_KeyPress);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(119, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(99, 14);
            this.label14.TabIndex = 31;
            this.label14.Text = "Tiempo de espera";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.panel3.Controls.Add(this.label15);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(969, 44);
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
            this.label15.Size = new System.Drawing.Size(936, 39);
            this.label15.TabIndex = 0;
            this.label15.Text = "Modelo Q";
            this.label15.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // modelo_Q
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(943, 621);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txt_tiempoEspera);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txt_inventarioSegu);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.txt_TiempoEntreP);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_costoTotal);
            this.Controls.Add(this.txt_puntoReo);
            this.Controls.Add(this.txt_numPedidos);
            this.Controls.Add(this.txt_Qoptimo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txt_plazoE);
            this.Controls.Add(this.lbl_plazoE);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_diasAño);
            this.Controls.Add(this.txt_costoPedir);
            this.Controls.Add(this.txt_costoM);
            this.Controls.Add(this.txt_costoPro);
            this.Controls.Add(this.txt_demanda);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modelo_Q";
            this.Text = "modelo_Q";
            this.panel3.ResumeLayout(false);
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
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_costoTotal;
        private System.Windows.Forms.TextBox txt_puntoReo;
        private System.Windows.Forms.TextBox txt_numPedidos;
        private System.Windows.Forms.TextBox txt_Qoptimo;
        private System.Windows.Forms.TextBox txt_TiempoEntreP;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_inventarioSegu;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txt_tiempoEspera;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label15;
    }
}