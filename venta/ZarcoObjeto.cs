using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace venta
{
    public abstract class ZarcoObjeto
    {
        public int ID;

        public abstract void Alta();

        public abstract void Baja();

        public abstract void Cambio();
    }
}
