using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;
using System.Data;
using MySql.Data.MySqlClient;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class TecnicoRepository
    {
        static public void agregar(Tecnico p)
        {
            // String query = "Insert into Tecnico (dni) values (" + p.dni +")";

            MySqlCommand cmd = new MySqlCommand(
               "INSERT INTO TECNICO" +
               "(dni)" +
               " VALUES (@dni)"
               );

            cmd.Parameters.AddWithValue("@dni", p.dni);

            Conexion conexion = new Conexion();
            conexion.QueryInsertDeleteUpdate(cmd);
        }

        static public void eliminar(Tecnico p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM TECNICO" +
                "where dni = @dni"
                );

            cmd.Parameters.AddWithValue("@dni", p.dni);

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static DataTable/*List<Persona>*/ ListarTodos()
        {
            String query = "SELECT * FROM TECNICO";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
