using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Inheritance
{
    using Common;

    public class Employee : Human
    {
        public double Salary { get; set; }

        public bool BuildCard()
        {
            if(Age >= 18 && Age <= 45)
            {
                Console.WriteLine("Card was built");
                Console.WriteLine("\tCard Information:");
                Console.WriteLine(ToString());

                return true;
            }

            Console.WriteLine("Card wasn't built");

            return false;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nAge: {Age}\nSalary: {Salary}\n";
        }
    }
}
