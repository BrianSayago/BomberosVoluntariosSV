using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;

namespace CapaNegocio
{
    public class TareaService
    {

        private ConexionDB conexionDB = new ConexionDB();

        // Método para registrar una tarea y actualizar la asistencia
        public bool RegistrarTareaYActualizarAsistencia(int idBombero, string descripcionTarea)
        {
            // 1. Insertar la tarea y obtener el ID de la tarea recién creada
            int idTarea = conexionDB.InsertarTarea(idBombero, descripcionTarea);

            if (idTarea > 0)
            {
                // 2. Obtener la fecha actual para actualizar la asistencia
                int idFecha = conexionDB.ObtenerFechaActual();

                // 3. Actualizar la asistencia con la tarea realizada
                return conexionDB.ActualizarAsistenciaConTarea(idBombero, idTarea, idFecha);
            }

            return false;
        }

    }
}
