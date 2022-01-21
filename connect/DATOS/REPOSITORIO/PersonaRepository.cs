using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;

namespace CoolSoft.DATOS.REPOSITORIO
{

    static public class PersonaRepository
    {
        public static void agregar(Persona p)
        {
            //String query = "Insert into persona (Dni, Nombre, Apellido) values (\"" + p.dni+ "\",\"" + p.nombre+ "\",\"" + p.apellido+ "\");";

            String query = string.Format(
                "Insert into persona (dni, nombre, apellido) values ('{0}','{1}','{2}');",
                p.dni,
                p.nombre,
                p.apellido);

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query); 
        }

        public static void eliminar(Persona p)
        {
            String query = "Delete from persona where dni = "+p.dni;

            Conexion conexion=new Conexion();
            conexion.QueryInsert(query);
        }

        public static DataTable/*List<Persona>*/ ListarTodos()
        {
            String query = "SELECT * FROM PERSONA";

            Conexion conexion=new Conexion();
            return conexion.QuerySelect(query);
            
        }
    }
}
