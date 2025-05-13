using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseño;

namespace BSV
{
    public partial class FormAdmin : Form
    {
        Diseño diseño= new Diseño ();
        public FormAdmin()
        {
            InitializeComponent();
            diseño.formAdmin(panel_Barra_Vertical, this, tmContraerMenu, tmExpandirMenu, panel_Min_Cerrar, panelC);
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_Min_Cerrar_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void bttn_Reuniones_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormReuniones());
        }

        private void bttn_AsistenciaAreas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormAsistArea());
        }

        private void btnAsistInstitu_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormAsistInstitu());
        }

        private void bntTareas_Click(object sender, EventArgs e)
        {
            AbrirFormHijo( new FormTareas ());
        }

        private void bttn_ABM_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormABM());
        }
        private void bttnIngEgr_Click(object sender, EventArgs e)
        {
            AbrirFormHijo(new FormIngrEgr());
        }
        private void bttnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Funcion Abre form Hijo ------------------------------------------------------------------
        private void AbrirFormHijo(object formHijo)
        {
            if (this.panelC.Controls.Count > 0)
                this.panelC.Controls.RemoveAt(0);
            Form Formhijo = formHijo as Form;
            Formhijo.TopLevel = false;
            Formhijo.Dock = DockStyle.Fill;
            Formhijo.FormBorderStyle = FormBorderStyle.None;
            this.panelC.Controls.Add(Formhijo);
            this.panelC.Tag = Formhijo;
            Formhijo.Show();
        }

        private void pbLogoPag_Click(object sender, EventArgs e)
        {

        }


        //-----------------------------------------------------------------------------------------


    }
}
