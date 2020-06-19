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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.cmb_desviacionEstandar = new System.Windows.Forms.ComboBox();
            this.cmb_probabilidadDemanda = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(403, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modelo P";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(114, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Datos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Resultado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Demanda promedio:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Plazo de entrega:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(34, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Desvision estandar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(31, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Probabilidad de cumplir la demanda:";
            // 
            // txt_demandaP
            // 
            this.txt_demandaP.Location = new System.Drawing.Point(240, 144);
            this.txt_demandaP.Name = "txt_demandaP";
            this.txt_demandaP.Size = new System.Drawing.Size(100, 20);
            this.txt_demandaP.TabIndex = 8;
            // 
            // txt_plazoEntrega
            // 
            this.txt_plazoEntrega.Location = new System.Drawing.Point(240, 178);
            this.txt_plazoEntrega.Name = "txt_plazoEntrega";
            this.txt_plazoEntrega.Size = new System.Drawing.Size(100, 20);
            this.txt_plazoEntrega.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(438, 214);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(127, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Cantidad optima de pedir:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(438, 178);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Desviacion estandar de la demanda:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(606, 151);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "z:";
            // 
            // txt_cantidadOptima
            // 
            this.txt_cantidadOptima.Location = new System.Drawing.Point(640, 218);
            this.txt_cantidadOptima.Name = "txt_cantidadOptima";
            this.txt_cantidadOptima.Size = new System.Drawing.Size(100, 20);
            this.txt_cantidadOptima.TabIndex = 18;
            // 
            // txt_desvEstandarDem
            // 
            this.txt_desvEstandarDem.Location = new System.Drawing.Point(640, 182);
            this.txt_desvEstandarDem.Name = "txt_desvEstandarDem";
            this.txt_desvEstandarDem.Size = new System.Drawing.Size(100, 20);
            this.txt_desvEstandarDem.TabIndex = 17;
            // 
            // txt_z
            // 
            this.txt_z.Location = new System.Drawing.Point(640, 148);
            this.txt_z.Name = "txt_z";
            this.txt_z.Size = new System.Drawing.Size(100, 20);
            this.txt_z.TabIndex = 16;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(106, 357);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(75, 23);
            this.btn_calcular.TabIndex = 19;
            this.btn_calcular.Text = "Calcular";
            this.btn_calcular.UseVisualStyleBackColor = true;
            // 
            // btn_limpiar
            // 
            this.btn_limpiar.Location = new System.Drawing.Point(240, 357);
            this.btn_limpiar.Name = "btn_limpiar";
            this.btn_limpiar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_limpiar.Size = new System.Drawing.Size(75, 23);
            this.btn_limpiar.TabIndex = 20;
            this.btn_limpiar.Text = "Limpiar";
            this.btn_limpiar.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(31, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Periodo de revision:";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(240, 214);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 10;
            // 
            // cmb_desviacionEstandar
            // 
            this.cmb_desviacionEstandar.FormattingEnabled = true;
            this.cmb_desviacionEstandar.Location = new System.Drawing.Point(240, 244);
            this.cmb_desviacionEstandar.Name = "cmb_desviacionEstandar";
            this.cmb_desviacionEstandar.Size = new System.Drawing.Size(100, 21);
            this.cmb_desviacionEstandar.TabIndex = 21;
            // 
            // cmb_probabilidadDemanda
            // 
            this.cmb_probabilidadDemanda.FormattingEnabled = true;
            this.cmb_probabilidadDemanda.Location = new System.Drawing.Point(240, 280);
            this.cmb_probabilidadDemanda.Name = "cmb_probabilidadDemanda";
            this.cmb_probabilidadDemanda.Size = new System.Drawing.Size(100, 21);
            this.cmb_probabilidadDemanda.TabIndex = 22;
            // 
            // modelo_P
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 621);
            this.Controls.Add(this.cmb_probabilidadDemanda);
            this.Controls.Add(this.cmb_desviacionEstandar);
            this.Controls.Add(this.btn_limpiar);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.txt_cantidadOptima);
            this.Controls.Add(this.txt_desvEstandarDem);
            this.Controls.Add(this.txt_z);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txt_plazoEntrega);
            this.Controls.Add(this.txt_demandaP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modelo_P";
            this.Text = "modelo_P";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
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
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ComboBox cmb_desviacionEstandar;
        private System.Windows.Forms.ComboBox cmb_probabilidadDemanda;
    }
}