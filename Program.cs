using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjercicioClinica
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // CAMBIA ESTA LÍNEA:
            Application.Run(new FrmDetalleHistoriaClinica());

            // Antes estaba: Application.Run(new Menu());
            // Application.Run(new Menu());
        }
    }
}
