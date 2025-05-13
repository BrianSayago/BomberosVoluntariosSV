using CapaNegocio;
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
    public partial class FormTareas : Form
    {
        Imprimir negocio = new Imprimir();
        public FormTareas()
        {
            InitializeComponent();
        }

        private void bttnImprimir_Click(object sender, EventArgs e)
        {
            negocio.ExportaPDF(dtgTareas, "Planilla_Tareas");
        }

    }
}
