using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortCollections
{
    class Program
    {
        public static void Main()
        {
            IList<int> intList = new List<int>();
            intList.Add(80);
            intList.Add(20);
            intList.Add(110);
            intList.Add(40);
            Console.WriteLine("**********************Before Sorting*************************");
            foreach (var item in intList)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine("\n**********************After Sorting*************************");
            var SortedIntList= intList.OrderBy(x => x).ToList();
            foreach (var item in SortedIntList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            IList<string> strList = new List<string>();
            strList.Add("one");
            strList.Add("two");
            strList.Add("three");
            strList.Add("four");
            strList.Add("five");
            strList.Add("six");
            strList.Add(null);

            foreach (var item in strList)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();

            IList<Student> studentList = new List<Student>();
            studentList.Add(new Student());
            studentList.Add(new Student());
            studentList.Add(new Student());

            Console.WriteLine(studentList.Count);

        }
    }

    public class Student
    {

    }
}
