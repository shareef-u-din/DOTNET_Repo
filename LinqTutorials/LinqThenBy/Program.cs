using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqThenBy
{
    class Program
    {
        public static void Main()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 15 } ,
                new Student() { StudentID = 3, StudentName = "Ram",  Age = 25 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 19 }
            };
            Console.WriteLine("**********************************Query Syntax*************************************");
            var multiSortingResult = from s in studentList
                                     orderby s.StudentName,s.Age
                                     select s;
            foreach (var std in multiSortingResult)
                Console.WriteLine("Name: {0}, Age {1}", std.StudentName, std.Age);

            Console.WriteLine("**********************************Method Syntax*************************************");
            var multiSortingResults = studentList.OrderBy(s => s.StudentName)
                                            .ThenByDescending(s => s.Age)
                                            .Select(s => s);
            foreach (var std in multiSortingResults)
                Console.WriteLine("Name: {0}, Age {1}", std.StudentName, std.Age);
        }

    }

    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }
}
