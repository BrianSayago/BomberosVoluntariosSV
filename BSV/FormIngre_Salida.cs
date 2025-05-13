using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaDatos;

namespace BSV
{
    public partial class FormIngre_Salida : Form
    {
        public bool EsEgreso { get; set; } // Indica si estamos en modo Egreso o Ingreso

        public FormIngre_Salida()
        {
            InitializeComponent();
        }


        public void SetNombreYApellido(string nombre, string apellido, int idBombero)
        {
            txtNyA.Text = $"{nombre} {apellido}"; // Establece el texto del TextBox
            lbl_idbombero.Text = idBombero.ToString();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void FormIngre_Salida_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        public string TextolblTitulo
        {
            get { return lblTitulo.Text; }
            set { lblTitulo.Text = value ?? string.Empty; }
        }
        public string TextolblSeguro
        {
            get { return lblSeguro.Text; }
            set { lblSeguro.Text = value ?? string.Empty; }
        }
        public string TextoNombreApellido
        {
            get { return txtNyA.Text; }
            set { txtNyA.Text = value ?? string.Empty; }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            // Verificamos si es un Egreso o un Ingreso
            if (EsEgreso)
            {
                RegistrarEgreso();
            }
            else
            {
                RegistrarIngreso();
            }
        }

        private void RegistrarIngreso()
        {
            ConexionDB db = new ConexionDB();
            string idbombero = lbl_idbombero.Text;
            int id_bombero = Convert.ToInt32(idbombero);
            int id_fecha = 0;
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToString("HH:mm:ssss");

            id_fecha = db.ObtenerIdFecha(fecha);
            if (id_fecha == 0)
            {
                id_fecha = db.InsertarFecha(fecha);
            }
            db.InsertarIngresoBomberoPorId(id_bombero, id_fecha, hora);
            this.Close();
        }

        private void RegistrarEgreso()
        {
            string idbombero = lbl_idbombero.Text;
            ConexionDB db = new ConexionDB();
            int id_bombero = Convert.ToInt32(idbombero);
            bool egresoExitoso = db.RegistrarEgreso(id_bombero);

            if (egresoExitoso)
            {
                MessageBox.Show("Egreso registrado correctamente.");
            }
            else
            {
                MessageBox.Show("Ocurrió un error al registrar el egreso.");
            }
            this.Close();
        }
        private void btnSI_Click(object sender, EventArgs e)
        {
            
            
        }

        private void btnNO_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
