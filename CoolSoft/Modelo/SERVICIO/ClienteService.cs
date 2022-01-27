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

        static public bool Eliminar(Cliente c)
        {

            return true;
        }

        static public void modificarCliente(Cliente c ,bool cliente , bool persona , bool titular , Titular t , Titular tn ,Persona p ,Persona pn )
        {
            // bool orden si modifico orden 
            
            if (cliente)
                ClienteRepository.modificar(c,c);
            if (persona)
                PersonaRepository.modificar(p,pn);
            if (titular)
                TitularRepository.modificar(t, tn);

        }

    }
}
