﻿using System;   

namespace lab._02.RadiansToDegrees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double radians = double.Parse(Console.ReadLine());
            double degree = radians * 180 / Math.PI;

            Console.WriteLine(degree);
        }
    }
}
