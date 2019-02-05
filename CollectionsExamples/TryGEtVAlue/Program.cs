using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryGEtVAlue
{
    class Program
    {
        public static void Main()
        {
            Dictionary<int, string> dict = new Dictionary<int, string>()
                                                            {
                                                                {1,"One"},
                                                                {2, "Two"},
                                                                {3,"Three"}
                                                            };


            string result;

            if (dict.TryGetValue(2, out result))
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Could not find the specified key.");
            }
        }
    }
}
