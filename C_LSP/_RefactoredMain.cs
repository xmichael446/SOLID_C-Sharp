using System;
using SOLID.C_LSP.Refactored;

namespace SOLID.C_LSP
{
    public class RefactoredMain
    {
        public static void Run()
        {
            BaseEmployee emp = new CEO() {FirstName = "Tim", LastName = "Corey"};
            emp.CalculatePerHourRate(2);

            Console.WriteLine($"{emp.FirstName}'s salary is ${emp.Salary}/hour.");
            Console.ReadLine();
        }
    }
}