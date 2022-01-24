using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

using CoolSoft.DATOS.ENTIDADES;

namespace CoolSoft.DATOS.REPOSITORIO
{

    static public class PersonaRepository
    {
        public static void agregar(Persona p)
        {
            //String query = string.Format(
            //    "Insert into persona (dni, nombre, apellido) values ('{0}','{1}','{2}');",
            //    p.dni,
            //    p.nombre,
            //    p.apellido);

            MySqlCommand cmd = new MySqlCommand(
               "INSERT INTO PERSONA" +
               "(dni, nombre, apellido)" +
               " VALUES (@dni, @nombre, @apellido)"
               );

            cmd.Parameters.AddWithValue("@dni", p.dni);
            cmd.Parameters.AddWithValue("@nombre", p.nombre);
            cmd.Parameters.AddWithValue("@apellido", p.apellido);

            Conexion conexion = new Conexion();
            conexion.QueryInsert(cmd);

        }

        public static void eliminar(Persona p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM PERSONA" +
                "where dni = @dni"
                );

            cmd.Parameters.AddWithValue("@dni", p.dni);

            conexion.QueryInsert(cmd);
        }

        public static DataTable/*List<Persona>*/ ListarTodos()
        {
            String query = "SELECT * FROM PERSONA";

            Conexion conexion=new Conexion();
            return conexion.QuerySelect(query);
            
        }
    }
}
