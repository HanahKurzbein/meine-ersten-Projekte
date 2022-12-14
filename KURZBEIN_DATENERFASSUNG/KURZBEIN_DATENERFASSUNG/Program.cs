using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KURZBEIN_DATENERFASSUNG
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main()                                              // Hier wird nichts(!) verändert...
        {
            Application.EnableVisualStyles();                           // ...Aufrufen von MainForm Form1...
            Application.SetCompatibleTextRenderingDefault(false);       // ...beim Start des Programms und...
            Application.Run(new Form1());                               // ...während das Programm läuft
        }
    }
}
