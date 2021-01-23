namespace MesaDeRegalos
{
    partial class Billing
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
            this.gridRegalos = new System.Windows.Forms.DataGridView();
            this.Deseo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.lblNumeroTarjeta = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCVV = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nummonth = new System.Windows.Forms.NumericUpDown();
            this.numyear = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gridRegalos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummonth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyear)).BeginInit();
            this.SuspendLayout();
            // 
            // gridRegalos
            // 
            this.gridRegalos.AllowUserToAddRows = false;
            this.gridRegalos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridRegalos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Deseo,
            this.Precio});
            this.gridRegalos.Location = new System.Drawing.Point(296, 117);
            this.gridRegalos.Name = "gridRegalos";
            this.gridRegalos.Size = new System.Drawing.Size(244, 150);
            this.gridRegalos.TabIndex = 3;
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
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft YaHei UI Light", 15.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(334, 64);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(164, 28);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Sus regalos son:";
            this.lbl2.Click += new System.EventHandler(this.lbl2_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(371, 9);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(99, 42);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Pago";
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(639, 492);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(112, 66);
            this.btnPagar.TabIndex = 6;
            this.btnPagar.Text = "Proceder al pago";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(41, 492);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(112, 66);
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.Text = "Regresar a Lista de Deseos";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblNumeroTarjeta
            // 
            this.lblNumeroTarjeta.AutoSize = true;
            this.lblNumeroTarjeta.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroTarjeta.Location = new System.Drawing.Point(37, 319);
            this.lblNumeroTarjeta.Name = "lblNumeroTarjeta";
            this.lblNumeroTarjeta.Size = new System.Drawing.Size(140, 21);
            this.lblNumeroTarjeta.TabIndex = 8;
            this.lblNumeroTarjeta.Text = "Número de tarjeta:";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(183, 322);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(192, 20);
            this.txtNumero.TabIndex = 9;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(540, 322);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(192, 20);
            this.txtNombre.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(394, 319);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre de tarjeta:";
            // 
            // txtCVV
            // 
            this.txtCVV.Location = new System.Drawing.Point(448, 382);
            this.txtCVV.Name = "txtCVV";
            this.txtCVV.Size = new System.Drawing.Size(67, 20);
            this.txtCVV.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 382);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 21);
            this.label2.TabIndex = 12;
            this.label2.Text = "CVV:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 382);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha Expiración:";
            // 
            // nummonth
            // 
            this.nummonth.Location = new System.Drawing.Point(180, 386);
            this.nummonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nummonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nummonth.Name = "nummonth";
            this.nummonth.Size = new System.Drawing.Size(41, 20);
            this.nummonth.TabIndex = 15;
            this.nummonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // numyear
            // 
            this.numyear.Increment = new decimal(new int[] {
            21,
            0,
            0,
            0});
            this.numyear.Location = new System.Drawing.Point(243, 386);
            this.numyear.Maximum = new decimal(new int[] {
            26,
            0,
            0,
            0});
            this.numyear.Name = "numyear";
            this.numyear.Size = new System.Drawing.Size(40, 20);
            this.numyear.TabIndex = 16;
            this.numyear.Value = new decimal(new int[] {
            21,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(227, 386);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "/";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Arial Unicode MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(409, 282);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 21);
            this.lblTotal.TabIndex = 18;
            // 
            // Billing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 590);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numyear);
            this.Controls.Add(this.nummonth);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCVV);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblNumeroTarjeta);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnPagar);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.gridRegalos);
            this.Name = "Billing";
            this.Text = "Billing";
            this.Load += new System.EventHandler(this.Billing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridRegalos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nummonth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numyear)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn Deseo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        public System.Windows.Forms.DataGridView gridRegalos;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Label lblNumeroTarjeta;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCVV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nummonth;
        private System.Windows.Forms.NumericUpDown numyear;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblTotal;
    }
}