using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestEquality
{

    public class Program
    {
        public static void Main()
        {
            Person p1 = new Person { Name = "Jay", Age = 25 };
            Person p2 = p1;
            Person p3 = new Person { Name = "Jay", Age = 25 };

            Console.WriteLine(p1.Equals(p2));  // True
            Console.WriteLine(p1 == p2);       // True

            Console.WriteLine(p1.Equals(p3));  // False
            Console.WriteLine(p1 == p3);       // False
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
