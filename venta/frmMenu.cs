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
        frmEvento eventoForm;
        frmRegistrarCliente clienteForm;
        frmEditarCliente editarForm;

        public frmMenu()
        {
            InitializeComponent();
            ventaForm = null;
            eventoForm = null;
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

        private void realizarEventoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (eventoForm == null)
            {
                eventoForm = new frmEvento();
                eventoForm.Show();
            }
            else
            {
                eventoForm.Dispose();
                eventoForm = null;
                eventoForm = new frmEvento();
                eventoForm.Show();
            }
        }

        private void editarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (editarForm == null)
            {
                editarForm = new frmEditarCliente();
                editarForm.ShowDialog(this);
            }
            else
            {
                editarForm.Dispose();
                editarForm = null;
                editarForm = new frmEditarCliente();
                editarForm.ShowDialog(this);
            }
        }

        private void registrarClienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (clienteForm == null)
            {
                clienteForm = new frmRegistrarCliente();
                clienteForm.ShowDialog(this);
            }
            else
            {
                clienteForm.Dispose();
                clienteForm = null;
                clienteForm = new frmRegistrarCliente();
                clienteForm.ShowDialog(this);
            }
        }
    }
}
