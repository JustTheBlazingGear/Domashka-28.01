using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main()
        {
            double a = -200;
            double d = 0.2;
            for (int i = 0; i < 150; i++)
            {
                Console.WriteLine(a + " ");
                a = a + d;
            }
            Console.ReadLine();
        }
    }
}
