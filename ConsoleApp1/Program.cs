using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();
            var cl = new ClassLibrary1.Class1();
            int a = 2;
            int b = 2;
            int c =cl.Method1(a, b);
            Console.WriteLine(c);
        }

    }
}
