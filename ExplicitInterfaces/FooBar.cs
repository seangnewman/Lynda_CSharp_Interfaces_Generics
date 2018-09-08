using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExplicitInterfaces
{
    class FooBar: IFoo, IBar
    {
        void IFoo.SomeMethod()
        {
            Console.WriteLine("This is IFoo's SomeMethod");
        }

        void IBar.SomeMethod()
        {
            Console.WriteLine("This is IBar's SomeMethod");
        }

        public void SomeMethod()
        {
            Console.WriteLine("This is the class SomeMethod");
        }

    }
}
