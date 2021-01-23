namespace MesaDeRegalos
{
    partial class ListaDeseos
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
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.gridDeseos = new System.Windows.Forms.DataGridView();
            this.Deseo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.gridRegalos = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbl3 = new System.Windows.Forms.Label();
            this.btnConfirmar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridDeseos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegalos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(251, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(290, 42);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Mesa de Regalos";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(240, 71);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(304, 28);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Agregue los regalos que deseé";
            // 
            // gridDeseos
            // 
            this.gridDeseos.AllowUserToAddRows = false;
            this.gridDeseos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridDeseos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deseo,
            this.Precio,
            this.Agregar});
            this.gridDeseos.Location = new System.Drawing.Point(225, 118);
            this.gridDeseos.Name = "gridDeseos";
            this.gridDeseos.Size = new System.Drawing.Size(345, 150);
            this.gridDeseos.TabIndex = 2;
            this.gridDeseos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridDeseos_CellContentClick);
            // 
            // Deseo
            // 
            this.Deseo.HeaderText = "Deseo";
            this.Deseo.Name = "Deseo";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // Agregar
            // 
            this.Agregar.HeaderText = "¿Agregar?";
            this.Agregar.Name = "Agregar";
            this.Agregar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // gridRegalos
            // 
            this.gridRegalos.AllowUserToAddRows = false;
            this.gridRegalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegalos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.gridRegalos.Location = new System.Drawing.Point(225, 334);
            this.gridRegalos.Name = "gridRegalos";
            this.gridRegalos.Size = new System.Drawing.Size(345, 150);
            this.gridRegalos.TabIndex = 3;
            this.gridRegalos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridRegalos_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Deseo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Precio";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.HeaderText = "¿Eliminar?";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(253, 286);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(125, 28);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Mis regalos:";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Enabled = false;
            this.btnConfirmar.Location = new System.Drawing.Point(624, 497);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(112, 66);
            this.btnConfirmar.TabIndex = 5;
            this.btnConfirmar.Text = "Confirmar";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // ListaDeseos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 593);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.gridRegalos);
            this.Controls.Add(this.gridDeseos);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Name = "ListaDeseos";
            this.Text = "Bienvenido";
            this.Load += new System.EventHandler(this.ListaDeseos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridDeseos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegalos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Deseo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewButtonColumn Agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewButtonColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Button btnConfirmar;
        public System.Windows.Forms.DataGridView gridDeseos;
        public System.Windows.Forms.DataGridView gridRegalos;
    }
}

