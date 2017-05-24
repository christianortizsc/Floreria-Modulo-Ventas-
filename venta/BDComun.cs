using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace venta
{
    public class BDComun
    {
        public static SqlConnection obtenerConexion()
        {
            //SqlConnection Conn = new SqlConnection("Data source=CHRISTIANSPC; Initial Catalog=Escuela; User ID=sa; Password=hola");
            //SqlConnection Conn = new SqlConnection("Server = BURRITO\\SQLEXPRESS; Initial Catalog=floreria; Integrated Security = True; ");
            //SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=floreria;Integrated Security=SSPI;");
            SqlConnection Conn = new SqlConnection("Data Source=ZARCOSERVER\\SQLSERVER;Initial Catalog=floreria;User ID=sa; Password=sasa");

            Conn.Open();
            return Conn;
        }
    }
}
