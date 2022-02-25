using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.REPOSITORIO;

namespace CoolSoft.Modelo.SERVICIO
{
    static class TecnicoService
    {
        static public int Agregar(Tecnico t)
        {
            if (!TecnicoRepository.BuscarUno(t.dni))
            {
                TecnicoRepository.Agregar(t);
            }
            else
            {
                MessageBox.Show("El técnico ya se encuentra cargado");
                
            }
            return t.dni; 
        }

        static public void Modificar(Tecnico viejo, Tecnico modificado)
        {
            TecnicoRepository.modificar(viejo, modificado);
        }


        static public void Eliminar(Tecnico t)
        {
                TecnicoRepository.Eliminar(t);     
        }



    }
}
