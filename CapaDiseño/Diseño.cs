using System;
using System.Drawing;
using System.Windows.Forms;

namespace CapaDiseño
{
    public class Diseño
    {
        public void formR (Form formulario)
        {

        }
        //diseño de fomulario de tareas del inicio--------------------------------------------------------------------------------
        public void formT (Form formulario)
        {
            TextBox txtLegajos = formulario.Controls["txtLegajos"] as TextBox;
            TextBox txtTarea = formulario.Controls["txtTarea"] as TextBox;
            ComboBox cmbAreas = formulario.Controls["cmbAreas"] as ComboBox;
            txtLegajos.Leave += txtLegajos_Leave;
            txtLegajos.Enter += txtLegajos_Enter;
            txtTarea.Leave += txtTarea_Leave;
            txtTarea.Enter += txtTarea_Enter;
            cmbAreas.Leave += cmbTareas_Leave;
            cmbAreas.Enter += cmbTareas_Enter;

        }      //TEXTBOX y COMBOBOX
        private void cmbTareas_Leave(object sender, EventArgs e)
        {
            ComboBox cmbTareas = (ComboBox)sender;
            if (cmbTareas.Text == "") { cmbTareas.Text = "LISTA DE AREAS"; }
        }
        private void cmbTareas_Enter(object sender, EventArgs e)
        {
            ComboBox cmbTareas = (ComboBox)sender;
            if (cmbTareas.Text == "LISTA DE AREAS") { cmbTareas.Text = ""; }
        }

