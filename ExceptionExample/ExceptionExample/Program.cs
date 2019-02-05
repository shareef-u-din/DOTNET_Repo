using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionExample
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int d = 0;
                Console.WriteLine(10 / d);
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Arithmetic exception caught");
            }
        }
    }
}
