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
    static class TecnicoOrdenRepository
    {
        static public void agregar(TecnicoOrden p)
        {
            //String query = "Insert into tecnicoorden (dni, idp, id) values (" + p.dni + "," + p.idp + "," + p.id + ")";

            MySqlCommand cmd = new MySqlCommand(
                            "INSERT INTO TECNICOORDEN" +
                             "(Dni, IdParte)" +
                             " VALUES (@Dni, @IdParte)"
                             );

            cmd.Parameters.AddWithValue("@Dni", p.dni);
            cmd.Parameters.AddWithValue("@IdParte", p.idParte);

            Conexion conexion = new Conexion();
            conexion.QueryInsertDeleteUpdate(cmd);
        }

        static public void eliminar(TecnicoOrden p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM TECNICOORDEN " +
                "where Dni = @Dni and IdParte = @IdParte"
                );

            cmd.Parameters.AddWithValue("@Dni", p.dni);
            cmd.Parameters.AddWithValue("@IdParte", p.idParte);

            conexion.QueryInsertDeleteUpdate(cmd);
        }


        public static void modificar(TecnicoOrden viejo, Tecnico nuevo)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE PARTEORDEN" +
                 "SET Dni = @Dni2 " +
                  "where Dni = @Dni and IdParte = @IdParte");


            cmd.Parameters.AddWithValue("@Dni", viejo.dni);
            cmd.Parameters.AddWithValue("@IdParte", viejo.idParte);

            cmd.Parameters.AddWithValue("@Dni2", nuevo.dni);


            Conexion conexion = new Conexion();

            conexion.QueryInsertDeleteUpdate(cmd);

        }

        public static DataTable ListarTodos()
        {
            String query = "SELECT * FROM TECNICOORDEN";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }

        public static bool BuscarUno(TecnicoOrden t)
        {
            String query =
                "SELECT * FROM CLIENTE " +
                "where Dni = \"" + t.dni + "\" and " +
                "IdParte = \"" + t.idParte + "\"";


            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }
    }
}
