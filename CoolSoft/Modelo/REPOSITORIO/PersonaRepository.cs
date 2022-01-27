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
        public static void Agregar(Persona p)
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
            conexion.QueryInsertDeleteUpdate(cmd);

        }


        public static void eliminar(Persona p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM PERSONA" +
                "where dni = @dni"
                );

            cmd.Parameters.AddWithValue("@dni", p.dni);

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static bool BuscarUno(int dni)
        {
            String query = "SELECT * FROM PERSONA WHERE dni = \"" + dni+"\"";

            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else 
                return false;
            
        }

        public static void modificar(Persona p, Persona pn)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE PERSONA" +
                 "SET Dni = @Dni2, Nombre = @nombre2, Apellido = @apellido2  " +
                  "where Dni = @Dni ");


            cmd.Parameters.AddWithValue("@dni", p.dni);
            cmd.Parameters.AddWithValue("@dni2", pn.dni);
            cmd.Parameters.AddWithValue("@nombre2", pn.nombre);
            cmd.Parameters.AddWithValue("@apellido2", pn.apellido);

            Conexion conexion = new Conexion();

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static DataTable/*List<Persona>*/ ListarTodos()
        {
            String query = "SELECT * FROM PERSONA";

            Conexion conexion=new Conexion();
            return conexion.QuerySelect(query);
            
        }
    }
}