        private void txtTarea_Leave(object sender, EventArgs e)
        {
            TextBox txtTarea = (TextBox)sender;
            if (txtTarea.Text == "") { txtTarea.Text = "TAREAS"; }
        }
        private void txtTarea_Enter(object sender, EventArgs e)
        {
            TextBox txtTarea = (TextBox)sender;
            if (txtTarea.Text == "TAREAS") { txtTarea.Text = ""; }
        }
        //diseño de fomulario de inciio--------------------------------------------------------------------------------
        private Form _formInicio;
        private Panel _MenuVertical;
        private Label _lblFecha;
        private Label _lblHora;
        private Timer _tmrFechaHora;
        private Panel _panelInicio;
        public void FormInicioDiseño (Form formulario, Panel PanelInicio, Panel PanelBarraTitulo, Panel MenuVertical,  Timer tmrFechaHora,Form login )
        {
            _formInicio = formulario;
            _MenuVertical = MenuVertical;
            _tmrFechaHora = tmrFechaHora;
            _panelInicio = PanelInicio;
            TextBox txtLegajos = PanelInicio.Controls["txtLegajos"] as TextBox;
            Button bttn_Urgencias = MenuVertical.Controls["bttn_Urgencias"] as Button;
            Button btnAdministracion = MenuVertical.Controls["btnAdministracion"] as Button;
            Button bttn_TareasVer = MenuVertical.Controls["bttnTareaaI"] as Button;
            PictureBox iconminimizar = PanelBarraTitulo.Controls["iconminimizar"] as PictureBox;
            Label lblFecha = PanelInicio.Controls["lblFecha"] as Label;
            _lblFecha = lblFecha;
            Label lblHora = PanelInicio.Controls["lblHora"] as Label;
            _lblHora = lblHora;
            PanelInicio.Paint += panelInicio_Paint;

            txtLegajos.Leave += txtLegajos_Leave;
            txtLegajos.Enter += txtLegajos_Enter;
            
            if (iconminimizar!=null)  iconminimizar.Click += iconminimizar_Click; 

            if (bttn_Urgencias != null)
            {
                bttn_Urgencias.MouseEnter += btn_MouseEnter;
                bttn_Urgencias.MouseLeave += bttn_MouseLeave;
                bttn_Urgencias.MouseDown += bttn_MouseDown;
            }

            if (btnAdministracion != null)
            {
                btnAdministracion.MouseEnter += btn_MouseEnter;
                btnAdministracion.MouseLeave += bttn_MouseLeave;
                btnAdministracion.MouseDown += bttn_MouseDown;
            }

            if (bttn_TareasVer != null)
            {
                bttn_TareasVer.MouseEnter += btn_MouseEnter;
                bttn_TareasVer.MouseLeave += bttn_MouseLeave;
                bttn_TareasVer.MouseDown += bttn_MouseDown;
            }            
           
            _tmrFechaHora.Tick += tmrFechaHora_Tick;

        }
        private void txtLegajos_Leave(object sender, EventArgs e)
        {
            TextBox txtLegajos =(TextBox)sender;
            if (txtLegajos.Text == "") { txtLegajos.Text = "CÓDIGO"; }
        }
        private void txtLegajos_Enter(object sender, EventArgs e)
        {
            TextBox txtLegajos = (TextBox)sender;
            if (txtLegajos.Text == "CÓDIGO") { txtLegajos.Text = ""; }
        }
        //METODO PARA DIVIDIR DE COLOR EL PANEL INICIAL
        private void panelInicio_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Color colorSuperior = Color.Goldenrod;//FromArgb(64, 69, 76);
            Color colorInferior = Color.White;
            int altura = _panelInicio.Height;
            using (Brush brushSuperior = new SolidBrush(colorSuperior))
            {
                g.FillRectangle(brushSuperior, 0, 0, _panelInicio.Width, altura / 2);
            }
            using (Brush brushInferior = new SolidBrush(colorInferior))
            {
                g.FillRectangle(brushInferior, 0, altura / 2, _panelInicio.Width, altura / 2);
            }
            using (Pen penGold = new Pen(Color.Gold, 5)) // Color dorado y ancho de 5 píxeles
            {
                int y = altura / 2; // Posición Y donde se dibujará la línea
                g.DrawLine(penGold, 0, y, _panelInicio.Width, y); // Dibuja la línea horizontal
            }
        }
        //función de Cerrar y Minimizar el formulario.
        private void iconminimizar_Click(object sender, EventArgs e)
        {
            _formInicio.WindowState = FormWindowState.Minimized;
        }
    /*    int lx, ly; int sw, sh;
      private void iconmaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            iconrestaurar.Visible = true;
            iconmaximizar.Visible = false;
        }
        private void iconrestaurar_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            iconrestaurar.Visible = false;
            iconmaximizar.Visible = true;
        }*/
      //detalle de borde al boto administracion- 
        Panel P1 = new Panel();
        Panel P2 = new Panel();
        private void btn_MouseEnter(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            _MenuVertical.Controls.Add(P1);
            P1.BackColor = Color.FromArgb(255, 255, 255);
            P1.Size = new Size(5, bttn.Size.Height);
            P1.Location = new Point(bttn.Location.X - 5, bttn.Location.Y);
        }
        private void bttn_MouseLeave(object sender, EventArgs e)
        {
            _MenuVertical.Controls.Remove(P1);
        }
        private void bttn_MouseDown(object sender, MouseEventArgs e)
        {
            foreach (Control control in _MenuVertical.Controls)
            {
                if (control is Button)
                {
                    switch (control.Name)
                    {
                        case " bttn_Urgencias  ":
                            _MenuVertical.Controls.Remove(P2);
                            BtnClickeado(sender);
                            break;
                        case "btnAdministracion":
                            _MenuVertical.Controls.Remove(P2);
                            BtnClickeado(sender);
                            break;
                        case "bttn_TareasVer":
                            _MenuVertical.Controls.Remove(P2);
                            BtnClickeado(sender);
                            break;
                    }
                }
            }
        }
        private void BtnClickeado(object sender)
        {
            Button bttn = sender as Button;
            _MenuVertical.Controls.Add(P2);
            P2.BackColor = Color.FromArgb(255, 255, 255);
            P2.Size = new Size(5, bttn.Size.Height);
            P2.Location = new Point(bttn.Location.X -5, bttn.Location.Y);
        }
        //FECHA Y HORA
        private void tmrFechaHora_Tick(object sender, EventArgs e)
        {
           _lblFecha.Text = DateTime.Now.ToLongDateString();
           _lblHora.Text = DateTime.Now.ToString("HH:mm:ssss");
        }

