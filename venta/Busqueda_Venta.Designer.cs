namespace venta
{
    partial class Busqueda_Venta
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
            this.data_BusquedaVenta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tex_Nombre = new System.Windows.Forms.TextBox();
            this.ID_Venta = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_BusquedaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // data_BusquedaVenta
            // 
            this.data_BusquedaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_BusquedaVenta.Location = new System.Drawing.Point(12, 90);
            this.data_BusquedaVenta.Name = "data_BusquedaVenta";
            this.data_BusquedaVenta.Size = new System.Drawing.Size(670, 297);
            this.data_BusquedaVenta.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // tex_Nombre
            // 
            this.tex_Nombre.Location = new System.Drawing.Point(62, 43);
            this.tex_Nombre.Name = "tex_Nombre";
            this.tex_Nombre.Size = new System.Drawing.Size(196, 20);
            this.tex_Nombre.TabIndex = 2;
            this.tex_Nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tex_Nombre_KeyUp);
            // 
            // ID_Venta
            // 
            this.ID_Venta.AutoSize = true;
            this.ID_Venta.Location = new System.Drawing.Point(59, 74);
            this.ID_Venta.Name = "ID_Venta";
            this.ID_Venta.Size = new System.Drawing.Size(52, 13);
            this.ID_Venta.TabIndex = 3;
            this.ID_Venta.Text = "ID_Venta";
            this.ID_Venta.Visible = false;
            // 
            // Busqueda_Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 399);
            this.Controls.Add(this.ID_Venta);
            this.Controls.Add(this.tex_Nombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_BusquedaVenta);
            this.Name = "Busqueda_Venta";
            this.Text = "Busqueda_Venta";
            ((System.ComponentModel.ISupportInitialize)(this.data_BusquedaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView data_BusquedaVenta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tex_Nombre;
        private System.Windows.Forms.Label ID_Venta;
    }
}