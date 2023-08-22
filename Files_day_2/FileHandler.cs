using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Files_day_2
{
    class FileHandler
    {
        string path = "Files\\People.txt";

        public List<string> ReadFile()
        {
            List<string> PersonList = new List<string>();
            try
            {
                if(File.Exists(path) == true)
                {
                    if (File.ReadAllLines(path) != null)
                    {
                        PersonList = File.ReadAllLines(path).ToList();
                        Console.WriteLine("Successfull file read");
                    }
                    else
                    {
                        Console.WriteLine("File is empty");
                    }
                }
                else
                {
                    Console.WriteLine("File does not exist.");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            return PersonList;
        }
        public void WriteFile(List<string> People)
        {
            Console.Clear();
            try
            {
                FileStream fs = new FileStream(path, FileMode.OpenOrCreate);
                fs.Close();
                File.WriteAllLines(path, People);
                Console.WriteLine("Successfull file write");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
            
        }
    }
}
