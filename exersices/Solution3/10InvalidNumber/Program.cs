﻿using System;

namespace _10InvalidNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //100…200] или е 0
            int number = int.Parse(Console.ReadLine());
            if (number >= 100 && number <= 200)
            { }
            else if (number == 0) { }
            else
                Console.WriteLine("invalid");
        }
    }
}
