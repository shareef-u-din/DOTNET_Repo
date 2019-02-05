using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Validator
{
    class Test
    {
        static public bool ValidateEmail(string email)
        {
            string pattern = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z"; 

            Match match = Regex.Match(email, pattern);

            return match.Success;
        }
        static public bool ValidateIp(string ipAddress)
        {
            string pattern = @"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]).){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$";

            Match match = Regex.Match(ipAddress, pattern);

            return match.Success;
        }
        static void Main(string[] args)
        {
            do
            {
                Console.WriteLine("**Enter Email**");
                string email = Console.ReadLine();

                Console.WriteLine("**Enter IP Address**");
                string ip = Console.ReadLine();


                if (Test.ValidateEmail(email))
                {
                    Console.WriteLine("Valid Email Address");
                }
                else
                {
                    Console.WriteLine("Invalid Email Address");
                }

                if (Test.ValidateIp(ip))
                {
                    Console.WriteLine("Valid IP Address");
                }
                else
                {
                    Console.WriteLine("Invalid IP Address");
                }

            }
            while (Console.ReadLine() == "y");
           
        }
    }
}
