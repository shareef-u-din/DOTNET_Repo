using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqOrderBy
{
    class Program
    {
        public static void Main()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 21 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 29 }
            };
            Console.WriteLine("**************************Query Syntax*************************");
            var orderByResult = from s in studentList
                                where s.Age >20 
                                orderby s.StudentName //Sorts the studentList collection in ascending order
                                select s;
            Console.WriteLine("Ascending Order:");
            foreach (var std in orderByResult)
                Console.WriteLine(std.StudentName);

            var orderByDescendingResult = from s in studentList //Sorts the studentList collection in descending order
                                          where s.Age>20
                                          orderby s.StudentName descending
                                          select s;

            Console.WriteLine("Descending Order:");
            foreach (var std in orderByDescendingResult)
                Console.WriteLine(std.StudentName);
            Console.WriteLine("**************************Method Syntax*************************");
            var orderByResults = studentList.Where(s => s.Age > 20)
                                      .OrderBy(s => s.StudentName)
                                      .Select(s => s);
            Console.WriteLine("Ascending Order:");
            foreach (var std in orderByResults)
                Console.WriteLine(std.StudentName);

            var orderByDescendingResults = studentList.Where(s => s.Age > 20)
                                                      .OrderByDescending(s => s.StudentName)
                                                      .Select(s => s);

            Console.WriteLine("Descending Order:");
            foreach (var std in orderByDescendingResults)
                Console.WriteLine(std.StudentName);
        }

    }

    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }
}
