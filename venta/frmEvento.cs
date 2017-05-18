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

        decimal totalAcum = 0;
        private void button5_Click(object sender, EventArgs e)
        {
            string paramBus = Convert.ToString(eventoCB.SelectedItem);
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Select descripcion,id_producto,precio from producto where descripcion='{0}'", paramBus), conexion);
                SqlDataReader reader = comando.ExecuteReader();
                decimal total = 0;
                while (reader.Read())
                {
                    total = 1 * Convert.ToDecimal(reader.GetDecimal(2));
                    dataGridView2.Rows.Add(Convert.ToString(reader.GetInt32(1)), reader.GetString(0), "$" + Convert.ToString(reader.GetDecimal(2)), 1, "$" + Convert.ToString(total));
                    totalAcum = totalAcum + total;
                    maskedTextBox1.Text = "$" + totalAcum.ToString();
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
                    string resta = Convert.ToString(row.Cells[2].Value);
                    resta = resta.Substring(1);
                    totalAcum = totalAcum - Convert.ToDecimal(resta);
                    maskedTextBox1.Text = "$" + totalAcum.ToString();
                    dataGridView2.Rows.Remove(row);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Evento evento = new Evento();
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
            }
            else
            {
                evento.id_local = ((KeyValuePair<int, string>)comboBox1.SelectedItem).Key;
                evento.Observaciones = descripcionTB.Text;
                evento.Id_cliente = ((KeyValuePair<int, string>)this.cmb_Clientes.SelectedItem).Key;
                evento.PrecioTotal = totalAcum;
                totalAcum = 0;
                evento.fechaEvento = DateTime.ParseExact(dateTimePicker1.Text, "dd/MM/yyyy hh:mm tt", null).ToString();
                maskedTextBox1.Text = "$" + totalAcum.ToString();

                int id_venta = EventoDAL.AgregarVenta(evento);//agregada inicio de transacción
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
                if(EventoDAL.ActualizaVenta(id_evento, id_venta)>0)
                {
                    MessageBox.Show("Los datos fueron guardados correctamente","Aviso");
                }
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

    }
}
