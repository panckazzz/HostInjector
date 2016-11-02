using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace HostInjector
{
    public class MyHeaderCollection : WebHeaderCollection
    {
        public new void Set(string name, string value)
        {
            AddWithoutValidate(name, value);
        }
        //or
        public new string this[string name]
        {
            get { return base[name]; }
            set { AddWithoutValidate(name, value); }
        }
    }
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
                if (System.IO.File.Exists("version.txt") == false && Application.StartupPath.Contains("visual studio") == false)
                MessageBox.Show("This is beta version , you may encounter errors please report them to gersy.ch2@gmail.com"+Environment.NewLine+" , and it does not support multiThreading so the tool may be slow due to your internet connection", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch { } Application.Run(new FormMain());
            
            if (Application.StartupPath.Contains("Visual Studio"))
                return;
            try
            {
                System.IO.File.WriteAllText("version.txt", "Version:"+Program.version);
            }
            catch { }
        }

        public static string version = "0.1"; 
    }
}
