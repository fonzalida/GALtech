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
    static class TitularRepository
    {
        static void agregar(Titular p)
        {
            //String query = "Insert into Titular (dni, IdCliente) values (" + p.dni + "," + p.IdCliente+")";

            MySqlCommand cmd = new MySqlCommand(
              "INSERT INTO TITULAR" +
              "(dni, IdCliente)" +
              " VALUES (@dni, @IdCliente)"
              );

            cmd.Parameters.AddWithValue("@dni", p.dni);
            cmd.Parameters.AddWithValue("@IdCliente", p.IdCliente);

            Conexion conexion = new Conexion();
            conexion.QueryInsert(cmd);
        }

        static void eliminar(Titular p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM TITULAR" +
                "where dni = @dni"
                );

            cmd.Parameters.AddWithValue("@dni", p.dni);

            conexion.QueryInsert(cmd);
        }

        public static DataTable/*List<Persona>*/ ListarTodos()
        {
            String query = "SELECT * FROM TITULAR";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
