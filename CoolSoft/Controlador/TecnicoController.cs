using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
