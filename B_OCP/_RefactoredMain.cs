using System;
using System.Collections.Generic;
using SOLID.B_OCP.Refactored;

namespace SOLID.B_OCP
{
    public static class RefactoredMain
    {
        public static void Run()
        {
            List<IApplicantModel> applicants = new List<IApplicantModel>
            {
                new PersonModel() {FirstName = "Tim", LastName = "Corey"},
                new ManagerModel() {FirstName = "Nancy", LastName = "Storm"},
                new ExecutiveModel() {FirstName = "Sue", LastName = "Roman"}
            };

            List<EmployeeModel> employees = Hirer.Hire(applicants);

            Logger.LogEmployees(employees);
        }
    }
}