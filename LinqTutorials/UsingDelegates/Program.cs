﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegates
{
    class Student 
    {
        public int StudentID { get; set; }
        public String StudentName { get; set; }
        public int Age { get; set; }
    }
    delegate bool FindStudent(Student std);

    static class StudentExtension
    {
        public static IEnumerable<Student> where<T>(this IEnumerable<Student> stdArray, FindStudent del)
        {
            foreach (var item in stdArray)
            {
                if (del(item))
                {
                    yield return item;
                }


            }
        }
    }

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
                new Student { StudentID = 7, StudentName = "Rob",Age = 19  } 
            };

            var students = studentArray.where<Student>(delegate (Student std) {
                return std.Age > 12 && std.Age < 20;
            });
            foreach (var item in students)
            {
                Console.WriteLine($"Name :{item.StudentName}");
            }
        }
    }
}
