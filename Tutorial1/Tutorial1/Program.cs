﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tutorial1
{
    class Program
    {
        public int MyProperty { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine(new Program().x);

        }
         int x = 10;
    }
}
