using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_day_2
{
    class Person
    {
        private string name, surname;
        private int age;

        public Person(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public int Age { get => age; set => age = value; }

        public override string ToString()
        {
            return string.Format("Name: {0} | Surname: {1} | Age: {2}"
                , this.name, this.surname, this.age);
        }
    }
}
