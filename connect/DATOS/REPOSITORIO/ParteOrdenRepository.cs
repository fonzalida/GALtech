using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class ParteOrdenRepository
    {
        static void agregar(Parte_Orden p)
        {
            String query = "Insert into parteorden (idp, id, fechainicio, fechafin, completa) values (" + p.IdP + "," + p.Id + "," + p.FechaInicio + "," + p.FechaFin + "," + p.Completa + ")";

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        static void eliminar(Parte_Orden p)
        {
            String query = "Delete from parteorden where IdP = " + p.IdP;

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        static void/*List<Parte_Orden>*/ ListarTodos(Parte_Orden p)
        {
            String query = "";

            Conexion conexion = new Conexion();
            conexion.QuerySelect(query);

        }
    }
}
