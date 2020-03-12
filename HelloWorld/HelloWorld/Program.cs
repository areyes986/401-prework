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

//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            /*
//            int x;
//            int y;

//            x = 7;
//            y = x + 3;

//            Console.WriteLine(y);
//            Console.ReadLine();
//            */

//            Console.WriteLine("What is your name?");

//            Console.Write("Type your first name: ");
//            string myFirstName = Console.ReadLine();

//            Console.Write("Type your last name: ");
//            string myLastName = Console.ReadLine();

//            Console.WriteLine("Hello, " + myFirstName + " " + myLastName + "!");
//            Console.ReadLine();
//        }
//    }
//}


// FOR LOOP INTERATION

//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            for (int i = 0; i < 10; i++)
//            {
//                //Console.WriteLine(i);
//                if (i == 7)
//                {
//                    Console.WriteLine("You found 7!");
//                    break;

//                }
//            }

//            for (int myValue = 0; myValue < 12; myValue++)
//            {
//                Console.WriteLine(myValue);
//            }

//            Console.ReadLine();
//        }
//    }
//}



// ARRAYS

//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //array, 5 elements inside the array
//            /*
//            int[] numbers = new int[5];

//            numbers[0] = 4;
//            numbers[1] = 8;
//            numbers[2] = 15;
//            numbers[3] = 16;
//            numbers[4] = 23;


//            Console.WriteLine(numbers.Length); //Output: 5
//            Console.ReadLine();
//            */

//            //int[] numbers = new int[] { 4, 8, 15, 16, 23, 42 };

//            //string[] names = new string[] {"ally", "mochi", "jin", "kudo"};

//            /*
//            for (int i = 0; i < names.Length; i++)
//            {
//                Console.WriteLine(names[i]);
//            }
//            Console.ReadLine();
//            */


//            /*
//            foreach (string name in names)
//            {
//                Console.WriteLine(name);
//            }
//            Console.ReadLine();
//            */

//            string zig = "You can get what you want out of life" + 
//                "if you help enough other people to get what they want.";

//            char[] charArray = zig.ToCharArray();
//            Array.Reverse(charArray);

//            foreach (char zigChar in charArray)
//            {
//                Console.Write(zigChar);
//            }
//            Console.ReadLine();



//        }
//    }
//}


// create and calling methods


//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("The Name Game");

//            Console.Write("Whats your first name? ");
//            string firstName = Console.ReadLine();


//            Console.Write("Whats your last name? ");
//            string lastName = Console.ReadLine();


//            Console.Write("Where were you born? ");
//            string city = Console.ReadLine();



//            DisplayResult(
//                ReverseString(firstName),
//                ReverseString(lastName),
//                ReverseString(city));

//            Console.WriteLine();

//            DisplayResult(ReverseString(firstName) + " " +
//                ReverseString(lastName) + " " +
//                ReverseString(city)
//                );


//            Console.ReadLine();
//        }

//        private static string ReverseString(string message)
//        {
//            char[] messageArray = message.ToCharArray();
//            Array.Reverse(messageArray);
//            return String.Concat(messageArray);
//        }

//        private static void DisplayResult(
//            string reversedFirstName, 
//            string reversedLastName, 
//            string reversedCity)
//        {
//            Console.Write("Resutls: ");
//            Console.Write(String.Format("{0} {1} {2}",
//                reversedFirstName,
//                reversedLastName,
//                reversedCity));

//        }

//        private static void DisplayResult(string message)
//        {
//            Console.Write("Resutls: ");
//            Console.Write(message);

//        }


//    }
//}




// void, do something but do not report back



//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            string message = "Hello World!";
//            char[] messageArray = message.ToCharArray();

//            foreach (char item in messageArray)
//            {
//                Console.WriteLine(item);
//            }
//            Console.ReadLine();
//        }
//    }
//}


//WHILE LOOPS
//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            bool displayMenu = true;
//            while (displayMenu)
//            {
//                displayMenu = MainMenu();
//            }
//        }

//        private static bool MainMenu()
//        {

//            Console.Clear();
//            Console.WriteLine("Choose an option:");
//            Console.WriteLine("1) Print Numbers Game");
//            Console.WriteLine("2) Guessing Game");
//            Console.WriteLine("3) Exit");
//            string result = Console.ReadLine();

