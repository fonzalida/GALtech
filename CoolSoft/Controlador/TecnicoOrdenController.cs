using CoolSoft.Modelo.ENTIDADES;
using CoolSoft.Modelo.REPOSITORIO;
using CoolSoft.Modelo.SERVICIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoolSoft.Controlador
{
    class TecnicoOrdenController
    {
        public static void Cargar(
           string Dni,
           string idParte
           )

        {

           //TecnicoOrdenRepository.BuscarUno(int.Parse(Dni), int.Parse(idParte));
            
            
                TecnicoOrden tecnico = new TecnicoOrden();

                tecnico.dni = int.Parse(Dni);
                tecnico.idParte = int.Parse(idParte);
                

                OrdenService.Agregar(tecnico);
        }



        public static void Modificar(
            string Dni,
            TecnicoOrden viejo
            )
        {

            TecnicoOrden tecnico = new TecnicoOrden();

            tecnico.dni = int.Parse(Dni);
            

            OrdenService.modificar(viejo, tecnico);
        }


        public static TecnicoOrden DataGridViewToTecnico(DataGridViewCellCollection dr)
        {

            //foreach (DataGridViewCell cell in dr)
            //{
            //    Debug.WriteLine(cell.Value.ToString());
            //}


            TecnicoOrden tecnico = new TecnicoOrden();

            tecnico.dni = int.Parse(dr[0].Value.ToString());
            tecnico.idParte = int.Parse(dr[1].Value.ToString());


            return tecnico;


        }

        public static void Eliminar(
            DataGridViewCellCollection dr
            )
        {
            TecnicoOrden tecnico = new TecnicoOrden();

            tecnico.dni = int.Parse(dr["Dni"].Value.ToString());
            tecnico.idParte = int.Parse(dr["IdParte"].Value.ToString());

            OrdenService.Eliminar(tecnico);

        }
    }
}
