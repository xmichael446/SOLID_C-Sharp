using System;

namespace SOLID.A_SRP
{
    public class PersonDataCapture
    {
        public static Person Capture()
        {
            Person output = new Person();
            
            Console.WriteLine("What is your first name: ");
            output.FirstName = Console.ReadLine();
            
            Console.WriteLine("What is your last name: ");
            output.LastName = Console.ReadLine();

            return output;
        }
    }
}