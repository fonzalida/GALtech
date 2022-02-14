using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.SERVICIO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        public static void Modificar(
            string DniCuit,
            string Nombre,
            string Domicilio,
            string Localidad,
            string Provincia,
            string Telefono1,
            string Telefono2, 
            int IdCliente
            )
        {
            Cliente cliente = new Cliente();

            cliente.idCliente = IdCliente;
            cliente.dniCuit = long.Parse(DniCuit);
            cliente.nombre = CG.EsNullOString(Nombre);
            cliente.domicilio = CG.EsNullOString(Domicilio);
            cliente.localidad = CG.EsNullOString(Localidad);
            cliente.provincia = CG.EsNullOString(Provincia);
            cliente.telefono1 = CG.EsNullOString(Telefono1);
            cliente.telefono2 = CG.EsNullOString(Telefono2);

            ClienteService.modificarCliente(cliente);

        }

        /* public static void Eliminar(
             string DniCuit
             )
         {
             Cliente cliente = new Cliente();

             cliente.dniCuit = long.Parse(DniCuit);

             ClienteService.Eliminar(cliente);

         }*/


        public static Cliente DataGridViewToCliente(DataGridViewCellCollection dr)
        {

            //foreach (DataGridViewCell cell in dr)
            //{
            //    Debug.WriteLine(cell.Value.ToString());
            //}

            Cliente cliente = new Cliente();

            cliente.idCliente = int.Parse(dr[0].Value.ToString());
            cliente.dniCuit = long.Parse(dr[1].Value.ToString());
            cliente.nombre = dr[2].Value.ToString();
            cliente.domicilio = dr[3].Value.ToString();
            cliente.localidad = dr[4].Value.ToString();
            cliente.provincia = dr[5].Value.ToString();
            cliente.telefono1 = dr[6].Value.ToString();
            cliente.telefono2 = dr[7].Value.ToString();

            return cliente;


        }
    }
}
