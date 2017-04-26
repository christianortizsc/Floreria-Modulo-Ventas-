using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace venta
{
    public partial class Cliente : Persona
    {
        public double Credito;

        public Cliente()
        {
            this.ID = -1;
            this.Credito = 0;
        }

        public Cliente(int ID, string Nombre, int Credito, string RFC, string Telefono, string Direccion)
        {
            this.ID = ID;
            this.Nombre = Nombre;
            this.RFC = RFC;
            this.Credito = Credito;
            this.Telefono = Telefono;
            this.Direccion = Direccion;
        }

        public override void Alta()
        {
            try
            {
                using(SqlConnection Conn = BDComun.obtenerConexion())
                {
                    this.checkIfRegistered(Conn);
                    string querytext = "INSERT INTO CLIENTE(nombre_cliente, direccion_cliente, rfc, telefono_cliente) VALUES ('{0}', '{1}', '{2}', '{3}');";
                    SqlCommand query = new SqlCommand(string.Format(querytext, this.Nombre, this.Direccion, this.RFC, this.Telefono));
                    query.Connection = Conn;
                    query.ExecuteNonQuery();
                    Conn.Close();
                }
                
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public override void Baja()
        {

        }

        public override void Cambio()
        {

        }

        private void checkIfRegistered(SqlConnection conn)
        {
            string querytext = "SELECT COUNT(*) AS 'Clientes' FROM CLIENTE WHERE RFC = '" + this.RFC+"';";
            SqlCommand query = new SqlCommand(querytext);
            query.Connection = conn;
            var dataset = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query);
            adapter.Fill(dataset);
            string result = dataset.Tables[0].Rows[0]["Clientes"].ToString();
            if(Convert.ToInt32(result) != 0)
            {
                throw new Exception("El cliente ya esta registrado en la base de datos.");
            }
        }
    }
}
