using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.Modelo.ENTIDADES;
using MySql.Data.MySqlClient;

namespace CoolSoft.Modelo.REPOSITORIO
{
    public static class OrdenRepository
    {
        public static int agregar(Orden p)
        {
            p.completada = 0;


            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO ORDEN" +
                "(FechaRecepcion ,TareaDesarrollar, IdCliente, Completada)" +
                " VALUES (@FechaRecepcion, @TareaDesarrollar, @IdCliente, @Completada)" +
               "SELECT LAST_INSERT_ID();"
                );

            //cmd.Parameters.AddWithValue("@IdOrden",p.IdOrden);
            cmd.Parameters.AddWithValue("@FechaRecepcion",p.fechaRecepcion);
            cmd.Parameters.AddWithValue("@TareaDesarrollar", p.tareaDesarrollar);
            //cmd.Parameters.AddWithValue("@TareaDesarrollada", p.tareaDesarrollada);
            //cmd.Parameters.AddWithValue("@Precio",p.Precio);
            cmd.Parameters.AddWithValue("@IdCliente",p.idCliente);
            cmd.Parameters.AddWithValue("@Completada",p.completada);

            Conexion conexion = new Conexion();
            //conexion.QueryInsertDeleteUpdate(cmd);
            return conexion.QueryId(cmd);
        }

        public static void eliminar(Orden p)
        {
            
            Conexion conexion = new Conexion();
            MySqlCommand cmd = new MySqlCommand(
                "Delete from orden "+ 
                "where IdOrden = @IdOrden"
                );

            cmd.Parameters.AddWithValue("@IdOrden", p.idOrden);

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static bool BuscarUno(int IdOrden)
        {
            String query = "SELECT * FROM ORDEN WHERE IdOrden = \"" + IdOrden + "\"";

            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }

        public static void modificar(Orden p, Orden pn)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE Orden" +
                 "SET FechaRecepcion = @FechaRecepcion2, TareaDesarrollar = @TareaDesarrollar2, TareaDesarrollada = @TareaDesarrollada2, Precio = @Precio2 ,IdCliente = @IdCliente2, Completada = @Completada2" +
                  "WHERE IdOrden = @IdOrden ");

            cmd.Parameters.AddWithValue("@IdOrden", p.fechaRecepcion);

            cmd.Parameters.AddWithValue("@FechaRecepcion2", pn.fechaRecepcion);
            cmd.Parameters.AddWithValue("@TareaDesarrollar2", pn.tareaDesarrollar);
            cmd.Parameters.AddWithValue("@TareaDesarrollada2", pn.tareaDesarrollada);
            cmd.Parameters.AddWithValue("@Precio2",pn.precio);
            cmd.Parameters.AddWithValue("@IdCliente2", pn.idCliente);
            cmd.Parameters.AddWithValue("@Completada2", pn.completada);

            Conexion conexion = new Conexion();
            //conexion.QueryId(cmd) no necesitamos retornar el id
            conexion.QueryInsertDeleteUpdate(cmd);
            
        }

        public static DataTable ListarTodos()
        {
            String query = "SELECT * FROM ORDEN";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
