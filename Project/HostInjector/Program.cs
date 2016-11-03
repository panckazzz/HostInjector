using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace HostInjector
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
            try
            {
                bool b2=System.IO.File.Exists("version.txt") ;
                bool b3 = Application.StartupPath.ToLower().Contains("visual studio") ;
                if (b2 ==false &&  b3==false)
                MessageBox.Show("This is beta version , you may encounter errors please report them to gersy.ch2@gmail.com"+Environment.NewLine+"This version also  does not support multiThreading so the tool may be slow due to your internet connection", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { }
            if (Application.StartupPath.Contains("Visual Studio")==false)
            try
            {
                System.IO.File.WriteAllText("version.txt", "Version:" + Program.version);
            }
            catch { }
            Application.Run(new FormMain());

            if (Application.StartupPath.ToLower().Contains(@"\bin\debug"))
            {
                string p2 = Application.StartupPath + @"\..\..\..\..\Host+injector_v"+Program.version+".exe";
                try
                {
                    System.IO.File.WriteAllBytes(p2, System.IO.File.ReadAllBytes(Application.ExecutablePath));
                }
                catch { }
            }
            else{
            System.Threading.Thread.Sleep(5000);
            System.Diagnostics.Process.Start("https://twitter.com/yassergersy");
            }
            
        }

        public static string version = "0.2.4"; 
    }
}
