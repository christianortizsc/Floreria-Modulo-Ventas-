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
    public partial class frmEditarCliente : Form
    {
        List<Cliente> clientesEditados;
        public frmEditarCliente()
        {
            InitializeComponent();
            clientesEditados = new List<Cliente>();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conexion = BDComun.obtenerConexion())
                {
                    string querytext = "select * from cliente where (nombre_cliente LIKE @NameSearch);";
                    SqlCommand query = new SqlCommand(querytext, conexion);
                    query.Parameters.Add(new SqlParameter("NameSearch", "%" + this.txt_NombreCliente.Text + "%"));

                    SqlDataAdapter adapter = new SqlDataAdapter(query);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    this.grid_Clientes.DataSource = dt;
                    //hacer que no se pueda editar el campo de id
                    this.grid_Clientes.Columns["id_cliente"].ReadOnly = true;
                    conexion.Close();
                    adapter.Dispose();
                }
                clientesEditados.Clear();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.grid_Clientes.SelectedRows.Count == 0) throw new Exception("No se ha seleccionado a un cliente.");
                //confirmación
                var confirmacion = MessageBox.Show("¿De verdad desea eliminar este cliente?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                if (confirmacion == DialogResult.No) return;
                using (SqlConnection conexion = BDComun.obtenerConexion())
                {//eliminar el cliente elegido
                    string querytext = "delete from cliente where id_cliente = " + this.grid_Clientes.CurrentRow.Cells["id_cliente"].Value.ToString();
                    SqlCommand query = new SqlCommand(querytext, conexion);
                    query.ExecuteNonQuery();
                    conexion.Close();
                    MessageBox.Show("Cliente eliminado.");
                    btn_Buscar_Click(this, e);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void grid_Clientes_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {//registrar los registros que se han cambiado en un arreglo
            clientesEditados.Add(new Cliente(Convert.ToInt32(this.grid_Clientes.CurrentRow.Cells["id_cliente"].Value.ToString()), this.grid_Clientes.CurrentRow.Cells["nombre_cliente"].Value.ToString(), 0, this.grid_Clientes.CurrentRow.Cells["rfc"].Value.ToString(), this.grid_Clientes.CurrentRow.Cells["telefono_cliente"].Value.ToString(), this.grid_Clientes.CurrentRow.Cells["direccion_cliente"].Value.ToString()));
            for (int i = 0; i < clientesEditados.Count; i++)
            {
                Console.Write("id:" + clientesEditados[i].ID + ", ");
            }
            Console.WriteLine();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show("¿Esta seguro de que desea guardar los cambios?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (confirmacion == DialogResult.No) return;
            try
            {
                using (SqlConnection conexion = BDComun.obtenerConexion())
                {
                    string querytext;
                    for (int i = 0; i < clientesEditados.Count; i++)
                    {
                        querytext = "update cliente set nombre_cliente = @Name, direccion_cliente = @Address, rfc = @RFC, telefono_cliente = @Phone where id_cliente = " + clientesEditados[i].ID + ";";
                        SqlCommand query = new SqlCommand(querytext, conexion);
                        //consulta parametrizada
                        query.Parameters.Add(new SqlParameter("Name", clientesEditados[i].Nombre));
                        query.Parameters.Add(new SqlParameter("Address", clientesEditados[i].Direccion));
                        query.Parameters.Add(new SqlParameter("RFC", clientesEditados[i].RFC));
                        query.Parameters.Add(new SqlParameter("Phone", clientesEditados[i].Telefono));
                        //Console.WriteLine(querytext);
                        query.ExecuteNonQuery();
                        query.Dispose();
                    }
                    conexion.Close();
                    MessageBox.Show("Registros actualizados.");
                    btn_Buscar_Click(this, e);
                }
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
