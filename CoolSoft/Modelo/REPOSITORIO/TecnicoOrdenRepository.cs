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
        static public void agregar(TecnicoOrden p)
        {
            //String query = "Insert into tecnicoorden (dni, idp, id) values (" + p.dni + "," + p.idp + "," + p.id + ")";

            MySqlCommand cmd = new MySqlCommand(
                            "INSERT INTO TECNICOORDEN" +
                             "(Dni, IdP, Id)" +
                             " VALUES (@Dni, @IdP, @Id)"
                             );

            cmd.Parameters.AddWithValue("@Dni", p.dni);
            cmd.Parameters.AddWithValue("@IdP", p.idParte);
            cmd.Parameters.AddWithValue("@Id", p.idOrden);

            Conexion conexion = new Conexion();
            conexion.QueryInsertDeleteUpdate(cmd);
        }

        static public void eliminar(TecnicoOrden p)
        {
            Conexion conexion = new Conexion();

            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM TECNICOORDEN " +
                "where Dni = @Dni and Idp = @IdP and Id = @Id"
                );

            cmd.Parameters.AddWithValue("@Dni", p.dni);
            cmd.Parameters.AddWithValue("@IdP", p.idParte);
            cmd.Parameters.AddWithValue("@Id", p.idOrden);

            conexion.QueryInsertDeleteUpdate(cmd);
        }

        public static bool BuscarUno(int dni, int IdP, int Id)
        {
            String query = "SELECT * FROM TECNICOORDEN WHERE dni = \"" + dni + "\" and IdP = \"" + IdP + "\" and Id = \"" + Id + "\"";

            Conexion conexion = new Conexion();
            if (conexion.QuerySelect(query).Rows.Count == 1)
                return true;
            else
                return false;

        }

        public static DataTable/*List<Tecnico_Orden>*/ ListarTodos()
        {
            String query = "SELECT * FROM TECNICOORDEN";

            Conexion conexion = new Conexion();
            return conexion.QuerySelect(query);

        }
    }
}
