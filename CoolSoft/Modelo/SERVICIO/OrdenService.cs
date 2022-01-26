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
        static public bool Agregar(Orden o)
        {

            int idOrden = OrdenRepository.agregar(o);
            ParteOrdenRepository.agregar(new ParteOrden(idOrden, 1));

            return true;

        }

        static public bool Eliminar(Orden o)
        {
            if (OrdenRepository.BuscarUno(o.IdOrden))
            {
                OrdenRepository.eliminar(o);
                return true;
            }
            else
            {
                MessageBox.Show("La orden no existe");
                return false;
            }


        }


    }

    
}
