using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoolSoft.Controlador
{
    static class ClienteController
    {



        
        public static void Cargar(
            string DniCuit, 
            string Nombre, 
            string Domicilio,
            string Localidad, 
            string Provincia, 
            string Telefono1, 
            string Telefono2
            )
        {

            Cliente cliente = new Cliente();

            cliente.dniCuit = long.Parse(DniCuit);
            cliente.nombre = CG.EsNullOString(Nombre);
            cliente.domicilio = CG.EsNullOString(Domicilio);
            cliente.localidad = CG.EsNullOString(Localidad);
            cliente.provincia = CG.EsNullOString(Provincia);
            cliente.telefono1 = CG.EsNullOString(Telefono1);
            cliente.telefono2 = CG.EsNullOString(Telefono2);

            ClienteService.Agregar(cliente);

        }
    }
}
