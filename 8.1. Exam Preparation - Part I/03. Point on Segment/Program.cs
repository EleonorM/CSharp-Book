﻿namespace _03.Point_on_Segment
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var n1 = int.Parse(Console.ReadLine());
            var n2 = int.Parse(Console.ReadLine());
            var n = int.Parse(Console.ReadLine());

            var left = Math.Min(n1, n2);
            var right = Math.Max(n1, n2);

            var leftDist = Math.Abs(n - left);
            var rightDist = Math.Abs(n - right);
            if (n >= left && n <= right)
            {
                Console.WriteLine("in");
            }
            else
            {
                Console.WriteLine("out");
            }

            Console.WriteLine(Math.Min(leftDist, rightDist));
        }
    }
}
