using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace venta
{
    public partial class frmMenu : Form
    {
        Form1 ventaForm;
        public frmMenu()
        {
            InitializeComponent();
            ventaForm = null;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ventaForm == null)
            {
                ventaForm = new Form1();
                ventaForm.ShowDialog(this);
            }
            else
            {
                ventaForm.Dispose();
                ventaForm = null;
                ventaForm = new Form1();
                ventaForm.ShowDialog(this);
            }
        }
    }
}
