using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{

    
    public class Emergencia
    {

        public string Fecha { get; set; }
        public string HoraI { get; set; }
        public string HoraF { get; set; }
        public string PResponsable { get; set; }
        public List<string> Bomberos { get; set; }
        public string Observaciones { get; set; }
    }
    public class EmergenciaService
    {

        private int ObtenerIdBomberoPorNyA(string nombreBombero, string apellidoBombero)
        {
            string query = "SELECT id_bombero FROM Bomberos WHERE nombre = @nombre AND apellido = @apellido";

            using (SqlConnection con = new SqlConnection(ConexionDB.strConexion))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", nombreBombero);
                cmd.Parameters.AddWithValue("@apellido", apellidoBombero);

                con.Open();
                return Convert.ToInt32(cmd.ExecuteScalar());
            }
        }
        public bool GuardarEmergencia(string observaciones, string personalResponsable, string horaInicio, string horaFin, string fecha, List<string> bomberosSeleccionados)
        {
         

            string queryEmergencia = "INSERT INTO Emergencias (detalle, usuario_responsable, emergencia_inicio, emergencia_fin, fecha) " +
                                     "VALUES (@detalle, @usuario_responsable, @emergencia_inicio, @emergencia_fin, @fecha);" +
                                     "SELECT SCOPE_IDENTITY();"; // Para obtener el ID de la emergencia recién insertada.

            using (SqlConnection con = new SqlConnection(ConexionDB.strConexion))
            {
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    SqlCommand cmdEmergencia = new SqlCommand(queryEmergencia, con, transaction);
                    cmdEmergencia.Parameters.AddWithValue("@detalle", observaciones);
                    cmdEmergencia.Parameters.AddWithValue("@usuario_responsable", personalResponsable);
                    cmdEmergencia.Parameters.AddWithValue("@emergencia_inicio", horaInicio);
                    cmdEmergencia.Parameters.AddWithValue("@emergencia_fin", horaFin);
                    cmdEmergencia.Parameters.AddWithValue("@fecha", fecha);

                    // Ejecutar el comando para la emergencia y obtener el ID generado
                    int idEmergencia = Convert.ToInt32(cmdEmergencia.ExecuteScalar());

                    // Ahora insertamos los bomberos asociados a esa emergencia
                    foreach (string bombero in bomberosSeleccionados)
                    {
                        // Suponiendo que tienes un método para obtener el idBombero a partir del nombre:
                        string[] nombreYApellido = bombero.Split(' ');

                        if (nombreYApellido.Length == 2) // Verificar que haya un nombre y un apellido
                        {
                            string nombreBombero = nombreYApellido[0];
                            string apellidoBombero = nombreYApellido[1];

                            // Obtener el ID del bombero usando el nombre y el apellido
                            int idBombero = ObtenerIdBomberoPorNyA(nombreBombero, apellidoBombero);

                            string queryBomberos = "INSERT INTO Emergencias_Bomberos (id_emergencia, id_bombero) VALUES (@id_emergencia, @id_bombero);";
                            SqlCommand cmdBomberos = new SqlCommand(queryBomberos, con, transaction);
                            cmdBomberos.Parameters.AddWithValue("@id_emergencia", idEmergencia);
                            cmdBomberos.Parameters.AddWithValue("@id_bombero", idBombero);
                            cmdBomberos.ExecuteNonQuery();
                        }
                        else
                        {
                            // Manejo de error: nombre y apellido no están correctamente formateados
                            throw new Exception("El formato del nombre del bombero no es válido. Se espera 'Nombre Apellido'.");
                        }
                    }

                    // Confirmar la transacción
                    transaction.Commit();
                    return true;
                }
                catch (Exception)
                {
                    // En caso de error, se deshace la transacción
                    transaction.Rollback();
                    return false;
                }
            }
        }

     
       
    }
}
