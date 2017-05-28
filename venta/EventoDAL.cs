using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace venta
{
    class EventoDAL
    {
        private static string[] info;

        public static int AgregarEvento(Evento evento, int id_venta)
        {
            int idEvento=0;
            info = new string[6];
            info[0] = evento.Id_cliente.ToString();
            info[1] = evento.fechaEvento;
            info[2] = evento.id_local.ToString();
            info[3] = evento.Observaciones;
            info[4] = evento.id_empleado.ToString();
            info[5] = id_venta.ToString();
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand queryEvento = new SqlCommand(string.Format(
"Insert into evento (id_cliente, fecha_evento, id_local, observaciones_evento, id_venta) output inserted.id_evento values ('{0}', '{1}', '{2}', '{3}', '{5}')",info), Conn);
                
                var dr = queryEvento.ExecuteReader();
                while (dr.Read())
                {
                    idEvento = dr.GetInt32(0);
                }
            }
            return idEvento;
        }

        public static int ActualizaVenta(int idEvento, int id_venta)
        {
            int ret = 0;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                //actualizar la venta con el id_evento generado a ver si works
                SqlCommand queryUpdateVenta = new SqlCommand(string.Format("UPDATE venta set id_evento='{0}' where id_venta='{1}'", idEvento, id_venta), Conn);
                ret = queryUpdateVenta.ExecuteNonQuery();//yes it worked
            }
            return ret;
        }

        public static int AgregarVenta(Evento venta)
        {
            DateTime now = DateTime.Now;
            int idVenta = 0;
            info = new string[9];

            info[0] = now.ToString();               //fecha_venta
            info[1] = venta.Observaciones;          //observaciones
            info[2] = venta.PrecioTotal.ToString(); //precio_total
            info[3] = "1";                          //crédito
            info[4] = "0";                          //factura
            info[5] = null;                         //tipo_venta
            info[6] = null;                         //tipo_arreglo
            info[7] = venta.Id_cliente.ToString();  //id_cliente
            info[8] = null;                         //venta.id_empleado.ToString();//id_empleado


            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format(
"Insert into venta (fecha_venta, observaciones, precio_total, credito, factura, tipo_venta, tipo_arreglo, id_cliente) output inserted.id_venta values ('{0}', '{1}', '{2}', '{3}','{4}', '{5}', '{6}', '{7}')", info), Conn);

                var dr = Comando.ExecuteReader();
                while (dr.Read())
                {
                    idVenta = dr.GetInt32(0);//regresa la columna 1, en este caso, el id_venta
                }
            }
            return idVenta;
        }

        public static void AgregaDetalleVenta(string[] items, int id_venta)
        {
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand query = new SqlCommand(string.Format("Insert into detalle_venta values ('{0}', '{1}', '{2}', '{3}', '{4}')", items), Conn);
                query.ExecuteNonQuery();
            }
        }
    }
}
