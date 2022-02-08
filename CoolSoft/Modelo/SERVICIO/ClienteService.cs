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
    static public class ClienteService
    {
        static public int Agregar(Cliente c)
        {
            if (!ClienteRepository.BuscarUno(c.dniCuil))
            {
                return ClienteRepository.Agregar(c); //retornar la id de cliente
            }
            else
            {
                MessageBox.Show("El dni/cuit del cliente ya se encuentra cargado");
                
            }
            return -1;


        }

        //static public bool Eliminar(Cliente c)
        //{
        //    return true;
        //}

        static public void modificarCliente(Cliente modificado)
        {
               ClienteRepository.modificar(modificado,modificado);
        }

    }
}
