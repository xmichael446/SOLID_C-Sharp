using System;
using SOLID.C_LSP.Initial;

namespace SOLID.C_LSP
{
    public class InitialMain
    {
        public static void Run()
        {
            Manager accountingVp = new Manager() {FirstName = "Emma", LastName = "Stone"};
            accountingVp.CalculatePerHourRate(4);

            Employee emp = new Manager() {FirstName = "Tim", LastName = "Corey"};
            emp.AssignManager(accountingVp);
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");
            Console.ReadLine();
        }
    }
}