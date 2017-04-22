using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace venta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            combo1();
        }

        public void combo1()
        {
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                   "Select descripcion from producto "), conexion);
                

                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    productocmb.Items.Add(reader.GetString(0));                 
                }
                conexion.Close();
                
            }

        }

        
        public void combo()
        {
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand cm = new SqlCommand("select descripcion from producto");

                try
                {
                    SqlDataReader dr = cm.ExecuteReader();

                    while (dr.Read())
                    {
                        productocmb.Items.Add(dr["descripcion"]);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("error");
                }
            }


        }

        public Venta VentaActual { get; set; }
        private void button2_Click(object sender, EventArgs e)
        {
            Venta Venta = new Venta();
            Venta.NombreEnvio = nomEnvtxt.Text;
            Venta.DireccionEnvio = dirEnvtxt.Text;
            Venta.HoraEnvio = hrEnvtxt.Text;
            Venta.Observaciones = observacionestxt.Text;
            string ptotal = tottxt.Text;
            ptotal = ptotal.Replace(",", ".");
            Venta.PrecioTotal = ptotal; 

            if (crechb.Checked)
            {
                Venta.Credito = 1;
            }
            else
            {
                Venta.Credito = 0;
            }

            if (facchb.Checked)
            {
                Venta.Factura = 1;
            }
            else
            {
                Venta.Factura = 0;
            }

            int resultado = VentaDAL.Agregar(Venta);
            if (resultado > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se guardaron los datos", " Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            insertDetalle();
        }

        string[,] arrDetVen = new string[100,5];
        private void button3_Click(object sender, EventArgs e)
        {
            string paramBus = Convert.ToString(productocmb.SelectedItem);
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                   "Select descripcion,id_producto,precio from producto where descripcion='{0}' ", paramBus),  conexion);


                SqlDataReader reader = comando.ExecuteReader();

                double total=0.0;

                while (reader.Read())
                {
                    /*dataGridView1.Rows[contP].Cells[0].Value = Convert.ToString(reader.GetInt32(1));
                    dataGridView1.Rows[contP].Cells[1].Value = reader.GetString(0);
                    dataGridView1.Rows[contP].Cells[2].Value = Convert.ToString(reader.GetDecimal(2));
                    dataGridView1.Rows[contP].Cells[3].Value = Convert.ToString(cantSpn.Value);
                    total = Convert.ToDouble(cantSpn.Value) * Convert.ToDouble(reader.GetDecimal(2));
                    dataGridView1.Rows[contP].Cells[4].Value = Convert.ToString(total);
                    contP++;*/
                    total = Convert.ToDouble(cantSpn.Value) * Convert.ToDouble(reader.GetDecimal(2));
                    dataGridView1.Rows.Add(Convert.ToString(reader.GetInt32(1)), reader.GetString(0),"$"+ Convert.ToString(reader.GetDecimal(2)), Convert.ToString(cantSpn.Value), "$"+Convert.ToString(total));
                    cantSpn.Value=0;
                    tottxt.Text = Convert.ToString(Convert.ToDouble(tottxt.Text)+total);
                    
                }
                conexion.Close();

            }
            
        }

        public string getIndex()
        {
            string index = "";
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                   "select IDENT_CURRENT('venta')"), conexion);


                SqlDataReader reader = comando.ExecuteReader();

                while (reader.Read())
                {
                    index = Convert.ToString(reader.GetDecimal(0));
                }
                conexion.Close();

            }
            return index;
        }

        public void insertDetalle()
        {
            arrDetVen[0, 0] = "Rosa";
            arrDetVen[0, 1] = "3";
            arrDetVen[0, 2] = "75,50";
            arrDetVen[0, 3] = "1";
            arrDetVen[0, 4] = "1";
            
            
            for (int i = 0; i <= dataGridView1.Rows.Count-2; i++)
            {
                DetalleVenta DetalleVenta = new DetalleVenta();
                DetalleVenta.Nombre = Convert.ToString(dataGridView1.Rows[i].Cells[1].Value);
                DetalleVenta.Cantidad = Convert.ToInt32(dataGridView1.Rows[i].Cells[3].Value);
                string ptotal = Convert.ToString(dataGridView1.Rows[i].Cells[4].Value);
                ptotal = ptotal.Replace(",", ".");
                ptotal = ptotal.Substring(1);              
                DetalleVenta.PrecioTotal = ptotal;
                DetalleVenta.IdProducto = Convert.ToInt32(dataGridView1.Rows[i].Cells[0].Value);
                DetalleVenta.IdVenta = Convert.ToInt32(getIndex());
                int resultado = DetalleVentaDAL.Agregar(DetalleVenta);
            }
            


            
            

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    string resta = Convert.ToString(row.Cells[4].Value);
                    resta = resta.Substring(1);
                    tottxt.Text = Convert.ToString(Convert.ToDouble(tottxt.Text) - Convert.ToDouble(resta));
                    dataGridView1.Rows.Remove(row);
                }
            }
        }
    }
}
