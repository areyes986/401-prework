using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Allys giveaway!");
            Console.Write("Choose a door: 1,2 or 3:");
            string userValue = Console.ReadLine();

            string message = "";

            if (userValue == "1")
                 message = "You won a new car!";
            else if (userValue == "2")          
                message = "You won a boat!";           
            else if (userValue == "3")           
                message = "You won a new cat!";          
            else
            {
                message = "Sorry you lose.";
                //message = message + ":)"; 
                message += ":D";
            }
            
            Console.WriteLine(message);
            Console.ReadLine();
            */

            Console.WriteLine("Allys giveaway!");
            Console.Write("Choose a door: 1,2 or 3:");
            string userValue = Console.ReadLine();

            string message = (userValue == "1") ? "boat" : "strand of lint";
            string message1 = "fool";
            //Console.Write("You won a ");
            //Console.Write(message);
            //Console.Write(".");
            //Console.WriteLine("You won a {0}.", message);
            Console.WriteLine("You entered: {0}, therefore, You won a {1}. {2}", userValue, message, message1);

            Console.ReadLine();


        }
    }

}

// main is method, first method was app is executed.
// class called program, container for all of methods of app
//namespace called helloWorld, 

//  = is an assignment operator , == evaluation if true or false