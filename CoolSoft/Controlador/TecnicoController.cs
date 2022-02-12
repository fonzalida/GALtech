using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.Controlador
{
    static class TecnicoController
    {

        public static void Cargar(
            string Dni,
            string Nombre,
            string Telefono
            )

        {
            Tecnico tecnico = new Tecnico();

            tecnico.dni = int.Parse(Dni);
            tecnico.nombre = CG.EsNullOString(Nombre);
            tecnico.telefono = CG.EsNullOString(Telefono);

            TecnicoService.Agregar(tecnico);
        }



        public static void Modificar(
            string Dni,
            string Nombre,
            string Telefono
            )
        {
            
            Tecnico tecnico = new Tecnico();

            tecnico.dni = int.Parse(Dni);
            tecnico.nombre = CG.EsNullOString(Nombre);
            tecnico.telefono = CG.EsNullOString(Telefono);

            TecnicoService.Modificar(tecnico);
        }


        public static Tecnico DataGridViewToTecnico(DataGridViewCellCollection dr)
        {

            //foreach (DataGridViewCell cell in dr)
            //{
            //    Debug.WriteLine(cell.Value.ToString());
            //}


            Tecnico tecnico = new Tecnico();

            tecnico.dni = int.Parse(dr[0].Value.ToString());
            tecnico.nombre = dr[1].Value.ToString();
            tecnico.telefono = dr[2].Value.ToString();
            

            return tecnico;


        }

        public static void Eliminar(
            string Dni
            )
        {
            Tecnico tecnico = new Tecnico();

            tecnico.dni = int.Parse(Dni);

            TecnicoService.Eliminar(tecnico);

        }


    }
}
