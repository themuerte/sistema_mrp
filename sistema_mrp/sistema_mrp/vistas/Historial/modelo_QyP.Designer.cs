namespace sistema_mrp.vistas.Historial
{
    partial class modelo_QyP
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
            this.dtg_modeloQ = new System.Windows.Forms.DataGridView();
            this.dtg_modeloP = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_modeloQ)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_modeloP)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_modeloQ
            // 
            this.dtg_modeloQ.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_modeloQ.Location = new System.Drawing.Point(44, 70);
            this.dtg_modeloQ.Name = "dtg_modeloQ";
            this.dtg_modeloQ.Size = new System.Drawing.Size(849, 201);
            this.dtg_modeloQ.TabIndex = 1;
            // 
            // dtg_modeloP
            // 
            this.dtg_modeloP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_modeloP.Location = new System.Drawing.Point(44, 368);
            this.dtg_modeloP.Name = "dtg_modeloP";
            this.dtg_modeloP.Size = new System.Drawing.Size(849, 201);
            this.dtg_modeloP.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.label1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(-1, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(943, 44);
            this.label1.TabIndex = 24;
            this.label1.Text = "Modelo Q";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(143)))), ((int)(((byte)(212)))));
            this.label2.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(-1, 304);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(943, 44);
            this.label2.TabIndex = 25;
            this.label2.Text = "Modelo P";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // modelo_QyP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(943, 621);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtg_modeloP);
            this.Controls.Add(this.dtg_modeloQ);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "modelo_QyP";
            this.Text = "modelo_QyP";
            ((System.ComponentModel.ISupportInitialize)(this.dtg_modeloQ)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_modeloP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dtg_modeloQ;
        private System.Windows.Forms.DataGridView dtg_modeloP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}