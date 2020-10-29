using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;

namespace Interfez
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ConexionGeneral cg = new ConexionGeneral();
            cg.DBCreator();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Inicio i = new Inicio();
            i.ShowDialog();
            Application.Run();
        }
    }
}
