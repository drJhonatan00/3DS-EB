using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp10
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string pokaYoke = @"WindowsFormsApp10.pdb.config";
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string alpha = File.ReadAllText(pokaYoke);
            if(alpha == "watashi wa watashi sore dake")
            {
                Application.Run(new Form3());
            }
            else
            {
                Application.Run(new Form1());
            }
            
        }
    }
}
