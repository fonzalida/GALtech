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
        public static void agregar(Orden p)
        {
            //String query = "Insert into orden (IdOrden, Fecha_Recepcion, Tarea_Desarrollar, Tarea_Desarrollada, Precio, IdCliente, Completada) values (" + p.IdOrden + "," + p.FechaRecepcion + "," + p.TareaDesarrollar + "," + p.TareaDesarrollada + "," + p.Precio + "," + p.IdCliente + "," + p.Completada + ")";

            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO ORDEN"+
                "(IdOrden, FechaRecepcion, TareaDesarrollar, TareaDesarrollada, Precio, IdCliente, Completada)"+
                " VALUES (@IdOrden, @FechaRecepcion, @TareaDesarrollar, @TareaDesarrollada, @Precio, @IdCliente, @Completada)"
                );

            cmd.Parameters.AddWithValue("@IdOrden",p.IdOrden);
            cmd.Parameters.AddWithValue("@FechaRecepcion",p.FechaRecepcion);
            cmd.Parameters.AddWithValue("@TareaDesarrollar", p.TareaDesarrollar);
            cmd.Parameters.AddWithValue("@TareaDesarrollada", p.TareaDesarrollada);
            cmd.Parameters.AddWithValue("@Precio",p.Precio);
            cmd.Parameters.AddWithValue("@IdCliente",p.IdCliente);
            cmd.Parameters.AddWithValue("@Completada",p.Completada);

            Conexion conexion = new Conexion();
            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static void eliminar(Orden p)
        {
            
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "Delete from orden "+ 
                "where IdOrden = @IdOrden"
                );

            cmd.Parameters.AddWithValue("@IdOrden", p.IdOrden);

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
