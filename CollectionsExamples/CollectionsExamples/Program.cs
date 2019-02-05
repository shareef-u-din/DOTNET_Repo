using System;
using System.Linq;
using System.Collections.Generic;

namespace CollectionsExamples
{

    public class Program
    {
        public static void Main()
        {
            IDictionary<int, Student> studentDict = new Dictionary<int, Student>()
                    {
                        { 1, new Student(){ StudentID =1, StudentName = "Bill"}},
                        { 2, new Student(){ StudentID =2, StudentName = "Steve"}},
                        { 3, new Student(){ StudentID =3, StudentName = "Ram"}}
                    };

            Student std = new Student() { StudentID = 1, StudentName = "Bill" };

            KeyValuePair<int, Student> studentToFind = new KeyValuePair<int, Student>(1, std);

            bool result = studentDict.Contains(studentToFind, new StudentDictionaryComparer());

            Console.WriteLine("Found Student? {0}", result);
        }
    }

    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
    }

    class StudentDictionaryComparer : IEqualityComparer<KeyValuePair<int, Student>>
    {
        public bool Equals(KeyValuePair<int, Student> x, KeyValuePair<int, Student> y)
        {
            if (x.Key == y.Key && (x.Value.StudentID == y.Value.StudentID) && (x.Value.StudentName == y.Value.StudentName))
                return true;

            return false;
        }

        public int GetHashCode(KeyValuePair<int, Student> obj)
        {
            return obj.Key.GetHashCode();
        }
    }
}
