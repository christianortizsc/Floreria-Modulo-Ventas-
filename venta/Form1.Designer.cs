namespace venta
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.nomClitxt = new System.Windows.Forms.TextBox();
            this.nomEnvtxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dirEnvtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.hrEnvtxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.observacionestxt = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.crechb = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.facchb = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cantSpn = new System.Windows.Forms.NumericUpDown();
            this.productocmb = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.tottxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.cmb_Clientes = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.cantSpn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Cliente:";
            // 
            // nomClitxt
            // 
            this.nomClitxt.Location = new System.Drawing.Point(132, 61);
            this.nomClitxt.Name = "nomClitxt";
            this.nomClitxt.Size = new System.Drawing.Size(295, 20);
            this.nomClitxt.TabIndex = 1;
            this.nomClitxt.KeyUp += new System.Windows.Forms.KeyEventHandler(this.nomClitxt_KeyUp);
            // 
            // nomEnvtxt
            // 
            this.nomEnvtxt.Location = new System.Drawing.Point(137, 363);
            this.nomEnvtxt.Name = "nomEnvtxt";
            this.nomEnvtxt.Size = new System.Drawing.Size(297, 20);
            this.nomEnvtxt.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre Envio:";
            // 
            // dirEnvtxt
            // 
            this.dirEnvtxt.Location = new System.Drawing.Point(137, 393);
            this.dirEnvtxt.Name = "dirEnvtxt";
            this.dirEnvtxt.Size = new System.Drawing.Size(297, 20);
            this.dirEnvtxt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 396);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Dirección Envio:";
            // 
            // hrEnvtxt
            // 
            this.hrEnvtxt.Location = new System.Drawing.Point(137, 426);
            this.hrEnvtxt.Name = "hrEnvtxt";
            this.hrEnvtxt.Size = new System.Drawing.Size(100, 20);
            this.hrEnvtxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 426);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Hora Envio:";
            // 
            // observacionestxt
            // 
            this.observacionestxt.Location = new System.Drawing.Point(466, 363);
            this.observacionestxt.Name = "observacionestxt";
            this.observacionestxt.Size = new System.Drawing.Size(264, 96);
            this.observacionestxt.TabIndex = 8;
            this.observacionestxt.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(464, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(109, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Observaciones:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // crechb
            // 
            this.crechb.AutoSize = true;
            this.crechb.Location = new System.Drawing.Point(653, 251);
            this.crechb.Name = "crechb";
            this.crechb.Size = new System.Drawing.Size(15, 14);
            this.crechb.TabIndex = 10;
            this.crechb.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(573, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Crédito:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(573, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Factura:";
            // 
            // facchb
            // 
            this.facchb.AutoSize = true;
            this.facchb.Location = new System.Drawing.Point(653, 283);
            this.facchb.Name = "facchb";
            this.facchb.Size = new System.Drawing.Size(15, 14);
            this.facchb.TabIndex = 12;
            this.facchb.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DarkOrchid;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(24, 464);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 26);
            this.button2.TabIndex = 15;
            this.button2.Text = "Registrar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 91);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 16);
            this.label8.TabIndex = 16;
            this.label8.Text = "Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 16);
            this.label9.TabIndex = 18;
            this.label9.Text = "Cantidad:";
            // 
            // cantSpn
            // 
            this.cantSpn.Location = new System.Drawing.Point(137, 118);
            this.cantSpn.Name = "cantSpn";
            this.cantSpn.Size = new System.Drawing.Size(50, 20);
            this.cantSpn.TabIndex = 19;
            // 
            // productocmb
            // 
            this.productocmb.FormattingEnabled = true;
            this.productocmb.Location = new System.Drawing.Point(137, 91);
            this.productocmb.Name = "productocmb";
            this.productocmb.Size = new System.Drawing.Size(121, 21);
            this.productocmb.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Nombre,
            this.Precio,
            this.Cantidad,
            this.Total});
            this.dataGridView1.Location = new System.Drawing.Point(15, 155);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(544, 150);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrchid;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(24, 329);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 26);
            this.button3.TabIndex = 22;
            this.button3.Text = "Agregar";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tottxt
            // 
            this.tottxt.Location = new System.Drawing.Point(593, 171);
            this.tottxt.Name = "tottxt";
            this.tottxt.Size = new System.Drawing.Size(100, 20);
            this.tottxt.TabIndex = 24;
            this.tottxt.Text = "0.0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(593, 155);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Precio Total:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DarkOrchid;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(112, 328);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 25;
            this.button4.Text = "Borrar";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(573, 174);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 16);
            this.label11.TabIndex = 26;
            this.label11.Text = "$";
            // 
            // cmb_Clientes
            // 
            this.cmb_Clientes.FormattingEnabled = true;
            this.cmb_Clientes.Location = new System.Drawing.Point(438, 61);
            this.cmb_Clientes.Name = "cmb_Clientes";
            this.cmb_Clientes.Size = new System.Drawing.Size(370, 21);
            this.cmb_Clientes.TabIndex = 27;
            this.cmb_Clientes.SelectionChangeCommitted += new System.EventHandler(this.cmb_Clientes_SelectionChangeCommitted);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label12.Location = new System.Drawing.Point(16, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 28);
            this.label12.TabIndex = 28;
            this.label12.Text = "Ventas";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.DarkOrchid;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(112, 464);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(92, 26);
            this.button5.TabIndex = 16;
            this.button5.Text = "Busqueda";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(836, 502);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmb_Clientes);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.tottxt);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.productocmb);
            this.Controls.Add(this.cantSpn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.facchb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.crechb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.observacionestxt);
            this.Controls.Add(this.hrEnvtxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dirEnvtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nomEnvtxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nomClitxt);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.cantSpn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nomClitxt;
        private System.Windows.Forms.TextBox nomEnvtxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox dirEnvtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox hrEnvtxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox observacionestxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox crechb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox facchb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown cantSpn;
        private System.Windows.Forms.ComboBox productocmb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.TextBox tottxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmb_Clientes;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button5;
    }
}

