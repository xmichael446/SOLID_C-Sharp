using System;

namespace SOLID.C_LSP.Refactored
{
    public class Manager : Employee, IManager
    {
        public override void CalculatePerHourRate(int rank)
        {
            decimal baseAmount = 19.85M;

            Salary = baseAmount + rank * 2;
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("Simulation");
        }
    }
}