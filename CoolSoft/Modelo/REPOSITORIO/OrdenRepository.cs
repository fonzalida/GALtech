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
            //p.completada = 0;


            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO ORDEN" +
                "(FechaRecepcion ,TareaDesarrollar, IdCliente) " +
                "VALUES (@FechaRecepcion, @TareaDesarrollar, @IdCliente);" +
               "SELECT LAST_INSERT_ID();"
                );

            //cmd.Parameters.AddWithValue("@IdOrden",p.IdOrden);
            cmd.Parameters.AddWithValue("@FechaRecepcion",p.fechaRecepcion.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TareaDesarrollar", p.tareaDesarrollar);
            //cmd.Parameters.AddWithValue("@TareaDesarrollada", p.tareaDesarrollada);
            //cmd.Parameters.AddWithValue("@Precio",p.Precio);
            cmd.Parameters.AddWithValue("@IdCliente",p.idCliente);
            //cmd.Parameters.AddWithValue("@Completada",0);

            Conexion conexion = new Conexion();
            //conexion.QueryInsertDeleteUpdate(cmd);
            return conexion.QueryId(cmd);
        }

        public static void eliminar(Orden p)
        {
            
            Conexion conexion = new Conexion();
            MySqlCommand cmd = new MySqlCommand(
                "Delete from orden "+ 
                "where IdOrden = @IdOrden and Completada = 0"
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
                 "SET FechaRecepcion = @FechaRecepcion2, TareaDesarrollar = @TareaDesarrollar2, Precio = @Precio2 ,IdCliente = @IdCliente2, Completada = @Completada2" +
                  "WHERE IdOrden = @IdOrden ");

            cmd.Parameters.AddWithValue("@IdOrden", p.fechaRecepcion);

            cmd.Parameters.AddWithValue("@FechaRecepcion2", pn.fechaRecepcion);
            cmd.Parameters.AddWithValue("@TareaDesarrollar2", pn.tareaDesarrollar);
            //cmd.Parameters.AddWithValue("@TareaDesarrollada2", pn.tareaDesarrollada);
            cmd.Parameters.AddWithValue("@Precio2",pn.precio);
            cmd.Parameters.AddWithValue("@IdCliente2", pn.idCliente);
            cmd.Parameters.AddWithValue("@Completada2", pn.completada);

            Conexion conexion = new Conexion();
            //conexion.QueryId(cmd) no necesitamos retornar el id
            conexion.QueryInsertDeleteUpdate(cmd);
            
        }

        //public static DataTable ListarTodos()
        //{
        //    String query = "SELECT * FROM ORDEN";

        //    Conexion conexion = new Conexion();
        //    return conexion.QuerySelect(query);

        //}

        public static DataTable ListarTodos()
        {
            String query =
                "SELECT DATE_FORMAT(DATE(FechaRecepcion), \"%d %c %Y\") AS Recepcion, " +
                "IdOrden, TareaDesarrollar, " +
                "Nombre AS Cliente, Precio AS Importe, " +
                "Completada, Cliente.IdCliente " +
                "FROM ORDEN " +
                "INNER JOIN CLIENTE " +
                "ON ORDEN.IDCLIENTE = CLIENTE.IDCLIENTE";
            

            //            INNER JOIN TecnicoOrden
            //ON ParteOrden.IdParte = TecnicoOrden.IdParte
            //and TecnicoOrden.Dni = { dni tecnico}
            //            and ParteOrden.Completa = 0
            //INNER JOIN Orden
            //ON ParteOrden.IdOrden = Orden.IdOrden

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
