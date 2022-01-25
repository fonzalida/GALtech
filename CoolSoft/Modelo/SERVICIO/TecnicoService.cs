using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoolSoft.DATOS.ENTIDADES;
using CoolSoft.DATOS.REPOSITORIO;

namespace CoolSoft.DATOS.SERVICIO
{
    static class TecnicoService
    {
        static public bool Agregar(Tecnico t, List<Persona> ListaP)
        {


            foreach (Persona p in ListaP)
            {
                if (!PersonaRepository.BuscarUno(t.dni))
                    PersonaRepository.Agregar(p);

                TecnicoRepository.agregar(new Tecnico(t.dni));
            }

            return true;
        }

        static public bool Eliminar(Tecnico t, List<Persona> ListaP)
        {


            foreach (Persona p in ListaP)
            {
                if (!PersonaRepository.BuscarUno(t.dni))
                    //PersonaRepository.eliminar(p); 
                    
              TecnicoRepository.eliminar(t);

            }

            return true;
        }

    }
}
