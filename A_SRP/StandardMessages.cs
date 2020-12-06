using System;

namespace SOLID.A_SRP
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!!!");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Press Enter key to exit...");
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You didn't give us a valid {fieldName}!");
        }
    }
}