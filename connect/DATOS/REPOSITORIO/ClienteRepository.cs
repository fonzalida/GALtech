using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class ClienteRepository
    {
        static void agregar(Cliente p)
        {
            String query = "Insert into Persona (IdCliente, nombre, domicilio, telefono) values ("+p.IdCliente+","+p.nombre+ "," +p.Domicilio+ "," +p.Telefono+")";

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        static void eliminar(Cliente p)
        {
            String query = "Delete from Persona where dni = " + p.IdCliente;

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query);
        }

        static void/*List<Persona>*/ ListarTodos(Cliente p)
        {
            String query = "";

            Conexion conexion = new Conexion();
            conexion.QuerySelect(query);

        }
    }
}
