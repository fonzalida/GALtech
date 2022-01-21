using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class MaterialRepository
    {
        static void agregar(Material p)
        {
            String query = "Insert into material (IdMat, IdOrden, Cantidad, Descripcion) values (" + p.IdMat + "," + p.IdOrden + "," + p.cantidad + "," + p.descripcion + ")";

            Conexion conexion = new Conexion();
            //conexion.QueryInsert(query);
        }

        static void eliminar(Material p)
        {
            String query = "Delete from material where IdMat = " + p.IdMat;

            Conexion conexion = new Conexion();
            //conexion.QueryInsert(query);
        }

        static void/*List<Material>*/ ListarTodos(Material p)
        {
            String query = "";

            Conexion conexion = new Conexion();
            conexion.QuerySelect(query);

        }
    }
}