        //diseño de fomulario de login--------------------------------------------------------------------------------
        public void fromLoginDiseño (Form formuario)
        {
            TextBox txtUsuario = formuario.Controls["txtUsuario"] as TextBox;
            TextBox txtContraseña = formuario.Controls["txtContraseña"] as TextBox;
            if (txtUsuario != null)
            {
                txtUsuario.Leave += txtUsuario_Leave;
                txtUsuario.Enter += txtUsuario_Enter;
            }
            if (txtContraseña != null)
            {
                txtContraseña.Leave += txtContraceña_Leave;
                txtContraseña.Enter += txtContraceña_Enter;
            }  
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            TextBox txtUsuario = (TextBox)sender;
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Silver;
            }
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            TextBox txtUsuario = (TextBox)sender;
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.Black;
            }
        }
        private void txtContraceña_Leave(object sender, EventArgs e)//-------
        {
            TextBox txtContraseña = (TextBox)sender;
            if (string.IsNullOrWhiteSpace(txtContraseña.Text))
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.ForeColor = Color.Silver;
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
        private void txtContraceña_Enter(object sender, EventArgs e)//-------
        {
            TextBox txtContraseña = (TextBox)sender;
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.ForeColor = Color.Black;
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        //diseño de fomulario de ingreso egreso--------------------------------------------------------------------------------  
        public void formInEgDieseño (Form formulario)
        {
            TextBox txtNyA = formulario.Controls["txtNyA "] as TextBox; 
            if (txtNyA != null)
            {
                txtNyA.Leave += txtNyA_Leave;
                txtNyA.Enter += txtNyA_Enter;
            }
        }
        private void txtNyA_Leave(object sender, EventArgs e)
        {
            TextBox txtNyA = (TextBox)sender;
            if (txtNyA.Text == "") { txtNyA.Text = "Nombre y Apellido"; }
        }
        private void txtNyA_Enter(object sender, EventArgs e)
        {
            TextBox txtNyA = (TextBox)sender;
            if (txtNyA.Text == "Nombre y Apellido") { txtNyA.Text = ""; }
        }

        //diseño de fomulario Administracion --------------------------------------------------------------------------------  
        private Panel _BarraVertical;
        private Timer _tmContraerMenu;
        private Timer _tmExpandirMenu;
        private  Form _formularioA;
        private Panel _panelC;
        public void formAdmin(Panel panel_Barra_Vertical, Form formulario,Timer tmContraerMenu, Timer tmExpandirMenu,Panel panel_Min_Cerrar, Panel panelC)
        {
            _formularioA = formulario;
            _BarraVertical= panel_Barra_Vertical;
            _tmContraerMenu = tmContraerMenu;
            _tmExpandirMenu = tmExpandirMenu;
            _panelC = panelC;
            Button bttn_AsistenciaAreas = panel_Barra_Vertical.Controls["bttn_AsistenciaAreas"] as Button;
            Button btnAsistInstitu = panel_Barra_Vertical.Controls["btnAsistInstitu"] as Button;
            Button bntTareas = panel_Barra_Vertical.Controls["bntTareas"] as Button;
            Button bttn_Reuniones = panel_Barra_Vertical.Controls["bttn_Reuniones"] as Button;
            Button bttn_ABM = panel_Barra_Vertical.Controls["bttn_ABM"] as Button;
            Button bttnIngEgr = panel_Barra_Vertical.Controls["bttnIngEgr"] as Button;
            PictureBox btnMenu = panel_Barra_Vertical.Controls["btnMenu"] as PictureBox;
            PictureBox iconminimizar = panel_Min_Cerrar.Controls["iconminimizar"] as PictureBox;

            if (bttn_AsistenciaAreas != null)
            {
                bttn_AsistenciaAreas.MouseEnter += btn_MouseEnter1;
                bttn_AsistenciaAreas.MouseLeave += bttn_MouseLeave1;
                bttn_AsistenciaAreas.MouseDown += bttn_MouseDown1;
            }
            if (btnAsistInstitu != null)
            {
                btnAsistInstitu.MouseEnter += btn_MouseEnter1;
                btnAsistInstitu.MouseLeave += bttn_MouseLeave1;
                btnAsistInstitu.MouseDown += bttn_MouseDown1;
            }
            if (bntTareas != null)
            {
                bntTareas.MouseEnter += btn_MouseEnter1;
                bntTareas.MouseLeave += bttn_MouseLeave1;
                bntTareas.MouseDown += bttn_MouseDown1;
            }
            if (bttn_Reuniones != null)
            {
                bttn_Reuniones.MouseEnter += btn_MouseEnter1;
                bttn_Reuniones.MouseLeave += bttn_MouseLeave1;
                bttn_Reuniones.MouseDown += bttn_MouseDown1;
            }
            if (bttn_ABM != null)
            {
                bttn_ABM.MouseEnter += btn_MouseEnter1;
                bttn_ABM.MouseLeave += bttn_MouseLeave1;
                bttn_ABM.MouseDown += bttn_MouseDown1;
            }
            if (bttnIngEgr != null)
            {
                bttnIngEgr.MouseEnter += btn_MouseEnter1;
                bttnIngEgr.MouseLeave += bttn_MouseLeave1;
                bttnIngEgr.MouseDown += bttn_MouseDown1;
            }
            btnMenu.Click += btnMenu_Click;
            _tmContraerMenu.Tick += tmContraerMenu_Tick;
            _tmExpandirMenu.Tick += tmExpandirMenu_Tick;
            iconminimizar.Click += iconminimizar1_Click;

        }

        private void iconminimizar1_Click(object sender, EventArgs e)
        {
            _formularioA.WindowState = FormWindowState.Minimized;
        }
        //mueve menu 
        private void btnMenu_Click(object sender, EventArgs e)
        {
            //-------CON EFECTO SLIDING
            if (_BarraVertical.Width == 260)
            {
                _tmContraerMenu.Start();
            }
            else if (_BarraVertical.Width == 50)
            {
                _tmExpandirMenu.Start(); 
            }
        }
        private void tmExpandirMenu_Tick(object sender, EventArgs e)
        {
            if (_BarraVertical.Width >= 260)
                _tmExpandirMenu.Stop();
            else
            {
                _BarraVertical.Width = _BarraVertical.Width + 5;
                _panelC.Location = new Point(_panelC.Location.X + 2, _panelC.Location.Y);
            }
        }
        private void tmContraerMenu_Tick(object sender, EventArgs e)
        {
            if (_BarraVertical.Width <= 50)
                _tmContraerMenu.Stop();
            else
            {
                _BarraVertical.Width = _BarraVertical.Width - 5;
                _panelC.Location = new Point(_panelC.Location.X - 2, _panelC.Location.Y);
            }
        }
        //detalle de borde al boto administracion- 
        Panel P1a = new Panel();
        Panel P2a = new Panel();
        private void btn_MouseEnter1(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            _BarraVertical.Controls.Add(P1a);
            P1a.BackColor = Color.FromArgb(255, 255, 255);
            P1a.Size = new Size(5, bttn.Size.Height);
            P1a.Location = new Point(bttn.Location.X - 5, bttn.Location.Y);
        }
        private void bttn_MouseLeave1(object sender, EventArgs e)
        {
            _BarraVertical.Controls.Remove(P1a);
        }
        private void bttn_MouseDown1(object sender, MouseEventArgs e)
        {
            foreach (Control control in _BarraVertical.Controls)
            {
                if (control is Button)
                {
                    switch (control.Name)
                    {
                    case "bttn_AsistenciaAreas":
                            _BarraVertical.Controls.Remove(P2);
                            BtnClickeado1(sender);
                            break;
                    case " btnAsistInstitu":
                            _BarraVertical.Controls.Remove(P2);
                            BtnClickeado1(sender);
                            break;
                    case "bntTareas":
                            _BarraVertical.Controls.Remove(P2);
                            BtnClickeado1(sender);
                            break;
                    case "bttn_Reuniones":
                            _BarraVertical.Controls.Remove(P2);
                            BtnClickeado1(sender);
                            break;
                    case "bttn_ABM":
                            _BarraVertical.Controls.Remove(P2);
                            BtnClickeado1(sender);
                            break;
                    }
                }
            }
        }
        private void BtnClickeado1(object sender)
        {
            Button bttn = sender as Button;
            _BarraVertical.Controls.Add(P2a);
            P2a.BackColor = Color.FromArgb(255, 255, 255);
            P2a.Size = new Size(5, bttn.Size.Height);
            P2a.Location = new Point(bttn.Location.X - 5, bttn.Location.Y);
        }
        //--------------------------------------

        //diseño de fomulario Administracion --------------------------------------------------------------------------------
        private Panel _panelBarra;
        public void formAMB(Panel panelBarra, Form formulario)
        {
            _panelBarra = panelBarra;
            Button bttnEditaArea = panelBarra.Controls["bttnEditaArea"] as Button;
            Button bttnEditaPersonal = panelBarra.Controls["bttnEditaPersonal"] as Button;
            Button bttnEditaTarea = panelBarra.Controls["bttnEditaTarea"] as Button;
            if (bttnEditaPersonal != null)
            {
                bttnEditaPersonal.MouseDown += bttnPersonal_MouseDown;
                bttnEditaPersonal.MouseEnter += bttnPersonal_MouseEnter;
                bttnEditaPersonal.MouseLeave += bttnPersonal_MouseLeave;
            }
            if (bttnEditaArea != null)
            {
                bttnEditaArea.MouseDown += bttnPersonal_MouseDown;
                bttnEditaArea.MouseEnter += bttnPersonal_MouseEnter;
                bttnEditaArea.MouseLeave += bttnPersonal_MouseLeave;
            }
            if (bttnEditaTarea != null)
            {
                bttnEditaTarea.MouseDown += bttnPersonal_MouseDown;
                bttnEditaTarea.MouseEnter += bttnPersonal_MouseEnter;
                bttnEditaTarea.MouseLeave += bttnPersonal_MouseLeave;
            }

        }


       Panel Panel = new Panel();
        Panel Panel1 = new Panel();
        private void bttnPersonal_MouseDown(object sender, MouseEventArgs e)
        {
            Button bttn = sender as Button;
            _panelBarra.Controls.Add(Panel);
            Panel.BackColor = Color.FromArgb(147, 6, 6);
            Panel.Size = new Size(bttn.Size.Width, 5);
            //coloco el panel debajo del ocntrol
            Panel.Location = new Point(bttn.Location.X, bttn.Location.Y + bttn.Size.Height);
        }
        private void bttnPersonal_MouseEnter(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            _panelBarra.Controls.Add(Panel1);
            Panel1.BackColor = Color.FromArgb(147, 6, 6);
            Panel1.Size = new Size(bttn.Size.Width, 5);
            //coloco el panel debajo del ocntrol
            Panel1.Location = new Point(bttn.Location.X, bttn.Location.Y + bttn.Size.Height);
        }

        private void bttnPersonal_MouseLeave(object sender, EventArgs e)
        {
            _panelBarra.Controls.Remove(Panel1);
        }


















    }
}
