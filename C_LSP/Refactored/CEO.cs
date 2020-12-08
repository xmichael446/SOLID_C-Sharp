using System;

namespace SOLID.C_LSP.Refactored
{
    public class CEO : BaseEmployee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 150M;

            Salary = baseAmount * rank;
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