using System;
using System.Windows.Forms;
using CapaDiseño;
using CapaDatos;
using System.Data;
using CapaNegocio;

namespace BSV
{
    public partial class FormTareasI : Form
    {
        private ConexionDB conexionDB = new ConexionDB();
        private TareaService tareaService = new TareaService();

        Diseño diseño = new Diseño();
        public FormTareasI()
        {
            InitializeComponent();
            diseño.formT(this);
            CargarAreas();
        }

        private void CargarAreas()
        {
            DataTable dtAreas = conexionDB.ObtenerAreas();

            cmbAreas.DataSource = dtAreas;
            cmbAreas.DisplayMember = "nombre_area";  
            cmbAreas.ValueMember = "id_area";       
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconminimizar_Click(object sender, EventArgs e)
        {
          this.WindowState = FormWindowState.Minimized;
        }

        private void bttnG_Click(object sender, EventArgs e)
        {
            try
            {
                // Obtener el ID del bombero, la descripción de la tarea y el área seleccionada
                int idBombero = Convert.ToInt32(txtLegajos.Text);
                string descripcionTarea = txtTarea.Text;

                // Validar los campos antes de proceder


                if (string.IsNullOrEmpty(descripcionTarea))
                {
                    MessageBox.Show("Debe ingresar una descripción de la tarea.");
                    return;
                }

                // Registrar la tarea y actualizar la asistencia
                bool resultado = tareaService.RegistrarTareaYActualizarAsistencia(idBombero, descripcionTarea);

                if (resultado)
                {
                    MessageBox.Show("Tarea registrada y puntaje actualizado correctamente.");
                }
                else
                {
                    MessageBox.Show("Error al registrar la tarea o actualizar el puntaje.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }
    }
}
