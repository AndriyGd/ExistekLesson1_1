using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Interfaces
{
    public class Dog : Animal
    {
        public int Age { get; set; }
        public override string FullName => $"{base.FullName} {Age}";

        public Dog(string @class) : base(@class)
        {
        }
    }
}
