using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.REPOSITORIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.Modelo.SERVICIO
{
    static public class OrdenService
    {
        static public int Agregar<T>(T objeto)
        {
            if (objeto is Orden)
            {
                int idOrden = OrdenRepository.agregar(objeto as Orden);
                ParteOrdenRepository.agregar(new ParteOrden(idOrden));

                return idOrden;
            }


            else if (objeto is ParteOrden)
            {
                ParteOrdenRepository.agregar(objeto as ParteOrden);
            }


            else if (objeto is TecnicoOrden)
            {
                if(!TecnicoOrdenRepository.BuscarUno(objeto as TecnicoOrden))
                {
                    TecnicoOrdenRepository.agregar(objeto as TecnicoOrden);
                    
                }
                else
                {
                    MessageBox.Show("El tecnico ya se encuentra asociado a este trabajo");
                    return 0;
                }
                
            }


            else if (objeto is Material)
            {
                MaterialRepository.agregar(objeto as Material);
               
            }

            return -1;

        }

        static public void Eliminar<T>(T objeto)
        {
            if (objeto is Orden)
                OrdenRepository.eliminar(objeto as Orden);

            else if (objeto is ParteOrden)
                ParteOrdenRepository.eliminar(objeto as ParteOrden);

            else if (objeto is TecnicoOrden)
                TecnicoOrdenRepository.eliminar(objeto as TecnicoOrden);

            else if (objeto is Material)
                MaterialRepository.eliminar(objeto as Material);
        }


        static public void modificar<T>(T objetoViejo, T objectoNuevo)
        {
            
            if (objetoViejo is Orden)
                OrdenRepository.modificar(objetoViejo as Orden, objectoNuevo as Orden);

            else if (objetoViejo is ParteOrden)
                ParteOrdenRepository.modificar(objetoViejo as ParteOrden, objectoNuevo as ParteOrden);

            else if (objetoViejo is TecnicoOrden)
                TecnicoOrdenRepository.modificar(objetoViejo as TecnicoOrden, objectoNuevo as Tecnico);

            else if(objetoViejo is Material)
                MaterialRepository.modificar(objetoViejo as Material, objectoNuevo as Material);

        }




    }

    
}
