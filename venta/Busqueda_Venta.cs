using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace venta
{
    public partial class Busqueda_Venta : Form
    {
        private DataGridView data_BusquedaVenta;
        private Label label1;
        private Label ID_Venta;
        private Label label2;
        private Button but_Factura;
        private TextBox tex_IdVenta;
        private TextBox tex_Nombre;

        public Busqueda_Venta()
        {
                InitializeComponent();
            
                //string Connect = "Data Source=.; Initial Catalog=floreria; Integrated Security=True";
                string Connect = "Data Source=localhost\\SQLEXPRESS; Initial Catalog=floreria; Integrated Security=True"; 
                string sql = "select c.nombre_cliente, d.cantidad, d.nombre, d.precio_total, v.id_venta, v.fecha_venta, v.nombre_envio, v.direccion_envio, v.id_cliente from detalle_venta as d join venta as v on d.id_venta = v.id_venta join cliente as c on c.id_cliente = v.id_cliente";
                SqlConnection coneccion = new SqlConnection(Connect);
                SqlDataAdapter DataAdap = new SqlDataAdapter(sql, coneccion);
                DataSet ds = new DataSet();
                coneccion.Open();
                DataAdap.Fill(ds, "detalle_table");
                coneccion.Close();
                data_BusquedaVenta.DataSource = ds;
                data_BusquedaVenta.DataMember = "detalle_Table";
            
        }

        private void tex_Nombre_KeyUp(object sender, KeyEventArgs e)
        {
            using (SqlConnection coneccion = BDComun.obtenerConexion())
            {
                SqlConnection conec = BDComun.obtenerConexion();
                SqlCommand cmd = conec.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select c.nombre_cliente, d.cantidad, d.nombre, d.precio_total, v.id_venta, v.fecha_venta, v.nombre_envio, v.direccion_envio, v.id_cliente from detalle_venta as d join venta as v on d.id_venta = v.id_venta join cliente as c on c.id_cliente = v.id_cliente where c.nombre_cliente like ('" + tex_Nombre.Text + "%')";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                data_BusquedaVenta.DataSource = dt;
                conec.Close();
            }
        }

        private void InitializeComponent()
        {
            this.data_BusquedaVenta = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.ID_Venta = new System.Windows.Forms.Label();
            this.tex_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.but_Factura = new System.Windows.Forms.Button();
            this.tex_IdVenta = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.data_BusquedaVenta)).BeginInit();
            this.SuspendLayout();
            // 
            // data_BusquedaVenta
            // 
            this.data_BusquedaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_BusquedaVenta.Location = new System.Drawing.Point(12, 90);
            this.data_BusquedaVenta.Name = "data_BusquedaVenta";
            this.data_BusquedaVenta.Size = new System.Drawing.Size(882, 361);
            this.data_BusquedaVenta.TabIndex = 0;
            this.data_BusquedaVenta.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_BusquedaVenta_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del cliente";
            // 
            // ID_Venta
            // 
            this.ID_Venta.AutoSize = true;
            this.ID_Venta.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold);
            this.ID_Venta.Location = new System.Drawing.Point(59, 74);
            this.ID_Venta.Name = "ID_Venta";
            this.ID_Venta.Size = new System.Drawing.Size(66, 16);
            this.ID_Venta.TabIndex = 2;
            this.ID_Venta.Text = "ID_Venta";
            // 
            // tex_Nombre
            // 
            this.tex_Nombre.Location = new System.Drawing.Point(151, 42);
            this.tex_Nombre.Name = "tex_Nombre";
            this.tex_Nombre.Size = new System.Drawing.Size(196, 20);
            this.tex_Nombre.TabIndex = 3;
            this.tex_Nombre.TextChanged += new System.EventHandler(this.tex_Nombre_TextChanged);
            this.tex_Nombre.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tex_Nombre_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.label2.Location = new System.Drawing.Point(16, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 28);
            this.label2.TabIndex = 4;
            this.label2.Text = "Buqueda venta";
            // 
            // but_Factura
            // 
            this.but_Factura.BackColor = System.Drawing.Color.DarkOrchid;
            this.but_Factura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.but_Factura.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.but_Factura.ForeColor = System.Drawing.Color.White;
            this.but_Factura.Location = new System.Drawing.Point(12, 457);
            this.but_Factura.Name = "but_Factura";
            this.but_Factura.Size = new System.Drawing.Size(75, 26);
            this.but_Factura.TabIndex = 5;
            this.but_Factura.Text = "Factura";
            this.but_Factura.UseVisualStyleBackColor = false;
            this.but_Factura.Click += new System.EventHandler(this.but_Factura_Click);
            // 
            // tex_IdVenta
            // 
            this.tex_IdVenta.Location = new System.Drawing.Point(151, 68);
            this.tex_IdVenta.Name = "tex_IdVenta";
            this.tex_IdVenta.Size = new System.Drawing.Size(100, 20);
            this.tex_IdVenta.TabIndex = 6;
            // 
            // Busqueda_Venta
            // 
            this.BackColor = System.Drawing.Color.LightBlue;
            this.BackgroundImage = global::venta.Properties.Resources.flores_zarco51;
            this.ClientSize = new System.Drawing.Size(906, 520);
            this.Controls.Add(this.tex_IdVenta);
            this.Controls.Add(this.but_Factura);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tex_Nombre);
            this.Controls.Add(this.ID_Venta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_BusquedaVenta);
            this.Name = "Busqueda_Venta";
            this.Text = "Busqueda ventas";
            ((System.ComponentModel.ISupportInitialize)(this.data_BusquedaVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void tex_Nombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_Factura_Click(object sender, EventArgs e)
        {
            string n = tex_IdVenta.Text;

            facturacion factu = new facturacion();
            ReportDocument oRep = new ReportDocument();
            ParameterField pf = new ParameterField();
            ParameterFields pfs = new ParameterFields();
            ParameterDiscreteValue pdv = new ParameterDiscreteValue();
            pf.Name = "@facturacion";
            pdv.Value = n;
            pf.CurrentValues.Add(pdv);
            pfs.Add(pf);
            factu.crystalReportViewer1.ParameterFieldInfo = pfs;
            oRep.Load(@"C:\Users\carlo\Documents\Floreria-Modulo-Ventas-\venta\CrystalReport1.rpt");
            factu.crystalReportViewer1.ReportSource = oRep;
            factu.Show();
            oRep.ExportToDisk(ExportFormatType.PortableDocFormat, @"C:\Users\carlo\Desktop\Facturas\factura.pdf");
        }

        private void data_BusquedaVenta_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            DataGridViewRow mostrar = data_BusquedaVenta.Rows[e.RowIndex];
            tex_IdVenta.Text = data_BusquedaVenta.Rows[e.RowIndex].Cells[4].Value.ToString();
        }

        private void but_seleccionar_Click(object sender, EventArgs e)
        {
            //ID_Venta.Text = this.data_BusquedaVenta.CurrentCell.Value.ToString();
        }
    }
}
