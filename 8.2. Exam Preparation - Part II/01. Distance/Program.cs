﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Distance
{
    class Program
    {
        static void Main(string[] args)
        {
            var beguiningSpeed = int.Parse(Console.ReadLine());
            var FirstTime = int.Parse(Console.ReadLine());
            var SecondTime = int.Parse(Console.ReadLine());
            var ThirdTime = int.Parse(Console.ReadLine());

            var FirstKm = FirstTime / 60.0 * beguiningSpeed;
            var SecondKm = SecondTime / 60.0 * (beguiningSpeed + 0.1 * beguiningSpeed);
            var ThirdKm = ThirdTime / 60.0 * (beguiningSpeed + 0.1 * beguiningSpeed - 0.05 * (beguiningSpeed + 0.1 * beguiningSpeed));
            Console.WriteLine("{0:0.00}",FirstKm+SecondKm+ThirdKm);
        }
    }
}
