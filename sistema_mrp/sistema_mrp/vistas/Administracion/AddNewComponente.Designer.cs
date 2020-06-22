namespace sistema_mrp.vistas.Administracion
{
    partial class AddNewComponente
    {
        private string tipo;
        private int idPadre;

        public AddNewComponente(string tipo, int idPadre)
        {
            InitializeComponent();
            this.tipo = tipo;
            this.idPadre = idPadre;
        }

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.idComponenteH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.plazoCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoCH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUnidNecExist = new System.Windows.Forms.TextBox();
            this.tbMargenSegExist = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAddComponentExist = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbPrecio = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbplazoNew = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbUnidNew = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMargenSegNew = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbTipoNew = new System.Windows.Forms.ComboBox();
            this.btnAgregarComponenteNew = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 32);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(553, 336);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.Tag = "";
            this.tabControl1.UseWaitCursor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAddComponentExist);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.tbMargenSegExist);
            this.tabPage1.Controls.Add(this.tbUnidNecExist);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dataGridView3);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(545, 310);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Componente Existente";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.UseWaitCursor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnAgregarComponenteNew);
            this.tabPage2.Controls.Add(this.cbTipoNew);
            this.tabPage2.Controls.Add(this.tbMargenSegNew);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.tbUnidNew);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tbplazoNew);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.tbPrecio);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.tbNombre);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(545, 310);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Nuevo Componente";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.UseWaitCursor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idComponenteH,
            this.nombreCH,
            this.descripcionCH,
            this.precioCH,
            this.plazoCH,
            this.tipoCH});
            this.dataGridView3.Location = new System.Drawing.Point(6, 6);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(533, 190);
            this.dataGridView3.TabIndex = 17;
            // 
            // idComponenteH
            // 
            this.idComponenteH.HeaderText = "id";
            this.idComponenteH.Name = "idComponenteH";
            this.idComponenteH.ReadOnly = true;
            this.idComponenteH.Visible = false;
            // 
            // nombreCH
            // 
            this.nombreCH.HeaderText = "nombre";
            this.nombreCH.Name = "nombreCH";
            this.nombreCH.ReadOnly = true;
            // 
            // descripcionCH
            // 
            this.descripcionCH.HeaderText = "descripcion";
            this.descripcionCH.Name = "descripcionCH";
            this.descripcionCH.Visible = false;
            // 
            // precioCH
            // 
            this.precioCH.HeaderText = "precio";
            this.precioCH.Name = "precioCH";
            this.precioCH.ReadOnly = true;
            // 
            // plazoCH
            // 
            this.plazoCH.HeaderText = "plazo";
            this.plazoCH.Name = "plazoCH";
            this.plazoCH.ReadOnly = true;
            // 
            // tipoCH
            // 
            this.tipoCH.HeaderText = "tipo";
            this.tipoCH.Name = "tipoCH";
            this.tipoCH.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Id del componente seleccionado: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(207, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "<id>";
            // 
            // tbUnidNecExist
            // 
            this.tbUnidNecExist.Location = new System.Drawing.Point(412, 206);
            this.tbUnidNecExist.Name = "tbUnidNecExist";
            this.tbUnidNecExist.Size = new System.Drawing.Size(100, 20);
            this.tbUnidNecExist.TabIndex = 20;
            // 
            // tbMargenSegExist
            // 
            this.tbMargenSegExist.Location = new System.Drawing.Point(412, 235);
            this.tbMargenSegExist.Name = "tbMargenSegExist";
            this.tbMargenSegExist.Size = new System.Drawing.Size(100, 20);
            this.tbMargenSegExist.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Unidades Necesarias:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(298, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Márgen de Seguridad:";
            // 
            // btnAddComponentExist
            // 
            this.btnAddComponentExist.Location = new System.Drawing.Point(370, 271);
            this.btnAddComponentExist.Name = "btnAddComponentExist";
            this.btnAddComponentExist.Size = new System.Drawing.Size(75, 23);
            this.btnAddComponentExist.TabIndex = 24;
            this.btnAddComponentExist.Text = "Agregar";
            this.btnAddComponentExist.UseVisualStyleBackColor = true;
            this.btnAddComponentExist.Click += new System.EventHandler(this.btnAddComponentExist_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(112, 38);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(100, 20);
            this.tbNombre.TabIndex = 1;
            this.tbNombre.TextChanged += new System.EventHandler(this.tbNombre_TextChanged);
            // 
            // tbPrecio
            // 
            this.tbPrecio.Location = new System.Drawing.Point(112, 90);
            this.tbPrecio.Name = "tbPrecio";
            this.tbPrecio.Size = new System.Drawing.Size(100, 20);
            this.tbPrecio.TabIndex = 3;
            this.tbPrecio.TextChanged += new System.EventHandler(this.tbPrecio_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Precio Unitario";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // tbplazoNew
            // 
            this.tbplazoNew.Location = new System.Drawing.Point(179, 137);
            this.tbplazoNew.Name = "tbplazoNew";
            this.tbplazoNew.Size = new System.Drawing.Size(100, 20);
            this.tbplazoNew.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(30, 140);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(125, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Plazo de Entrega (Unid): ";
            // 
            // tbUnidNew
            // 
            this.tbUnidNew.Location = new System.Drawing.Point(410, 38);
            this.tbUnidNew.Name = "tbUnidNew";
            this.tbUnidNew.Size = new System.Drawing.Size(100, 20);
            this.tbUnidNew.TabIndex = 11;
            this.tbUnidNew.TextChanged += new System.EventHandler(this.tbUnidNew_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(282, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 13);
            this.label10.TabIndex = 10;
            this.label10.Text = "Unidades:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // tbMargenSegNew
            // 
            this.tbMargenSegNew.Location = new System.Drawing.Point(410, 87);
            this.tbMargenSegNew.Name = "tbMargenSegNew";
            this.tbMargenSegNew.Size = new System.Drawing.Size(100, 20);
            this.tbMargenSegNew.TabIndex = 13;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(273, 90);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "Stock de Seguridad";
            // 
            // cbTipoNew
            // 
            this.cbTipoNew.FormattingEnabled = true;
            this.cbTipoNew.Items.AddRange(new object[] {
            "dia",
            "semana",
            "mes"});
            this.cbTipoNew.Location = new System.Drawing.Point(285, 136);
            this.cbTipoNew.Name = "cbTipoNew";
            this.cbTipoNew.Size = new System.Drawing.Size(121, 21);
            this.cbTipoNew.TabIndex = 14;
            // 
            // btnAgregarComponenteNew
            // 
            this.btnAgregarComponenteNew.Location = new System.Drawing.Point(231, 203);
            this.btnAgregarComponenteNew.Name = "btnAgregarComponenteNew";
            this.btnAgregarComponenteNew.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarComponenteNew.TabIndex = 15;
            this.btnAgregarComponenteNew.Text = "Agregar";
            this.btnAgregarComponenteNew.UseVisualStyleBackColor = true;
            this.btnAgregarComponenteNew.Click += new System.EventHandler(this.btnAgregarComponenteNew_Click);
            // 
            // AddNewComponente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 403);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddNewComponente";
            this.Text = "Nuevo Componente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnAddComponentExist;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMargenSegExist;
        private System.Windows.Forms.TextBox tbUnidNecExist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn idComponenteH;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn plazoCH;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoCH;
        private System.Windows.Forms.TextBox tbMargenSegNew;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbUnidNew;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbplazoNew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbPrecio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnAgregarComponenteNew;
        private System.Windows.Forms.ComboBox cbTipoNew;
    }
}