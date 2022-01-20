using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class OrdenRepository
    {
        static void agregar(Orden p)
        {
            String query = "Insert into orden (IdOrden, Fecha_Recepcion, Tarea_Desarrollar, Tarea_Desarrollada, Precio, IdCliente, Completada) values (" + p.IdOrden + "," + p.FechaRecepcion + "," + p.TareaDesarrollar + "," + p.TareaDesarrollada + "," + p.Precio + "," + p.IdCliente + "," + p.Completada + ")";

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        static void eliminar(Orden p)
        {
            String query = "Delete from orden where IdOrden = " + p.IdOrden;

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        static void/*List<Orden>*/ ListarTodos(Orden p)
        {
            String query = "";

            Conexion conexion = new Conexion();
            conexion.QuerySelect(query);

        }
    }
}
