﻿using System;

namespace PasswordGuess
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            if(password!= "s3cr3t!P@ssw0rd")
            {
                Console.WriteLine("Wrong password!");
            }
            else 
            {
                Console.WriteLine("Welcome");
            }
        }
    }
}
