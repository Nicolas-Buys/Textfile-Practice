using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_day_2
{
    class Program
    {
        enum Menu
        {
            Add = 1,
            Display, 
            Save, 
            Exit
        }
        static void Main(string[] args)
        {
            FileHandler fh = new FileHandler();
            DataHandler dh = new DataHandler();
            List<Person> People = dh.FormatRead(fh.ReadFile());
            bool cont = true;
            while(cont == true)
            {
                Console.Clear();
                for (int i = 1; i < 5; i++)
                {
                    Console.WriteLine("{0}. {1}", i, (Menu)i);
                }
                int choice = int.Parse(Console.ReadLine());
                switch ((Menu)choice)
                {
                    case Menu.Add:
                        People.Add(AddPerson());
                        break;
                    case Menu.Display:
                        foreach (Person item in People)
                        {
                            Console.WriteLine(item.ToString());
                           
                        }
                        Console.ReadKey();
                        break;
                    case Menu.Save:
                        fh.WriteFile(dh.FormatWrite(People));
                        break;
                    case Menu.Exit:
                        cont = false;
                        break;
                }
            }
        }
        static Person AddPerson()
        {
            Console.Clear();
            Console.WriteLine("Enter a name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter a Surname: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            int age = int.Parse(Console.ReadLine());
            return new Person(name, surname, age);
        }
    }
}