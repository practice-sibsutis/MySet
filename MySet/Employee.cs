using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySet
{
    internal class Employee : Person
    {
        string company;

        public Employee(string name, string secondName, string company) : base(name, secondName)
        {
            this.company = company;
        }

        public override string ToString()
        {
            return base.ToString() + " " + company;
        }

        public string Company
        {
            set
            {
                company = value;
            }

            get => company;
        }

        public void Work()
        {
            Console.WriteLine($"{Name} {SecondName} работает в {company}");
        }

    }
}
