using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqJoin
{
    class Program
    {
        public static void Main()
        {
            // Student collection
            IList<Student> studentList = new List<Student>() {
                new Student() { StudentID = 1, StudentName = "John", Age = 18, StandardID = 1 } ,
                new Student() { StudentID = 2, StudentName = "Steve",  Age = 21, StandardID = 1 } ,
                new Student() { StudentID = 3, StudentName = "Bill",  Age = 18, StandardID = 2 } ,
                new Student() { StudentID = 4, StudentName = "Ram" , Age = 20, StandardID = 2 } ,
                new Student() { StudentID = 5, StudentName = "Ron" , Age = 21 }
            };

            IList<Standard> standardList = new List<Standard>() {
                new Standard(){ StandardID = 1, StandardName="Standard 1"},
                new Standard(){ StandardID = 2, StandardName="Standard 2"},
                new Standard(){ StandardID = 3, StandardName="Standard 3"}
            };
            Console.WriteLine("***********************Method Synatx**********************");
            var innerJoinResult = studentList.Join(// outer sequence
                          standardList,  // inner sequence
                          student => student.StandardID,    // outerKeySelector
                          standard => standard.StandardID,  // innerKeySelector
                          (student, standard) => new  // result selector
                      {
                              StudentName = student.StudentName,
                              StandardName = standard.StandardName
                          });

            foreach (var obj in innerJoinResult.OrderByDescending(s=>s.StandardName))
            {

                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }
            Console.WriteLine("***********************Query Synatx**********************");
            var innerJoin = from s in studentList // outer sequence
                            join st in standardList //inner sequence
                            on s.StandardID equals st.StandardID // key selector
                            select new
                            { // result selector
                                StudentName = s.StudentName,
                                StandardName = st.StandardName
                            };
            foreach (var obj in innerJoin.OrderBy(s => s.StandardName))
            {

                Console.WriteLine("{0} - {1}", obj.StudentName, obj.StandardName);
            }

        }

    }

    public class Student
    {

        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
        public int StandardID { get; set; }
    }

    public class Standard
    {

        public int StandardID { get; set; }
        public string StandardName { get; set; }
    }
}
