using System;



    // IF STATEMENTS
//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            /*
//            Console.WriteLine("Allys giveaway!");
//            Console.Write("Choose a door: 1,2 or 3:");
//            string userValue = Console.ReadLine();

//            string message = "";

//            if (userValue == "1")
//                 message = "You won a new car!";
//            else if (userValue == "2")          
//                message = "You won a boat!";           
//            else if (userValue == "3")           
//                message = "You won a new cat!";          
//            else
//            {
//                message = "Sorry you lose.";
//                //message = message + ":)"; 
//                message += ":D";
//            }

//            Console.WriteLine(message);
//            Console.ReadLine();
//            */

//            Console.WriteLine("Allys giveaway!");
//            Console.Write("Choose a door: 1,2 or 3:");
//            string userValue = Console.ReadLine();

//            string message = (userValue == "1") ? "boat" : "strand of lint";
//            //Console.Write("You won a ");
//            //Console.Write(message);
//            //Console.Write(".");
//            //Console.WriteLine("You won a {0}.", message);
//            Console.WriteLine("You entered: {0}, therefore, You won a {1}. {2}", userValue, message);

//            Console.ReadLine();


//        }
//    }

//}

// main is method, first method was app is executed.
// class called program, container for all of methods of app
//namespace called helloWorld, 

//  = is an assignment operator , == evaluation if true or false



    // VARIABLES
namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int x;
            int y;

            x = 7;
            y = x + 3;

            Console.WriteLine(y);
            Console.ReadLine();
            */

            Console.WriteLine("What is your name?");

            Console.Write("Type your first name: ");
            string myFirstName = Console.ReadLine();

            Console.Write("Type your last name: ");
            string myLastName = Console.ReadLine();

            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + "!");
            Console.ReadLine();
        }
    }
}
