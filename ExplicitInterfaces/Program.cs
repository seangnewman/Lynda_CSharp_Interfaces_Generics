using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces
{

    class Program
    {
        static void Main(string[] args) {

            FooBar fb = new FooBar();
            fb.SomeMethod();

            IFoo ifoo = fb as IFoo;
            ifoo.SomeMethod();

            IBar ibar = fb as IBar;
            ibar.SomeMethod();

            Console.WriteLine("\nPress Enter key to continue...");
            Console.ReadLine();
        }
    }
}
