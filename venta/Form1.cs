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
        frmRegistrarCliente f;
        public Form1()
        {
            f = null;
            InitializeComponent();
            try
            {
                combo1();
                llenarClienteCombo();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void llenarClienteCombo()
        {
            try
            {
                Dictionary<int, string> cmbSource = new Dictionary<int, string>();
                if (this.nomClitxt.Text != "")
                {
                    if (this.nomClitxt.Text.Trim().Length >= 3)
                    {
                        using (SqlConnection conexion = BDComun.obtenerConexion())
                        {
                            string querytext = "select * from cliente where (nombre_cliente LIKE @NameSearch);";
                            SqlCommand query = new SqlCommand(querytext, conexion);
                            query.Parameters.Add(new SqlParameter("NameSearch", "%" + this.nomClitxt.Text + "%"));

                            SqlDataAdapter adapter = new SqlDataAdapter(query);
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            conexion.Close();
                            adapter.Dispose();
                            cmb_Clientes.DataSource = null;
                            cmb_Clientes.Items.Clear();

                            foreach (DataRow row in dt.Rows)
                            {
                                cmbSource.Add(Convert.ToInt32(row["id_cliente"].ToString()), row["nombre_cliente"].ToString());
                            }
                        }
                    }
                }
                cmbSource.Add(-1, "<Agregar nuevo cliente>");
                cmb_Clientes.DataSource = new BindingSource(cmbSource, null);
                cmb_Clientes.DisplayMember = "Value";
                cmb_Clientes.ValueMember = "Key";
                cmb_Clientes.SelectedIndex = 0;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
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
            Venta.Id_cliente = ((KeyValuePair<int, string>)this.cmb_Clientes.SelectedItem).Key;
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
                insertarCredito(Venta.Id_cliente, "21/05/2017",Venta.PrecioTotal);
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

        public void insertarCredito(int idCliente,string fecha,string importe)
        {
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand cm = new SqlCommand(string.Format("Insert into cuentas_por_cobrar(id_cliente,fecha,importe) values ('{0}', '{1}', '{2}')",
                    idCliente, fecha, importe), Conn);

                cm.ExecuteNonQuery();


                try
                {
                    
                }
                catch (Exception e)
                {
                    MessageBox.Show("error");
                }
            }
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

        private void nomClitxt_KeyUp(object sender, KeyEventArgs e)
        {
            llenarClienteCombo();
        }

        private void cmb_Clientes_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (cmb_Clientes.SelectedIndex == cmb_Clientes.Items.Count - 1)
            {
                if (f == null)
                {
                    f = new frmRegistrarCliente();
                    f.ShowDialog(this);
                }
                else
                {
                    f.Dispose();
                    f = null;
                    f = new frmRegistrarCliente();
                    f.ShowDialog(this);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Busqueda_Venta busque = new Busqueda_Venta();
            busque.Show();
        }
    }
}
