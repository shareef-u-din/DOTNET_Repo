using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryGenericIEnumerable
{
    public class Student
    {
        public string Name { get; set; }
        public int RollNumber { get; set; }

        public Student(string name, int roll)
        {
            this.Name = name;
            this.RollNumber = roll;
        }
    }
}
