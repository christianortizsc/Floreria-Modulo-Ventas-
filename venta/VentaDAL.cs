using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace venta
{
    public class VentaDAL
    {

        public static int Agregar(Venta pVenta)
        {
            int retorno = 0;
            DateTime now = DateTime.Now;
            using (SqlConnection Conn = BDComun.obtenerConexion())
            {
                SqlCommand Comando = new SqlCommand(string.Format("Insert into venta (nombre_envio, hora_envio, direccion_envio, fecha_venta, credito, factura, precio_total, observaciones) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}', '{7}')",
                    pVenta.NombreEnvio, pVenta.HoraEnvio, pVenta.DireccionEnvio, now, pVenta.Credito, pVenta.Factura, pVenta.PrecioTotal, pVenta.Observaciones), Conn);

                retorno = Comando.ExecuteNonQuery();
            }
            return retorno;
        }



        //public static List<Venta> BuscarAlumnos(String pNombre, String pApellido)
        //{
        //    List<Venta> Lista = new List<Venta>();
        //    using (SqlConnection conexion = BDComun.obtenerConexion())
        //    {
        //        SqlCommand comando = new SqlCommand(string.Format(
        //           "Select Id, Nombre, Apellido, Direccion, Fecha_nacimiento from Alumnos where Nombre='{0}' and Apellido='{1}' ", pNombre, pApellido), conexion);
        //         /*   "Select Id, Nombre, Apellido, Direccion, Fecha_nacimiento from Alumnos where Nombre like '%{0}%' and Apellido like '%{1}%' ", pNombre, pApellido), conexion);*/

        //        SqlDataReader reader = comando.ExecuteReader();

        //        while (reader.Read())
        //        {
        //            Alumno pAlumno = new Alumno();
        //            pAlumno.Id = reader.GetInt64(0);
        //            pAlumno.Nombre = reader.GetString(1);
        //            pAlumno.Apellido = reader.GetString(2);
        //            pAlumno.Direccion = reader.GetString(3);
        //            pAlumno.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));

        //            Lista.Add(pAlumno);
        //        } 
        //        conexion.Close();
        //        return Lista;
        //    }



        //        }

        //public static Alumno obtenerAlumno(Int64 pId)
        //{
        //    List<Alumno> Lista = new List<Alumno>();
        //    using (SqlConnection conexion = BDComun.obtenerConexion())
        //    {
        //        Alumno pAlumno = new Alumno();
        //        SqlCommand comando = new SqlCommand(string.Format(
        //            "Select Id, Nombre, Apellido, Direccion, Fecha_nacimiento from Alumnos where Id={0}", pId), conexion);

        //        SqlDataReader reader = comando.ExecuteReader();

        //        while (reader.Read())
        //        {

        //            pAlumno.Id = reader.GetInt64(0);
        //            pAlumno.Nombre = reader.GetString(1);
        //            pAlumno.Apellido = reader.GetString(2);
        //            pAlumno.Direccion = reader.GetString(3);
        //            pAlumno.Fecha_Nac = Convert.ToString(reader.GetDateTime(4));


        //        }
        //        conexion.Close();
        //        return pAlumno;
        //    }



        //}

        //public static int Modificar(Alumno pAlumno)
        //{
        //    int retorno = 0;
        //    using (SqlConnection conexion = BDComun.obtenerConexion())
        //    {
        //        SqlCommand comando = new SqlCommand(string.Format("Update Alumnos set Nombre='{0}', Apellido='{1}', Direccion='{2}', Fecha_nacimiento='{3}' where Id={4}",
        //            pAlumno.Nombre, pAlumno.Apellido, pAlumno.Direccion, pAlumno.Fecha_Nac, pAlumno.Id), conexion);

        //        retorno = comando.ExecuteNonQuery();
        //        conexion.Close();

        //    }
        //    return retorno;
        //}

        public static int Eliminar(Int64 pId)
        {
            int retorno;
            using (SqlConnection conexion = BDComun.obtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("Delete from Alumnos where Id={0}", pId), conexion);
                retorno = comando.ExecuteNonQuery();
                conexion.Close();

            }
            return retorno;
        }

    }
}
