﻿using System;
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
            SqlConnection Conn = new SqlConnection("Data Source=localhost\\SQLEXPRESS;Initial Catalog=floreria;Integrated Security=SSPI;");
            Conn.Open();
            return Conn;
        }
    }
}
