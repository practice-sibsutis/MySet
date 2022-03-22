using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MySet
{
    internal class Person
    {
        private string name;
        private string secondName;

        public Person(string name, string secondName)
        {
            this.name = name;
            this.secondName = secondName;
        }

        public override string ToString()
        {
            return name + " " + secondName;
        }

        public void SetName(string name)
        {
            if(string.IsNullOrEmpty(name) != true)
            {
                this.name = name;
            }
        }


        public string Name
        {

            get => name;
        }

        public string SecondName
        {
            get => secondName;
        }
    }
}
