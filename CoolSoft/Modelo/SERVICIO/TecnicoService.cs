using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoolSoft.DATOS.ENTIDADES;
using CoolSoft.DATOS.REPOSITORIO;

namespace CoolSoft.DATOS.SERVICIO
{
    static class TecnicoService
    {
        static public bool Agregar(Tecnico t)
        {

            TecnicoRepository.agregar(t);
            return true;
        }

        static public bool Eliminar(Tecnico t)
        {
            if (TecnicoRepository.BuscarUno(t.dni))
            {
                TecnicoRepository.eliminar(t);
                return true;
            }
            else
            {
                MessageBox.Show("El tecnico no existe");
                return false;
            }

            
        }



    }
}
