using CoolSoft.Vista;
using CoolSoft.Vista.Herencia;
using CoolSoft.VISTA;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace connect
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Form1());
            //Application.Run(new Test());
            //Application.Run(new Detalles());

            Application.Run(new FormularioPrincipal());




            //Application.Run(new FormPresentacion());
        }
    }
}
