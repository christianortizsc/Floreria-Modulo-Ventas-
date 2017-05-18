namespace venta
{
    partial class frmLugaresEvento
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_NombreLocal = new System.Windows.Forms.TextBox();
            this.txt_DireccionLocal = new System.Windows.Forms.TextBox();
            this.btn_Registrar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // txt_NombreLocal
            // 
            this.txt_NombreLocal.Location = new System.Drawing.Point(92, 46);
            this.txt_NombreLocal.Name = "txt_NombreLocal";
            this.txt_NombreLocal.Size = new System.Drawing.Size(270, 20);
            this.txt_NombreLocal.TabIndex = 2;
            // 
            // txt_DireccionLocal
            // 
            this.txt_DireccionLocal.Location = new System.Drawing.Point(92, 79);
            this.txt_DireccionLocal.Name = "txt_DireccionLocal";
            this.txt_DireccionLocal.Size = new System.Drawing.Size(270, 20);
            this.txt_DireccionLocal.TabIndex = 3;
            // 
            // btn_Registrar
            // 
            this.btn_Registrar.BackColor = System.Drawing.Color.DarkOrchid;
            this.btn_Registrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Registrar.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn_Registrar.ForeColor = System.Drawing.Color.White;
            this.btn_Registrar.Location = new System.Drawing.Point(279, 111);
            this.btn_Registrar.Name = "btn_Registrar";
            this.btn_Registrar.Size = new System.Drawing.Size(83, 28);
            this.btn_Registrar.TabIndex = 6;
            this.btn_Registrar.Text = "Registrar";
            this.btn_Registrar.UseVisualStyleBackColor = false;
            this.btn_Registrar.Click += new System.EventHandler(this.btn_Registrar_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label12.Location = new System.Drawing.Point(5, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(174, 28);
            this.label12.TabIndex = 58;
            this.label12.Text = "Salón de evento";
            // 
            // frmLugaresEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::venta.Properties.Resources.LogoZarco;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(378, 203);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btn_Registrar);
            this.Controls.Add(this.txt_DireccionLocal);
            this.Controls.Add(this.txt_NombreLocal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Name = "frmLugaresEvento";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Salones de evento";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_NombreLocal;
        private System.Windows.Forms.TextBox txt_DireccionLocal;
        private System.Windows.Forms.Button btn_Registrar;
        private System.Windows.Forms.Label label12;
    }
}