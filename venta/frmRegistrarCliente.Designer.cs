﻿namespace venta
{
    partial class frmRegistrarCliente
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
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.txt_RFC = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_RFC = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.txt_Telefono = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Registrar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_Registrar.ForeColor = System.Drawing.Color.White;
            this.btn_Registrar.Location = new System.Drawing.Point(275, 141);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(83, 28);
            this.btn_Registrar.TabIndex = 5;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.RegistrarCliente);
            // 
            // txt_NombreCliente
            // 
            this.txt_NombreCliente.Location = new System.Drawing.Point(88, 24);
            this.txt_NombreCliente.Name = "txt_NombreCliente";
            this.txt_NombreCliente.Size = new System.Drawing.Size(270, 20);
            this.txt_NombreCliente.TabIndex = 1;
            // 
            // txt_RFC
            // 
            this.txt_RFC.Location = new System.Drawing.Point(88, 62);
            this.txt_RFC.MaxLength = 13;
            this.txt_RFC.Name = "txt_RFC";
            this.txt_RFC.Size = new System.Drawing.Size(99, 20);
            this.txt_RFC.TabIndex = 2;
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Location = new System.Drawing.Point(88, 101);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(270, 20);
            this.txt_Direccion.TabIndex = 4;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Nombre.Location = new System.Drawing.Point(12, 25);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(60, 16);
            this.lbl_Nombre.TabIndex = 5;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_RFC
            // 
            this.lbl_RFC.AutoSize = true;
            this.lbl_RFC.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RFC.Location = new System.Drawing.Point(12, 63);
            this.lbl_RFC.Name = "lbl_RFC";
            this.lbl_RFC.Size = new System.Drawing.Size(32, 16);
            this.lbl_RFC.TabIndex = 6;
            this.lbl_RFC.Text = "RFC";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Telefono.Location = new System.Drawing.Point(193, 63);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(62, 16);
            this.lbl_Telefono.TabIndex = 7;
            this.lbl_Telefono.Text = "Teléfono";
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_Direccion.Location = new System.Drawing.Point(12, 102);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(70, 16);
            this.lbl_Direccion.TabIndex = 8;
            this.lbl_Direccion.Text = "Dirección";
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Location = new System.Drawing.Point(258, 62);
            this.txt_Telefono.Mask = "(999) 000-0000";
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(100, 20);
            this.txt_Telefono.TabIndex = 3;
            // 
            // frmRegistrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::venta.Properties.Resources.flores_zarco51;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(409, 222);
            this.Controls.Add(this.txt_Telefono);
            this.Controls.Add(this.lbl_Direccion);
            this.Controls.Add(this.lbl_Telefono);
            this.Controls.Add(this.lbl_RFC);
            this.Controls.Add(this.lbl_Nombre);
            this.Controls.Add(this.txt_Direccion);
            this.Controls.Add(this.txt_RFC);
            this.Controls.Add(this.txt_NombreCliente);
            this.Controls.Add(this.btn_Registrar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmRegistrarCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Registro de cliente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.TextBox txt_NombreCliente;
        private System.Windows.Forms.TextBox txt_RFC;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_RFC;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.MaskedTextBox txt_Telefono;
    }
}