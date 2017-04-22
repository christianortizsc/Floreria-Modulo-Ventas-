using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace venta
{
    class DetalleVenta
    {
        public Int32 Cantidad { get; set; }
        public String Nombre { get; set; }
        public Int32 IdVenta { get; set; }
        public Int32 IdProducto { get; set; }
        public String PrecioTotal { get; set; }
        public DetalleVenta() { }


    }
}
