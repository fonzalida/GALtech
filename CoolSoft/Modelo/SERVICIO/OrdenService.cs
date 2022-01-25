using CoolSoft.DATOS.ENTIDADES;
using CoolSoft.DATOS.REPOSITORIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.DATOS.SERVICIO
{
    static public class OrdenService
    {
        static public bool Agregar(Orden p, Cliente c)
        {

            if (!PersonaRepository.BuscarUno(p.dni))
                PersonaRepository.Agregar(p);

            if (TecnicoRepository.BuscarUno(p.dni))
            {
                MessageBox.Show("El tecnico ya se encuentra cargado");
                return false;
            }
            else
            {
                TecnicoRepository.agregar(new Tecnico(p.dni));
                return true;
            }



        }


    }
}
