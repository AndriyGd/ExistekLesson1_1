using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Interfaces
{
    public class AnimalRepository
    {
        private readonly List<Animal> _animals;

        public AnimalRepository()
        {
            _animals = new List<Animal>();
        }

        public void AddAnimal(Animal animal)
        {
            _animals.Add(animal);
        }

        public void VoiceAll()
        {
            _animals.ForEach(a =>
            {
                Console.WriteLine($"Full Name: {a.FullName}");
                a.Voice();
            });
        }
    }
}
