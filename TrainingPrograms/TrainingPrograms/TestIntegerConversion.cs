using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TrainingPrograms
{
    class TestIntegerConversion
    {
        static void Main(string[] args)
        {
            int x = GetIntegerValue.ParseInt(Console.ReadLine());

            Console.WriteLine("The Value Of X = " + x);

            int? z = GetIntegerValue.ParseNullableInt(Console.ReadLine());

            Console.WriteLine("The Value Of Z = " + z);
        }
    }
}
