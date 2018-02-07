using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace Singleton2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (Process.GetProcesses().Count(x => x.ProcessName == Process.GetCurrentProcess().ProcessName) > 1)
                Process.GetCurrentProcess().Kill(); //Console.WriteLine("I'm a married!"); //
            else 
                Console.WriteLine("I'm a single!");
            Console.ReadLine();
        }
    }
}
