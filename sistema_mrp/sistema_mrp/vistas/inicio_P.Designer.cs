namespace sistema_mrp
{
    partial class btn_GesInventario
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_inicio = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_historia = new System.Windows.Forms.Button();
            this.btn_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_inicio);
            this.panel1.Location = new System.Drawing.Point(-1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(261, 118);
            this.panel1.TabIndex = 0;
            // 
            // lbl_inicio
            // 
            this.lbl_inicio.AutoSize = true;
            this.lbl_inicio.Font = new System.Drawing.Font("MS Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_inicio.Location = new System.Drawing.Point(77, 44);
            this.lbl_inicio.Name = "lbl_inicio";
            this.lbl_inicio.Size = new System.Drawing.Size(102, 27);
            this.lbl_inicio.TabIndex = 0;
            this.lbl_inicio.Text = "Inicio";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 58);
            this.button1.TabIndex = 1;
            this.button1.Text = "gestion de inventario";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_historia
            // 
            this.btn_historia.Location = new System.Drawing.Point(47, 250);
            this.btn_historia.Name = "btn_historia";
            this.btn_historia.Size = new System.Drawing.Size(157, 58);
            this.btn_historia.TabIndex = 2;
            this.btn_historia.Text = "Historial";
            this.btn_historia.UseVisualStyleBackColor = true;
            this.btn_historia.Click += new System.EventHandler(this.btn_historia_Click);
            // 
            // btn_salir
            // 
            this.btn_salir.Image = global::sistema_mrp.Properties.Resources.shapes_and_symbols;
            this.btn_salir.Location = new System.Drawing.Point(12, 345);
            this.btn_salir.Name = "btn_salir";
            this.btn_salir.Size = new System.Drawing.Size(35, 34);
            this.btn_salir.TabIndex = 3;
            this.btn_salir.Text = "}";
            this.btn_salir.UseVisualStyleBackColor = true;
            this.btn_salir.Click += new System.EventHandler(this.btn_salir_Click);
            // 
            // btn_GesInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 391);
            this.Controls.Add(this.btn_salir);
            this.Controls.Add(this.btn_historia);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "btn_GesInventario";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_inicio;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_historia;
        private System.Windows.Forms.Button btn_salir;
    }
}

