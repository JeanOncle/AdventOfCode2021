﻿using System;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            var exercise = new Day10.Exercise();
            Console.WriteLine(exercise.GetFirstAnswer());
            Console.WriteLine(exercise.GetSecondAnswer());
            Console.ReadLine();
        }
    }
}
