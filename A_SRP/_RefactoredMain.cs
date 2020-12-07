namespace SOLID.A_SRP
{
    public class RefactoredMain
    {
        public static void Run()
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();

            bool isUserValid = PersonValidator.Validate(user);
            if (!isUserValid)
            {
                StandardMessages.EndApplication();
            }
            
            AccountGenerator.CreateAccount(user);
            
            StandardMessages.EndApplication();
        }
    }
}