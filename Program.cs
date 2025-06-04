using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PandaModTools
{
    internal static class Program
    {
        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        static void Main(String[] args)
        {
          // bash command: 
          // mcs -out:PandaModTools.exe -r:System.Windows.Forms.dll -r:System.Data.dll -r:System.Drawing.dll Program.cs Form1.cs Form1.Designer.cs && mono PandaModTools.exe
            Console.WriteLine("--- PandaModTools ---");

            if (args.Length == 0)
            {
              Application.EnableVisualStyles();
              Application.SetCompatibleTextRenderingDefault(false);
              Application.Run(new Form1());
            } else {
              Console.WriteLine("--- DEVELOPER-Mode ---");
              Console.WriteLine($"--- ARGUMENTS [{args.Length}]: {string.Join(", ", args)}");
            }
        }
    }
}
