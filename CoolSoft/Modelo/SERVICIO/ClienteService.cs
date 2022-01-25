using CoolSoft.DATOS.ENTIDADES;
using CoolSoft.DATOS.REPOSITORIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.DATOS.SERVICIO
{
    static public class ClienteService
    {
        static public bool Agregar(Cliente c, List<Persona> ListaP)
        {

            
            int IdCliente = ClienteRepository.Agregar(c); //retornar la id de cliente

            foreach(Persona p in ListaP)
            {
                if(!PersonaRepository.BuscarUno(p.dni))
                    PersonaRepository.Agregar(p);

                TitularRepository.Agregar(new Titular(p.dni, IdCliente));
            }

            return true;
        }

    }
}
