using System;
using System.Collections.Generic;

namespace SOLID.B_OCP.Refactored
{
    public class Logger
    {
        public static void LogEmployees(List<EmployeeModel> employees)
        {
            foreach (var emp in employees)
            {
                Console.WriteLine(
                    $"{emp.FirstName} {emp.LastName}. Email: {emp.EmailAddress} Manager: {emp.IsManager} Executive: {emp.IsExecutive}");
            }
        }
    }
}