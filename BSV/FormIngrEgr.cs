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
    public partial class FormIngrEgr : Form
    {
        public FormIngrEgr()
        {
            InitializeComponent();
        }

        private void picBoxInfor_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Al clickear se modificara solo la hora de salida.", sender as Control, new Point(0, 20), 5000);
        }
    }
}
