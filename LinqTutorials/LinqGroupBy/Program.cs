using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqGroupBy
{
    class Program
    {
        public static void Main()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20 } ,
                new Student() { StudentID = 5, StudentName = "Sita",  Age = 18 } ,
                new Student() { StudentID = 6, StudentName = "Dhruv" , Age = 20 } ,
                new Student() { StudentID = 7, StudentName = "Madhuri",  Age = 18 } ,
                new Student() { StudentID = 8, StudentName = "Abhishek" , Age = 20 } ,
                new Student() { StudentID = 9, StudentName = "Ravan" , Age = 21 }
            };
            Console.WriteLine("**********************Query Synatx*********************");
            var groupedResult = from s in studentList
                                orderby s.StudentName
                                group s by s.Age;

                                

            //iterate each group        
            foreach (var ageGroup in groupedResult)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
            Console.WriteLine("**********************Method Synatx*********************");
            var groupedResults = studentList.GroupBy(s => s.Age);
            var newResults = groupedResult.OrderByDescending(s => s.Count());
            //iterate each group        
            foreach (var ageGroup in newResults)
            {
                Console.WriteLine("Age Group: {0}", ageGroup.Key); //Each group has a key 

                foreach (Student s in ageGroup) // Each group has inner collection
                    Console.WriteLine("Student Name: {0}", s.StudentName);
            }
        }

    }

    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }

    }
}
