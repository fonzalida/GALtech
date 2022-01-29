using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;
using MySql.Data.MySqlClient;

namespace CoolSoft.DATOS.REPOSITORIO
{
    public static class OrdenRepository
    {
        public static int agregar(Orden p)
        {
            //String query = "Insert into orden ( Fecha_Recepcion, Tarea_Desarrollar, Tarea_Desarrollada, Precio, IdCliente, Completada) values (" + p.IdOrden + "," + p.FechaRecepcion + "," + p.TareaDesarrollar + "," + p.TareaDesarrollada + "," + p.Precio + "," + p.IdCliente + "," + p.Completada + ")";

            //MySqlCommand cmd = new MySqlCommand(
            //    "INSERT INTO ORDEN"+
            //    "(FechaRecepcion, TareaDesarrollar, TareaDesarrollada, IdCliente, Completada)"+
            //    " VALUES (@FechaRecepcion, @TareaDesarrollar, @TareaDesarrollada, @IdCliente, @Completada)" +
            //   "SELECT LAST_INSERT_ID();"
            //    );
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO ORDEN" +
                "(TareaDesarrollar, TareaDesarrollada, IdCliente, Completada)" +
                " VALUES (@TareaDesarrollar, @TareaDesarrollada, @IdCliente, @Completada)" +
               "SELECT LAST_INSERT_ID();"
                );

            //cmd.Parameters.AddWithValue("@IdOrden",p.IdOrden);
            //cmd.Parameters.AddWithValue("@FechaRecepcion",p.FechaRecepcion);
            cmd.Parameters.AddWithValue("@TareaDesarrollar", p.tareaDesarrollar);
            cmd.Parameters.AddWithValue("@TareaDesarrollada", p.tareaDesarrollada);
            //cmd.Parameters.AddWithValue("@Precio",p.Precio);
            cmd.Parameters.AddWithValue("@IdCliente",p.dniCuit);
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

        public static void modificar(Orden p)
        {

            MySqlCommand cmd = new MySqlCommand(
                "UPDATE Orden" +
                 "SET FechaRecepcion = @FechaRecepcion, TareaDesarrollar = @TareaDesarrollar, TareaDesarrollada = @TareaDesarrollada, Precio = @Precio ,IdCliente = @IdCliente, Completada = @Completada" +
                  "WHERE IdOrden = @IdOrden ");
                

           
            cmd.Parameters.AddWithValue("@FechaRecepcion",p.fechaRecepcion);
            cmd.Parameters.AddWithValue("@TareaDesarrollar", p.tareaDesarrollar);
            cmd.Parameters.AddWithValue("@TareaDesarrollada", p.tareaDesarrollada);
            cmd.Parameters.AddWithValue("@Precio",p.precio);
            cmd.Parameters.AddWithValue("@IdCliente", p.dniCuit);
            cmd.Parameters.AddWithValue("@Completada", p.completada);

            Conexion conexion = new Conexion();
            //conexion.QueryId(cmd) no necesitamos retornar el id
            conexion.QueryInsertDeleteUpdate(cmd);
            
        }

        public static DataTable/*List<Orden>*/ ListarTodos()
        {
            String query = "SELECT * FROM ORDEN";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
