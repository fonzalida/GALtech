using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class TecnicoOrdenRepository
    {
        static void agregar(Tecnico_Orden p)
        {
            String query = "Insert into tecnicoorden (dni, idp, id) values (" + p.dni + "," + p.idp + "," + p.id + ")";

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        static void eliminar(Tecnico_Orden p)
        {
            String query = "Delete from tecnicoorden where dni = " + p.dni;

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        static void/*List<Tecnico_Orden>*/ ListarTodos(Tecnico_Orden p)
        {
            String query = "";

            Conexion conexion = new Conexion();
            conexion.QuerySelect(query);

        }
    }
}
