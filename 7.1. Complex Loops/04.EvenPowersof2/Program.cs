﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowersof2
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var num = 1;
            // for (int i = 0; i <= n; i+=2)
            // {
            //     Console.WriteLine(num);
            //     num =num * 4;
            // }
            for (int i = 0; i <= n/2; i++)
            {
                Console.WriteLine(num);
                num = num * 4;
            }
        }
    }
}
