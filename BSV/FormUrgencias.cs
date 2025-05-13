using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CapaDatos;
using CapaNegocio;

namespace BSV
{
    public partial class FormUrgencias : Form
    {
       Imprimir negocio = new Imprimir();
        public FormUrgencias()
        {
            InitializeComponent();
            CargarBomberos();
        }

        private void CargarBomberos()
        {
            ConexionDB conexionDB = new ConexionDB();
            List<Persona> listaBomberos = conexionDB.ObtenerTodosLosBomberos();

            // Limpiar los ComboBoxes antes de cargarlos
            cmbBomberos.Items.Clear();
            cmbPersonaResponsable.Items.Clear();
            listBoxBomb.Items.Clear();  

            // Cargar cada bombero en los ComboBoxes
            foreach (Persona bombero in listaBomberos)
            {
                cmbBomberos.Items.Add($"{bombero.Nombre} {bombero.Apellido}");
                cmbPersonaResponsable.Items.Add($"{bombero.Nombre} {bombero.Apellido}");
            }
        }

        private void bttnImprimir_Click(object sender, EventArgs e)
        {
            negocio.ExportaPDF(dtgvUrgencias,"Planilla_Urgencias");
        }

        private void iconcerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxBomb_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            listBoxBomb.Items.Remove(listBoxBomb.SelectedItem);
        }

        private void picBoxInfor_MouseEnter(object sender, EventArgs e)
        {
            ToolTip toolTip = new ToolTip();
            toolTip.Show("Al clickear doble se eliminara el bombero.",sender as Control , new Point(0, 20), 5000);
        }

        private void txtBombero_TextChanged(object sender, EventArgs e)
        {

        }

        private void bttnG_Click(object sender, EventArgs e)
        {


            string horaInicioTexto = txtHsInicio.Text;
            string horaFinTexto = txtHsFin.Text;
            TimeSpan horaInicio = TimeSpan.Parse(horaInicioTexto);
            TimeSpan horaFin = TimeSpan.Parse(horaFinTexto);
            string horaInicioFormateada = horaInicio.ToString(@"hh\:mm");
            string horaFinFormateada = horaFin.ToString(@"hh\:mm");

            string personalResponsable = cmbPersonaResponsable.Text;
                List<string> bomberosSeleccionados = listBoxBomb.Items.Cast<string>().ToList();
                string observaciones = txtObservaciones.Text;
                
            
                string fecha = txtFecha.Text;


                // Guardar los datos en la base de datos
                EmergenciaService emergenciaService = new EmergenciaService();
                bool resultado = emergenciaService.GuardarEmergencia(observaciones,personalResponsable,horaInicioFormateada,horaFinFormateada,fecha,bomberosSeleccionados);

            if (resultado)
                {
                    MessageBox.Show("La emergencia se guardó correctamente.");
                }
                else
                {
                    MessageBox.Show("Ocurrió un error al guardar la emergencia.");
                }
            

        }

        private void botonEditado2_Click(object sender, EventArgs e)
        {

        }

        private void botonEditado1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cmbBomberos.Text))
            {
                // Verificar si el bombero ya está en la lista
                if (!listBoxBomb.Items.Contains(cmbBomberos.Text))
                {
                    listBoxBomb.Items.Add(cmbBomberos.Text); // Agregar el bombero a la lista
                }
                else
                {
                    MessageBox.Show("El bombero ya está en la lista.");
                }
            }
            else
            {
                MessageBox.Show("Seleccione un bombero para agregar.");
            }
        }
    }
}
