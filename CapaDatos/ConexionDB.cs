using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    public class ConexionDB
    {
        public static string strConexion = $"Server=localhost\\SQLEXPRESS;Database=BomberosSV;Trusted_Connection=True;";

        SqlConnection Conexion;
        SqlCommand Orden;

        public SqlDataReader LeerSQL(string Consulta)
        {
            SqlDataReader Lector;
            //creamos la conexión con la base de datos
            Conexion = new SqlConnection(strConexion);
            //establecemos la consulta dentro de la conexión
            Orden = new SqlCommand(Consulta, Conexion);
            try
            {
                Conexion.Open();//abrimos la conexion

                //ejecutamos la consulta y la asignamos al DataReader
                Lector = Orden.ExecuteReader();

                return Lector; //retornamos los datos obtenidos

            }
            catch
            {
                Lector = null;
                Conexion.Close();
                return Lector;
            }
        }

        public List<Persona> ObtenerBomberos()
        {
            List<Persona> listaBomberos = new List<Persona>();
            string consulta = "SELECT B.id_bombero, B.nombre, B.apellido, B.dni, B.activo, J.nombre AS Jerarquia, A.nombre AS Area " +
                              "FROM Bomberos B " +
                              "INNER JOIN Jerarquias J ON B.id_jerarquia = J.id_jerarquia " +
                              "INNER JOIN Areas A ON B.id_area = A.id_area";

            SqlDataReader reader = LeerSQL(consulta);

            if (reader != null)
            {
                while (reader.Read())
                {
                    Persona bombero = new Persona
                    {
                        IdBombero = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Apellido = reader.GetString(2),
                        DNI = reader.GetString(3),
                        Activo = reader.GetBoolean(4),
                        Jerarquia = reader.GetString(5),
                        Area = reader.GetString(6)
                    };
                    listaBomberos.Add(bombero);
                }
                reader.Close();
                Conexion.Close();
            }
            return listaBomberos;
        }

        public Persona ObtenerBomberoPorId(int idBombero)
        {
            Persona bombero = null;
            string consulta = "SELECT B.id_bombero, B.nombre, B.apellido, B.dni, B.activo, J.nombre_jerarquia AS Jerarquia, A.nombre_area AS Area  FROM Bomberos B INNER JOIN Jerarquias J ON B.id_jerarquia = J.id_jerarquia INNER JOIN Areas A ON B.id_area = A.id_area WHERE id_bombero = @IdBombero";

            using (SqlConnection conexion = new SqlConnection(strConexion))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@IdBombero", idBombero);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {
                        bombero = new Persona
                        {
                            IdBombero = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Apellido = reader.GetString(2),
                            DNI = reader.GetString(3),
                            Activo = reader.GetBoolean(4),
                            Jerarquia = reader.GetString(5),
                            Area = reader.GetString(6)
                        };
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al buscar el bombero: " + ex.Message);
                }
            }

            return bombero;
        }

        public int ObtenerIdFecha(string fecha)
        {
            int idFecha = 0;
            string consulta = "SELECT id_fecha  FROM Fecha  WHERE descripcion = @fecha";

            using (SqlConnection conexion = new SqlConnection(strConexion))
            {
                SqlCommand comando = new SqlCommand(consulta, conexion);
                comando.Parameters.AddWithValue("@fecha", fecha);

                try
                {
                    conexion.Open();
                    SqlDataReader reader = comando.ExecuteReader();

                    if (reader.Read())
                    {

                        idFecha = reader.GetInt32(0);

                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Manejo de errores
                    Console.WriteLine("Error al buscar la fecha: " + ex.Message);
                }
            }

            return idFecha;
        }
        public bool InsertarIngresoBomberoPorId(int idBombero, int id_fecha, string horaIngreso)
        {
            Conexion = new SqlConnection(strConexion);
            string consulta = "INSERT INTO Asistencias (id_bombero,id_fecha, hora_ingreso) VALUES (@idBombero,@id_fecha, @horaIngreso)";
            Orden = new SqlCommand(consulta, Conexion);
            Orden.Parameters.AddWithValue("@idBombero", idBombero);
            Orden.Parameters.AddWithValue("@id_fecha", id_fecha);
            Orden.Parameters.AddWithValue("@horaIngreso", horaIngreso);


            try
            {
                Conexion.Open();

                int filasAfectadas = Orden.ExecuteNonQuery();

                Conexion.Close();
                return filasAfectadas > 0;
            }
            catch
            {
                Conexion.Close();
                return false;
            }
        }

        public int InsertarFecha(string fecha)
        {
            Conexion = new SqlConnection(strConexion);
            string consulta = "INSERT INTO Fecha (descripcion) VALUES (@descripcion)";
            Orden = new SqlCommand(consulta, Conexion);
            Orden.Parameters.AddWithValue("@descripcion", fecha);
            int idFecha = 0;
            try
            {
                Conexion.Open();

                int filasAfectadas = Orden.ExecuteNonQuery();

                Conexion.Close();

            }
            catch
            {
                Conexion.Close();

            }

            idFecha = ObtenerIdFecha(fecha);
            return idFecha;
        }

        public DataTable ObtenerAreas()
        {

            string query = "SELECT id_area, nombre_area FROM Areas WHERE activo = 1";
            using (SqlConnection con = new SqlConnection(ConexionDB.strConexion))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                con.Open();
                da.Fill(dt);
                return dt;
            }
        }

        // Método para insertar una tarea en la tabla Tareas
        public int InsertarTarea(int idBombero, string descripcion)
        {
            string query = "INSERT INTO Tareas (id_bombero, descripcion) OUTPUT INSERTED.id_tarea VALUES (@id_bombero, @descripcion)";

            using (SqlConnection con = new SqlConnection(ConexionDB.strConexion))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id_bombero", idBombero);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);

                con.Open();
                int idTarea = (int)cmd.ExecuteScalar(); // Devuelve el ID de la tarea insertada
                return idTarea;
            }
        }

        public bool ActualizarAsistenciaConTarea(int idBombero, int idTarea, int idFecha)
        {
            string query = "UPDATE Asistencias SET id_tarea = @id_tarea, puntaje = '1' WHERE id_bombero = @id_bombero AND id_fecha = @id_fecha";

            using (SqlConnection con = new SqlConnection(ConexionDB.strConexion))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id_tarea", idTarea);
                cmd.Parameters.AddWithValue("@id_bombero", idBombero);
                cmd.Parameters.AddWithValue("@id_fecha", idFecha);

                con.Open();
                int rowsAffected = cmd.ExecuteNonQuery(); // Verifica si se actualizó alguna fila
                return rowsAffected > 0; // Devuelve true si se actualizó al menos una fila
            }
        }

        // Método para obtener la fecha actual
        public int ObtenerFechaActual()
        {

            string fechaHoy = DateTime.Now.ToShortDateString(); // Formato de la fecha
            string query = "SELECT id_fecha FROM Fecha WHERE descripcion = @fecha";

            using (SqlConnection con = new SqlConnection(ConexionDB.strConexion))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fecha", fechaHoy);
                con.Open();
                int idFecha = (int)cmd.ExecuteScalar(); // Devuelve el ID de la fecha
                return idFecha;
            }
        }

        public bool VerificarIngreso(int idBombero)
        {
            string query = "SELECT COUNT(*) FROM Asistencias WHERE id_bombero = @idBombero AND hora_egreso IS NULL";

            using (SqlConnection con = new SqlConnection(ConexionDB.strConexion))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@idBombero", idBombero);

                con.Open();
                int result = (int)cmd.ExecuteScalar();
                return result > 0; // Si existe un registro sin egreso
            }
        }

        public bool RegistrarEgreso(int idBombero)

        {
            string querySelect = "SELECT hora_ingreso FROM Asistencias WHERE id_bombero = @id_bombero AND hora_egreso IS NULL";

            using (SqlConnection con = new SqlConnection(ConexionDB.strConexion))
            {
                SqlCommand cmdSelect = new SqlCommand(querySelect, con);
                cmdSelect.Parameters.AddWithValue("@id_bombero", idBombero);

                con.Open();
                object horaIngresoObj = cmdSelect.ExecuteScalar(); // Obtenemos la hora de ingreso
                con.Close();

                if (horaIngresoObj == null)
                {
                    return false; // No se encontró un ingreso válido, retornar falso
                }

                DateTime horaIngreso = DateTime.ParseExact(horaIngresoObj.ToString(), "HH:mm:ssss", null);

                // Obtenemos la hora actual
                DateTime horaEgreso = DateTime.Now;
                string horaEgresoStr = horaEgreso.ToString("HH:mm:ssss");

                // Calculamos la diferencia de tiempo entre ingreso y egreso
                TimeSpan tiempoTrabajado = horaEgreso - horaIngreso;

                // Determinamos el puntaje: 1 si trabajó más de una hora, 0 si trabajó menos
                string puntaje = tiempoTrabajado.TotalHours >= 1 ? "1" : "0";

                // Consulta para registrar la hora de egreso y el puntaje
                string queryUpdate = "UPDATE Asistencias SET hora_egreso = @hora_egreso, puntaje = @puntaje WHERE id_bombero = @id_bombero AND hora_egreso IS NULL";

                SqlCommand cmdUpdate = new SqlCommand(queryUpdate, con);
                cmdUpdate.Parameters.AddWithValue("@hora_egreso", horaEgresoStr);
                cmdUpdate.Parameters.AddWithValue("@puntaje", puntaje);
                cmdUpdate.Parameters.AddWithValue("@id_bombero", idBombero);

                con.Open();
                int rowsAffected = cmdUpdate.ExecuteNonQuery(); // Actualizamos el registro
                return rowsAffected > 0; // Retorna true si se actualizó alguna fila
            }
        }

        public List<Persona> ObtenerTodosLosBomberos()
        {
            List<Persona> listaBomberos = new List<Persona>();

            string query = "SELECT id_bombero, nombre, apellido FROM Bomberos";

            using (SqlConnection con = new SqlConnection(ConexionDB.strConexion))
            {
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Persona bombero = new Persona();
                    bombero.IdBombero = Convert.ToInt32(reader["id_bombero"]);
                    bombero.Nombre = reader["Nombre"].ToString();
                    bombero.Apellido = reader["Apellido"].ToString();

                    listaBomberos.Add(bombero);
                }
                reader.Close();
            }

            return listaBomberos;
        }

    


    }
}