//            if (result == "1")
//            {
//                PrintNumbers();
//                return true;
//            }

//            if (result == "2")
//            {
//                GuessingGame();
//                return true;
//            }

//            if (result == "3")

//            {
//                return false;
//            }

//            else
//            {
//                return true;
//            }
//        }

//        private static void PrintNumbers()
//        {
//            Console.Clear();
//            Console.WriteLine("Print Numbers!");

//            Console.Write("Type a number: ");
//            int result = int.Parse(Console.ReadLine());
//            int counter = 1;

//            while (counter < result + 1)            
//            {
//                Console.Write(counter);
//                Console.Write("-");
//                counter++;
//            }

//            Console.ReadLine();
//        }

//        private static void GuessingGame()
//        {
//            Console.Clear();
//            Console.WriteLine("Guessing game!");

//            Random myRandom = new Random();
//            int randomNumber = myRandom.Next(1, 11);

//            int guesses = 0;
//            bool incorrect = true;

//            do
//            {
//                Console.WriteLine("Guess a number between 1-10: ");
//                string result = Console.ReadLine();
//                guesses++;
//                if (result == randomNumber.ToString())
//                    incorrect = false;
//                else
//                    Console.WriteLine("Wrong");

//            } while (incorrect);
//            Console.WriteLine("Correct! you had {0} guesses", guesses);
//            Console.ReadLine();

//        }
//    }
//}

// DATES AND TIME

//namespace HelloWorld
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            DateTime myValue = DateTime.Now;
//            //Console.WriteLine(myValue.ToString());
//            //Console.WriteLine(myValue.ToShortDateString());
//            //Console.WriteLine(myValue.ToShortTimeString());
//            //Console.WriteLine(myValue.ToLongDateString());
//            //Console.WriteLine(myValue.ToLongTimeString());
//            //Console.WriteLine(myValue.AddDays(3).ToLongDateString());
//            //Console.WriteLine(myValue.AddHours(3).ToLongTimeString());
//            //Console.WriteLine(myValue.AddDays(-3).ToLongDateString());

//            //Console.WriteLine(myValue.Month);

//            //DateTime myBirthday = new DateTime(1991, 1, 22);
//            //Console.WriteLine(myBirthday.ToShortDateString());

//            DateTime myBirthday = DateTime.Parse("1/22/1991");
//            TimeSpan myAge = DateTime.Now.Subtract(myBirthday);
//            Console.WriteLine(myAge.TotalDays);

//            Console.ReadLine();
//        }
//    }
//}

    //STRINGS

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //string myString = "My \"so-called\" life";
            //string myString = "What if i need a \nnew line?";
            //string myString = "Go to your C:\\ drive";
            //string myString = @"Go to your c:\ drive";

            //string myString = string.Format("{0:C}", 123.45);
            //string myString = string.Format("{0:N}", 123435432);
            //string myString = string.Format("{0:P}", .123);
            //string myString = string.Format("{0:(###)###-####}", 1234567890);

            //string myString = " That summer we took threes across the board ";

            //myString = myString.Substring(6); // shows characters after 6 position
            //myString = myString.ToUpper();
            //myString = myString.Replace(" ", "--");
            //myString = myString.Remove(6, 14); 

            /*
            myString = String.Format("Length before: {0} -- Length after: {1}",
                myString.Length,
                myString.Trim().Length);
                */

            /*
            string myString = "";

            for (int i = 0; i < 100; i++)
            {
                myString += "--" + i.ToString();
            }
            */

            System.Text.StringBuilder myString = new System.Text.StringBuilder();

            for (int i = 0; i < 100; i++)
            {
                myString.Append("--");
                myString.Append(i);
            }

            Console.WriteLine(myString);
            Console.ReadLine();

      
        }
    }
}


// NOTES
int a = 7;
int b = 4;
int c = 3;
int d = (a + b) / c;
int e = (a + b) % c;
Console.WriteLine($"quotient: {d}");
Console.WriteLine($"remainder: {e}");


int max = int.MaxValue;
int min = int.MinValue;
Console.WriteLine($"The range of integers is {min} to {max}");
// Output: The range of integers is -2147483648 to 2147483647
