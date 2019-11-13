using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Inheritance
{
    using Common;

    public class HumanRepository
    {
        private readonly List<Human> _humans;

        public HumanRepository()
        {
            _humans = new List<Human>();
        }

        public void AddHuman(Human human)
        {
            _humans.Add(human);
        }

        public void PrintHumans()
        {
            _humans.ForEach(Console.WriteLine);
        }

        public Human GetHumanById(int id)
        {
            foreach (var human in _humans)
            {
                if (human.Id.Equals(id)) return human;
            }

            return null;
        }
    }
}
