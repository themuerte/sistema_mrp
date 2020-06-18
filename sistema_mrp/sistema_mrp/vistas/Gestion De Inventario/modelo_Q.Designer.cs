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
            this.lbl_modeloQ = new System.Windows.Forms.Label();
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
            this.SuspendLayout();
            // 
            // lbl_modeloQ
            // 
            this.lbl_modeloQ.AutoSize = true;
            this.lbl_modeloQ.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_modeloQ.Location = new System.Drawing.Point(399, 27);
            this.lbl_modeloQ.Name = "lbl_modeloQ";
            this.lbl_modeloQ.Size = new System.Drawing.Size(109, 24);
            this.lbl_modeloQ.TabIndex = 0;
            this.lbl_modeloQ.Text = "Modelo Q";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(178, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Demanda anual:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Costo del producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(178, 166);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Costo de mantenimiento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Costo de pedir: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(178, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Dias trabajados por año:";
            // 
            // txt_demanda
            // 
            this.txt_demanda.Location = new System.Drawing.Point(299, 90);
            this.txt_demanda.Name = "txt_demanda";
            this.txt_demanda.Size = new System.Drawing.Size(100, 20);
            this.txt_demanda.TabIndex = 6;
            this.txt_demanda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_demanda_KeyPress);
            // 
            // txt_costoPro
            // 
            this.txt_costoPro.Location = new System.Drawing.Point(299, 125);
            this.txt_costoPro.Name = "txt_costoPro";
            this.txt_costoPro.Size = new System.Drawing.Size(100, 20);
            this.txt_costoPro.TabIndex = 7;
            this.txt_costoPro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoPro_KeyPress);
            // 
            // txt_costoPedir
            // 
            this.txt_costoPedir.Location = new System.Drawing.Point(299, 195);
            this.txt_costoPedir.Name = "txt_costoPedir";
            this.txt_costoPedir.Size = new System.Drawing.Size(100, 20);
            this.txt_costoPedir.TabIndex = 9;
            this.txt_costoPedir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoPedir_KeyPress);
            // 
            // txt_costoM
            // 
            this.txt_costoM.Location = new System.Drawing.Point(299, 163);
            this.txt_costoM.Name = "txt_costoM";
            this.txt_costoM.Size = new System.Drawing.Size(100, 20);
            this.txt_costoM.TabIndex = 8;
            this.txt_costoM.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_costoM_KeyPress);
            // 
            // txt_diasAño
            // 
            this.txt_diasAño.Location = new System.Drawing.Point(299, 256);
            this.txt_diasAño.Name = "txt_diasAño";
            this.txt_diasAño.Size = new System.Drawing.Size(100, 20);
            this.txt_diasAño.TabIndex = 10;
            this.txt_diasAño.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_diasAño_KeyPress);
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(199, 310);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 11;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(315, 310);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 12;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            this.btn_limpiar.Click += new System.EventHandler(this.btn_limpiar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(456, 90);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Q optimo:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Numeros de pedidos al año: ";
            // 
            // lbl_plazoE
            // 
            this.lbl_plazoE.AutoSize = true;
            this.lbl_plazoE.Location = new System.Drawing.Point(178, 229);
            this.lbl_plazoE.Name = "lbl_plazoE";
            this.lbl_plazoE.Size = new System.Drawing.Size(93, 13);
            this.lbl_plazoE.TabIndex = 15;
            this.lbl_plazoE.Text = "Plazo de entrega: ";
            // 
            // txt_plazoE
            // 
            this.txt_plazoE.Location = new System.Drawing.Point(299, 226);
            this.txt_plazoE.Name = "txt_plazoE";
            this.txt_plazoE.Size = new System.Drawing.Size(100, 20);
            this.txt_plazoE.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(456, 184);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Punto de reorden:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(459, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Costo total:";
            // 
            // txt_costoTotal
            // 
            this.txt_costoTotal.Location = new System.Drawing.Point(605, 213);
            this.txt_costoTotal.Name = "txt_costoTotal";
            this.txt_costoTotal.Size = new System.Drawing.Size(100, 20);
            this.txt_costoTotal.TabIndex = 23;
            // 
            // txt_puntoReo
            // 
            this.txt_puntoReo.Location = new System.Drawing.Point(605, 181);
            this.txt_puntoReo.Name = "txt_puntoReo";
            this.txt_puntoReo.Size = new System.Drawing.Size(100, 20);
            this.txt_puntoReo.TabIndex = 22;
            // 
            // txt_numPedidos
            // 
            this.txt_numPedidos.Enabled = false;
            this.txt_numPedidos.Location = new System.Drawing.Point(605, 125);
            this.txt_numPedidos.Name = "txt_numPedidos";
            this.txt_numPedidos.Size = new System.Drawing.Size(100, 20);
            this.txt_numPedidos.TabIndex = 21;
            // 
            // txt_Qoptimo
            // 
            this.txt_Qoptimo.Enabled = false;
            this.txt_Qoptimo.Location = new System.Drawing.Point(605, 90);
            this.txt_Qoptimo.Name = "txt_Qoptimo";
            this.txt_Qoptimo.Size = new System.Drawing.Size(100, 20);
            this.txt_Qoptimo.TabIndex = 20;
            this.txt_Qoptimo.TextChanged += new System.EventHandler(this.txt_Qoptimo_TextChanged);
            // 
            // txt_TiempoEntreP
            // 
            this.txt_TiempoEntreP.Enabled = false;
            this.txt_TiempoEntreP.Location = new System.Drawing.Point(605, 155);
            this.txt_TiempoEntreP.Name = "txt_TiempoEntreP";
            this.txt_TiempoEntreP.Size = new System.Drawing.Size(100, 20);
            this.txt_TiempoEntreP.TabIndex = 25;
            this.txt_TiempoEntreP.TextChanged += new System.EventHandler(this.txt_TiempoEntreP_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(456, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tiempo entre pedidos";
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(605, 310);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 26;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // modelo_Q
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(943, 621);
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
            this.Controls.Add(this.lbl_modeloQ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modelo_Q";
            this.Text = "modelo_Q";
            this.Load += new System.EventHandler(this.modelo_Q_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_modeloQ;
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
    }
}