using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

#if false
            var repos = new AnimalRepository();
            Cat cat = new Cat("Cat")
            {
                Name = "Ghlp"
            };
            var fox = new Fox("Fox")
            {
                Name = "Gol"
            };
            var dog = new Dog("Хаскі")
            {
                Name = "Люсі",
                Age = 1
            };
            Console.WriteLine(dog.Name);
            var a = new Animal("Abcd")
            {
                Name = "XdfJ"
            };

            //fox.Voice();
            repos.AddAnimal(a);
            repos.AddAnimal(cat);
            repos.AddAnimal(fox);
            repos.AddAnimal(dog);

            repos.VoiceAll(); 
#endif
            var helper = new ServiceHelper();

            var google = new GoogleService();
            var oneDrive = new OneDriveService();
            helper.AddService(google);
            helper.AddService(oneDrive);

            helper.Upload("Lesson1.cs");
            helper.Download("Lesson2.cs");

            Console.ReadLine();
        }
    }
}
