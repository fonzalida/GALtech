using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;

namespace CoolSoft.DATOS.REPOSITORIO
{

    static class PersonaRepository
    {
        static void agregar(Persona p)
        {
            String query = "Insert into Persona (dni, nombre, apellido) values ("p.dni+","+p.nombre+","+p.apellido+")";

            Conexion conexion = new Conexion();
            conexion.QueryInsert(query); 
        }

        static void eliminar(Persona p)
        {
            String query = "Delete from Persona where dni = "+p.dni;

            Conexion conexion=new Conexion();
            conexion.QueryInsert(query);
        }

        static List<Persona> ListarTodos(Persona p)
        {
            String query = "";

            Conexion conexion=new Conexion();
            conexion.QuerySelect(query);
        }
    }
}
