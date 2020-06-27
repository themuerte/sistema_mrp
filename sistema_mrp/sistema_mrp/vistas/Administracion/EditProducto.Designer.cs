namespace sistema_mrp.vistas.Administracion
{
    partial class EditProducto
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
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.mtbPrecio = new System.Windows.Forms.MaskedTextBox();
            this.mtbUnidades = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.Location = new System.Drawing.Point(62, 241);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(129, 23);
            this.btnEditProduct.TabIndex = 22;
            this.btnEditProduct.Text = "Guardar Cambios";
            this.btnEditProduct.UseVisualStyleBackColor = true;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(26, 126);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Unidades:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Precio Unitario";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(126, 25);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Nombre:";
            // 
            // mtbPrecio
            // 
            this.mtbPrecio.Location = new System.Drawing.Point(126, 80);
            this.mtbPrecio.Mask = "9999.99";
            this.mtbPrecio.Name = "mtbPrecio";
            this.mtbPrecio.Size = new System.Drawing.Size(100, 20);
            this.mtbPrecio.TabIndex = 23;
            // 
            // mtbUnidades
            // 
            this.mtbUnidades.Location = new System.Drawing.Point(126, 126);
            this.mtbUnidades.Mask = "999";
            this.mtbUnidades.Name = "mtbUnidades";
            this.mtbUnidades.Size = new System.Drawing.Size(100, 20);
            this.mtbUnidades.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Descripción:";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(126, 173);
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(100, 20);
            this.tbDescripcion.TabIndex = 26;
            // 
            // EditProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 332);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mtbUnidades);
            this.Controls.Add(this.mtbPrecio);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.label5);
            this.Name = "EditProducto";
            this.Text = "Editar Producto";
            this.Load += new System.EventHandler(this.AddProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox mtbPrecio;
        private System.Windows.Forms.MaskedTextBox mtbUnidades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescripcion;
    }
}