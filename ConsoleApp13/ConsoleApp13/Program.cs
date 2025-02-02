using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main()
        {
            double a = 10;
            double d = 0.1;
            double sum = 10;
            int i = 0;
            int x1 = 0;
            int x2 = 0;
            for (i = 0; i <= 10; i++)
            {
                Console.WriteLine($"День {i} - {a:F2} км");
                if (a >= 20 & x1 == 0)
                {
                    Console.WriteLine($"В {i} день лыжник прошёл 20 км за день.");
                    x1 = 1;
                }
                if (sum >= 100 & x2 == 0)
                {
                    Console.WriteLine($"В {i} день лыжник прошёл 100 км за этот и прошлые дни ({sum:F2} км).");
                    x2 = 1;
                }
                a = a * (1 + d);
                sum = sum + a;
            }
            Console.ReadLine();
        }
    }
}
