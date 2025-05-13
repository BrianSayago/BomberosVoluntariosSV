using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaDiseño;


namespace BSV
{
    public partial class Login : Form
    {
        public static FormAdmin formAdmin { get; set; }
        Diseño diseño = new Diseño();
        public Login()
        { 
            InitializeComponent();
            diseño.fromLoginDiseño(this);   
           
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            // Obtener los valores de los TextBox
            string usuario = txtUsuario.Text;
            string contrasena = txtContraseña.Text;

            // Verificar las credenciales
            if (usuario == "123" && contrasena == "123") // Cambia "admin" por la contraseña que desees
            {
                // Cerrar el formulario si las credenciales son correctas
                this.DialogResult = DialogResult.OK; // Opcional: establece un resultado para el formulario
                //mostrar administarcion.Show
                this.Close(); // Cierra el formulario
                formAdmin = new FormAdmin();
                formAdmin.Show();
            }
            else
            {
                // Mostrar mensaje de error si las credenciales son incorrectas
                lblError.Text = "Usuario o contraseña incorrectos.";
                lblError.ForeColor = Color.Red; // Cambia el color del texto a rojo
            }
        }

    }
}
