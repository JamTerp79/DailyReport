using System;

namespace DailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints "The Tech Academy"
            Console.WriteLine("The Tech Academy");

            // Prints "Student Daily Report"
            Console.WriteLine("Student Daily Report");

            // Variables to store the user's answers
            string name;
            string course;
            int pageNumber;
            bool needHelp;
            string positiveExperience;
            string otherFeedback;
            int hoursStudied;

            // Asks the user for their name
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();

            // Asks the user for the course they are on
            Console.WriteLine("What course are you on?");
            course = Console.ReadLine();

            // Asks the user for the page number they are on
            Console.WriteLine("What page number are you on?");
            pageNumber = int.Parse(Console.ReadLine());

            // Asks the user if they need help with anything
            Console.WriteLine("Do you need help with anything? (true/false)");
            needHelp = bool.Parse(Console.ReadLine());

            // Asks the user for any positive experiences they would like to share
            Console.WriteLine("Were there any positive experiences you'd like to share?");
            positiveExperience = Console.ReadLine();

            // Asks the user for any other feedback they would like to provide
            Console.WriteLine("Is there any other feedback you'd like to provide?");
            otherFeedback = Console.ReadLine();

            // Asks the user how many hours they studied today
            Console.WriteLine("How many hours did you study today?");
            hoursStudied = int.Parse(Console.ReadLine());

            // Prints a thank you message
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");

            // Leaves window open
            Console.ReadLine();
        }
    }
}

