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
using System.Configuration;
using System.Text.RegularExpressions;

namespace venta
{
    public partial class frmEvento : Form
    {
        frmRegistrarCliente f;

        public frmEvento()
        {
            f = null;
            InitializeComponent();
            // Cargo los datos que tendra el combobox
            combo();
            comboBox1.DisplayMember = "Value";
            comboBox1.ValueMember = "Key";
            Autocomplete();
            comboBox1.AutoCompleteMode = AutoCompleteMode.Suggest;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            dateTimePicker1.MinDate = DateTime.Now;
            try
            {
                llenarClienteCombo();
            }
            catch (Exception e)
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
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void eventoCB_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == comboBox1.Items.Count - 1)
            {
                frmLugaresEvento le = new frmLugaresEvento();
                le.ShowDialog(this);
                Autocomplete();
            }
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
        private void nomClitxt_KeyUp(object sender, KeyEventArgs e)
        {
            llenarClienteCombo();
        }

        //metodo para cargar los datos de la bd
        public static DataTable Datos()
        {
            DataTable dt = new DataTable();

            SqlConnection conexion = BDComun.obtenerConexion();

            string consulta = "SELECT id_local, nombre_local FROM local"; //consulta a la tabla local
            SqlCommand comando = new SqlCommand(consulta, conexion);

            SqlDataAdapter adap = new SqlDataAdapter(comando);

            adap.Fill(dt);
            return dt;
        }

        //metodo para cargar la coleccion de datos para el autocomplete
        Dictionary<int, string> keysColeccion;
        public void Autocomplete()
        {
            DataTable dt = Datos();

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            keysColeccion = new Dictionary<int, string>();
            //recorrer y cargar los items para el autocompletado
            foreach (DataRow row in dt.Rows)
            {
                coleccion.Add(Convert.ToString(row["nombre_local"]));
                keysColeccion.Add(Convert.ToInt32(row["id_local"]), Convert.ToString(row["nombre_local"]));
            }
            keysColeccion.Add(-1, "<Agregar lugar de evento>");
            comboBox1.AutoCompleteCustomSource = coleccion;
            comboBox1.DataSource = new BindingSource(keysColeccion, null);
        }

