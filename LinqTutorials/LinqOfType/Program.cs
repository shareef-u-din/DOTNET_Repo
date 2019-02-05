using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOfType
{
    class Program
    {
        public static void Main()
        {
            IList mixedList = new ArrayList();
            mixedList.Add(0);
            mixedList.Add("One");
            mixedList.Add("Two");
            mixedList.Add(3);
            mixedList.Add(new Student() { StudentID = 1, StudentName = "Bill" });
            Console.WriteLine("**********************Query Syntax*******************");
            var stringResult = from s in mixedList.OfType<string>()
                               select s;

            var intResult = from s in mixedList.OfType<int>()
                            select s;

            var stdResult = from s in mixedList.OfType<Student>()
                            select s;

            foreach (var str in stringResult)
                Console.WriteLine("Strings "+str);

            foreach (var integer in intResult)
                Console.WriteLine("Integer " + integer);

            foreach (var std in stdResult)
                Console.WriteLine("Students " + std.StudentName);
            Console.WriteLine("**********************Method Syntax*******************");
            var allStrings = mixedList.OfType<string>();
            intResult = mixedList.OfType<int>();
            stdResult = mixedList.OfType<Student>();

            foreach (var str in allStrings)
                Console.WriteLine("Strings " + str);

            foreach (var integer in intResult)
                Console.WriteLine("Integer " + integer);

            foreach (var std in stdResult)
                Console.WriteLine("Students " + std.StudentName);


        }
    }

    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }
}
