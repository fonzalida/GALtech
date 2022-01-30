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
        static public int Agregar(Cliente c)
        {

            
            return ClienteRepository.Agregar(c); //retornar la id de cliente

        }

        static public bool Eliminar(Cliente c)
        {

            return true;
        }

        static public void modificarCliente(Cliente c)
        {
               ClienteRepository.modificar(c,c);

        }

    }
}
