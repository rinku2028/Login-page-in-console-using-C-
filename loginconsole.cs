﻿using System;

namespace loginconsole
{
    class Program
    {
        static void Main(string[] args)
        {
< code >
    //Login Attempts counter
    int loginAttempts = 0;

            //Simple iteration upto three times
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password");
                string password = Console.ReadLine();

                if (username != "valid" || password != "valid")
                    loginAttempts++;
                else
                    break;
            }

            //Display the result
            if (loginAttempts > 2)
                Console.WriteLine("Login failure");
            else
                Console.WriteLine("Login successful");

            Console.ReadKey();
</ code >        }
    }
}
