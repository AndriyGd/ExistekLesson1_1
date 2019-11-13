using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Inheritance
{
    using Common;

    class Program
    {
        static void Main(string[] args)
        {
            var repos = new HumanRepository();

            var emp = new Employee
            {
                Name = "John",
                Salary = 5690,
                Age = 27
            };
            var emp2 = new Employee
            {
                Age = 50,
                Name = "Tom",
                Salary = 7900
            };
            if (emp.BuildCard())
            {
                repos.AddHuman(emp);
            }
            if (emp2.BuildCard())
            {
                repos.AddHuman(emp2);
            }

            Console.WriteLine("--------");
            repos.PrintHumans();

            var mn1 = new Manager(150.78)
            {
                Age = 29,
                Name = "Victor",
                CountEmployees = 5
            };

            repos.AddHuman(mn1);
            repos.AddHuman(new Manager(230.56)
            {
                Age = 30,
                Name = "Olga",
                CountEmployees = 14
            });

            Console.WriteLine("--------");
            repos.PrintHumans();

            Employee e = (Employee)repos.GetHumanById(11);
            Manager m = repos.GetHumanById(3) as Manager;

            if (repos.GetHumanById(4) is Manager man)
            {
                Console.WriteLine(man.Age);
            }
            else
            {
                Console.WriteLine("Manager does not exist!");
            }

            try
            {
                if(e == null) throw new HumanDoesNotExistException(11);
                Console.WriteLine(e.Name);
            }
            catch (NullReferenceException nX)
            {
                Console.WriteLine("Human does not exist!!!");
            }
            catch (HumanDoesNotExistException hE)
            {
                Console.WriteLine(hE.Message);
                //TODO .....
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally Code");
            }

            Console.ReadLine();
        }        
    }
}
