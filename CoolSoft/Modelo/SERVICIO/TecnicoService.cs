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
        static public int Agregar(Tecnico t)
        {
            if (!TecnicoRepository.BuscarUno(t.dni))
            {
                TecnicoRepository.agregar(t);
            }
            else
            {
                MessageBox.Show("El técnico ya se encuentra cargado");
                
            }

            return t.dni;

            
        }

        static public void Modificar(Tecnico viejo, Tecnico nuevo)
        {
            TecnicoRepository.modificar(viejo, nuevo);
        }

        static public void Eliminar(Tecnico t)
        {
                TecnicoRepository.eliminar(t);     
        }



    }
}
