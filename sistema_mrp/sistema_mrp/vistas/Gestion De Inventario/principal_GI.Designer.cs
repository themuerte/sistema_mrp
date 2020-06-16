namespace sistema_mrp.vistas.Gestion_de_inventario
{
    partial class principal_GI
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_modeloQ = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_planeacioA = new System.Windows.Forms.Button();
            this.btn_MRP = new System.Windows.Forms.Button();
            this.btn_modeloP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_prin = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_modeloQ);
            this.panel1.Controls.Add(this.btn_atras);
            this.panel1.Controls.Add(this.btn_planeacioA);
            this.panel1.Controls.Add(this.btn_MRP);
            this.panel1.Controls.Add(this.btn_modeloP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 621);
            this.panel1.TabIndex = 0;
            // 
            // btn_modeloQ
            // 
            this.btn_modeloQ.Location = new System.Drawing.Point(7, 230);
            this.btn_modeloQ.Name = "btn_modeloQ";
            this.btn_modeloQ.Size = new System.Drawing.Size(197, 46);
            this.btn_modeloQ.TabIndex = 5;
            this.btn_modeloQ.Text = "Modelo Q";
            this.btn_modeloQ.UseVisualStyleBackColor = true;
            this.btn_modeloQ.Click += new System.EventHandler(this.btn_modeloQ_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(69, 544);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 4;
            this.btn_atras.Text = "Atras";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_planeacioA
            // 
            this.btn_planeacioA.Location = new System.Drawing.Point(10, 379);
            this.btn_planeacioA.Name = "btn_planeacioA";
            this.btn_planeacioA.Size = new System.Drawing.Size(197, 46);
            this.btn_planeacioA.TabIndex = 3;
            this.btn_planeacioA.Text = "Plan Agregado";
            this.btn_planeacioA.UseVisualStyleBackColor = true;
            this.btn_planeacioA.Click += new System.EventHandler(this.btn_planeacioA_Click);
            // 
            // btn_MRP
            // 
            this.btn_MRP.Location = new System.Drawing.Point(10, 307);
            this.btn_MRP.Name = "btn_MRP";
            this.btn_MRP.Size = new System.Drawing.Size(197, 46);
            this.btn_MRP.TabIndex = 2;
            this.btn_MRP.Text = "MRP";
            this.btn_MRP.UseVisualStyleBackColor = true;
            this.btn_MRP.Click += new System.EventHandler(this.btn_MRP_Click);
            // 
            // btn_modeloP
            // 
            this.btn_modeloP.Location = new System.Drawing.Point(10, 156);
            this.btn_modeloP.Name = "btn_modeloP";
            this.btn_modeloP.Size = new System.Drawing.Size(197, 46);
            this.btn_modeloP.TabIndex = 1;
            this.btn_modeloP.Text = "Modelo P";
            this.btn_modeloP.UseVisualStyleBackColor = true;
            this.btn_modeloP.Click += new System.EventHandler(this.btn_modeloP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS PGothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion De Inventario";
            // 
            // panel_prin
            // 
            this.panel_prin.Location = new System.Drawing.Point(231, 3);
            this.panel_prin.Name = "panel_prin";
            this.panel_prin.Size = new System.Drawing.Size(943, 621);
            this.panel_prin.TabIndex = 1;
            // 
            // principal_GI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 627);
            this.Controls.Add(this.panel_prin);
            this.Controls.Add(this.panel1);
            this.Name = "principal_GI";
            this.Text = "principal_GI";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_modeloQ;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_planeacioA;
        private System.Windows.Forms.Button btn_MRP;
        private System.Windows.Forms.Button btn_modeloP;
        private System.Windows.Forms.Panel panel_prin;
    }
}