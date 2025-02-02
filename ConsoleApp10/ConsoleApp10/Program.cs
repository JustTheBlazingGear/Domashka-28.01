using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main()
        {
            int a = 1;
            int d = 4;
            int sum = 0;
            for (int i = 0; i < 5; i++)
            {
                sum = sum + a;
                Console.Write(a + " ");
                a = a + d;
            }
            Console.Write(", sum = " + sum);
            Console.ReadLine();
        }
    }
}
