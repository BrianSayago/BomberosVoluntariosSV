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
    public partial class FormReuniones : Form
    {
        public FormReuniones()
        {
            InitializeComponent();
        }

        private void picBoxInfor_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Al clickear doble se eliminara el bombero.", sender as Control, new Point(0, 20), 5000);
        }

        private void listBoxBomb_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBoxBomb.Items.Remove(listBoxBomb.SelectedItem);
        }
    }
}
