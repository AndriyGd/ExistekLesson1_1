using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 78;
            Int32 b = 100;
            var c = 89;

            Console.WriteLine($"A = {a}");
            Console.WriteLine($"B = {b}");
            Console.WriteLine(c);

            a = 129;
            Console.WriteLine($"A = {a}");

            float f = 56.92f;
            double d = 129.7341774256;

            Console.WriteLine($"F = {f}");
            Console.WriteLine($"D = {d}");
            float fg = f + 23.89f;

            Console.WriteLine(fg);

            Console.ReadLine();
        }
    }
}
