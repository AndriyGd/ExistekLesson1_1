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
#if false
            int a = 78;
            Int32 b = 100;
            var c = 89;

            //Console.WriteLine($"A = {a}");
            //Console.WriteLine($"B = {b}");
            //Console.WriteLine(c);

            a = 129;
            //Console.WriteLine($"A = {a}");

            float f = 56.92f;
            double d = 129.7358774256;

            Console.WriteLine($"F = {f}");
            Console.WriteLine($"D = {d:N}");
            float fg = f + 23.89f;

            //Console.WriteLine(fg);
            //Console.WriteLine($"{DateTime.Now:dd.MM.yyyy  H:m}");
            //Console.WriteLine(DateTime.Now.ToString("dddd MM.yyyy  H:m"));

            bool b1 = true;
            bool b2 = false;

            bool b3 = a > b;
            bool b4 = f == fg;
            bool b5 = f != fg;

            Guid id = Guid.NewGuid();

            //Console.WriteLine($"B1: {b1}; B2: {b2}; B3: {b3}; B4: {b4}; B4: {b5}");
            //Console.WriteLine($"ID: {id}");

            object obj = "Lesson 2";

            Console.WriteLine(obj);
            obj = a; //Boxing

            Console.WriteLine(obj);

            int ac = (int)obj; //unboxing
            Console.WriteLine(ac);

            obj = 789.8;

            if (obj is int)
            {
                int x = (int)obj;
                x += 100;

                Console.WriteLine(x);
            }
            else
            {
                Console.WriteLine(obj);
            }

            Run(TypeOs.Windows);
            RunS(TypeOs.Linux); 
#endif

#if false
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello {name}!!!");

            Console.Write("Enter first number: ");
            var aStr = Console.ReadLine();
            var a = int.Parse(aStr);

            Console.Write("Enter second number: ");
            aStr = Console.ReadLine();
            if (int.TryParse(aStr, out int b))
            {
                var sum = a + b;
                Console.WriteLine($"Sum = {sum}");
            }
            else
            {
                Console.WriteLine("User Invalid!!");
            } 
#endif
            var n = 5;
            var rn = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Rn = {rn.Next(500)}");
            }

            var c = "";

            while (c != "Q")
            {
                Console.WriteLine("Hello!");
                Console.WriteLine("Press 'Q' to Exit");
                c = Console.ReadLine();
            }

            var str = "Hello World!!";

            foreach (var ch in str)
            {
                Console.WriteLine(ch);
            }

            Console.ReadLine();
        }

        private static void Run(TypeOs typeOs)
        {
            if (typeOs == TypeOs.Android)
            {
                Console.WriteLine("Welcome to Android");
            }
            else if(typeOs == TypeOs.Windows)
            {
                Console.WriteLine("Hello! Welcome to Windows");
            }
            else if(typeOs == TypeOs.Linux)
            {
                
            }
        }

        private static void RunS(TypeOs typeOs)
        {
            switch (typeOs)
            {
                case TypeOs.Windows:
                    Console.WriteLine("Hello! Welcome to Windows");
                    break;
                case TypeOs.Linux:
                    Console.WriteLine("Hello! Welcome to Linux World");
                    break;
                case TypeOs.iOS:
                    break;
                case TypeOs.Android:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(typeOs), typeOs, null);
            }
        }
    }

    enum TypeOs
    {
        Windows, Linux, iOS, Android
    }
}
