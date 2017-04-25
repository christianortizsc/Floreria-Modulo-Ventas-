using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace venta
{
   public class Venta

    {
       public Int32 Id { get; set; }
       public String NombreEnvio {get; set;}
       public String HoraEnvio { get; set; }
       public String DireccionEnvio { get; set; }
       public String FechaVenta { get; set; }
       public String Observaciones { get; set; }
       public Int32 Credito { get; set; }
       public Int32 Factura { get; set; }
       public String PrecioTotal { get; set; }
       public Int32 Id_cliente { get; set; }


        public Venta() { }

       //public Venta(Int64 pId, String pNombreEnvio, String pHoraEnvio, String pFecha_Nac)
       //{
       //    this.Id = pId;
       //    this.NombreEnvio = pNombreEnvio;
       //    this.HoraEnvio = pHoraEnvio;
       //    this.Fecha_Nac = pFecha_Nac;
       //}
    }
}
