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
            bool tx = false;
            Form1 f = new Form1();
            f.ShowDialog();
            //Inicio i = new Inicio(tx);
            //i.ShowDialog();
            //Menu f = new Menu();
            //f.ShowDialog();
            Application.Run();
        }
    }
}
