﻿namespace FruitShop
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var fruit = Console.ReadLine().ToLower();
            var day = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine().ToLower());

            var price = -1.0;

            if (day == "monday" || day == "tuesday" || day == "wednesday" || day == "thursday" || day == "friday")
            {
                //Work day
                if (fruit == "banana") price = 2.50;
                else if (fruit == "apple") price = 1.20;
                else if (fruit == "orange") price = 0.85;
                else if (fruit == "grapefruit") price = 1.45;
                else if (fruit == "kiwi") price = 2.70;
                else if (fruit == "pineapple") price = 5.50;
                else if (fruit == "grapes") price = 3.85;
            }
            else if (day == "saturday" || day == "sunday")
            {
                //Weekend
                if (fruit == "banana") price = 2.70;
                else if (fruit == "apple") price = 1.25;
                else if (fruit == "orange") price = 0.90;
                else if (fruit == "grapefruit") price = 1.60;
                else if (fruit == "kiwi") price = 3.00;
                else if (fruit == "pineapple") price = 5.60;
                else if (fruit == "grapes") price = 4.20;
            }
            if (price > 0)
            {
                Console.WriteLine("{0:f2}", price * quantity);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
