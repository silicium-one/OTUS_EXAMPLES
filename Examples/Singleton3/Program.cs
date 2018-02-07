using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;

namespace Singleton3
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
/*        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }*/

        // This should all be refactored to make it less tightly-coupled, obviously.
        public static void Main(string[] args)
        {
          // Process the args.
          //<process args here>

          // Create the application base.
          MyWindowsApplicationBase appBase = new MyWindowsApplicationBase();

          // <1> Set the StartupNextInstance event handler.
            appBase.StartupNextInstance += (sender, eventArgs) =>
                {
                    MessageBox.Show("Not a single! " + args.Count());
                };

          // Show the main form of the app.
          appBase.Run(args);
        }
    }

    // This should all be refactored to make it less tightly-coupled, obviously.
    class MyWindowsApplicationBase : WindowsFormsApplicationBase
    {
        internal MyWindowsApplicationBase()
            : base()
        {
            // This is a single instance application.
            this.IsSingleInstance = true;

            // Set to the instance of your form to run.
            this.MainForm = new Form1();
        }
    }
}
