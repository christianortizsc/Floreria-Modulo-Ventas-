using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace venta
{
    public partial class frmLugaresEvento : Form
    {
        public frmLugaresEvento()
        {
            InitializeComponent();
        }

        private void frmLugaresEvento_Load(object sender, EventArgs e)
        {

        }

        private void btn_Registrar_Click(object sender, EventArgs e)
        {
            string nombre = txt_NombreLocal.Text;
            string direccion = txt_DireccionLocal.Text;
            string query = string.Format("insert into local (direccion_local,nombre_local) values('{0}','{1}')",direccion,nombre);
            SqlCommand com = new SqlCommand(query,BDComun.obtenerConexion());

            if (nombre!="" && direccion!="")
            {
                if (com.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Registro agregado con éxito", "Aviso");
                    txt_DireccionLocal.Clear();
                    txt_NombreLocal.Clear();
                }
            }
            else
            {
                MessageBox.Show("Verifique el nombre y/o la dirección del local");
            }
        }
    }
}
