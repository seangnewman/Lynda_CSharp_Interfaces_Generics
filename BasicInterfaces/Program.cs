using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicInterfaces
{


    class Program
    {
        static void Main(string[] args) {
            Document d = new Document("Test Document");
            d.Save();
            d.Load();
            d.NeedsSave = false;

            Console.WriteLine("\nPress Enter to continue...");
            Console.ReadLine();
        }
    }
}
