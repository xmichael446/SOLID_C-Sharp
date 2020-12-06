using System;

namespace SOLID.A_SRP
{
    public class _InitialMain
    {
        public static void Run()
        {
            
            // Welcome message, moved to StandardMessages
            // <------------------------------------------------------------------>
            Console.WriteLine("Welcome to my application!!!");
            // <------------------------------------------------------------------>

            
            // Capturing user data, moved to PersonDataCapture
            // <------------------------------------------------------------------>
            Person user = new Person();

            Console.WriteLine("What is your first name: ");
            user.FirstName = Console.ReadLine();
            
            Console.WriteLine("What is your last name: ");
            user.LastName = Console.ReadLine();
            // <------------------------------------------------------------------>

            
            // Person data validation, moved to PersonValidator
            // <------------------------------------------------------------------>
            if (string.IsNullOrWhiteSpace(user.FirstName))
            {
                
                // Validation error message, moved to StandardMessages
                // <------------------------------------------------------------------>
                Console.WriteLine("You didn't give us a valid first name!");
                // <------------------------------------------------------------------>

                // Application end message, moved to StandardMessages
                // <------------------------------------------------------------------>
                Console.WriteLine("Press Enter key to exit...");
                Console.ReadLine();
                // <------------------------------------------------------------------>
                
                return;
            }

            if (string.IsNullOrWhiteSpace(user.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                Console.WriteLine("Press Enter key to exit...");
                Console.ReadLine();
                return;
            }
            // <------------------------------------------------------------------>

            
            // User creation account specific message, moved to AccountGenerator
            // <------------------------------------------------------------------>
            Console.WriteLine($"Your username is {user.FirstName.Substring(0, 1)}{user.LastName}. ");
            // <------------------------------------------------------------------>
            
            
            Console.WriteLine("Press Enter key to exit...");
            Console.ReadLine();
        }
    }
}