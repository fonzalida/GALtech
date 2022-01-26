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
            ParteOrdenRepository.agregar(new Parte_Orden(idOrden, 1));

            return true;

        }


    }
}
