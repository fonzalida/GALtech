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
                      "INSERT INTO PARTEORDEN" +
                       "(IdParte, IdOrden, Completa)" +
                       " VALUES (@IdParte, @IdOrden, @Completa)"
                       );

          cmd.Parameters.AddWithValue("@IdParte", p.idParte);
          cmd.Parameters.AddWithValue("@IdOrden", p.idOrden);
          //cmd.Parameters.AddWithValue("@FechaInicio", p.fechaInicio);
          //cmd.Parameters.AddWithValue("@FechaFin", p.fechaFin);
          cmd.Parameters.AddWithValue("@Completa", p.completa);

            Conexion conexion = new Conexion();
            conexion.QueryInsertDeleteUpdate(cmd);
        }

        static public void eliminar(ParteOrden p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM PARTEORDEN " +
                "where IdParte = @IdParte"
                );

            cmd.Parameters.AddWithValue("@IdParte", p.idParte);

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static bool BuscarUno(long IdParte)
        {
            String query = "SELECT * FROM PARTEORDEN WHERE IdParte =" + IdParte;

            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }

        public static void modificar(ParteOrden p, ParteOrden pn)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE PARTEORDEN" +
                 "SET Completa = @Completa2" +
                  "where IdParte = @IdParte");

          

            cmd.Parameters.AddWithValue("@IdParte", pn.idParte);

            //cmd.Parameters.AddWithValue("@FechaInicio2", pn.fechaInicio);
            //cmd.Parameters.AddWithValue("@FechaFin2", pn.fechaFin);
            cmd.Parameters.AddWithValue("@Completa2", pn.completa);

            Conexion conexion = new Conexion();

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static DataTable ListarTodos(int idOrden)
        {
            String query = "SELECT * FROM PARTEORDEN WHERE IdOrden = " + idOrden;

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }

    }
}
