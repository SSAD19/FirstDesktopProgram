using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data; 

namespace Acciones
{
     public class general
    {
            public DataTable traerDatos (string comando){
             AccesoDatos.BaseDatos traer = new AccesoDatos.BaseDatos();
            
             DataTable Tabla = new DataTable();
             Tabla = traer.recuperarDB(comando);

             return Tabla; 

        }

    }
}
