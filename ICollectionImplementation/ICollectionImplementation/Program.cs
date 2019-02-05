using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICollectionImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = System.ConsoleColor.Yellow;
            Console.WriteLine("*****************************BusinessObjectCollection*******************************");
            BusinessObjectCollection<Person> boCollection =new BusinessObjectCollection<Person>() {
                new Person() { FirstName = "shareef", LastName = "bhat" },
                new Person() { FirstName = "Umer", LastName = "bhat" },
                new Person() { FirstName = "Ruhe", LastName = "bhat" },
                new Person() { FirstName = "kulsum", LastName = "bhat" },
                new Person() { FirstName = "Abida", LastName = "bhat" }
            };
            foreach (var item in boCollection)
            {
                Console.WriteLine("GUID : "+item.UniqueId+", "+item.FirstName+", "+item.LastName);
            }
            Console.ForegroundColor = System.ConsoleColor.White;
            Console.WriteLine("*****************************BusinessEnumerator*******************************");
            BusinessObjectEnumerator<Person> boEnumerable = new BusinessObjectEnumerator<Person>() {
                new Person() { FirstName = "shareef", LastName = "bhat" },
                new Person() { FirstName = "Umer", LastName = "bhat" },
                new Person() { FirstName = "Ruhe", LastName = "bhat" },
                new Person() { FirstName = "kulsum", LastName = "bhat" },
                new Person() { FirstName = "Abida", LastName = "bhat" }
            };
            foreach (var item in boEnumerable)
            {
                Console.WriteLine("GUID : " + item.UniqueId + ", " + item.FirstName + ", " + item.LastName);
            }

        }
    }
}
