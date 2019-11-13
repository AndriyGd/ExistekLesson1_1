using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Existek_Lesson1_1.Inheritance
{
    using Common;

    public class Manager : Human
    {
        public double Bonus { get; }
        public int CountEmployees { get; set; }

        public Manager(double bonus)
        {
            Bonus = bonus;
        }

        public override string ToString()
        {
            return $"Id: {Id}\nName: {Name}\nAge: {Age}\nBonus: {Bonus}\nCount Employees:  {CountEmployees}\n";
        }
    }
}
