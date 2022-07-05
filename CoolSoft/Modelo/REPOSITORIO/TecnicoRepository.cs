using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.Modelo.ENTIDADES;
using System.Data;
using MySqlConnector;

namespace CoolSoft.Modelo.REPOSITORIO
{
    static class TecnicoRepository
    {
        static public int Agregar(Tecnico p)
        {
            // String query = "Insert into Tecnico (dni) values (" + p.dni +")";

            MySqlCommand cmd = new MySqlCommand(
               "INSERT INTO tecnico" +
                "(Dni, Nombre, Telefono)" +
                 " VALUES (@dni, @nombre, @telefono); " +
                  " SELECT LAST_INSERT_ID();"
               );

            cmd.Parameters.AddWithValue("@dni", p.dni);
            cmd.Parameters.AddWithValue("@nombre", p.nombre);
            cmd.Parameters.AddWithValue("@telefono", p.telefono);


            Conexion conexion = new Conexion();
            return conexion.QueryId(cmd);
        }

        static public void Alta(int dni)
        {
            Conexion conexion = new Conexion();
            MySqlCommand cmd = new MySqlCommand(
               "UPDATE tecnico " +
                 "SET Activo = 1 " +
                  "where Dni = @dni  ");
            cmd.Parameters.AddWithValue("@dni", dni);
            conexion.QueryInsertDeleteUpdate(cmd);
        }

        static public void Eliminar(Tecnico p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
               "UPDATE tecnico " +
                 "SET Activo = 0 " +
                  "where Dni = @dni  ");
           

            cmd.Parameters.AddWithValue("@dni", p.dni);
            //cmd.Parameters.AddWithValue("@activo", /*p.activo.ToString()*/);

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static void modificar(Tecnico viejo, Tecnico nuevo)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE tecnico " +
                 "SET Dni = @dni2, Nombre = @nombre2, Telefono = @telefono2, Activo = 1 " +
                  "where Dni = @dni  ");

            cmd.Parameters.AddWithValue("@dni", viejo.dni);

            cmd.Parameters.AddWithValue("@dni2", nuevo.dni);
            cmd.Parameters.AddWithValue("@nombre2", nuevo.nombre);
            cmd.Parameters.AddWithValue("@telefono2", nuevo.telefono);

            Conexion conexion = new Conexion();

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static bool BuscarUno(int dni)
        {
            String query = "SELECT * FROM tecnico WHERE Dni = \"" + dni + "\"";

            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }

        public static DataTable ListarTodos()
        {
            String query = "SELECT * FROM tecnico WHERE Activo = 1";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }

        public static string BuscarNombre(int dni)
        {
            String query = "SELECT Nombre FROM tecnico WHERE Dni = " + dni;
            Conexion conexion = new Conexion();
            var resultado = conexion.QuerySelect(query);
            Console.WriteLine(resultado.Rows.Count);
            return resultado.Rows[0].Field<string>("Nombre");


        }
    }
}
