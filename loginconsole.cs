using System;

namespace loginconsole
{
    class loginconsole
    {
        static void Main(string[] args)
        {

    //Login Attempts counter
    int loginAttempts = 0;

            //Checking to login (Attempt upto 3 times otherwise not able to login)
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Please enter username");
                string username = Console.ReadLine();
                Console.WriteLine("Please enter password");
                string password = Console.ReadLine();

                if (username != "001" || password != "jay")
                    loginAttempts++;
                else
                    break;
            }

            //Display the result
            if (loginAttempts > 2)
                Console.WriteLine("You failed to login!!");
            else
                Console.WriteLine("You are successfully logged in!!");

            Console.ReadKey();
        }
    }
}
