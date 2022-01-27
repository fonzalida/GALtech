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


        static public void modificarOrden(Orden o, bool orden , ParteOrden p, TecnicoOrden t1, Tecnico t2, bool parte, bool tecnico)
        {
            // bool orden si modifico orden 
            // bool parte si modifico o no la parte 
            // bool tecnico si modifico el tecnico
            if (orden)
                OrdenRepository.modificar(o);
            if (parte)
                ParteOrdenRepository.modificar(p);
            if (tecnico)
                TecnicoOrdenRepository.modificar(t2, t1);

        }

      

       


    }

    
}
