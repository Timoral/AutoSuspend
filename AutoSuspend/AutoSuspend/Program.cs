using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSuspend
{
    static class Program
    {
        private static string timeToLive;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            timeToLive = "120";
            try
            {
                timeToLive = args[0];
            }
            catch (IndexOutOfRangeException) { }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(timeToLive));
        }
    }
}
