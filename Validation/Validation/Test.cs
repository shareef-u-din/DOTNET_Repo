using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Validation
{
    class Test
    {
        static public bool ValidateEmail(string email)
        {
            return true;
        }
        static public bool ValidateIp(string ip)
        {
            string[] ips = ip.Split('.');
            if(ips.Length != 4)
            {
                return false;
            }
            foreach(string s in ips)
            {
                if (IntegerValue.ParseInt(s) > 255 || IntegerValue.ParseInt(s) < 0)
                {
                    return false;
                }
            }
            
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Email");
            string email = Console.ReadLine();

            Console.WriteLine("Enter IP Address");
            string ip = Console.ReadLine();

            if (Test.ValidateIp(ip))
            {
                Console.WriteLine("***** Valid IP Address");
            }
            else
            {
                Console.WriteLine("***** Invalid IP Address");
            }
            if (Test.ValidateEmail(email))
            {
                Console.WriteLine("***** Valid Email");
            }
            else
            {
                Console.WriteLine("***** Invalid Email");
            }
            
        }
    }
}
