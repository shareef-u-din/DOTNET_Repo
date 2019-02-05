using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegate
{
    class Program
    {
        public delegate void Test(string message);
        static Test Display = delegate (string message)
        {
            Console.WriteLine("Anonymous Delegate method :"+message);
        };
        static void Main(string[] args)
        {
           

            Display("Method Invoked Parameter");
            Console.ReadLine();
        }
    }
}