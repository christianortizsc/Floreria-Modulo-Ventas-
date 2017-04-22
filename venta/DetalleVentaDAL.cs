using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace venta
{
    class DetalleVentaDAL
    {
        public static int Agregar(DetalleVenta pDetVenta)
        {
            int retorno = 0;
            DateTime now = DateTime.Now;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert into detalle_venta (cantidad, nombre, precio_total, id_producto, id_venta) values ('{0}', '{1}', '{2}', '{3}', '{4}')",
                    pDetVenta.Cantidad, pDetVenta.Nombre, pDetVenta.PrecioTotal, pDetVenta.IdProducto, pDetVenta.IdVenta), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }
    }
}
