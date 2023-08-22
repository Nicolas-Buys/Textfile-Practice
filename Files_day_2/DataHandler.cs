using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_day_2
{
    class DataHandler
    {
        public List<Person> FormatRead(List<string> People)
        {
            List<Person> PersonList = new List<Person>();
            foreach (string item in People)
            {
                string[] Line = item.Split(',');
                PersonList.Add(new Person(Line[0], Line[1], int.Parse(Line[2])));
            }
            return PersonList;
        }

        public List<string> FormatWrite(List<Person> PersonList)
        {
            List<string> People = new List<string>();
            foreach (Person person in PersonList)
            {
                string line = string.Format("{0},{1},{2}", person.Name, person.Surname, person.Age);
                People.Add(line);
            }
            return People;
        }
    }
}
