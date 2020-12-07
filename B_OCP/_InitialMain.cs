using System;
using System.Collections.Generic;
using SOLID.B_OCP.Initial;

namespace SOLID.B_OCP
{
    public class InitialMain
    {
        public static void Run()
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel() {FirstName = "Tim", LastName = "Corey"},
                new PersonModel() {FirstName = "Sue", LastName = "Storm", TypeOfEmployee = EmployeeType.Manager},
                new PersonModel() {FirstName = "Nancy", LastName = "Roman", TypeOfEmployee = EmployeeType.Executive}
            };
            
            List<EmployeeModel> employees = new List<EmployeeModel>();

            foreach (var person in applicants)
            {
                employees.Add(Accounts.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{emp.FirstName}{emp.LastName}. Email: {emp.EmailAddress} Manager: {emp.IsManager} Executive: {emp.IsExecutive}");
            }
        }
    }
}