using System.Windows.Forms;
using CapaDiseño;

namespace BSV
{
    public partial class FormABM : Form
    {
        Diseño diseño= new Diseño();
        public FormABM()
        {
            InitializeComponent();
            diseño.formAMB(panelBarra, this);
        }

        private void bttnAreas_Click(object sender, System.EventArgs e)
        {
            AbrirFormHijo(new FormEditaArea());
        }

        private void bttnPersonal_Click(object sender, System.EventArgs e)
        {
             AbrirFormHijo(new FormEditaPersonal());
        }
        //Funcion Abre form Hijo ------------------------------------------------------------------
        private void AbrirFormHijo(object formHijo)
        {
            if (this.panelEditar.Controls.Count > 0)
                this.panelEditar.Controls.RemoveAt(0);
            Form Formhijo = formHijo as Form;
            Formhijo.TopLevel = false;
            Formhijo.Dock = DockStyle.Fill;
            Formhijo.FormBorderStyle = FormBorderStyle.None;
            this.panelEditar.Controls.Add(Formhijo);
            this.panelEditar.Tag = Formhijo;
            Formhijo.Show();
        }



        //-----------------------------------------------------------------------------------------
    }
}
