using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Interfaces
{
    public class Cat : Animal
    {
        public Cat(string @class) : base(@class)
        {
        }

        public override void Voice()
        {
            Console.WriteLine("Miav-Miav-Miav");
        }
    }
}
