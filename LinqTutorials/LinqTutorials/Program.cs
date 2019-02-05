using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LinqTutorials
{
    class Student
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
    }

    public static class StudentExtension
    {
        public static IEnumerable<T> Filter<T>(this IEnumerable<T> stdArray, Func<T, bool> predicate)
        {
            foreach (var item in stdArray)
            {
                if (predicate(item))
                {
                    yield return item;
                }
               

            }


        }
    }
    delegate bool FindStudent(Student std);
    class Program
    {
        static void Main(string[] args)
        {
            var studentArray = new List<Student>
           {
                new Student { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student { StudentID = 3, StudentName = "Bill",  Age = 25 } ,
                new Student { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student { StudentID = 5, StudentName = "Ron" , Age = 31 } ,
                new Student { StudentID = 6, StudentName = "Chris",  Age = 17 } ,
                new Student { StudentID = 7, StudentName = "Rob", Age = 19  }
           };
            var students = studentArray.Filter(e => e.Age < 25)
                .OrderBy(e => e.StudentName);
            Console.WriteLine($"Count ={students.Count()}");
            foreach (var s in students)
            {
                Console.WriteLine($"Name :{s.StudentName}");

            }


        }
    }
}
