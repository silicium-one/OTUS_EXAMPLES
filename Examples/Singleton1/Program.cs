using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Singleton1
{
    class Program
    {
        static bool IsSingleInstance()
        {
            bool flag;
            Mutex mutex = new Mutex(true, "MY_UNIQUE_MUTEX_NAME", out flag);
            return flag;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("I'm a single? " + IsSingleInstance());
            Console.ReadLine();
            Console.WriteLine("I'm a single? " + IsSingleInstance());
            Console.ReadLine();
        }
    }
}
