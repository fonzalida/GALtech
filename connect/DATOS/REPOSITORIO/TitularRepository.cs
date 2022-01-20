using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class TitularRepository
    {
        static void agregar(Titular p)
        {
            String query = "Insert into Titular (dni, IdCliente) values (" + p.dni + "," + p.IdCliente+")";

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        static void eliminar(Titular p)
        {
            String query = "Delete from Titular where dni = " + p.dni;

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        static void/*List<Persona>*/ ListarTodos(Titular p)
        {
            String query = "";

            Conexion conexion = new Conexion();
            conexion.QuerySelect(query);

        }
    }
}
