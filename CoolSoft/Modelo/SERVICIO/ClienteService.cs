﻿using CoolSoft.DATOS.ENTIDADES;
using CoolSoft.DATOS.REPOSITORIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.DATOS.SERVICIO
{
    static public class ClienteService
    {
        static public bool Agregar(Cliente c, Persona p)
        {

            int i;
            ClienteRepository.agregar(c); //retornar la id de cliente

            

            PersonaRepository.agregar(p);

            Titular t = new Titular();
            t.dni = p.dni;
            t.IdCliente = c.IdCliente;
            TitularRepository.agregar(t);

            return true;
        }

    }
}
