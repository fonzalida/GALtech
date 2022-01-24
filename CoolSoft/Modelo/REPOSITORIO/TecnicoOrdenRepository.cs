using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;
using System.Data;
using MySql.Data.MySqlClient;

namespace CoolSoft.DATOS.REPOSITORIO
{
    static class TecnicoOrdenRepository
    {
        static public void agregar(Tecnico_Orden p)
        {
            //String query = "Insert into tecnicoorden (dni, idp, id) values (" + p.dni + "," + p.idp + "," + p.id + ")";

            MySqlCommand cmd = new MySqlCommand(
                            "INSERT INTO TECNICOORDEN" +
                             "(Dni, IdP, Id)" +
                             " VALUES (@Dni, @IdP, @Id)"
                             );

            cmd.Parameters.AddWithValue("@Dni", p.dni);
            cmd.Parameters.AddWithValue("@IdP", p.idp);
            cmd.Parameters.AddWithValue("@Id", p.id);

            Conexion conexion = new Conexion();
            conexion.QueryInsert(cmd);
        }

        static public void eliminar(Tecnico_Orden p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM TECNICOORDEN " +
                "where Dni = @Dni"
                );

            cmd.Parameters.AddWithValue("@Dni", p.dni);

            conexion.QueryInsert(cmd);
        }

        public static DataTable/*List<Tecnico_Orden>*/ ListarTodos()
        {
            String query = "SELECT * FROM TECNICOORDEN";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
