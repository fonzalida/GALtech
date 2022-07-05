using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoolSoft.Modelo.ENTIDADES;
using MySqlConnector;

namespace CoolSoft.Modelo.REPOSITORIO
{
    public static class OrdenRepository
    { 
        public static int agregar(Orden p)
        {
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO orden" +
                "(FechaRecepcion ,TareaDesarrollar, IdCliente, Precio) " +
                "VALUES (@FechaRecepcion, @TareaDesarrollar, @IdCliente, 0);" +
                "SELECT LAST_INSERT_ID();"
                );

            cmd.Parameters.AddWithValue("@FechaRecepcion",p.fechaRecepcion.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TareaDesarrollar", p.tareaDesarrollar);
            cmd.Parameters.AddWithValue("@IdCliente",p.idCliente);

            Conexion conexion = new Conexion();
            return conexion.QueryId(cmd);
        }

        

        public static bool BuscarUno(int IdOrden)
        {
            String query = "SELECT * FROM orden WHERE IdOrden = \"" + IdOrden + "\"";

            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }

        public static void modificar(Orden p, Orden pn)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE orden " +
                 "SET FechaRecepcion = @FechaRecepcion2, TareaDesarrollar = @TareaDesarrollar2, Precio = @Precio2 ,IdCliente = @IdCliente2, Completada = @Completada2 " +
                  "WHERE IdOrden = @IdOrden ");

            cmd.Parameters.AddWithValue("@IdOrden", p.idOrden);

            cmd.Parameters.AddWithValue("@FechaRecepcion2", pn.fechaRecepcion.Date.ToString("yyyy-MM-dd"));
            cmd.Parameters.AddWithValue("@TareaDesarrollar2", pn.tareaDesarrollar);
            cmd.Parameters.AddWithValue("@Precio2",pn.precio);
            cmd.Parameters.AddWithValue("@IdCliente2", pn.idCliente);
            cmd.Parameters.AddWithValue("@Completada2", pn.completada);

            Conexion conexion = new Conexion();
            conexion.QueryInsertDeleteUpdate(cmd);
            
        }

        public static void eliminar(Orden p)
        {

            Conexion conexion = new Conexion();
            MySqlCommand cmd = new MySqlCommand(
                "UPDATE orden " +
                "SET Eliminada = 1 " +
                "where IdOrden = @IdOrden"
                );

            cmd.Parameters.AddWithValue("@IdOrden", p.idOrden);

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
                "SELECT DATE_FORMAT(DATE(FechaRecepcion), \"%d-%c-%Y\") AS Recepcion, " +
                "IdOrden, TareaDesarrollar, " +
                "Nombre AS Cliente, " +
                "Precio AS Importe, " +
                "Completada, " +
                "cliente.IdCliente " +
                "FROM orden " +
                "INNER JOIN cliente " +
                "ON orden.IdCliente = cliente.IdCliente " +
                "where Eliminada = 0" +
                " order by IdOrden desc";
            

            //            INNER JOIN TecnicoOrden
            //ON ParteOrden.IdParte = TecnicoOrden.IdParte
            //and TecnicoOrden.Dni = { dni tecnico}
            //            and ParteOrden.Completa = 0
            //INNER JOIN Orden
            //ON ParteOrden.IdOrden = Orden.IdOrden

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }


        public static DataTable ListarPorFecha(DateTime desde, DateTime hasta)
        {
            String query =
                "SELECT DATE_FORMAT(DATE(FechaRecepcion), \"%d %c %Y\") AS Recepcion, " +
                "IdOrden, TareaDesarrollar, " +
                "Nombre AS Cliente, " +
                "Precio AS Importe, " +
                "Completada, " +
                "cliente.IdCliente " +
                "FROM orden " +
                "INNER JOIN cliente " +
                "ON orden.IdCliente = cliente.IdCliente " +
                "WHERE FechaRecepcion BETWEEN \" " + desde.ToString("yyyy/MM/dd") + "\" AND \" " + hasta.ToString("yyyy/MM/dd") + "\" and Eliminada = 0";


            
            
            

            //            INNER JOIN TecnicoOrden
            //ON ParteOrden.IdParte = TecnicoOrden.IdParte
            //and TecnicoOrden.Dni = { dni tecnico}
            //            and ParteOrden.Completa = 0
            //INNER JOIN Orden
            //ON ParteOrden.IdOrden = Orden.IdOrden

           

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }

        public static DataTable ListarFiltros(int i)
        {
            String query =
                "SELECT DATE_FORMAT(DATE(FechaRecepcion), \"%d %c %Y\") AS Recepcion, " +
                "IdOrden, TareaDesarrollar, " +
                "Nombre AS Cliente, Precio AS Importe, " +
                "Completada, cliente.IdCliente " +
                "FROM orden " +
                "INNER JOIN cliente " +
                "ON orden.IdCliente = cliente.IdCliente " +
                "WHERE Completada = \"" + i + "\"";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }

    }
}
