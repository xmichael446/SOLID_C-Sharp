using System;

namespace SOLID.C_LSP.Initial
{
    public class CEO : Employee
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
        }

        public override void AssignManager(Employee manager)
        {
            throw new InvalidOperationException("The CEO has no Manager.");
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Simulation of reviewing someone's work.");
        }

        public void FireSomeone()
        {
            Console.WriteLine("You're fired!");
        }
    }
}