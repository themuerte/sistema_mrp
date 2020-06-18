namespace sistema_mrp.vistas.Historial
{
    partial class principal_historial
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
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_planAgre = new System.Windows.Forms.Button();
            this.btn_MRP = new System.Windows.Forms.Button();
            this.btn_modeloQyP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_principal = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_atras);
            this.panel1.Controls.Add(this.btn_planAgre);
            this.panel1.Controls.Add(this.btn_MRP);
            this.panel1.Controls.Add(this.btn_modeloQyP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 621);
            this.panel1.TabIndex = 0;
            // 
            // btn_atras
            // 
            this.btn_atras.Location = new System.Drawing.Point(71, 485);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(75, 23);
            this.btn_atras.TabIndex = 4;
            this.btn_atras.Text = "Atras ";
            this.btn_atras.UseVisualStyleBackColor = true;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_planAgre
            // 
            this.btn_planAgre.Location = new System.Drawing.Point(13, 334);
            this.btn_planAgre.Name = "btn_planAgre";
            this.btn_planAgre.Size = new System.Drawing.Size(197, 46);
            this.btn_planAgre.TabIndex = 3;
            this.btn_planAgre.Text = "Plan Agregado";
            this.btn_planAgre.UseVisualStyleBackColor = true;
            this.btn_planAgre.Click += new System.EventHandler(this.btn_planAgre_Click);
            // 
            // btn_MRP
            // 
            this.btn_MRP.Location = new System.Drawing.Point(13, 250);
            this.btn_MRP.Name = "btn_MRP";
            this.btn_MRP.Size = new System.Drawing.Size(197, 46);
            this.btn_MRP.TabIndex = 2;
            this.btn_MRP.Text = "MRP";
            this.btn_MRP.UseVisualStyleBackColor = true;
            this.btn_MRP.Click += new System.EventHandler(this.btn_MRP_Click);
            // 
            // btn_modeloQyP
            // 
            this.btn_modeloQyP.Location = new System.Drawing.Point(13, 166);
            this.btn_modeloQyP.Name = "btn_modeloQyP";
            this.btn_modeloQyP.Size = new System.Drawing.Size(197, 46);
            this.btn_modeloQyP.TabIndex = 1;
            this.btn_modeloQyP.Text = "Modelo Q y P";
            this.btn_modeloQyP.UseVisualStyleBackColor = true;
            this.btn_modeloQyP.Click += new System.EventHandler(this.btn_modeloQyP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(67, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial";
            // 
            // panel_principal
            // 
            this.panel_principal.Location = new System.Drawing.Point(228, 0);
            this.panel_principal.Name = "panel_principal";
            this.panel_principal.Size = new System.Drawing.Size(943, 621);
            this.panel_principal.TabIndex = 1;
            // 
            // principal_historial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 627);
            this.Controls.Add(this.panel_principal);
            this.Controls.Add(this.panel1);
            this.Name = "principal_historial";
            this.Text = "principal_historial";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_principal;
        private System.Windows.Forms.Button btn_modeloQyP;
        private System.Windows.Forms.Button btn_atras;
        private System.Windows.Forms.Button btn_planAgre;
        private System.Windows.Forms.Button btn_MRP;
    }
}