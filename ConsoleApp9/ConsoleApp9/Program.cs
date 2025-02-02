using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main()
        {
            int a = 1;
            int d = 4;
            for (int i = 0; i < 5; i++)
            {
                Console.Write(a + " ");
                a = a + d;
            }
            Console.ReadLine();
        }
    }
}
