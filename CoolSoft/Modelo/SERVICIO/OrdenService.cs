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
    static public class OrdenService
    {
        static public bool Agregar(Orden o, Cliente c)
        {
             int id = c.IdCliente;
            if (!ClienteRepository.BuscarUno(c.IdCliente))
            {
                int IdCliente = ClienteRepository.Agregar(c); //retornar la id de cliente
                id = IdCliente;


            }

            OrdenRepository.agregar(new Orden(o.IdOrden, id));
            ParteOrdenRepository.agregar(new Parte_Orden( id));


            return true;
            



        }


    }
}
