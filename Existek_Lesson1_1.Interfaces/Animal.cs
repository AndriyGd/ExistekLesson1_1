using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Interfaces
{
    public class Animal
    {
        public string Class { get;}
        public string Name { get; set; }
        public virtual string FullName => $"{Class} {Name}";

        public Animal(string @class)
        {
            Class = @class;
        }

        public virtual void Voice()
        {
            Console.WriteLine($"Gav-Gav-Gav");
        }
    }
}
