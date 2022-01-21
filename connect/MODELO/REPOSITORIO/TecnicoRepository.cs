using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class TecnicoRepository
    {
        static void agregar(Tecnico p)
        {
            String query = "Insert into Tecnico (dni) values (" + p.dni +")";

            Conexion conexion = new Conexion();
            //conexion.QueryInsert(query);
        }

        static void eliminar(Tecnico p)
        {
            String query = "Delete from Tecnico where dni = " + p.dni;

            Conexion conexion = new Conexion();
            //conexion.QueryInsert(query);
        }

        static void/*List<Persona>*/ ListarTodos(Tecnico p)
        {
            String query = "";

            Conexion conexion = new Conexion();
            conexion.QuerySelect(query);

        }
    }
}
