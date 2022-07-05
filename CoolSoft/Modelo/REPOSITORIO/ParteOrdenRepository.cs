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
    static class ParteOrdenRepository
    {
        static public void agregar(ParteOrden p)
        {
            // String query = "Insert into parteorden (idp, id, fechainicio, fechafin, completa) values (" + p.IdP + "," + p.Id + "," + p.FechaInicio + "," + p.FechaFin + "," + p.Completa + ")";

         MySqlCommand cmd = new MySqlCommand(
                      "INSERT INTO parteorden" +
                       "(IdParte, IdOrden, Completa, FechaInicio, FechaFin)" +
                       " VALUES (@IdParte, @IdOrden, @Completa, @FechaInicio, @FechaFin, @TareaDesarrollada)"
                       );

          cmd.Parameters.AddWithValue("@IdParte", p.idParte);
          cmd.Parameters.AddWithValue("@IdOrden", p.idOrden);
          cmd.Parameters.AddWithValue("@FechaInicio", p.fechaInicio);
          cmd.Parameters.AddWithValue("@FechaFin", p.fechaFin);
            cmd.Parameters.AddWithValue("@TareaDesarrollada", p.tareaDesarrollada);
            cmd.Parameters.AddWithValue("@Completa", p.completa);

            Conexion conexion = new Conexion();
            conexion.QueryInsertDeleteUpdate(cmd);
        }

        static public void eliminar(ParteOrden p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM parteorden " +
                "where IdParte = @IdParte"
                );

            cmd.Parameters.AddWithValue("@IdParte", p.idParte);

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static bool BuscarUno(long IdParte)
        {
            String query = "SELECT * FROM parteorden WHERE IdParte =" + IdParte;

            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }

        public static void modificar(ParteOrden p, ParteOrden pn)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE parteorden" +
                 "SET Completa = @Completa2" +
                  "where IdParte = @IdParte");

          

            cmd.Parameters.AddWithValue("@IdParte", pn.idParte);

            cmd.Parameters.AddWithValue("@FechaInicio2", pn.fechaInicio);
            cmd.Parameters.AddWithValue("@FechaFin2", pn.fechaFin);
            cmd.Parameters.AddWithValue("@TareaDesarrollada2", pn.tareaDesarrollada);
            cmd.Parameters.AddWithValue("@Completa2", pn.completa);

            Conexion conexion = new Conexion();

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static DataTable ListarTodos(int idOrden)
        {
            String query = "SELECT * FROM parteorden WHERE IdOrden = " + idOrden;

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }

    }
}
