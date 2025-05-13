using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using CapaDiseño;
using CapaNegocio;
using CapaDatos;



namespace BSV
{
    public partial class Inicio : Form
    {
        Diseño diseño = new Diseño();
        Login login;
        FormIngre_Salida formIngre_Salida;
        FormUrgencias formUg;
        FormTareasI formTareas;
        public Inicio()
        {
            InitializeComponent();
            //Estas lineas eliminan un poco los parpados del formulario o controles de la interfaz
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            this.DoubleBuffered = true;
            //diseño
            diseño.FormInicioDiseño(this, panelInicio, PanelBarraTitulo, MenuVertical,tmrFechaHora, login);
        }
       

        //eventos
        private void bttnTareaaI_Click(object sender, EventArgs e)
        {
             if (formTareas == null || formTareas.IsDisposed) 
                {
                   formTareas = new FormTareasI();
                    formTareas.Show(); 
                }
                else
                { formTareas.BringToFront(); } //trae al frente 
        }
        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            if (login == null || login.IsDisposed || !login.Visible) //si el login no esta abierto
            {
                if (Login.formAdmin== null || Login.formAdmin.IsDisposed) //ademas si el form de administracion no esta abierto
                {
                   login = new Login();
                   login.Show(); //muestro el login
                }
                else//sie el login esta cerrado pero Administracion abierto
                { Login.formAdmin.BringToFront(); } //trae al frente administracion
            }
            else //si el login esta abierto
            { login.BringToFront(); } //lo traigo al frente
        }
        private void btnIngreso_Click(object sender, EventArgs e)
        {
            
            AbrirIngresoSalida("Ingreso CONFIRMADO", "¿Seguro que desea ingresar?", false); // esEgreso = false

        }

        private void btnEgreso_Click(object sender, EventArgs e)
        {
            Conectar.CodigoIngreso(txtLegajos.Text);
            AbrirIngresoSalida("Registrar Egreso", "¿Seguro que desea egresar?", true); // esEgreso = true
        }     
        private void iconcerrar_Click(object sender, EventArgs e)
        {
            if (Login.formAdmin == null || Login.formAdmin.IsDisposed || !Login.formAdmin.Visible) //si el login no esta abierto
            { Application.Exit(); }
            else //si el login esta abierto
            {
                Login.formAdmin.BringToFront();//lo traigo al frente
                MessageBox.Show("Cierre secion antes de cerrar el programa.");
            }
        }
        private void bttn_Urgencias_Click(object sender, EventArgs e)
        {
            if (formUg == null || formUg.IsDisposed) { formUg = new FormUrgencias(); formUg.Show(); }
            else { formUg.BringToFront(); }
        }        

   

      //funciones
        private void AbrirIngresoSalida(string textoLabel1="", string textoLabel2="", bool esEgreso = false)//-----cambio de texto
        {
            string idBomberoTexto = txtLegajos.Text;

            if (!int.TryParse(idBomberoTexto, out int idBombero))
            {
                MessageBox.Show("Por favor, ingrese un código de bombero válido.");
                return;
            }

            BomberoService bomberoService = new BomberoService();
            Persona bombero = bomberoService.ObtenerBomberoPorId(idBombero);

           

            if (bombero == null) // Si no se encuentra el bombero
            {
                MessageBox.Show("Bombero no encontrado. Verifique el ID e intente de nuevo.");
                return; // Si no existe, termina el método aquí.
            }

            // 2. Si el bombero existe, procede con la lógica de abrir el formulario.
            if (login != null && !login.IsDisposed && login.Visible)
            {
                return; // No abrir Form de IngresoSalida si Login está abierto
            }
            else
            {
                if (formIngre_Salida != null && !formIngre_Salida.IsDisposed && formIngre_Salida.Visible)
                {
                    formIngre_Salida.BringToFront();
                    return; // No abrir IngresoSalida si ya está abierto
                }
                else if (formIngre_Salida == null || formIngre_Salida.IsDisposed || !formIngre_Salida.Visible)
                {
                    // Crear una nueva instancia del formulario y pasarle los parámetros.
                    formIngre_Salida = new FormIngre_Salida();
                    formIngre_Salida.TextolblTitulo = textoLabel1; // Establece el texto para label1
                    formIngre_Salida.TextolblSeguro = textoLabel2; // Establece el texto para label2
                    formIngre_Salida.SetNombreYApellido(bombero.Nombre, bombero.Apellido, bombero.IdBombero);
                    formIngre_Salida.EsEgreso = esEgreso; // Indica si es un egreso
                    formIngre_Salida.Show(); // Abre el formulario
                    formIngre_Salida.FormClosed += (s, args) => formIngre_Salida = null; // Restablece la referencia al cerrar
                }
            }
            // Si IngresoSalida ya está abierto, no se hace nada
        }
     //función de arrastrar el formulario.
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void PanelBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
