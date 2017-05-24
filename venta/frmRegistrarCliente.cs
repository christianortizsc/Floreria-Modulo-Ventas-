using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace venta
{
    public partial class frmRegistrarCliente : Form
    {
        TextBox[] boxes;
        public frmRegistrarCliente()
        {
            InitializeComponent();
            makeTextBoxList(3);
        }

        private void RegistrarCliente(object sender, EventArgs e)
        {
            Cliente c = new Cliente();
            if(checkBlanks(this.boxes) == 0)
            {
                try
                {
                    //validaciones
                    c.Nombre = txt_NombreCliente.Text;
                    if(c.Nombre.Any(char.IsDigit)) throw new Exception("El nombre ingresado no es válido.");
                    c.RFC = txt_RFC.Text.ToUpper();
                    if (c.RFC.Length < 12 && c.RFC.Length > 13) throw new Exception("El RFC ingresado no es válido.");
                    c.Telefono = txt_Telefono.Text;
                    if(c.Telefono.Length != 14) throw new Exception("El número telefónico ingresado no es válido.");
                    c.Direccion = txt_Direccion.Text;

                    c.Alta();

                    clearTextBoxes(this.boxes);
                }
                catch(Exception err)
                {
                    MessageBox.Show("Ha ocurrido un error:\n" + err.Message);
                }
            }
            else
            {
                MessageBox.Show("Hay campos sin llenar.");
            }
        }

        private void makeTextBoxList(int amount)
        {
            boxes = new TextBox[amount];
            boxes[0] = this.txt_NombreCliente;
            boxes[1] = this.txt_RFC;
            boxes[2] = this.txt_Direccion;
        }

        private void clearTextBoxes(TextBox[] txtArray)
        {
            for(int i = 0; i < txtArray.Length; i++)
            {
                txtArray[i].Text = "";
            }
            this.txt_Telefono.Text = "";
        }

        private int checkBlanks(TextBox[] txtArray)
        {
            string str;
            for(int i = 0; i < txtArray.Length; i++)
            {
                str = txtArray[i].Text;
                str.Trim();
                if (str == "") return 1;
            }
            if (this.txt_Telefono.Text.Trim() == "") return 1; 
            return 0;
        }
    }
}
