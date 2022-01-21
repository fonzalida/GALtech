using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;

namespace CoolSoft.DATOS.REPOSITORIO
{
    public static class OrdenRepository
    {
        public static void agregar(Orden p)
        {
            //String query = "Insert into orden (IdOrden, Fecha_Recepcion, Tarea_Desarrollar, Tarea_Desarrollada, Precio, IdCliente, Completada) values (" + p.IdOrden + "," + p.FechaRecepcion + "," + p.TareaDesarrollar + "," + p.TareaDesarrollada + "," + p.Precio + "," + p.IdCliente + "," + p.Completada + ")";

            

            String query = String.Format(
                "Insert into orden (IdOrden, FechaRecepcion, TareaDesarrollar, TareaDesarrollada, Precio, IdCliente, Completada) values ('1', now(), '{2}', '{3}', '{4}', '{5}', '{6}')",
                //"Insert into orden (IdOrden, FechaRecepcion, TareaDesarrollar, TareaDesarrollada, Precio, IdCliente, Completada) values ('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', '{6}')",
                p.IdOrden, 
                //p.FechaRecepcion.Date.ToString("yyyy-MM-dd"),
                p.TareaDesarrollar,
                p.TareaDesarrollada,
                p.Precio,
                p.IdCliente//,
                //p.Completada
                );

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        public static void eliminar(Orden p)
        {
            String query = "Delete from orden where IdOrden = " + p.IdOrden;

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        public static DataTable/*List<Orden>*/ ListarTodos()
        {
            String query = "SELECT * FROM ORDEN";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
