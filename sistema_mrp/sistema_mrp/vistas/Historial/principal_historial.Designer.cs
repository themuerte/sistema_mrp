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
            this.btn_salir = new System.Windows.Forms.Button();
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
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_atras);
            this.panel1.Controls.Add(this.btn_planAgre);
            this.panel1.Controls.Add(this.btn_MRP);
            this.panel1.Controls.Add(this.btn_modeloQyP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(223, 629);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_salir
            // 
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Image = global::sistema_mrp.Properties.Resources.shapes_and_symbols;
            this.btn_salir.Location = new System.Drawing.Point(13, 575);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(38, 40);
            this.btn_salir.TabIndex = 5;
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_atras.FlatAppearance.BorderSize = 0;
            this.btn_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.ForeColor = System.Drawing.Color.White;
            this.btn_atras.Location = new System.Drawing.Point(13, 403);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(197, 31);
            this.btn_atras.TabIndex = 4;
            this.btn_atras.Text = "Atras ";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_planAgre
            // 
            this.btn_planAgre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_planAgre.FlatAppearance.BorderSize = 0;
            this.btn_planAgre.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_planAgre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_planAgre.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_planAgre.ForeColor = System.Drawing.Color.White;
            this.btn_planAgre.Location = new System.Drawing.Point(13, 270);
            this.btn_planAgre.Name = "btn_planAgre";
            this.btn_planAgre.Size = new System.Drawing.Size(197, 40);
            this.btn_planAgre.TabIndex = 3;
            this.btn_planAgre.Text = "Plan Agregado";
            this.btn_planAgre.UseVisualStyleBackColor = false;
            this.btn_planAgre.Click += new System.EventHandler(this.btn_planAgre_Click);
            // 
            // btn_MRP
            // 
            this.btn_MRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_MRP.FlatAppearance.BorderSize = 0;
            this.btn_MRP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_MRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MRP.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MRP.ForeColor = System.Drawing.Color.White;
            this.btn_MRP.Location = new System.Drawing.Point(13, 218);
            this.btn_MRP.Name = "btn_MRP";
            this.btn_MRP.Size = new System.Drawing.Size(197, 46);
            this.btn_MRP.TabIndex = 2;
            this.btn_MRP.Text = "MRP";
            this.btn_MRP.UseVisualStyleBackColor = false;
            this.btn_MRP.Click += new System.EventHandler(this.btn_MRP_Click);
            // 
            // btn_modeloQyP
            // 
            this.btn_modeloQyP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_modeloQyP.FlatAppearance.BorderSize = 0;
            this.btn_modeloQyP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_modeloQyP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modeloQyP.Font = new System.Drawing.Font("Microsoft JhengHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modeloQyP.ForeColor = System.Drawing.Color.White;
            this.btn_modeloQyP.Location = new System.Drawing.Point(13, 166);
            this.btn_modeloQyP.Name = "btn_modeloQyP";
            this.btn_modeloQyP.Size = new System.Drawing.Size(197, 46);
            this.btn_modeloQyP.TabIndex = 1;
            this.btn_modeloQyP.Text = "Modelo Q y P";
            this.btn_modeloQyP.UseVisualStyleBackColor = false;
            this.btn_modeloQyP.Click += new System.EventHandler(this.btn_modeloQyP_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "principal_historial";
            this.Text = "principal_historial";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_salir;
    }
}