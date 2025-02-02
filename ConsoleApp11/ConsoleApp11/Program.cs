using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main()
        {
            int a = 100;
            int d = 50;
            int sum = 0;
            for (int i = 0; i < 10; i++)
            {
                sum = sum + a;
                Console.Write(a + " ");
                a = a + d;
            }
            Console.Write(", Сумма = " + sum + " рублей");
            Console.ReadLine();
        }
    }
}