        decimal totalAcum = 0;//suma del total de los productos
        int[,] arrStock = new int[100, 1];
        int contP = 0;
        decimal totalTextBox;//el número que se pondrá en el textbox
        private void button5_Click(object sender, EventArgs e)
        {
            string paramBus = Convert.ToString(eventoCB.SelectedItem);
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format(
                    "Select descripcion,id_producto,precio,stock from producto where descripcion='{0}'", paramBus), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                decimal total = 0;
                while (reader.Read())
                {
                    int stock = reader.GetInt32(3);
                    if (stock == 0)
                    {
                        MessageBox.Show("No hay producto en existencia.");
                    }
                    else if (stock < cantSpn.Value)
                    {
                        MessageBox.Show("La cantidad solicitada es mayor al stock en existencia. Stock actual: " + Convert.ToString(stock) + ".");
                    }
                    else
                    {
                        contP++;
                        arrStock[dataGridView2.Rows.Count - 1, 0] = stock;
                        total = Convert.ToInt32(cantSpn.Value) * Convert.ToDecimal(reader.GetDecimal(2));
                        dataGridView2.Rows.Add(Convert.ToString(reader.GetInt32(1)), reader.GetString(0), "$" + Convert.ToString(reader.GetDecimal(2)), cantSpn.Value, "$" + Convert.ToString(total));
                        totalAcum = totalAcum + total;
                        totalTextBox = totalAcum;
                        cantSpn.Value = 1;
                        maskedTextBox1.Text = "$" + totalTextBox.ToString();
                    }
                }
                conexion.Close();

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView2.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    for (int i = row.Index; i < contP - 1; i++)
                    {
                        arrStock[i, 0] = arrStock[i + 1, 0];
                    }
                    contP--;
                    string resta = Convert.ToString(row.Cells[4].Value);
                    resta = resta.Substring(1);
                    totalAcum = totalAcum - Convert.ToDecimal(resta);
                    maskedTextBox1.Text = "$" + totalAcum.ToString();
                    dataGridView2.Rows.Remove(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (((KeyValuePair<int, string>)this.cmb_Clientes.SelectedItem).Key == -1)
            {
                MessageBox.Show("Por favor seleccione un cliente.");
                return;
            }
            bool localTextError = true;
            foreach (KeyValuePair<int, string> locales in comboBox1.Items)
            {
                if (locales.Value == (comboBox1.Text))
                {
                    localTextError = false;
                    break;
                }
            }
            if (localTextError)
            {
                MessageBox.Show("Verifique que el nombre del local esté bien escrito", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Evento evento = new Evento();
            evento.id_local = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
            evento.Observaciones = descripcionTB.Text;
            evento.Id_cliente = ((KeyValuePair<int, string>)this.cmb_Clientes.SelectedItem).Key;
            evento.PrecioTotal = totalAcum;
            totalAcum = 0;
            evento.fechaEvento = DateTime.ParseExact(dateTimePicker1.Text, "dd/MM/yyyy hh:mm tt", null).ToString();
            maskedTextBox1.Text = "$" + totalAcum.ToString();

            int id_venta = EventoDAL.AgregarVenta(evento);
            int id_evento = EventoDAL.AgregarEvento(evento, id_venta);

            string[] data;

            foreach (DataGridViewRow items in dataGridView2.Rows)
            {
                data = new string[5];
                if (!items.IsNewRow)
                {
                    data[0] = items.Cells[3].Value.ToString();//cantidad
                    data[1] = items.Cells[1].Value.ToString();//nombre
                    data[2] = items.Cells[2].Value.ToString().Substring(1);//precio
                    data[3] = items.Cells[0].Value.ToString();//id_producto
                    data[4] = id_venta.ToString();
                    EventoDAL.AgregaDetalleVenta(data, id_venta);//al terminar de leer una fila, la ingresa
                }
            }

            insertarCredito(evento.Id_cliente, totalTextBox, id_venta, id_evento);
            restarStock();

            if (EventoDAL.ActualizaVenta(id_evento, id_venta) > 0)
            {
                MessageBox.Show("Datos Guardados Correctamente", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se guardaron los datos", " Error al Guardar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
        }

        public void combo()
        {
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand cm = new SqlCommand(string.Format("select descripcion from producto"), Conn);
                try
                {
                    SqlDataReader dr = cm.ExecuteReader();

                    while (dr.Read())
                    {
                        eventoCB.Items.Add(dr["descripcion"]);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("error");
                }
            }
        }
        public void restarStock()
        {
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                for (int i = 0; i <= dataGridView2.Rows.Count - 2; i++)
                {
                    int idProducto = Convert.ToInt32(dataGridView2.Rows[i].Cells[0].Value);
                    int cantP = Convert.ToInt32(dataGridView2.Rows[i].Cells[3].Value);
                    int newStock = arrStock[i, 0] - cantP;
                    SqlCommand cm = new SqlCommand(string.Format("UPDATE producto SET stock='{0}' WHERE id_producto = '{1}'; ",
                        newStock, idProducto), Conn);
                    cm.ExecuteNonQuery();
                }
                try
                {

                }
                catch (Exception e)
                {
                    MessageBox.Show("error");
                }
            }
        }

        public void insertarCredito(int idCliente, decimal importe, int idVenta, int idEvento)
        {
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                try
                {
                var fecha = DateTime.Now;
                SqlCommand cm = new SqlCommand(string.Format("Insert into cuentas_por_cobrar(id_cliente,fecha,importe,id_venta,id_evento) values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    idCliente, fecha, importe, idVenta, idEvento), Conn);
                cm.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    MessageBox.Show("error");
                }
            }
        }
        decimal resta = 0;//total a restar al total del textbox
        string regex = @"^\d*(\.\d?\d)?$";
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            Regex validation = new Regex(regex);
            if (validation.IsMatch(textBox1.Text))
            {
                totalTextBox = totalAcum - resta;
                maskedTextBox1.Text = "$" + totalTextBox;
                Console.WriteLine("match");
            }
            else
            {
                Console.WriteLine("no match");
            }
            e.Handled = true;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
            if (char.IsDigit(e.KeyChar) || 
                e.KeyChar == '.' || 
                e.KeyChar == (char)Keys.Back || 
                e.KeyChar == (char)Keys.Left || 
                e.KeyChar == (char)Keys.Right)
            {
                e.Handled = false;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                resta = Convert.ToDecimal(textBox1.Text);
            }
            else
            {
                Console.WriteLine("null");
                resta = 0;
            }
        }
    }
}
