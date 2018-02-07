using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Net.Mime;
using System.Security.Principal;
using System.Text;

namespace AdminRights
{
    class Program
    {

        static void Main(string[] args)
        {
            WindowsPrincipal pricipal = new WindowsPrincipal(WindowsIdentity.GetCurrent());
            bool hasAdministrativeRight = pricipal.IsInRole(WindowsBuiltInRole.Administrator);

            Console.WriteLine("Am an Administrator ? " + hasAdministrativeRight);
            Console.ReadLine();
        }
    }
}
