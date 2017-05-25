namespace venta
{
    partial class frmEditarCliente
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
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.label_Buscar = new System.Windows.Forms.Label();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.grid_Clientes = new System.Windows.Forms.DataGridView();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.btn_Buscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_Clientes)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(149, 68);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(385, 20);
            this.txt_NombreCliente.TabIndex = 0;
            // 
            // label_Buscar
            // 
            this.label_Buscar.AutoSize = true;
            this.label_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Buscar.Location = new System.Drawing.Point(14, 69);
            this.label_Buscar.Name = "label_Buscar";
            this.label_Buscar.Size = new System.Drawing.Size(129, 16);
            this.label_Buscar.TabIndex = 1;
            this.label_Buscar.Text = "Nombre de cliente";
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold);
            this.label_Titulo.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label_Titulo.Location = new System.Drawing.Point(12, 9);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(197, 28);
            this.label_Titulo.TabIndex = 2;
            this.label_Titulo.Text = "Edición de clientes";
            // 
            // grid_Clientes
            // 
            this.grid_Clientes.AllowUserToAddRows = false;
            this.grid_Clientes.AllowUserToDeleteRows = false;
            this.grid_Clientes.AllowUserToResizeRows = false;
            this.grid_Clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_Clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_Clientes.Location = new System.Drawing.Point(17, 99);
            this.grid_Clientes.MultiSelect = false;
            this.grid_Clientes.Name = "grid_Clientes";
            this.grid_Clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_Clientes.Size = new System.Drawing.Size(613, 321);
            this.grid_Clientes.TabIndex = 1;
            this.grid_Clientes.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_Clientes_CellValueChanged);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Guardar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_Guardar.ForeColor = System.Drawing.Color.White;
            this.btn_Guardar.Location = new System.Drawing.Point(542, 426);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(88, 31);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Eliminar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.btn_Eliminar.Location = new System.Drawing.Point(446, 426);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(90, 31);
            this.btn_Eliminar.TabIndex = 3;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = false;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cerrar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_Cerrar.Location = new System.Drawing.Point(17, 426);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(90, 31);
            this.btn_Cerrar.TabIndex = 2;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Buscar
            // 
            this.btn_Buscar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Buscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Buscar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_Buscar.ForeColor = System.Drawing.Color.White;
            this.btn_Buscar.Location = new System.Drawing.Point(540, 62);
            this.btn_Buscar.Name = "btn_Buscar";
            this.btn_Buscar.Size = new System.Drawing.Size(90, 31);
            this.btn_Buscar.TabIndex = 5;
            this.btn_Buscar.Text = "Buscar";
            this.btn_Buscar.UseVisualStyleBackColor = false;
            this.btn_Buscar.Click += new System.EventHandler(this.btn_Buscar_Click);
            // 
            // frmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::venta.Properties.Resources.flores_zarco51;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(642, 469);
            this.Controls.Add(this.btn_Buscar);
            this.Controls.Add(this.btn_Cerrar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.grid_Clientes);
            this.Controls.Add(this.label_Titulo);
            this.Controls.Add(this.label_Buscar);
            this.Controls.Add(this.txt_NombreCliente);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEditarCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Editar clientes";
            ((System.ComponentModel.ISupportInitialize)(this.grid_Clientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.Label label_Buscar;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.DataGridView grid_Clientes;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Cerrar;
        private System.Windows.Forms.Button btn_Buscar;
    }
}