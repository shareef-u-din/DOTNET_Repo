using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryGenericIEnumerable
{
    class Program
    {
        static void Main(string[] args)
        {
            EnumerableGeneric<Student> StudentList = new EnumerableGeneric<Student>
            {
               new Student("Shareef",77),
               new Student("Rohit",73),
               new Student("Menendu",5),
               new Student("Dhruv",1)
            };
            StudentList.Add(new Student("Madhuri", 55));
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            foreach (var item in StudentList)
            {
                Console.WriteLine("Student Name :"+item.Name+",  Roll Number :"+item.RollNumber);
            }
            Console.WriteLine("***************************************************************************");

            EnumerableGeneric<Person> PersonList = new EnumerableGeneric<Person>
            {
               new Person() { Name="Kashif",Age=23},
               new Person("Rohit",73),
               new Person("Dinesh",5),
               new Person("Dhruv",11)
            };
            PersonList.Add(new Person("Madhuri", 15));
            Console.ForegroundColor = ConsoleColor.Red;
            foreach (var item in PersonList)
            {
                Console.WriteLine("Person Name :" + item.Name + ",  Age :" + item.Age);
            }

        }
    }
    class Person
    {
        public string  Name { get; set; }
        public int Age { get; set; }
        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }
        public Person()
        {

        }
    }
}
