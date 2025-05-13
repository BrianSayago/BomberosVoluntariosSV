using CapaDatos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{



    public class BomberoService
    {
        private ConexionDB conexion = new ConexionDB();

        public Persona ObtenerBomberoPorId(int idBombero)
        {
            return conexion.ObtenerBomberoPorId(idBombero);
        }
    }

  
}


    
