﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;
using System.Data;
using MySql.Data.MySqlClient;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class ParteOrdenRepository
    {
        static public void agregar(Parte_Orden p)
        {
            // String query = "Insert into parteorden (idp, id, fechainicio, fechafin, completa) values (" + p.IdP + "," + p.Id + "," + p.FechaInicio + "," + p.FechaFin + "," + p.Completa + ")";

         MySqlCommand cmd = new MySqlCommand(
                      "INSERT INTO PARTEORDEN" +
                       "(Idp, Id, Fechainicio, Fechafin, Completa)" +
                       " VALUES (@IdP, @Id, @Fechainicio, @Fechafin, @Completa)"
                       );

          cmd.Parameters.AddWithValue("@IdP", p.IdP);
          cmd.Parameters.AddWithValue("@Id", p.Id);
          cmd.Parameters.AddWithValue("@Fechainicio", p.FechaInicio);
          cmd.Parameters.AddWithValue("@FechaFin", p.FechaFin);
          cmd.Parameters.AddWithValue("@Completa", p.Completa);

            Conexion conexion = new Conexion();
            conexion.QueryInsertDeleteUpdate(cmd);
        }

        static public void eliminar(Parte_Orden p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM PARTEORDEN " +
                "where IdP = @IdP and Id = @Id"
                );

            cmd.Parameters.AddWithValue("@IdP", p.IdP);
            cmd.Parameters.AddWithValue("@Id", p.Id);

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static bool BuscarUno(int Idp, int Id)
        {
            String query = "SELECT * FROM PARTEORDEN WHERE Idp = \"" + Idp + "\" and Id = \"" + Id + "\"";

            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }

        public static DataTable/*List<Parte_Orden>*/ ListarTodos()
        {
            String query = "SELECT * FROM PARTEORDEN";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
