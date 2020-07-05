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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal_GI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_salir = new System.Windows.Forms.Button();
            this.btn_modeloQ = new System.Windows.Forms.Button();
            this.btn_atras = new System.Windows.Forms.Button();
            this.btn_planeacioA = new System.Windows.Forms.Button();
            this.btn_MRP = new System.Windows.Forms.Button();
            this.btn_modeloP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_prin = new System.Windows.Forms.Panel();
            this.MensajeSalir = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.panel1.Controls.Add(this.btn_salir);
            this.panel1.Controls.Add(this.btn_modeloQ);
            this.panel1.Controls.Add(this.btn_atras);
            this.panel1.Controls.Add(this.btn_planeacioA);
            this.panel1.Controls.Add(this.btn_MRP);
            this.panel1.Controls.Add(this.btn_modeloP);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(225, 636);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // btn_salir
            // 
            this.btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_salir.FlatAppearance.BorderSize = 0;
            this.btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_salir.Font = new System.Drawing.Font("Microsoft JhengHei UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_salir.ForeColor = System.Drawing.Color.White;
            this.btn_salir.Image = global::sistema_mrp.Properties.Resources.shapes_and_symbols;
            this.btn_salir.Location = new System.Drawing.Point(10, 561);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(64, 50);
            this.btn_salir.TabIndex = 6;
            this.btn_salir.UseVisualStyleBackColor = false;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            this.btn_salir.MouseHover += new System.EventHandler(this.btn_salir_MouseHover);
            // 
            // btn_modeloQ
            // 
            this.btn_modeloQ.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_modeloQ.FlatAppearance.BorderSize = 0;
            this.btn_modeloQ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_modeloQ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modeloQ.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modeloQ.ForeColor = System.Drawing.Color.White;
            this.btn_modeloQ.Location = new System.Drawing.Point(10, 199);
            this.btn_modeloQ.Name = "btn_modeloQ";
            this.btn_modeloQ.Size = new System.Drawing.Size(197, 39);
            this.btn_modeloQ.TabIndex = 5;
            this.btn_modeloQ.Text = "Modelo Q";
            this.btn_modeloQ.UseVisualStyleBackColor = false;
            this.btn_modeloQ.Click += new System.EventHandler(this.btn_modeloQ_Click);
            // 
            // btn_atras
            // 
            this.btn_atras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_atras.FlatAppearance.BorderSize = 0;
            this.btn_atras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_atras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_atras.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_atras.ForeColor = System.Drawing.Color.White;
            this.btn_atras.Location = new System.Drawing.Point(10, 407);
            this.btn_atras.Name = "btn_atras";
            this.btn_atras.Size = new System.Drawing.Size(197, 31);
            this.btn_atras.TabIndex = 4;
            this.btn_atras.Text = "Atrás";
            this.btn_atras.UseVisualStyleBackColor = false;
            this.btn_atras.Click += new System.EventHandler(this.btn_atras_Click);
            // 
            // btn_planeacioA
            // 
            this.btn_planeacioA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_planeacioA.FlatAppearance.BorderSize = 0;
            this.btn_planeacioA.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_planeacioA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_planeacioA.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_planeacioA.ForeColor = System.Drawing.Color.White;
            this.btn_planeacioA.Location = new System.Drawing.Point(10, 290);
            this.btn_planeacioA.Name = "btn_planeacioA";
            this.btn_planeacioA.Size = new System.Drawing.Size(197, 39);
            this.btn_planeacioA.TabIndex = 3;
            this.btn_planeacioA.Text = "Plan Agregado";
            this.btn_planeacioA.UseVisualStyleBackColor = false;
            this.btn_planeacioA.Click += new System.EventHandler(this.btn_planeacioA_Click);
            // 
            // btn_MRP
            // 
            this.btn_MRP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_MRP.FlatAppearance.BorderSize = 0;
            this.btn_MRP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_MRP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MRP.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MRP.ForeColor = System.Drawing.Color.White;
            this.btn_MRP.Location = new System.Drawing.Point(10, 244);
            this.btn_MRP.Name = "btn_MRP";
            this.btn_MRP.Size = new System.Drawing.Size(197, 40);
            this.btn_MRP.TabIndex = 2;
            this.btn_MRP.Text = "MRP";
            this.btn_MRP.UseVisualStyleBackColor = false;
            this.btn_MRP.Click += new System.EventHandler(this.btn_MRP_Click);
            // 
            // btn_modeloP
            // 
            this.btn_modeloP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.btn_modeloP.FlatAppearance.BorderSize = 0;
            this.btn_modeloP.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_modeloP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_modeloP.Font = new System.Drawing.Font("Microsoft JhengHei UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_modeloP.ForeColor = System.Drawing.Color.White;
            this.btn_modeloP.Location = new System.Drawing.Point(10, 156);
            this.btn_modeloP.Name = "btn_modeloP";
            this.btn_modeloP.Size = new System.Drawing.Size(197, 37);
            this.btn_modeloP.TabIndex = 1;
            this.btn_modeloP.Text = "Modelo P";
            this.btn_modeloP.UseVisualStyleBackColor = false;
            this.btn_modeloP.Click += new System.EventHandler(this.btn_modeloP_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft New Tai Lue", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(0, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion De Inventario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_prin
            // 
            this.panel_prin.Location = new System.Drawing.Point(231, -3);
            this.panel_prin.Name = "panel_prin";
            this.panel_prin.Size = new System.Drawing.Size(927, 627);
            this.panel_prin.TabIndex = 1;
            this.panel_prin.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_prin_Paint);
            this.panel_prin.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_prin_MouseDown);
            // 
            // principal_GI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 627);
            this.Controls.Add(this.panel_prin);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "principal_GI";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "principal_GI";
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Button btn_salir;
        private System.Windows.Forms.ToolTip MensajeSalir;
    }
}