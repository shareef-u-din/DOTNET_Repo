using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqWhere
{
    class Student
    {
        public int StudentID { get; set; }
        public String  StudentName { get; set; }
        public int Age { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IList<Student> studentList = new List<Student>()
            {
                new Student() { StudentID = 1, StudentName = "John", Age = 13} ,
                new Student() { StudentID = 2, StudentName = "Moin",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20} ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 15 }
            };
            Console.WriteLine("**************************Using Query Method*************************");
            var filteredResult = from s in studentList
                                 where s.Age > 12 && s.Age < 20
                                 select s.StudentName;
            foreach (var item in filteredResult)
            {
                Console.WriteLine($"Name :{item}");
            }
            Console.WriteLine("**************************Using Method Method*************************");
            var filteredListUsingQueryMethod = studentList.Where(s => s.Age > 12 && s.Age < 20)
                .Select(s=>s.StudentName);

            
            foreach (var item in filteredListUsingQueryMethod)
            {
                Console.WriteLine($"Name :{item}");
            }
            Console.WriteLine("**************************Using Delegate Method*************************");
            
            var filteredListUsingDelegateMethod = studentList.Where(delegate(Student s) {
                                                                    return s.Age > 12 && s.Age < 20;})
                .OrderBy(s=>s.StudentName)
                .Select(s => s.StudentName);

            foreach (var item in filteredListUsingDelegateMethod)
            {
                Console.WriteLine($"Name :{item}");
            }

        }
    }
}
