using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BSV
{
    public partial class FormEditaPersonal : Form
    {
        public FormEditaPersonal()
        {
            InitializeComponent();
        }

        private void chBoxCuenta_CheckedChanged(object sender, EventArgs e)
        {
            if (chBoxCuenta.Checked) { label5.Visible = true; txtContraseña.Visible = true; }   
            else { label5.Visible = false; txtContraseña.Visible = false; }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                bttnActivaEmpleado.Enabled = true;
                bttnInactivaEmpleado.Enabled = false;
            }
            else
            {
                bttnActivaEmpleado.Enabled = false;
                bttnInactivaEmpleado.Enabled = true;
            }
        }
    }
}
