
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograms
{
    class Test : Exception
    {
        public string Message { get; set; }
        internal Test()
        {
            this.Message = "Exception Example";
        }
    }
    class Program
    {
        internal static void Main1(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x < 0)
            {
                try
                {
                    throw new Test();
                }
                catch (Test ex)
                {
                    Console.WriteLine(ex.Message);
                    
                }

            }
            else
            {
                Console.WriteLine("The input Number is :{0}",x);
            }
        }
    }
}
