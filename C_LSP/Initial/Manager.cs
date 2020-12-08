using System;

namespace SOLID.C_LSP.Initial
{
    public class Manager : Employee
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