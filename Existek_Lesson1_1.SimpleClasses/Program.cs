using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.SimpleClasses
{
    using System.Collections;
    using static IdHelper;

    class Program
    {
        static void Main(string[] args)
        {
            var department = new Department();

            department.AddEmployee(new Employee("John", 24));
            department.AddEmployee(new Employee("Viktor", 25));
            department.AddEmployee(new Employee("Olga", 24));
            department.AddEmployee(new Employee("Tom", 28));
            department.AddEmployee(new Employee(28)
            {
                Name = "Igor"
            });
            Console.WriteLine(department.GetEmployeeBy(5));

            var em = department.GetEmployeeBy(2);
            Console.WriteLine(em.Name);

            foreach (var employee in department)
            {
                Console.WriteLine(employee);
            }

            Console.WriteLine();

            Console.WriteLine($"Count Employees: {department.CountEmployees}");

            Console.WriteLine(department[4]);

            department[4] = new Employee(31)
            {
                Name = "Petro"
            };

            Console.WriteLine(department[4]);

            Console.ReadLine();
        }
    }

    public static class IdHelper
    {
        private static int _idCounter;

        public static int GetNextId()
        {
            return ++_idCounter;
        }
    }

    class Employee
    {
        public string Name { get; set; }
        private readonly int _age = 0;
        private const string Position = "QA";

        public int Id { get; } = GetNextId();

        public Employee() : this("John", 18)
        {
            //Console.WriteLine("Object was created");
            //Position = "FDFd";
        }

        public Employee(int age)
        {
            _age = age;
        }

        public Employee(string name, int age)
        {
            Name = name;
            _age = age;

            //Console.WriteLine($"Name: {_name}\nAge: {_age}");
        }

        public void ChangeName(string name)
        {
            //_name = name; //readonly поле можна просвоїти значення підчас оголошення або в конструкторі
        }

        public override string ToString()
        {
            return $"Name: {Name}\nAge: {_age}\nId: {Id}\n";
        }
    }

    class Department : IEnumerable<Employee>
    {
        #region Class Fields

        private readonly List<Employee> _employees;
        #endregion

        #region Class Properties

        public int CountEmployees => _employees.Count;
        public int NumbersOfEmployee
        {
            get { return _employees.Count; }
        }

        public Employee this[int id]
        {
            get { return GetEmployeeBy(id); }
            set
            {
                for (int i = 0; i < _employees.Count; i++)
                {
                    if (_employees[i].Id == id)
                    {
                        _employees[i] = value;
                        break;
                    }
                }
            }
        }
        #endregion

        #region Class Constructors

        public Department()
        {
            _employees = new List<Employee>();
        }
        #endregion

        #region Class Methods

        public void AddEmployee(Employee employee)
        {
            _employees.Add(employee);
        }

        public Employee GetEmployeeBy(int id)
        {
            foreach (var employee in _employees)
            {
                if (employee.Id == id) return employee;
            }

            return null;
        }

        public IEnumerator<Employee> GetEnumerator()
        {
            return _employees.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    } 
    #endregion
}
