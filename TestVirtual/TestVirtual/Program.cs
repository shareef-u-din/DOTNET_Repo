using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVirtual
{
     class Program
    {
        protected int MyProperty { get; set; }
        public virtual void M()
        {

        }
      
       
    }
    class A : Program
    {
        public override  void M()
        {
            Console.WriteLine("Hello in A");
        }
        static void Main(string[] args)
        {
            A a = new A();
            a.MyProperty = 10;
            Console.WriteLine(a.MyProperty);
            
            a.M();
        }
    }
}
