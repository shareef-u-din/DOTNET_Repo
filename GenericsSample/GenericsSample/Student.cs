//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace GenericsSample
//{
//    public class Student:IEnumerable<Student>,ICollection<Student>
//    {
//        public string Name { get; set; }
//        public int RollNumber { get; set; }
//        public float CGPA { get; set; }

//        public int Count => this.StudentList.Count();

//        public bool IsReadOnly => throw new NotImplementedException();

//        List<Student> StudentList;
//        public Student()
//        {
//            Name = "";
//            RollNumber = 0;
//            CGPA = 0;
//            StudentList=new List<Student>();

//        }


//        public IEnumerator<Student> GetEnumerator()
//        {
//            while()
//        }

//        IEnumerator IEnumerable.GetEnumerator()
//        {
//            return this.GetEnumerator();
//        }

//        public void Add(Student item)
//        {
//            throw new NotImplementedException();
//        }

//        public void Clear()
//        {
//            throw new NotImplementedException();
//        }

//        public bool Contains(Student item)
//        {
//            throw new NotImplementedException();
//        }

//        public void CopyTo(Student[] array, int arrayIndex)
//        {
//            throw new NotImplementedException();
//        }

//        public bool Remove(Student item)
//        {
//            throw new NotImplementedException();
//        }
//    }
//}
