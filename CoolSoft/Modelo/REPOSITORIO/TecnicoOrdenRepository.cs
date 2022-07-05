using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.Modelo.ENTIDADES;
using System.Data;
using MySql.Data.MySqlClient;

namespace CoolSoft.Modelo.REPOSITORIO
{
    static class TecnicoOrdenRepository
    {
        static public void agregar(TecnicoOrden p)
        {
            //String query = "Insert into tecnicoorden (dni, idp, id) values (" + p.dni + "," + p.idp + "," + p.id + ")";

            MySqlCommand cmd = new MySqlCommand(
                            "INSERT INTO tecnicoorden" +
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
                "DELETE FROM tecnicoorden " +
                "where Dni = @Dni and IdParte = @IdParte"
                );

            cmd.Parameters.AddWithValue("@Dni", p.dni);
            cmd.Parameters.AddWithValue("@IdParte", p.idParte);

            conexion.QueryInsertDeleteUpdate(cmd);
        }


        public static void modificar(TecnicoOrden viejo, Tecnico nuevo)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE tecnicoorden" +
                 "SET Dni = @Dni2 " +
                  "where Dni = @Dni and IdParte = @IdParte");


            cmd.Parameters.AddWithValue("@Dni", viejo.dni);
            cmd.Parameters.AddWithValue("@IdParte", viejo.idParte);

            cmd.Parameters.AddWithValue("@Dni2", nuevo.dni);


            Conexion conexion = new Conexion();

            conexion.QueryInsertDeleteUpdate(cmd);

        }

        public static DataTable ListarTodos(int idParte)
        {
            String query = "SELECT * FROM tecnicoorden "+
                           "INNER JOIN parteorden " +
                           "ON tecnicoorden.IDPARTE = parteorden.IdParte" +
                           "INNER JOIN tecnico " +
                           "ON tecnico.Dni = tecnicoorden.Dni " +
                           "WHERE parteorden.IdParte = " + idParte ;

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }



        public static bool BuscarUno(TecnicoOrden t)
        {
            String query =
                "select * from tecnicoorden " +
                "INNER JOIN parteorden " +
                "ON tecnicoorden.IdParte = parteorden.IdParte " +
                "WHERE tecnicoorden.Dni = \"" + t.dni + "\" and " +
                "parteorden.IdParte = \"" + t.idParte + "\" and " +
                "parteorden.Completa = 0";

            //"SELECT * FROM TECNICOORDEN " +
            //"where Dni = \"" + t.dni + "\" and " +
            //"IdParte = \"" + t.idParte + "\" and " +
            //"";


            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }
    }
}
